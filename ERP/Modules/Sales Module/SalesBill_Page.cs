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

namespace ERP_Automation_Testing
{
    class SalesBill_Page
    {
        static IWebDriver Driver = Automation_Testing.Common.Driver;

        // Selectors
        //static By Add_Button = By.ClassName("btnAddItem");
        static By Add_Button =                          By.ClassName("btn-success");
        static By ClientName_SelectToggle =             By.CssSelector("#FormManager > div:nth-child(1) > div:nth-child(1) > div > div > a > span.select2-arrow.ui-select-toggle");
        static By ClientName_TextBox =                  By.CssSelector("#FormManager > div:nth-child(1) > div:nth-child(1) > div > div > div > div > input");
        static By StoreName_SelectToggle =              By.CssSelector("#FormManager > div:nth-child(1) > div:nth-child(3) > div > div > a > span.select2-arrow.ui-select-toggle");
        static By StoreName_TextBox =                   By.CssSelector("#FormManager > div:nth-child(1) > div:nth-child(3) > div > div > div > div > input");
        static By Description_TextBox =                 By.CssSelector("#SalesInvoice_Description");
        static By Date_TextBox =                        By.XPath("//*[@placeholder=\"DD-MM-YYYY\"]");
        static By PayMethod_SelectToggle =              By.CssSelector("#FormManager > div:nth-child(1) > div:nth-child(7) > div > div > a > span.select2-arrow.ui-select-toggle");
        static By PayMethod_TextBox =                   By.CssSelector("#FormManager > div:nth-child(1) > div:nth-child(7) > div > div > div > div > input");
        static By TreasuryName_SelectToggle =           By.CssSelector("#Treasury > div > div > a > span.select2-arrow.ui-select-toggle");
        static By TreasuryName_TextBox =                By.CssSelector("#Treasury > div > div > div > div > input");
        static By BankTransferNumber_TextBox =          By.CssSelector("#SalesInvoice_TransferNumber");
        static By BankAccountCode_SelectToggle =        By.CssSelector("#BankAccount > div > div > a > span.select2-arrow.ui-select-toggle");
        static By BankAccountCode_TextBox =             By.CssSelector("#BankAccount > div > div > div > div > input");
        static By ChequeNumber_TextBox =                By.CssSelector("#SalesInvoice_ChequeNumber");
        static By CardPaymentReceiptNumber_TextBox =    By.CssSelector("#SalesInvoice_CardPaymentReceiptNumber");

        static By AddDetails_Button =                   By.CssSelector("#FormManager > center > div > input");
        static By ItemInventoryCategory_SelectToggle =  By.CssSelector("#FormManager > table > tbody > tr > th:nth-child(1) > center > div > div > a > span.select2-arrow.ui-select-toggle");
        static By ItemInventoryCategory_TextBox =       By.CssSelector("#FormManager > table > tbody > tr > th:nth-child(1) > center > div > div > div > div > input");
        static By ItemName_SelectToggle =               By.CssSelector("#FormManager > table > tbody > tr > th:nth-child(2) > center > div > div > a > span.select2-arrow.ui-select-toggle");
        static By ItemName_TextBox =                    By.CssSelector("#FormManager > table > tbody > tr > th:nth-child(2) > center > div > div > div > div > input");
        static By Quantity_TextBox =                    By.CssSelector("#SalesInvoiceDetails_Quantity");
        static By Price_TextBox =                       By.CssSelector("#SalesInvoiceDetails_Price");
        static By Discount_TextBox =                    By.CssSelector("#SalesInvoiceDetails_Discount");
        static By CostCenterName_SelectToggle =         By.CssSelector("#FormManager > table > tbody > tr > th:nth-child(8) > center > div > div > a > span.select2-arrow.ui-select-toggle");
        static By CostCenterName_TextBox =              By.CssSelector("#FormManager > table > tbody > tr > th:nth-child(8) > center > div > div > div > div > input");
        static By AddAttachement_Button =               By.CssSelector("#AttachmentFormManager > div:nth-child(3) > div:nth-child(1) > div > div.drop-box.ng-pristine.ng-untouched.ng-valid.ng-empty > i");
        static By Save_Button =                         By.CssSelector("#mainModal > div > div > div.modal-body > div.modal-footer > input");
        static By NumOfItems_Text =                     By.ClassName("ui-grid-pager-count");
        static By Search_TextBox =                      By.XPath("//*[@placeholder=\"بحث\"]");
        static By Search_Button =                       By.ClassName("btn-light"); 

