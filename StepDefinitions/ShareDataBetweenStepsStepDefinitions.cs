using NUnit.Framework;

namespace SpecFlowProjectSharedata.StepDefinitions
{
    public class ShareDataBetweenStepsStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        public ShareDataBetweenStepsStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [When("I enter \"(.*?)\"")]
        public void WhenIEntre(int numberFirst)
        {
            _scenarioContext["Number1"] = numberFirst;
        }

        [When("I also enter \"(.*?)\"")]
        public void WhenIAlsoEnter(int numberSecond)
        {
            _scenarioContext["Number2"] = numberSecond;
        }

        [When("I chose \"(.*?)\"")]
        public void WhenIChose(string operation)
        {
            switch (operation)
            {
                case "+":
                    _scenarioContext["Result"] = (int)_scenarioContext["Number1"] + (int)_scenarioContext["Number2"];
                    break;
                case "-":
                    _scenarioContext["Result"] = (int)_scenarioContext["Number1"] - (int)_scenarioContext["Number2"];
                    break;
                case "*":
                    _scenarioContext["Result"] = (int)_scenarioContext["Number1"] * (int)_scenarioContext["Number2"];
                    break;
                case "/":
                    _scenarioContext["Result"] = (int)_scenarioContext["Number1"] / (int)_scenarioContext["Number2"];
                    break;
            }
        }

        [Then("I expect \"(.*?)\"")]
        public void ThenIExpect(int result)
        {
            Assert.AreEqual(_scenarioContext["Result"], result);
        }
    }
}
