using TechTalk.SpecFlow;

[Binding]
public class OrderPizzaSteps
{
    [Given("I am on the Pizza Selection page")]
    public void GivenIAmOnThePizzaSelectionPage()
    {
        // Implementation for navigating to Pizza Selection page
    }

    [When("I select a pizza type and quantity")]
    public void WhenISelectAPizzaTypeAndQuantity()
    {
        // Implementation for selecting pizza type and quantity
    }

    [When("I proceed to the Order Checkout page")]
    public void WhenIProceedToTheOrderCheckoutPage()
    {
        // Implementation for navigating to Order Checkout page
    }

    [Then("I should see the order details on the Order Confirmation page")]
    public void ThenIShouldSeeTheOrderDetailsOnTheOrderConfirmationPage()
    {
        // Implementation for verifying order details on the Order Confirmation page
    }
}
