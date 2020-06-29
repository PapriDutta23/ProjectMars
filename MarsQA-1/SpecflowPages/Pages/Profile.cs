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
        //Identifying Profile tab
        //IWebElement MyProfile => Driver.driver.FindElement(By.XPath("//div[contains(@class,'title')]"));

        //Identifying the language button
        IWebElement lnguageBtn => Driver.driver.FindElement(By.XPath("//a[@class='item active'][contains(.,'Languages')]"));

        //Identifying  the skills button
         IWebElement skillsBtn => Driver.driver.FindElement(By.XPath("//a[@class='item'][contains(.,'Skills')]"));

        ////Identifying the education button
        IWebElement educationBtn => Driver.driver.FindElement(By.XPath("//a[@class='item'][contains(.,'Education')]"));

        ////Identifying the certificate button
       IWebElement certificateBtn => Driver.driver.FindElement(By.XPath("//a[@class='item'][contains(.,'Certifications')]"));

        //Declaring Iwebelement variables
        IWebElement ValueAlert;
        IWebElement ValueClose;
       

        public void CheckProfile()
        {
            //Identifying the current profile which I have logged in and then click
            Driver.TurnOnWait();
            IWebElement ProfileIcon = Driver.driver.FindElement(By.XPath("(//a[@href='/Account/Profile'])[2]"));
            ProfileIcon.Click();

            var wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(5));
            wait.Until(d => d.FindElement(By.XPath("//div[contains(@class,'title')]")).Text.Contains("Papri Dutta"));
            IWebElement MyProfile = Driver.driver.FindElement(By.XPath("//div[contains(@class,'title')]"));
            Assert.AreEqual(MyProfile.Text, "Papri Dutta");
        }

        public  void addlanguage()
        {
            Driver.TurnOnWait();
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
            WaitPopUp();
            Assert.AreEqual(ValueAlert.Text, "Bengali has been added to your languages");
            ClosePopUp();
        }
        public  void addskill()
        {

            Driver.TurnOnWait();
            skillsBtn.Click();

            //Identifying add new button and then click
            IWebElement addnewskills = Driver.driver.FindElement(By.XPath("//div[@class='ui teal button'][contains(.,'Add New')]"));
            addnewskills.Click();

            // Identifying add skills text button and then click, sending value
            IWebElement addskillstxt = Driver.driver.FindElement(By.XPath("//input[contains(@placeholder,'Add Skill')]"));
            addskillstxt.Click();
            addskillstxt.SendKeys("Automation Tester");

            //Identifying the skills level dropdown and then click ,  , sending value
            IWebElement skillslevel = Driver.driver.FindElement(By.XPath("//select[contains(@class,'ui fluid dropdown')]"));
            skillslevel.Click();
            skillslevel.SendKeys("Beginner");
            skillslevel.Click();

            //Identifying the add new button and then click
            Driver.TurnOnWait();
            IWebElement skilladd = Driver.driver.FindElement(By.XPath("(//input[contains(@value,'Add')])"));
            skilladd.Click();

            //Assert that the values have been properly accepted by the system
            WaitPopUp();
            Assert.AreEqual(ValueAlert.Text, "Automation Tester has been added to your skills");
            ClosePopUp();

        }
        public   void addeducation()
        {
            Driver.TurnOnWait();
            educationBtn.Click();

            //Identifying add new education button and then click
            IWebElement addneweducation = Driver.driver.FindElement(By.XPath("(//div[@class='ui teal button '][contains(.,'Add New')])[2]"));
            addneweducation.Click();


            // Identifying add college text button and then click, sending value
            IWebElement addcollegetxt = Driver.driver.FindElement(By.XPath("//input[contains(@placeholder,'College/University Name')]"));
            addcollegetxt.Click();
            addcollegetxt.SendKeys("TAFE");

            //Identifying country of college/university dropdown and then click ,sending value
            IWebElement countryofcollege = Driver.driver.FindElement(By.XPath("//select[contains(@name,'country')]"));
            countryofcollege.Click();
            countryofcollege.SendKeys("Australia");

            //Identifying title dropdown button , click , then sending value
            IWebElement titledropdown = Driver.driver.FindElement(By.XPath("//select[contains(@name,'title')]"));
            titledropdown.Click();
            titledropdown.SendKeys("B.Sc");

            //Identifying degree  text type button , click , then sending value
            IWebElement degreetxt = Driver.driver.FindElement(By.XPath("//input[contains(@placeholder,'Degree')]"));
            degreetxt.Click();
            degreetxt.SendKeys("Honours");

            //Identifying year of graduation dropdown button , click , then sending value
            IWebElement graduationyeardropdown = Driver.driver.FindElement(By.XPath("//select[contains(@name,'yearOfGraduation')]"));
            graduationyeardropdown.Click();
            graduationyeardropdown.SendKeys("2018");
            graduationyeardropdown.Click();

            //Identifying the add new button and then click
            Driver.TurnOnWait();
            IWebElement educationadd = Driver.driver.FindElement(By.XPath("(//input[contains(@value,'Add')])"));
            educationadd.Click();

            //Assert that the values have been properly accepted by the system
            WaitPopUp();
            Assert.AreEqual(ValueAlert.Text, "Education has been added");
            ClosePopUp();

        }
        public void addcertificate()
        {
            Driver.TurnOnWait();
            certificateBtn.Click();


            //Identifying add new  certificate button and then click
            IWebElement addnewcertificate = Driver.driver.FindElement(By.XPath("(//div[@class='ui teal button '][contains(.,'Add New')])[3]"));
            addnewcertificate.Click();


            // Identifying add certification/award text button and then click, sending value
            IWebElement addcertificatetxt = Driver.driver.FindElement(By.XPath("//input[contains(@class,'certification-award capitalize')]"));
            addcertificatetxt.Click();
            addcertificatetxt.SendKeys("Beautician");

            //Identifying the certificate from , click ,sending value
            IWebElement certifiactefrom = Driver.driver.FindElement(By.XPath("//input[contains(@class,'received-from capitalize')]"));
            certifiactefrom.Click();
            certifiactefrom.SendKeys("India");

            //Identifying certificate year  , click and then sending value
            IWebElement certificateyear = Driver.driver.FindElement(By.XPath("//select[contains(@name,'certificationYear')]"));
            certificateyear.Click();
            certificateyear.SendKeys("2007");

            //Identifying the add new button and then click
            Driver.TurnOnWait();
            IWebElement certificationadd = Driver.driver.FindElement(By.XPath("(//input[contains(@value,'Add')])"));
            certificationadd.Click();

         }
        public void SuccessNotification()
        {
            //Assert that the values have been properly accepted by the system
            WaitPopUp();
            Assert.AreEqual(ValueAlert.Text, "Beautician has been added to your certification");
            ClosePopUp();

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
            WaitPopUp();
            Assert.AreEqual(ValueAlert.Text, "Hindi has been updated to your languages");
            ClosePopUp();

        }
        public void UpdateSkill()
        {
            //Identifying the SECOND DATA TAB LANGUAGE section and the click
            IWebElement SkillTab = Driver.driver.FindElement(By.XPath("//a[contains(@data-tab,'second')]"));
            SkillTab.Click();
            Driver.TurnOnWait();

            //Identifying pen like update sign icon and then click
            IWebElement SkillsUpdatePen = Driver.driver.FindElement(By.XPath("(//i[contains(@class,'outline write icon')])[3]"));
            SkillsUpdatePen.Click();

            //Identifying the first button in  skill name and then clicking
            IWebElement SkillName = Driver.driver.FindElement(By.XPath("//input[contains(@placeholder,'Add Skill')]"));
            SkillName.Click();

            //Clearing the data from skill name button
            SkillName.Clear();

            //entering the new data in skill button
            SkillName.SendKeys("Manual Tester");

            //Identifying the "Level"(second) button in skill and then click
            IWebElement level_skill = Driver.driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']"));
            level_skill.Click();

            //entering the new data from DROP down box  in skill button
            level_skill.SendKeys("Expert");

            //pressing the update button and then click
            IWebElement UpdtSkillBtn = Driver.driver.FindElement(By.XPath("//input[contains(@value,'Update')]"));
            UpdtSkillBtn.Click();

            //Assert that the values have been properly accepted by the system
            WaitPopUp();
            Assert.AreEqual(ValueAlert.Text, "Manual Tester has been updated to your skills");
            ClosePopUp();

        }
        public void UpdateEducation()

        {

            //Identifying the THIRD DATA TAB LANGUAGE section and the click
            IWebElement EducationTab = Driver.driver.FindElement(By.XPath("//a[contains(@data-tab,'third')]"));
            EducationTab.Click();

            //Identifying pen like update sign icon and then click
            IWebElement EducationUpdatePen = Driver.driver.FindElement(By.XPath("(//i[contains(@class,'outline write icon')])[4]"));
            EducationUpdatePen.Click();

            //Identifying the  "University name" (First button) in  education name and then clicking
            IWebElement UniName = Driver.driver.FindElement(By.XPath("//input[@name='instituteName']"));
            UniName.Click();


            //Clearing the data from skill name button
            UniName.Clear();

            //entering the new data in skill button
            UniName.SendKeys("WBUT");

            //Identifying the "Country"(second)  dropdown button in skill and then click
            IWebElement Country= Driver.driver.FindElement(By.XPath("//select[@name='country']"));
            Country.Click();

            
            //entering the new data  from the Country Dropdown box
            Country.SendKeys("India");

            //Identifying the "TITLE" of the education  Dropdown box and then click
            IWebElement Title = Driver.driver.FindElement(By.XPath("//select[@name='title']"));
            Title.Click();

            //Enterting data in "TITLE" dropdown box
            Title.SendKeys("B.Tech");

            //Identifying the "DEGREE" text box  , click and then clearing the Textbox and Then enetering data
            IWebElement Degree = Driver.driver.FindElement(By.XPath("//input[@name='degree']"));
            Degree.Click();
            Degree.Clear();
            Degree.SendKeys("Graduation");

            //Identifying "Year of Graduation" Dropdown button , click and then selecting data from the Dropdown box
            IWebElement Year = Driver.driver.FindElement(By.XPath("//select[contains(@name,'yearOfGraduation')]"));
            Year.Click();
            Year.SendKeys("2012");


            //pressing the Education update button and then click
            IWebElement UpdtEducationBtn = Driver.driver.FindElement(By.XPath("//input[contains(@value,'Update')]"));
            UpdtEducationBtn.Click();

            //Assert that the values have been properly accepted by the system
            WaitPopUp();
            Assert.AreEqual(ValueAlert.Text, "Education as been updated");
            ClosePopUp();

        }
        public void UpdateCertificate()

        {
            //Identifying the Fourth DATA TAB LANGUAGE section and the click
            IWebElement CertificateTab = Driver.driver.FindElement(By.XPath("//a[contains(@data-tab,'fourth')]"));
            CertificateTab.Click();

            //Identifying pen like update sign icon and then click
            IWebElement CertificateUpdatePen = Driver.driver.FindElement(By.XPath("(//i[contains(@class,'outline write icon')])[5]"));
            CertificateUpdatePen.Click();

            //Identifying the  "Certification name" (First button) in  Ceritification  , clearing the existing data and then clicking and sending data
            IWebElement CertificationName = Driver.driver.FindElement(By.XPath("//input[@name='certificationName']"));
             CertificationName.Click();
            CertificationName.Clear();
            CertificationName.SendKeys("PMTP");

            //Identifying the "Certificate From" (Second button) in Certification , clearing the data and then clicking and then sending data
            IWebElement CertificateFrom = Driver.driver.FindElement(By.XPath("//input[contains(@name,'certificationFrom')]"));
            CertificateFrom.Click();
            CertificateFrom.Clear();
            CertificateFrom.SendKeys("ADACTIN");

            //Identifying the "Certification Year" (Third button) dropdown box , and entering data from Dropdowbn box
            IWebElement CertificationYear = Driver.driver.FindElement(By.XPath("//select[contains(@name,'certificationYear')]"));
            CertificationYear.Click();
            CertificationYear.SendKeys("2020");

            //pressing the Certification update button and then click
            IWebElement UpdtCertificationBtn = Driver.driver.FindElement(By.XPath("//input[contains(@value,'Update')]"));
            UpdtCertificationBtn.Click();

            //Assert that the values have been properly accepted by the system
            WaitPopUp();
            Assert.AreEqual(ValueAlert.Text, "PMTP has been updated to your certification");
            ClosePopUp();


        }
        public void CheckUpdatedValues()
        {
            //Language update check
            //Identifying the FIRST DATA TAB LANGUAGE section and the click
            IWebElement LanguageTab = Driver.driver.FindElement(By.XPath("//a[contains(@data-tab,'first')]"));
            LanguageTab.Click();
            IWebElement LangUpd = Driver.driver.FindElement(By.XPath("//td[contains(.,'Hindi')]"));
            Assert.AreEqual(LangUpd.Text, "Hindi");

            //Skill update check
            //Identifying the SECOND DATA TAB LANGUAGE section and the click
            IWebElement SkillTab = Driver.driver.FindElement(By.XPath("//a[contains(@data-tab,'second')]"));
            SkillTab.Click();
            Driver.TurnOnWait();
            IWebElement SkillUpd = Driver.driver.FindElement(By.XPath("//td[contains(.,'Manual Tester')]"));
            Assert.AreEqual(SkillUpd.Text, "Manual Tester");

            //Education update check
            //Identifying the THIRD DATA TAB LANGUAGE section and the click
            IWebElement EducationTab = Driver.driver.FindElement(By.XPath("//a[contains(@data-tab,'third')]"));
            EducationTab.Click();
            IWebElement EdUpd = Driver.driver.FindElement(By.XPath("//td[contains(.,'WBUT')]"));
            Assert.AreEqual(EdUpd.Text, "WBUT");

            //Certificate update check
            //Identifying the Fourth DATA TAB LANGUAGE section and the click
            IWebElement CertificateTab = Driver.driver.FindElement(By.XPath("//a[contains(@data-tab,'fourth')]"));
            CertificateTab.Click();
            IWebElement CertUpd = Driver.driver.FindElement(By.XPath("//td[contains(.,'PMTP')]"));
            Assert.AreEqual(CertUpd.Text, "PMTP");

        }

        public void WaitPopUp()
        {
            var wait = new WebDriverWait(Driver.driver, new TimeSpan(0, 0, 5));
            wait.Until(WaitDriver => WaitDriver.FindElement(By.XPath("//div[contains(@class,'ns-box-inner')]")));
            ValueAlert = Driver.driver.FindElement(By.XPath("//div[contains(@class,'ns-box-inner')]"));
            Driver.TurnOnWait();
        }

        public void ClosePopUp ()
        {
            var wait = new WebDriverWait(Driver.driver, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(@class,'ns-box-inner')]")));
            ValueClose = Driver.driver.FindElement(By.XPath("//a[contains(@class,'ns-close')]"));
            ValueClose.Click();
            Driver.TurnOnWait();
        }
       
    }


}
