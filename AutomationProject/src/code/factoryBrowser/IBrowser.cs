﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationProject.src.code.factoryBrowser
{
    public interface IBrowser
    {
        IWebDriver Create();
    }
}
