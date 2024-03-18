using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace NEXT_BASKET_Updated_.Steps
{


    

    public class AmazonPage
    {
        private readonly IWebDriver _driver;

        public AmazonPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Method to navigate to the Amazon website
        public void NavigateToAmazonWebsite()
        {
            _driver.Navigate().GoToUrl("https://www.amazon.com/");
        }
        // Method to search for a product using the provided search text
        public void SearchForProduct(string searchText)
        {
            IWebElement searchBox = _driver.FindElement(By.Id("twotabsearchtextbox"));
            searchBox.SendKeys(searchText);
            searchBox.SendKeys(Keys.Enter);
        }
        // Method to click on the image of the first product in the search results
        public void ClickOnFirstProductImage()
        {
            IWebElement firstProductImage = _driver.FindElement(By.CssSelector(".s-result-item .s-image"));
            firstProductImage.Click();
        }
        // Method to add the currently viewed product to the cart
        public void AddProductToCart()
        {
            IWebElement addToCartButton = _driver.FindElement(By.Id("add-to-cart-button"));
            addToCartButton.Click();
        }
        // Method to navigate to the cart page
        public void NavigateToCart()
        {
            IWebElement cartIcon = _driver.FindElement(By.Id("nav-cart-text-container"));
            cartIcon.Click();
        }
        // Method to get the price of the product displayed in the cart
        public string GetProductPrice()
        {
            IWebElement priceElement = _driver.FindElement(By.CssSelector(".sc-badge-price-to-pay .a-section .a-size-medium"));
            return priceElement.Text;
        }

    }


}
