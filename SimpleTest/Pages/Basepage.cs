﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

using NUnit.Framework;

namespace Pages
{
    class BasePage 
    {
        String BaseUrl = "http://store.demoqa.com";
        public void TestApp() {
            IWebDriver driver = new ChromeDriver();
            driver.Url = BaseUrl;
                }

        [FindsBy(How = How.CssSelector, Using = "a.account_icon")]
        private static IWebElement MyAccountButton;
        [FindsBy(How = How.LinkText, Using = "Register")]
        private static IWebElement RegisterLink;
        

        public static void openBaseUrl()
        {
            Driver.
        }
        public static void isAccountButtonDisplayed()
        {
        }
        public static void isRegisterLinkDisplayed()
        {

        }
        public static void clickMyAccountButton(){
            MyAccountButton.Click();
           
        }

        public static void clickRegistrationLink()
        {
            RegisterLink.Click();
           
        }
    }
}
