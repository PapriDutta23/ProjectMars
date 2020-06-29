using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA_1.Hook_up
{
    [Binding]
    public class SellerCanAddProfileDetailsSteps
    {
        [Given(@"I have logged into the website")]
        public void GivenIHaveLoggedIntoTheWebsite()
        {
            //creating an instance(object) of the class profile
            Profile seller = new Profile();
            seller.CheckProfile();
        }
        [Given(@"I have entered language  , skills , education , certificate with Valid data")]
        public void GivenIHaveEnteredLanguageSkillsEducationCertificateWithValidData()
        {
            //creating an instance(object) of the class profile
            Profile seller = new Profile();
            seller.addlanguage();
            seller.addskill();
            seller.addeducation();
            seller.addcertificate();

        }
        [Then(@"I should receive an alert message of 'Successful addition""")]
        public void ThenIShouldReceiveAnAlertMessageOfSuccessfulAddition()
        {
            //Creating another instance of (object) of the class profile
            Profile seller2 = new Profile();
            seller2.SuccessNotification();

        }
       

        

       
        
       
        [Given(@"I have selected valid data from dropdown for hours,avavilability,earn target")]
        public void GivenIHaveSelectedValidDataFromDropdownForHoursAvavilabilityEarnTarget()
        {
            //Creating an instance of Profile description
            ProfileDescription person = new ProfileDescription();
            person.AddAvailability();
            person.AddHours();
            person.AddEarnTarget();
        }
        [Then(@"I should receive message of successful addition")]
        public void ThenIShouldReceiveMessageOfSuccessfulAddition()
        {
            ProfileDescription person = new ProfileDescription();
            person.SuccessAlert();
        }



        [Given(@"I have logged into the website and I go to My profile section")]
        public void GivenIHaveLoggedIntoTheWebsiteAndIGoToMyProfileSection()
        {
            //creating an instance(object) of the class profile
            Profile seller = new Profile();
            seller.CheckProfile();


        }
        [Given(@"I will click the ""(.*)"" button for the respective language , skill , education , certification tab and update the data")]
        public void GivenIWillClickTheButtonForTheRespectiveLanguageSkillEducationCertificationTabAndUpdateTheData(string p0)
        {
            //Creating an instance(object) of the class "Profile"
            Profile seller2 = new Profile();
            seller2.UpdateLanguage();
            seller2.UpdateSkill();
            seller2.UpdateEducation();
            seller2.UpdateCertificate();
        }
        [Then(@"I should be able to view the update information in '(.*)' section")]
        public void ThenIShouldBeAbleToViewTheUpdateInformationInSection(string p0)
        {
            //Identifying "My Profile" Tab and then click
            IWebElement MyProfile = Driver.driver.FindElement(By.XPath("(//a[@href='/Account/Profile'])[2]"));
            Driver.TurnOnWait();
            Profile seller3 = new Profile();
            seller3.CheckUpdatedValues();

        }

































        [Then(@"I am able to see it in my newly created profile")]
        public void ThenIAmAbleToSeeItInMyNewlyCreatedProfile()
        {
        //    ScenarioContext.Current.Pending();
        }

        


    }
}
