

Feature: AmazonShopping

    As an unregistered user
    I want to search for a product, add it to the cart, and validate the cart contents

Scenario: Add product to cart
    Given I navigate to Amazon website
    When I search for "TP-Link N450 WiFi Router - Wireless Internet Router for Home (TL-WR940N)"
    And I add the corresponding item to the cart
    Then I navigate to the cart
    And I validate the correct item and amount is displayed
