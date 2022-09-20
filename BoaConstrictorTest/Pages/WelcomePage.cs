using Boa.Constrictor.WebDriver;
using OpenQA.Selenium;
using static Boa.Constrictor.WebDriver.WebLocator;

namespace BoaConstrictorTest.Pages
{
    public static class WelcomePage
    {
        public static IWebLocator universeLabel => L("Hello Universe Label", By.XPath("//h1[contains(text(), 'Hello, Universe!')]"));
        public static IWebLocator welcomeLabel => L("Welcome Label", By.XPath("//h5[contains(text(), 'Welcome to Mission Control.')]"));
    }
}
