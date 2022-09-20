using Boa.Constrictor.WebDriver;
using OpenQA.Selenium;
using static Boa.Constrictor.WebDriver.WebLocator;

namespace BoaConstrictorTest.Pages
{
    public static class NavigationBar
    {
        public static IWebLocator projectList => L("Project Select Drop Down Menu", By.Id("select-project"));
        public static IWebLocator userManagementLink => L("User Management Page Link", By.CssSelector("[href*='Identity/Account/Manage']"));
        public static IWebLocator logoutButton => L("Log out Button", By.XPath("//button[contains(text(), 'Log Out')]"));
        public static IWebLocator colourModeButton => L("Light/Dark Mode Button", By.ClassName("awesome-button"));
        public static IWebLocator homePageButton => L("Home Page Button", By.Id("nav-link-home"));
        public static IWebLocator roadmapPageButton => L("Roadmap Page Button", By.Id("nav-link-roadmap"));
        public static IWebLocator featuresPageButton => L("Features Page Button", By.Id("nav-link-features"));
        public static IWebLocator kanbanPageButton => L("Kanban Page Button", By.Id("nav-link-kanban"));
        public static IWebLocator reportsPageButton => L("Reports Page Button", By.Id("nav-link-reports"));
        public static IWebLocator testingPageButton => L("Testing Page Button", By.Id("nav-link-testing"));
        public static IWebLocator administrationPageButton => L("Administration Page Button", By.Id("nav-link-administration"));
        public static IWebLocator diagnosticsPageButton => L("Diagnostics Page Button", By.Id("nav-link-diagnostics"));

    }
}

