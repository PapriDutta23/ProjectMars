using MarsQA_1.Helpers;
using MarsQA_1.Pages;
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
        
        //Login into the website
        [Given(@"I have logged into the website")]
        public void GivenIHaveLoggedIntoTheWebsite()
        {
            //call the SignIn class
            SignIn.SigninStep();
            
            //creating an instance(object) of the class profile
            Profile seller = new Profile();
            seller.CheckProfile();

        }



        //ADD LANGUAGE
        [Given(@"I have added language")]
        public void GivenIHaveAddedLanguage()
        {
            //creating an instance(object) of the class profile
            Profile seller = new Profile();
            seller.AddLanguage();
        }

        [When(@"I press the add button")]
        public void WhenIPressTheAddButton()
        {
            //creating an instance(object) of the class profile
            Profile seller = new Profile();
            seller.PressAddButton();
        }

        [Then(@"I should be able to view the added language")]
        public void ThenIShouldBeAbleToViewTheAddedLanguage()
        {
            //creating an instance(object) of the class profile
            Profile seller = new Profile();
            seller.CheckAddedLanguage();
        }




        //UPDATE LANGUAGE
        [Given(@"I have udpated language")]
        public void GivenIHaveUdpatedLanguage()
        {
            //creating an instance(object) of the class profile
            Profile seller = new Profile();
            seller.UpdateLanguage();
        }

        [When(@"I press the update button")]
        public void WhenIPressTheUpdateButton()
        {
            //creating an instance(object) of the class profile
            Profile seller = new Profile();
            seller.PressUpdateButton();
        }

        [Then(@"I should be able to view the updated language")]
        public void ThenIShouldBeAbleToViewTheUpdatedLanguage()
        {
            //creating an instance(object) of the class profile
            Profile seller = new Profile();
            seller.CheckUpdatedLanguage();
        }



        //DELETE LANGUAGE

        [Given(@"I have clicked the language tab")]
        public void GivenIHaveClickedTheLanguageTab()
        {
            //creating an instance(object) of the class profile
            Profile seller = new Profile();
            seller.GotoLanguage();
        }

        [When(@"I have pressed the delete sign")]
        public void WhenIHavePressedTheDeleteSign()
        {
            //creating an instance(object) of the class profile
            Profile seller = new Profile();
            seller.PressDelete();
        }

        [Then(@"I should be able to view no language")]
        public void ThenIShouldBeAbleToViewNoLanguage()
        {
            //creating an instance(object) of the class profile
            Profile seller = new Profile();
            bool Value = seller.CheckDeletedLanguage();
            //check the assertion whether there is no value available 
            Assert.AreEqual(Value, true);
        }


    }
}
