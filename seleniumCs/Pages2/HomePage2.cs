﻿using seleniumCs.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumCs.Pages2
{
    public class HomePage2:Inits
    {

        //readonly By dropdownBtn = By.XPath("//a[contains(text(),'Dropdown')]");
        public readonly By headerTxt = By.XPath("""//h1[@class="heading"]""");

        public HomePage2(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;  
        }

        public void ClickMenus(string menuName)
        {
            By el = By.XPath($"//a[contains(text(), '{menuName}')]");
            wait.Until(ExpectedConditions.ElementToBeClickable(el)).Click();

        }

    }
}
