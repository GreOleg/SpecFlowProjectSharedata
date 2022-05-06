namespace SpecFlowProjectSharedata.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly Calculator _calculator = new Calculator();        
        private int _result;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [When("I enter \"(.*?)\" use \"(.*?)\" and enter \"(.*?)\"")]
        public void WhenEnterTwoNumbersAndChoseOperation(int numberFirst, string operation, int numberSecond)
        {
            _calculator.FirstNumber = numberFirst;
            _calculator.SecondNumber = numberSecond;
            switch (operation)
            {   
                case "+":
                    _result = _calculator.Add();
                    break;
                case "-":
                    _result = _calculator.Subtract();
                    break;
                case "*":
                    _result = _calculator.Multiply();
                    break;
                case "/":
                    _result = _calculator.Divide();
                    break;
            }
        }

        [Then("I expect number \"(.*?)\"")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }
    }
}