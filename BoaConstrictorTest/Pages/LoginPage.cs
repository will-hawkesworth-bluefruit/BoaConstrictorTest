using Boa.Constrictor.WebDriver;
using OpenQA.Selenium;
using static Boa.Constrictor.WebDriver.WebLocator;

namespace BoaConstrictorTest.Pages
{
    public static class LoginPage
    {

        public const string Url = "http://192.168.3.63/Identity/Account/Login";

        public static IWebLocator emailInput => L("Login Email Field", By.Id("Input_Email"));
        public static IWebLocator passwordInput => L("Login Password Field", By.Id("Input_Password"));
        public static IWebLocator loginButton => L("Login Email Field", By.XPath("//button[contains(text(), 'Log in')]"));



    }
}
