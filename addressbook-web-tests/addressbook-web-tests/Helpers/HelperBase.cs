﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests.Helpers
{
    public class HelperBase
    {
        protected IWebDriver driver;
        public HelperBase (IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}