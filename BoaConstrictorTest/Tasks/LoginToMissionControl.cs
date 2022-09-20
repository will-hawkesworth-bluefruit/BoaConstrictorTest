using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using BoaConstrictorTest.Pages;

namespace BoaConstrictorTest.Tasks
{
    public class LoginToMissionControl : ITask
    {
        public string Email { get; }
        public string Password { get; }

        private LoginToMissionControl(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public static LoginToMissionControl With(string email, string password) => new LoginToMissionControl(email, password);

        public void PerformAs(IActor actor)
        {
            actor.AttemptsTo(SendKeys.To(LoginPage.emailInput, Email));
            actor.AttemptsTo(SendKeys.To(LoginPage.passwordInput, Password));
            actor.AttemptsTo(Click.On(LoginPage.loginButton));
        }


    }
}
