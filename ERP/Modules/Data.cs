using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using time = System.Threading.Thread;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Windows.Forms;
using System.IO;
using OpenQA.Selenium.Firefox;
 

namespace ERP_Automation_Testing
{
    public partial  class Data
    {
        //public static IWebDriver Driver = new ChromeDriver(@"F:\WebSites\Test\ERPAutomation\TestNeeds\");
        //public static IWebDriver Driver = new ChromeDriver(@"D:\BonianTFS\ERP\Source\Tools\ERP_Automation_Test\ERP_Automation_Test\TestNeeds");
        public static WebDriverWait Wait = new WebDriverWait(Automation_Testing.Common.Driver, TimeSpan.FromSeconds(10));

        internal static bool check(bool v1, string v2)
        {
            throw new NotImplementedException();
        }

        public static string ERP_URL = "https://erptest.boniantech.com/";
        //public static string ERPBaseLine_URL = "http://test.boniantech.com/erpBaseLine/";
        // public static string FARM_URL = "https://app.boniantech.com/FriendsFarm/";
        // admin 
        public static string user = "admin";
        public static string pwd = "9999";
        public static string gmail = "@gmail.com";

        // fin1
        //public static string user = "fin1";
        //// fin2
        //public static string user = "fin2";
        //// inv1
        //public static string user = "inv1";
        //// inv2
        //public static string user = "inv2";

        //public static string pwd = "1234";
        public static bool TestPassed = true;
        public static string[] letters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "I", "S" };
        public const int TEST_INDEX = 17;
        public static string Date = DateTime.Today.ToShortDateString().Replace("/", "-");
        public static String DateValue = DateTime.Now.ToString("dd-MM-yyyy");
        public static bool testingOnWebsite = false;


        // الملفات التعريفية
        public struct Customer
        {
            public static string Name = "Customer_" + Data.TEST_INDEX;
            public static string Email = "Customer_" + Data.TEST_INDEX + "@gmail.com";
            public static string Number = Data.TEST_INDEX.ToString();
            public static string ID_Type = "بطاقة شخصية";
            public static string ID_Number = "12345123451234";
            public static string Phone = "234234234";
            public static string Mobile = "01112345678";
            public static string Address = Data.TEST_INDEX + " Abbas El-Aqqad ST";
            public static string Country = Data.Place.CountryName;
            public static string Area = Data.Place.AreaName;
            public static string City = Data.Place.CityName;
            public static string District = Data.Place.DistrictName;
            public static string Nationality = Data.Place.Nationality;

        }

        public struct Supplier
        {
            public static string Name = "mohamed sayed";
            public static string Email = "Supplier" + Data.TEST_INDEX + "@gmail.com";
            public static string Phone = "234234234";
            public static string Mobile = "01112345678";
            public static string Address = "389 faisal";
            public static string Country = "مصر";
            public static string Area = "المنوفية";
            public static string City = "شبين الكوم";
            public static string District = "حي الاستاد";
            public static string NationalID = "231122211222112";
            public static string Describtion = "وصف";
            public static string password = "aA123456";
        }

        public struct Technicians
        {
            public static string Name = "Technicians_" + Data.TEST_INDEX;
            public static string Email = "Technicians" + Data.TEST_INDEX;
            public static string Phone = "234234234";
            public static string Mobile = "01112345678";
            public static string Address = Data.TEST_INDEX + " Abbas El-Aqqad ST";
            public static string specialist = "هندسة";
            public static string Degree = "فنى";
            public static string kind = "ذكر";
            public static string Nationality = "سعودي";
            public static string Identity = "جواز سفر";
            public static string status = "أعزب";
            public static string Description = "وصف";
            public static string username = "Ahmedfahmy";
            public static string password = "aA123456";
            public static string mobilnumber = "01221490860";
            public static string perseonalidentificationnumber = "23912544551412";
            public static string ReleaseDate = "29-5-2021";
            public static string salary = "5000";
            public static string Reasonofending = "استقالة";
        }
        public struct item
        {
            public static string Brand = "ANC";
            public static string category = "لحوم";
            public static string Tax = "50";
            public static string ItemTypeName = "اجهزة كهربية";
            public static string ItemName = "بفتيك";
            public static string ItemName1 = "بفتيك0";
            public static string Itemcode = "123";
            public static string ItemDescription = "وصف";
            public static string ItempurchasePrice = "1500";
            public static string ItemUnit = "unit";
            public static string Discountforsale = "10";
            public static string DefaultPurchaseDiscount = "20";
            public static string MaxDiscount = "50";
            public static string ItemPrice = "300";
            public static string Demandlimit = "20";
            public static string Demandlimitforinventory = "30";
            public static string Barcode = "012215452112";
            public static string Validityduration = "21555211";


        }
        public struct itemTypes

