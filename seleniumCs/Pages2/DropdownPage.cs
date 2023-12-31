﻿using seleniumCs.Utils;

namespace seleniumCs.Pages2
{
    public class DropdownPage : Inits
    {

        readonly By dropdown = By.Id("dropdown");

        public DropdownPage(IWebDriver driver, WebDriverWait wait) {
            this.driver = driver;
            this.wait = wait;
        }

        public void DropdownAction(string option)
        {
            IWebElement getOptionTxt = driver.FindElement(By.XPath($"//option[contains(text(), '{option}')]"));

            driver.FindElement(dropdown).Click();
            SelectElement select = new(driver.FindElement(dropdown));
            select.SelectByText(option);

            Console.WriteLine(getOptionTxt.GetAttribute("selected"));
            Assert.That(getOptionTxt.Selected, Is.True);
        }
    }
}
