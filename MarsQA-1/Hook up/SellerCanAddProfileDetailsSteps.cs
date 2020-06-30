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

        [Given(@"I have added language")]
        public void GivenIHaveAddedLanguage()
        {
            //creating an instance(object) of the class profile
            Profile seller = new Profile();
            seller.AddLanguage();
        }

        [Then(@"I should be able to view the added language")]
        public void ThenIShouldBeAbleToViewTheAddedLanguage()
        {
            //creating an instance(object) of the class profile
            Profile seller = new Profile();
            seller.CheckAddedLanguage();
        }

        [Given(@"I have udpated language")]
        public void GivenIHaveUdpatedLanguage()
        {
            //creating an instance(object) of the class profile
            Profile seller = new Profile();
            seller.UpdateLanguage();
        }


        [Then(@"I should be able to view the updated language")]
        public void ThenIShouldBeAbleToViewTheUpdatedLanguage()
        {
            //creating an instance(object) of the class profile
            Profile seller = new Profile();
            seller.CheckUpdatedLanguage();
        }

        [Given(@"I have deleted language")]
        public void GivenIHaveDeletedLanguage()
        {
            //creating an instance(object) of the class profile
            Profile seller = new Profile();
            seller.DeleteLanguage();
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
