using Boa.Constrictor.Logging;
using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using BoaConstrictorTest.Pages;
using BoaConstrictorTest.Tasks;
using OpenQA.Selenium.Chrome;

namespace BoaConstrictorTest.StepDefinitions
{
    [Binding]
    public class TestFeatureStepDefinitions
    {
        private ScenarioContext _scenarioContext;
        private IActor actor;

        public TestFeatureStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"Mission Control is running in Chrome")]
        public void GivenMissionControlIsRunningInChrome()
        {
            actor = _scenarioContext.ScenarioContainer.Resolve<Actor>();
            actor.AttemptsTo(Navigate.ToUrl(LoginPage.Url));
        }

        [When(@"the user enters the username and password")]
        public void WhenTheUserEntersTheUsernameAndPassword()
        {
            actor.AsksFor(ValueAttribute.Of(LoginPage.emailInput)).Should().BeEmpty();
            actor.AsksFor(ValueAttribute.Of(LoginPage.passwordInput)).Should().BeEmpty();
            actor.AttemptsTo(LoginToMissionControl.With("adminbobby@bluefruit.co.uk", "Password1!"));
        }

        [Then(@"the user is logged in")]
        public void ThenTheUserIsLoggedIn()
        {
            actor.WaitsUntil(Appearance.Of(WelcomePage.universeLabel), IsEqualTo.True());
        }
    }
}
