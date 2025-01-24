using Microsoft.Playwright;
using Microsoft.Playwright.MSTest;
using PlaywrightTests.PageObjects;

namespace PlaywrightTests
{
    [TestClass]
    public class UITestingPlaygroundTest : PageTest
    {

        [TestMethod]
        public async Task SuccessfulLoginUsingPOM()
        {
            var textInputPage = new TextInputPage(Page);

            // Navigate to the login page
            string newButtonName = "test";

            // Act
            await textInputPage.NavigateAsync();
            await textInputPage.EnterTextAsync(newButtonName);

            // Assert
            var buttonText = await textInputPage.Button.InnerTextAsync();
            Assert.AreEqual(newButtonName, buttonText);

        }

        [TestMethod]
        public async Task ButtonNameUpdatesAfterTextEntry()
        {
            // Arrange
            var textInputPage = new TextInputPage(Page);

            string newButtonName = "hello";

            // Act
            await textInputPage.NavigateAsync();
            await textInputPage.EnterTextAsync(newButtonName);

            // Assert
            var buttonText = await textInputPage.Button.InnerTextAsync();
            Assert.AreEqual(newButtonName, buttonText);

        }

        [TestMethod]
        public async Task ButtonClickExecutesSuccessfully()
        {
            // Arrange
            var textInputPage = new TextInputPage(Page);

            // Act
            await textInputPage.NavigateAsync();
            await textInputPage.ClickbuttonAsync();

        }

        [TestMethod]
        public async Task RetrieveButtonTextSuccessfully()
        {
            // Arrange
            var textInputPage = new TextInputPage(Page);

            string expectedText = "Button That Should Change it's Name Based on Input Value";

            // Act
            await textInputPage.NavigateAsync();
            var buttonText = await textInputPage.Button.InnerTextAsync();

            // Assert
            Assert.AreEqual(expectedText, buttonText);


        }
    }
}