        {
            public static string itemTypeName = "تكيف";
            public static string itemnature = "خامات";
            public static string status = "يزن";
            public static string ItemTypeDescription = "اجهزة كهربائية";

        }
        public struct Owner
        {
            public static string Name = "Owner " + Data.TEST_INDEX;
            public static string Email = "Owner" + Data.TEST_INDEX + "@gmail.com";
            public static string Number = Data.TEST_INDEX.ToString();
            public static string Phone = "234234234";
            public static string Mobile = "01112345678";
            public static string Address = Data.TEST_INDEX + " Abbas El-Aqqad ST";
            public static string Country = "مصر";
            public static string Area = "الأولى";
            public static string City = "القاهرة";
            public static string District = "مدينة نصر";
            public static string Nationality = "مصري";

        }

        public struct Place
        {
            public static string CountryName = "Country_" + TEST_INDEX;
            public static string Nationality = "Nationality_" + TEST_INDEX;
            public static string AreaName = "AreaName_" + TEST_INDEX;
            public static string CityName = "CityName_" + TEST_INDEX;
            public static string DistrictName = "DistrictName_" + TEST_INDEX;
        }



        // بيانات الحسابات
        public static string Bank = "Bank_" + TEST_INDEX;
        public static string Tax = "Tax_" + TEST_INDEX;
        public static string TaxValue = TEST_INDEX.ToString();
        public static string CostCenter = "CostCenter_" + TEST_INDEX;
        public static string Currency = "Currency_" + letters[TEST_INDEX];
        public static string CurrencyValue = TEST_INDEX.ToString();
        public static string Treasury = "Treasury_" + TEST_INDEX;

        public class BankAccount
        {
            public string Bank = Data.Bank;
            public string BankAccountCode = "BankAccount_" + TEST_INDEX;
            public string BankAccountNumber = "1234";
            public string CheckStart = "AT";
            public string FirstCheckNumber = "1001";
            public string PaymentCardCommission = TEST_INDEX.ToString();
        }

        // بيانات المخازن
        public static string Brand = "Brand_" + TEST_INDEX;
        public static string Store = "Store_" + TEST_INDEX;

        public static string InventoryCategory = "InventoryCategory" + TEST_INDEX;
        public static string ParentType = "";

        public static string ItemType = "ItemType_" + TEST_INDEX;
        public static string ItemNatural = "منتج";
        public static string address = "389faisalstreet";

        public static object AddAttachment { get; internal set; }

        public class Item
        {
            public string ItemName = "Item_" + TEST_INDEX;
            public string ItemPurchasePrice = (100 * TEST_INDEX).ToString();
            public string ItemInventoryCategory = InventoryCategory;
            public string ItemType = Data.ItemType;
            public string ItemBrand = Brand;
        }
        //## اذن اضافة
        public class AddingPermission
        {
            public static string profileType = "مورد";
            public static string Supplier = "ahmed fahmy";
            public static string Store = "ادوية";
            public static string inventorypermissionDescribtion = "وصف";
            public static string ItemTypeName = "ادوات مكتبية";
            public static string code = "قلم";
            public static string Quantity = "20";
            public static string Price = "150";
            public static string Date = DateValue;
        }
        public class Estates
        {
            public static string propertyType = "شقة";
            public static string Name = "شقة العجمي";
            public static string owner = "احمد حسن";
            public static string propertyspace = "200";
            public static string operationstartDate = "12-1-2022";
            public static string propertypurbose = "الايجار";
            public static string Rentvalue = "5000";
            public static string AnnualRent = "60000";
            public static string Describtion = "شقة ايجار";
            public static string country = "مصر";
            public static string Area = "القاهرة";
            public static string city = "مدينة نصر";
            public static string District = "الحي العاشر";
            public static string address = "مدينة نصر";



        }
        public class purchase1
        {
            public static string supplierName = "ahmed fahmy";
            public static string storeName = "1";
            public static string Date = "22-2-2022";
            public static string ItemType = "اجهزة كهربائية2";
            public static string codeName = "جوال";
            public static string itemcode = "32513";
            public static string quantity = "5";
            public static string price = "200";


        }
        public class itemstatusName
        {
            public static string itemstatusname = "status";
            public static string ItemTypeName = "ادوات مكتبية";
            public static string Namecode = "جوال";
        }
        public class Receiptvoucher
        {
            public static string profilType = "مورد";
            public static string receivefrom = "2ahmed fahmy";
            public static string profileaccountid = "النقدية بالصندوق";
            public static string currency = "الجنية المصري";
            public static string paymentmethod = "نقدا";
            public static string Treasury = "النقدية بالصندوق";
            public static string referenceType = "عقد";
            public static string serious = "5045";
            public static string Date = "20-12-2021";
            public static string collectiondate = "20-12-2021";
            public static string Amount = "5000";
            public static string Description = "Description";
            public static string Discount = "1";
            public static string AdditionalTax = "20";






        }
        public class inventorypermissionConstants
        {
            public static string profileType = "عميل";
            public static string customer = "123";
            public static string store = "1";
            public static string inventorypermissionDescribtion = "وصف";
            public static string Date = "15-12-2021";
            public static string ItemTypeName = "ادوات مكتبية";
            public static string code = "دباسة";
            public static string Quantity = "10";
            public static string Quantity1 = "15";

        }

