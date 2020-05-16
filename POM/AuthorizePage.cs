using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SprcFlow_NUnits.POM
{
    class AuthorizePage
    {
        public By UserNameField;
        public By PasswordField;
        public By LoginButton;
        public By RegistrationLink;
        public By Logo;
        public IWebDriver driver;

      
        public AuthorizePage(IWebDriver driver)
        {
            this.driver = driver;
            UserNameField = By.Id("nicknameEntry");
            PasswordField = By.Id("passwordEntry");
            LoginButton = By.Id("entry");
            RegistrationLink = By.Id("reg");
            Logo = By.XPath("//div[@id='containerEntry']//div[@class = 'logo__logo'] ");
            driver.Navigate().GoToUrl("http://e-chat-ub.eu-4.evennode.com/");

        }

        public void SetUserName(string name)
        {
            driver.FindElement(UserNameField).SendKeys(name);
        }
        

        public void SetPassword(string password)
        {
            driver.FindElement(PasswordField).SendKeys(password);

        }

        public void ClickSubmitButton()
        {
            driver.FindElement(LoginButton).Click();
        }

        public void Authorise(string name, string passworld)
        {
            SetUserName(name);
            SetPassword(passworld);
            ClickSubmitButton();
        }


    }
}
