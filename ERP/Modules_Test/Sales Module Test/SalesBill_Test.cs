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
//using System.Windows.Forms;



namespace ERP_Automation_Testing
{

    class M6_Sales_N1_SalesBill_Test
    {
        [SetUp]
        public static void Test_Init()
        {
            Automation_Testing.Common.Driver.Manage().Window.Maximize();
            Login_Page.LoginAsAdmin();
            SalesBill_Page.Goto();
        }

        [Test]
        [TestCase("Cash")]
        [TestCase("Bank_Transfer")]
        [TestCase("Cheque")]
        [TestCase("Payment_Cards")]

        public void T1_Add_SalesBill_Test(string Test_PaymentMethod)
        {
            string NoOfItemsBefore = " ", NoOfItemsAfter = " ";
            SalesBill_Page.Search(""); // BUG "عدم ظهور فواتير المشتريات الا بعد الضغط على زرار البحث"

            NoOfItemsBefore = SalesBill_Page.Number_Of_Items();
            Data.SalesBill NewSalesBill = new Data.SalesBill();

            switch (Test_PaymentMethod)
            {
                case "Cash":
                    NewSalesBill.PayMethod = "نقدا";
                    break;
                case "Bank_Transfer":
                    NewSalesBill.PayMethod = "تحويل بنكى";
                    break;
                case "Cheque":
                    NewSalesBill.PayMethod = "شيك";
                    break;
                case "Payment_Cards":
                    NewSalesBill.PayMethod = "بطاقات دفع";
                    break;
                default:
                    NewSalesBill.PayMethod = "نقدا";
                    break;
            }
            NewSalesBill.CostCenter = "مبيعات مصباح";
            // NewSalesBill.PayMethod = Test_PaymentMethod;
            SalesBill_Page.Add_SalesBill(NewSalesBill);
            NoOfItemsAfter = SalesBill_Page.Number_Of_Items();


            Assert.True(NoOfItemsBefore != NoOfItemsAfter, "T1_Add_SalesBill_" + Test_PaymentMethod + "_Test Failed");

        }

    }
}
