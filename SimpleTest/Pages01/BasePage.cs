﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Helpers;

namespace Pages01
{
    public abstract class BasePage

    {
        private IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = Browsers.GetDriver;
            PageFactory.InitElements(driver, this);
        }



    }
}
