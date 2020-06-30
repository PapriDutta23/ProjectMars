using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    public class Profile
    {
        

        public void CheckProfile()
        {
            //Identifying the current profile which I have logged in and then click
            Driver.TurnOnWait();
            IWebElement ProfileIcon = Driver.driver.FindElement(By.XPath("(//a[@href='/Account/Profile'])[2]"));
            ProfileIcon.Click();

            //Wait for the profile icon to be refreshed
            var wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(5));
            wait.Until(d => d.FindElement(By.XPath("//div[contains(@class,'title')]")).Text.Contains("Papri Dutta"));
            IWebElement MyProfile = Driver.driver.FindElement(By.XPath("//div[contains(@class,'title')]"));
           
            //Assert that I am in the right profile
            Assert.AreEqual(MyProfile.Text, "Papri Dutta");
        }

        public  void AddLanguage()
        {
             Driver.TurnOnWait();
            //Identifying the language button
            IWebElement lnguageBtn = Driver.driver.FindElement(By.XPath("//a[@class='item active'][contains(.,'Languages')]"));
            lnguageBtn.Click();

            //Identifying add new button and then click
            IWebElement addnewlanguage = Driver.driver.FindElement(By.XPath("(//div[contains(.,'Add New')])[11]"));
            addnewlanguage.Click();

            //Identifying add language text button and then click  , sending value
            IWebElement addlanguagetxt = Driver.driver.FindElement(By.XPath("//*[@type='text'][@placeholder='Add Language']"));
            addlanguagetxt.Click();
            addlanguagetxt.SendKeys("Bengali");

            //Identifying the language level dropdown and then click ,  , sending value
            IWebElement languagelevel = Driver.driver.FindElement(By.XPath("//*[contains(@name , 'level')]"));
            languagelevel.Click();
            languagelevel.SendKeys("Native/Bilingual");
           

            //Identifying the add button, click , sending value
            Driver.TurnOnWait();
            IWebElement languageadd = Driver.driver.FindElement(By.XPath("(//input[contains(@value,'Add')])"));
            languageadd.Click();

            //Assert that the values have been properly accepted by the system
            var wait = new WebDriverWait(Driver.driver, new TimeSpan(0, 0, 10));
            wait.Until(WaitDriver => WaitDriver.FindElement(By.XPath("//div[contains(@class,'ns-box-inner')]")));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(@class,'ns-box-inner')]")));
            IWebElement ValueAlert = Driver.driver.FindElement(By.XPath("//div[contains(@class,'ns-box-inner')]"));
            Driver.TurnOnWait();
            Assert.AreEqual(ValueAlert.Text, "Bengali has been added to your languages");
            IWebElement ValueClose = Driver.driver.FindElement(By.XPath("//a[contains(@class,'ns-close')]"));
            ValueClose.Click();
            Driver.TurnOnWait();
        }

        public void CheckAddedLanguage()
        {
            //Language update check
            //Identifying the FIRST DATA TAB LANGUAGE section and the click
            IWebElement LanguageTab = Driver.driver.FindElement(By.XPath("//a[contains(@data-tab,'first')]"));
            LanguageTab.Click();
            Driver.TurnOnWait();

            //Assert the selection of the languages
            try
            {
                //Assert the selction of the languages
                IWebElement LangUpd = Driver.driver.FindElement(By.XPath("//div[@data-tab='first']//table//tbody//tr[1]//td[1]"));
                Assert.AreEqual(LangUpd.Text, "Bengali");
                IWebElement Level = Driver.driver.FindElement(By.XPath("//div[@data-tab='first']//table//tbody//tr[1]//td[2]"));
                Assert.AreEqual(Level.Text, "Native/Bilingual");
            }
            catch (Exception)
            {
                Assert.Fail();
            }


        }

        public void UpdateLanguage()
        {
      

            //Identifying the FIRST DATA TAB LANGUAGE section and the click
            IWebElement LanguageTab = Driver.driver.FindElement(By.XPath("//a[contains(@data-tab,'first')]"));
            LanguageTab.Click();

            //Identifying pen like update sign icon and then click
            IWebElement LanguageUpdatePen = Driver.driver.FindElement(By.XPath("(//i[contains(@class,'outline write icon')])[2]"));
            LanguageUpdatePen.Click();

            //Identifying the first button in  language name and then clicking
            IWebElement LanguageName = Driver.driver.FindElement(By.XPath("//input[contains(@placeholder,'Add Language')]"));
            LanguageName.Click();

            //Clearing the data from language name button
            LanguageName.Clear();

            //entering the new data in language button
            LanguageName.SendKeys("Hindi");

            //Identifying the "Level"(second) button in language and then click
            IWebElement level_language = Driver.driver.FindElement(By.XPath("//select[@name='level']"));
            level_language.Click();
                        
            //entering the new data from Dropdown box in language level  button
            level_language.SendKeys("Basic");
            level_language.Click();

            //pressing the update button and then click
            IWebElement UpdtLanguageBtn = Driver.driver.FindElement(By.XPath("(//input[@value='Update'])[1]"));
            UpdtLanguageBtn.Click();

            //Assert that the values have been properly accepted by the system
            var wait = new WebDriverWait(Driver.driver, new TimeSpan(0, 0, 10));
            wait.Until(WaitDriver => WaitDriver.FindElement(By.XPath("//div[contains(@class,'ns-box-inner')]")));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(@class,'ns-box-inner')]")));
            IWebElement ValueAlert = Driver.driver.FindElement(By.XPath("//div[contains(@class,'ns-box-inner')]"));
            Driver.TurnOnWait();
            Assert.AreEqual(ValueAlert.Text, "Hindi has been updated to your languages");
            IWebElement ValueClose = Driver.driver.FindElement(By.XPath("//a[contains(@class,'ns-close')]"));
            ValueClose.Click();
            Driver.TurnOnWait();
        }

        public void CheckUpdatedLanguage()
        {
            //Language update check
            //Identifying the FIRST DATA TAB LANGUAGE section and the click
            IWebElement LanguageTab = Driver.driver.FindElement(By.XPath("//a[contains(@data-tab,'first')]"));
            LanguageTab.Click();
            Driver.TurnOnWait();

            //Assert the selction of the languages
            try
            {
                IWebElement LangUpd = Driver.driver.FindElement(By.XPath("//div[@data-tab='first']//table//tbody//tr[1]//td[1]"));
                Assert.AreEqual(LangUpd.Text, "Hindi");
                IWebElement Level = Driver.driver.FindElement(By.XPath("//div[@data-tab='first']//table//tbody//tr[1]//td[2]"));
                Assert.AreEqual(Level.Text, "Basic");
            }
            catch (Exception)
            {
                Assert.Fail();
            }

        }

        
        public void DeleteLanguage()
        {
            //Identifying the FIRST DATA TAB LANGUAGE section and the click
            IWebElement LanguageTab = Driver.driver.FindElement(By.XPath("//a[contains(@data-tab,'first')]"));
            LanguageTab.Click();

            //identifying the delete sign
            IWebElement LanguageDelete = Driver.driver.FindElement(By.XPath("//i[contains(@class,'remove icon')]"));
            LanguageDelete.Click();
            Driver.TurnOnWait();

            //Assert that the values have been properly accepted by the system
            var wait = new WebDriverWait(Driver.driver, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(@class,'ns-box-inner')]")));
            IWebElement ValueClose = Driver.driver.FindElement(By.XPath("//a[contains(@class,'ns-close')]"));
            ValueClose.Click();
            Driver.TurnOnWait();

        }

        public bool CheckDeletedLanguage()
        {
            // validate if there is any data post deletion
            
            try
            {
                Driver.driver.FindElement(By.XPath("//div[@data-tab='first']//table//tbody//tr[1]//td[1]"));
                return false;

            }
            catch (NoSuchElementException)
            {
                return true;
            }
        }
       


    }


}
