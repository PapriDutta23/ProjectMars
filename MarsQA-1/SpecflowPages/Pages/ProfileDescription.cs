using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Threading;

namespace MarsQA_1.SpecflowPages.Pages
{
    public class ProfileDescription
    {
        //Identifying the small Triangle type SIGN dropdown 
        IWebElement TriangleSign => Driver.driver.FindElement(By.XPath("(//i[contains(@class,'dropdown icon')])[2]"));

        //Identifying the first name button
        IWebElement FirstNameButton => Driver.driver.FindElement(By.XPath("//input[contains(@name,'firstName')]"));

        //Identifying the last name button
        IWebElement LastNameButton => Driver.driver.FindElement(By.XPath("//input[contains(@name,'lastName')]"));

        //Identifying the availability update symbol
        IWebElement AvailabilityUpdate => Driver.driver.FindElement(By.XPath("(//i[@class='right floated outline small write icon'])[1]"));

        //Identifying the availability dropdown
        IWebElement AvailabilityDropdown => Driver.driver.FindElement(By.XPath("//select[contains(@name,'availabiltyType')]"));

        //Identifying the  hours update symbol
        IWebElement HoursUpdate => Driver.driver.FindElement(By.XPath("(//i[@class='right floated outline small write icon'])[2]"));

        //Identifying the  availability hours pen like button
        IWebElement HoursDropdown => Driver.driver.FindElement(By.XPath("//select[contains(@name,'availabiltyHour')]"));

        //Identifying the Earn Target update button
        IWebElement EarnTargetUpdate => Driver.driver.FindElement(By.XPath("(//i[@class='right floated outline small write icon'])[3]"));

        //Identifying the Earn Target pen like button
        IWebElement EarnTargetDropdown => Driver.driver.FindElement(By.XPath("//select[contains(@name,'availabiltyTarget')]"));

        
        public void AddAvailability()
        {
            //Clicking the availabilityy update sign
            AvailabilityUpdate.Click();
                    
            //Clicking the availability dropdown and then choosing value by Text
            AvailabilityDropdown.Click();
            AvailabilityDropdown.SendKeys("Full Time");
            AvailabilityDropdown.Click();
            SuccessAlert();
          
        }
        public void AddHours()
        {
            //Clicking the hour update sign
            HoursUpdate.Click();
                                  
            //Clicking the Hours dropdown 
            HoursDropdown.Click();
            HoursDropdown.SendKeys("As needed");
            HoursDropdown.Click();
            SuccessAlert();

        }
        public void AddEarnTarget()
        {

            //Clicking the Earn Target update button
            EarnTargetUpdate.Click();
            
            //Clicking the Earn Target pen like button
            EarnTargetDropdown.Click();
            EarnTargetDropdown.SendKeys("More than $1000 per month");
            EarnTargetDropdown.Click();

            
        }

        

        public void SuccessAlert()
        {
            var wait = new WebDriverWait(Driver.driver, new TimeSpan(0, 0, 10));
            wait.Until(WaitDriver => WaitDriver.FindElement(By.XPath("//div[contains(@class,'ns-box-inner')]")).Text.Contains("Availability updated"));
            IWebElement ValueAlert = Driver.driver.FindElement(By.XPath("//div[contains(@class,'ns-box-inner')]"));
            Assert.AreEqual(ValueAlert.Text, "Availability updated");
        }

    }
    
}
