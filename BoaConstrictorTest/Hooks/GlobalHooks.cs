using Boa.Constrictor.Logging;
using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using BoaConstrictorTest.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BoaConstrictorTest.Hooks
{
    [Binding]
    public sealed class GlobalHooks
    {
        private ScenarioContext _scenarioContext;
        private IWebDriver driver;

        public GlobalHooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            IActor actor = _scenarioContext.ScenarioContainer.Resolve<Actor>();
            actor.AttemptsTo(QuitWebDriver.ForBrowser());
        }

        [BeforeScenario(Order = 0)]
        public void BeforeScenario()
        {
            WebDriverDriver driverSetup = new(_scenarioContext);
            _scenarioContext.Set(driver, "SeleniumDriver");

            driver = driverSetup.Setup("Chrome");
            IActor actor = new Actor("User", new ConsoleLogger());
            actor.Can(BrowseTheWeb.With(driver));

            _scenarioContext.ScenarioContainer.RegisterInstanceAs(actor);

        }
    }
}