        //## اذن صرف
        public class InventoryPermission1
        {
            public string Customer = Data.Customer.Name;
            public string Store = Data.Store;
            public string Date = Data.Date;
            public string ItemInventoryCategory = InventoryCategory;
            public string ItemName = "Item_" + TEST_INDEX;
            public string Quantity = "10";
        }

        // فاتورة مشتريات
        public class PurchasesBill
        {
            static Data.BankAccount BankAccount = new Data.BankAccount();
            public string Supplier = Data.Supplier.Name;
            public string Store = Data.Store;
            public string Date = Data.Date;
            public string ItemPurchasePrice = "700";
            public string ItemType = Data.ItemType;
            public string ItemName = "Item_" + TEST_INDEX;
            public string PayMethod = "نقدا"; // نقدا - تحويل بنكى - شيك - بطاقات دفع
            ///////////// cash ////////////////////
            public string Treasury = "النقدية بالصندوق";
            ////////////// bank transfer /////////////////
            public string BankAccountCode = "testBankAccount"; //Data.BankAccount.BankAccountCode;
            public string BankTransferNumber = "1234";
            ///////////////// cheque ///////////////////////
            public string ChequeNumber = BankAccount.CheckStart + BankAccount.FirstCheckNumber;
            //////////////// payment card /////////////////////
            public string CardPaymentReceiptNumber = "1234";
            //////////////////////////////////////////////
            public string Quantity = "100";
            public string Price = "500";
            public string Discount = "60";
            public string Tax = Data.Tax;
        }

        public class PurchaseReturnBill
        {
            public string Store = Data.Store;
            public string Date = Data.Date;
            public string Quantity = "50";
            public string Discount = "50";
        }


        public  class assets
        {
            public static string Brand = "Anc";
            public static  string originType = "اجهزة كهربائية2";
            public static string parentclass = "جبنة";
            public static string ageofassets = "10";
            public static string OriginName = "تكيفات6";
            public static string origincode = "9866555";
            public static string Thepriceofassets = "500000";
            public static string Date = "15-2-2023";







        }
        public class SalesBill
        {
            static Data.BankAccount BankAccount = new Data.BankAccount();
            public string Client = Data.Customer.Name;
            public string Store = Data.Store;
            public string Description = "test description" + TEST_INDEX;
            public string Date = Data.Date;
            public string ItemPurchasePrice = "700";
            public string ItemInventoryCategory = InventoryCategory;
            public string ItemName = "Item_" + TEST_INDEX;
            public string PayMethod = "نقدا"; //## نقدا - تحويل بنكى - شيك - بطاقات دفع
            //################### cash ###################
            public string Treasury = "النقدية بالصندوق";
            //################### bank transfer ###################
            public string BankAccountCode = BankAccount.BankAccountCode; //Data.BankAccount.BankAccountCode;
            public string BankTransferNumber = "1234";
            //################### cheque ###################
            public string ChequeNumber = BankAccount.CheckStart + BankAccount.FirstCheckNumber;
            //////////////// payment card ###################
            public string CardPaymentReceiptNumber = "1234";
            //##############################################
            public string Quantity = "10";
            public string Price = "500";
            public string Discount = "0";
            public string CostCenter = Data.CostCenter;
        }
        public class BanReason
        {
            public string Banresaon_name = "BanResaon" + letters[TEST_INDEX];

        }
        public static void Shortcut(String ShortKeys)
        {

            Automation_Testing.Common.Driver.FindElement(By.TagName("Html")).SendKeys(ShortKeys);

        }


        public static void Add_Attachment()
        {
            SendKeys.SendWait("shutterstock_1702317283");
            time.Sleep(1000);
            SendKeys.SendWait("{Enter}");
        }
        public class Buliding

        {
           public string Buliding_name = "عمارة المتولى" + letters[TEST_INDEX];
            public string Address = "المعادي _ مدينة الفرسان";
            public string Describtion = "عمارة المتولى عمارة جميلة";
            public string Property_Purpose = "للبيع او للإيجار";
            public string Amount = "5000000";
            public string Property_Space = "500";
            public string Rent_Value = "2000";
            public string Owner = "";
            public string Distract = "مدينة نصر";




            public static bool check(bool condition, string failmsg)
            {
                if (condition == false)
                {
                    if (testingOnWebsite == false)
                    {
                        Assert.IsTrue(false, failmsg);
                        return false;
                    }
                    else
                    {
                        // TestCases.BankTestCheckbox.BackColor = System.Drawing.Color.FromName("Green");
                        global::System.Windows.Forms.MessageBox.Show(failmsg);
                        return false;
                    }

                }
                else
                {
                    return true;
                }
            }
            
               
         
            }

        }
    }





