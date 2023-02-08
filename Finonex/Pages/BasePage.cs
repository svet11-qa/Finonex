using Finonex.Browser;
using OpenQA.Selenium;

namespace Finonex.Pages
{
    internal class BasePage
    {
        User user = new();
        DriverSettings driverSettings;
        Random random = new Random();

        protected readonly By FirstNameInput = By.XPath("//input[@name='FirstName']");
        protected readonly By LastNameInput = By.XPath("//input[@name='LastName']");
        protected readonly By EmailtInput = By.XPath("//input[@name='Email']");
        protected readonly By PhoneInput = By.XPath("//input[@name='Phone']");

        public void AddFirstName()
        {
            user.FirstName = ("John");
            DriverSettings.driver.FindElement(FirstNameInput).SendKeys(user.FirstName);
        }
        public void AddLastName()
        {
            user.LastName = ("Doe");
            DriverSettings.driver.FindElement(LastNameInput).SendKeys(user.LastName);
        }

        public void AddEmail()
        {
            var mail = random.Next(1, 999).ToString();
            user.Email = mail;
            DriverSettings.driver.FindElement(EmailtInput).SendKeys(mail);
        }

        public void AddPhone() => DriverSettings.driver.FindElement(PhoneInput).SendKeys("");

        public void AddUser()
        {
            AddFirstName();
            AddLastName();
        }
    }
}