        public static void Goto()
        {
            Pages.SalessBillPage();
            time.Sleep(2000);

        }
        public static void Add_SalesBill(Data.SalesBill SalesBill) 
	    {
        
            Driver.FindElement(Add_Button).Click();
            time.Sleep(3000);
		
            Driver.FindElement(ClientName_SelectToggle).Click();
            Driver.FindElement(ClientName_TextBox).SendKeys(SalesBill.Client + Keys.Enter);
		
            Driver.FindElement(StoreName_SelectToggle).Click();
            Driver.FindElement(StoreName_TextBox).SendKeys(SalesBill.Store + Keys.Enter);
		
            Driver.FindElement(Description_TextBox).SendKeys(SalesBill.Description);
            Driver.FindElement(Date_TextBox).Clear();
            Driver.FindElement(Date_TextBox).SendKeys(SalesBill.Date);
		
            Driver.FindElement(PayMethod_SelectToggle).Click();
            Driver.FindElement(PayMethod_TextBox).SendKeys(SalesBill.PayMethod + Keys.Enter);
		
            if (SalesBill.PayMethod == "نقدا") 
		    {
                Driver.FindElement(TreasuryName_SelectToggle).Click();
                Driver.FindElement(TreasuryName_TextBox).SendKeys(SalesBill.Treasury + Keys.Enter);
            } 
		    else if (SalesBill.PayMethod == "تحويل بنكى") 
		    {
                Driver.FindElement(BankTransferNumber_TextBox).Clear();
                Driver.FindElement(BankTransferNumber_TextBox).SendKeys(SalesBill.BankTransferNumber);
                Driver.FindElement(BankAccountCode_SelectToggle).Click();
                Driver.FindElement(BankAccountCode_TextBox).SendKeys(SalesBill.BankAccountCode + Keys.Enter);
            }
		    else if (SalesBill.PayMethod == "شيك") 
		    {
                Driver.FindElement(ChequeNumber_TextBox).SendKeys(SalesBill.ChequeNumber);
                Driver.FindElement(BankAccountCode_SelectToggle).Click();
                Driver.FindElement(BankAccountCode_TextBox).SendKeys(SalesBill.BankAccountCode + Keys.Enter);
            }
		    else if (SalesBill.PayMethod == "بطاقات دفع") 
		    {
                Driver.FindElement(CardPaymentReceiptNumber_TextBox).SendKeys(SalesBill.CardPaymentReceiptNumber);
                Driver.FindElement(BankAccountCode_SelectToggle).Click();
                Driver.FindElement(BankAccountCode_TextBox).SendKeys(SalesBill.BankAccountCode + Keys.Enter);
            }
            Driver.FindElement(AddDetails_Button).Click();
            //################## item details ##################
            Driver.FindElement(ItemInventoryCategory_SelectToggle).Click();
            Driver.FindElement(ItemInventoryCategory_TextBox).SendKeys(SalesBill.ItemInventoryCategory + Keys.Enter);
		
            Driver.FindElement(ItemName_SelectToggle).Click();
            Driver.FindElement(ItemName_TextBox).SendKeys(SalesBill.ItemName + Keys.Enter);
		
            Driver.FindElement(Quantity_TextBox).Clear();
            Driver.FindElement(Quantity_TextBox).SendKeys(SalesBill.Quantity);
		
            Driver.FindElement(Price_TextBox).Clear();
            Driver.FindElement(Price_TextBox).SendKeys(SalesBill.Price);
		
            Driver.FindElement(Discount_TextBox).Clear();
            Driver.FindElement(Discount_TextBox).SendKeys(SalesBill.Discount);
		
            Driver.FindElement(CostCenterName_SelectToggle).Click();
            Driver.FindElement(CostCenterName_TextBox).SendKeys(SalesBill.CostCenter + Keys.Enter);
		
            Driver.FindElement(AddAttachement_Button).Click();
            time.Sleep(2000);
            Data.Add_Attachment();
            time.Sleep(3000);
		
            Driver.FindElement(Save_Button).Click();
            time.Sleep(3000);
        }

        public static string Number_Of_Items()
        {
            return Driver.FindElement(NumOfItems_Text).Text;
        }

        public static string Search(string item)
        {
            Driver.FindElement(Search_TextBox).Clear();
            Driver.FindElement(Search_TextBox).SendKeys(item);
            Driver.FindElement(Search_Button).Click();
            time.Sleep(1000);

            if (Driver.FindElement(NumOfItems_Text).Text == "1 - 1 من 1")
            {
                return "Exist";
            }
            else if (Driver.FindElement(NumOfItems_Text).GetAttribute("class") == "ng-binding ng-hide")
            {
                return "NotExist";
            }
            else
            {
                return "Repeated";
            }
        }

    }
}
