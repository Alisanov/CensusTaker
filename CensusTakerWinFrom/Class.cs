using CensusTakerWinFrom.Properties;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensusTakerWinFrom
{
    public class Class
    {
        public const string PersonalAccountText = "personalaccount";
        public const string OperationText = "operation";
        public const string CompanyText = "company";
        public const string ResourseText = "resource";
        public const string AddressText = "address";

        public class PersonalAccount//счетчик
        {
            public Guid ID { get; set; } //индетификатор лицевого счета
            public string PersonalAcc { get; set; }//номер лицевого счета
            public Guid CompanyID { get; set; }//индектификатор компании
            public Guid ResourceID { get; set; }//индектификатор ресурса
            public Guid AddressID { get; set; }//индетификатор адреса 
            public double Tariff { get; set; } //тариф
            public int People { get; set; } //кол-во людей
            public bool PaymetMethod { get; set; } //способ оплаты 
            public DateTime Date { get; set; }//дата создания 
            //полное название счета
            public string NamePersonalAcc
            {
                get
                {
                    string namePersonalAcc = string.Format("№{0:#,###0.#}", PersonalAcc);
                    string resourse = string.Empty;
                    using (LiteDatabase database = new LiteDatabase(Settings.Default.Database))
                    {
                        LiteCollection<Resource> tableResourse = database.GetCollection<Resource>(ResourseText);
                        Resource resourseResult = tableResourse.FindById(ResourceID);
                        if (resourseResult != null)
                            resourse = resourseResult.Name;

                    }

                    return namePersonalAcc + " " + resourse;
                }
            }
            public string NamePersonalAccFull
            {
                get
                {
                    string namePersonalAcc = string.Format("№{0:#,###0.#}", PersonalAcc);
                    string resourse = string.Empty, company = string.Empty, address = string.Empty;
                    using (LiteDatabase database = new LiteDatabase(Settings.Default.Database))
                    {
                        LiteCollection<Resource> tableResourse = database.GetCollection<Resource>(ResourseText);
                        Resource resourseResult = tableResourse.FindById(ResourceID);
                        if(resourseResult != null)
                            resourse = resourseResult.Name;

                        LiteCollection<Company> tableCompany = database.GetCollection<Company>(CompanyText);
                        Company companyResult = tableCompany.FindById(CompanyID);
                        if(companyResult != null)
                            company = companyResult.Name;

                        LiteCollection<Address> tableAddress = database.GetCollection<Address>(AddressText);
                        Address addressResult = tableAddress.FindById(AddressID);
                        if(addressResult != null)
                            address = addressResult.FullAddress();
                    }

                    return namePersonalAcc + " " + resourse + " Компания: " + company + "\nАдрес: " + address; 
                }
            }
            //операция по счету
            public List<Operation> Operations
            {
                get
                {
                    List<Operation> operationsList = new List<Operation>();
                    using (LiteDatabase database = new LiteDatabase(Settings.Default.Database))
                    {
                        LiteCollection<Operation> tableOperation = database.GetCollection<Operation>(Class.OperationText);

                        IEnumerable<Operation> operations = tableOperation.Find(z => z.PersonalAccountID.Equals(ID));
                        operations = operations.OrderBy(z => z.Date);
                        operations = operations.OrderByDescending(z => z.PersonalAccountID);
                        foreach(Operation operation in operations)
                        {
                            operationsList.Add(operation);
                        }
                    }
                    return operationsList;
                }
            }

            public bool PaidСurrentMonth(LiteDatabase database)
            {
                LiteCollection<Class.Operation> tableOperation = database.GetCollection<Class.Operation>(Class.OperationText);

                IEnumerable<Class.Operation> operation = tableOperation.Find(x => x.PersonalAccountID.Equals(ID));
                operation = operation.OrderBy(x => x.Date);
                operation = operation.OrderByDescending(x => x.PersonalAccountID);
                if (operation.Count() > 0 && operation.Last().Date.Month == DateTime.Now.Month)
                    return true;
                else
                    return false;
            }

        }
        public class Operation//история операции 
        {
            public Guid ID { get; set; } //индетификатор операции
            public Guid PersonalAccountID { get; set; } //индетификатор лицевого счета
            public double NewIndicators { get; set; } //показатели счетчика новые
            public double OldIndicators { get; set; } //показатели счетчика старые
            public DateTime Date { get; set; } //дата операции
            public double Tariff { get; set; } //тариф при проведении операции
            public int People { get; set; } //кол-во людей
            public bool Status { get; set; } //статус операции
            public byte[] MemoryImage { get; set; }//изображение 

            //полное наименование лицевого счета
            public bool NamePersonalAccount(ref string result)
            {
                using (LiteDatabase database = new LiteDatabase(Settings.Default.Database))
                {
                    LiteCollection<PersonalAccount> tablePresonalAcc = database.GetCollection<PersonalAccount>(PersonalAccountText);
                    PersonalAccount personalAccResult = tablePresonalAcc.FindById(PersonalAccountID);
                    if (personalAccResult != null)
                    {
                        result = "№ " + personalAccResult.PersonalAcc;

                        LiteCollection<Resource> tableResourse = database.GetCollection<Resource>(ResourseText);
                        Resource resourseResult = tableResourse.FindById(personalAccResult.ResourceID);
                        if (resourseResult != null)
                            result += " " + resourseResult.Name;
                        return true;
                    }
                    else
                    {
                        result = "Нет лицевого счета";
                        return false;
                    }
                }
            }

            public bool PaymetMethod
            {
                get
                {
                    bool paymetMethod = false;
                    using (LiteDatabase database = new LiteDatabase(Settings.Default.Database))
                    {
                        LiteCollection<PersonalAccount> tablePresonalAcc = database.GetCollection<PersonalAccount>(PersonalAccountText);
                        PersonalAccount personalAccResult = tablePresonalAcc.FindById(PersonalAccountID);
                        if (personalAccResult != null)
                        {
                            paymetMethod = personalAccResult.PaymetMethod;
                        }
                    }

                    return paymetMethod;
                }
            }

            public double Summ
            {
                get
                {
                    double summ = 0;
                    using (LiteDatabase database = new LiteDatabase(Settings.Default.Database))
                    {
                        LiteCollection<PersonalAccount> tablePresonalAcc = database.GetCollection<PersonalAccount>(PersonalAccountText);
                        PersonalAccount personalAccResult = tablePresonalAcc.FindById(PersonalAccountID);
                        if (personalAccResult != null)
                        {
                            if (personalAccResult.PaymetMethod)
                                summ = People * Tariff;
                            else
                                summ = (NewIndicators - OldIndicators) * Tariff;
                        }
                    }
                    return summ;
                }
            }
            public Image Check
            {
                get
                {
                    Image check = Image.FromFile(Settings.Default.NoImageFileStream);
                    if (MemoryImage != null)
                    {
                        MemoryStream memoryStream = new MemoryStream(MemoryImage);
                        if (memoryStream.Length != 0)
                            check = Image.FromStream(memoryStream);
                        
                    }
                    return check;
                }
            }
            public byte[] MemoryImage2
            {
                get
                {
                    MemoryStream memoryStream = new MemoryStream();


                    if (MemoryImage != null)
                    {
                        MemoryStream memoryStreamThis = new MemoryStream(MemoryImage);
                        Image check = Image.FromStream(memoryStreamThis);
                        Bitmap newImage = new Bitmap(check.Width / 2, check.Height / 2);
                        using (Graphics gr = Graphics.FromImage(newImage))
                        {
                            gr.SmoothingMode = SmoothingMode.HighQuality;
                            gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                            gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                            gr.DrawImage(check, new Rectangle(0, 0, check.Width / 2, check.Height / 2));
                        }
                        newImage.Save(memoryStream, ImageFormat.Png);
                    }
                    return memoryStream.ToArray();
                }
            }

        }
        public class Address//адрес
        {
            public Guid ID { get; set; }//индетификатор адреса
            public string Region { get; set; }//область
            public string Area { get; set; }//район
            public string City { get; set; }//населенный пункт
            public string Street { get; set; } //наименование улицы
            public string NumberHome { get; set; }//номер дома
            public string ApartmentNumber { get; set; }//номер квартиры

            public string FullAddress()
            {
                return City + " ул. " + Street + " д. " + NumberHome; 
            }
        }
        public class Company//компания
        {
            public Guid ID { get; set; }//индетификатор организации
            public string Name { get; set; } //наименование организации
        }
        public class Resource//ресурс
        {
            public Guid ID { get; set; } //индектификатор ресурса
            public string Name { get; set; } //наименование ресурса
        }

    }
}
