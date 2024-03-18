using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using NEXT_BASKET_Updated_.Steps;// Import the AmazonPage class





namespace YourNamespace
{
    [Binding]
    public class AmazonShoppingSteps
    {
        private IWebDriver driver;

        public object SeleniumExtras { get; private set; }

        private IWebDriver _driver;
        private AmazonPage _amazonPage;

        [BeforeScenario]
        public void BeforeScenario()
        {
            // Initialize WebDriver and AmazonPage before each scenario
            _driver = new ChromeDriver();
            _amazonPage = new AmazonPage(_driver);


        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (_driver != null)
            {
                // Quit WebDriver after each scenario, ensuring proper cleanup
                _driver.Quit(); 
            }
        }

        [Given(@"I navigate to Amazon website")]
        public void GivenINavigateToAmazonWebsite()
        {
            // Navigate to Amazon website using AmazonPage method
            _amazonPage.NavigateToAmazonWebsite();
            // Wait for the page to load completely
            Thread.Sleep(15000);
        }





        [When(@"I search for ""(.*)""")]
        public void WhenISearchFor(string searchText)

        {

            // Search for the provided text using AmazonPage method
            _amazonPage.SearchForProduct(searchText);
            // Click on the image of the first product in the search results
            _amazonPage.ClickOnFirstProductImage();
           

        }
            [When(@"I add the corresponding item to the cart")]
        public void WhenIAddTheCorrespondingItemToTheCart()
        {

            // Add the currently viewed product to the cart using AmazonPage method
            _amazonPage.AddProductToCart();
          

        }

        [Then(@"I navigate to the cart")]
        public void ThenINavigateToTheCart()
        {

            // Navigate to the cart page using AmazonPage method
            _amazonPage.NavigateToCart();
           
        }

        [Then(@"I validate the correct item and amount is displayed")]
        public void ThenIValidateTheCorrectItemAndAmountIsDisplayed()
        {
           
            // Validate that the correct item price is displayed using AmazonPage method
            Assert.That(_amazonPage.GetProductPrice(), Is.EqualTo("$40.49"));

        }
    }
}
