Feature: Pizza Ordering

  Scenario: User selects a pizza
    Given the user is on the Pizza Selection page
    When the user selects a pizza type
    Then the selected pizza details should be displayed on the Order Checkout page

  Scenario: User checks out the order
    Given the user is on the Order Checkout page
    When the user provides the quantity for the selected pizza
    And clicks on the Checkout button
    Then the user should be redirected to the Order Confirmation page

  Scenario: Order confirmation details
    Given the user is on the Order Confirmation page
    Then the order ID, amount, and type of pizza should be displayed

