﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Settings;

namespace Pages
{
    public abstract class BasePage

    {
        protected IWebDriver driver;
        
        protected BasePage()
        {
            driver = Browsers.GetDriver;
            PageFactory.InitElements(driver, this);
        }
        
    }
}

