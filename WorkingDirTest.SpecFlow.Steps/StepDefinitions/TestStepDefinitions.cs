using WorkingDirTest.SpecFlow.Steps.WindowForm;

namespace WorkingDirTest.SpecFlow.Steps.StepDefinitions
{
    [Binding]
    public sealed class TestStepDefinitons
    {
        private Form _form;
        public TestStepDefinitons(Form form)
        {
            _form = form;
        }

        [When("the button is clicked")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _form.ClickButton();
        }

        [Then("the label text should be (.*)")]
        public void ThenTheResultShouldBe(string result)
        {
            _form.GetLableText().Should().Be(result);
        }
    }
}