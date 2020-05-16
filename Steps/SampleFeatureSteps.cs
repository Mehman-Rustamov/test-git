using System;
using TechTalk.SpecFlow;

namespace SprcFlow_NUnits
{
    [Binding]
    public class SampleFeatureSteps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(string p0)
        {
            Console.WriteLine("Вывод текста = " + p0);
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
    
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
  
        }
    }
}
