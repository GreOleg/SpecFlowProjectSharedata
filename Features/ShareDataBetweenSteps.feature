Feature: ShareDataBetweenSteps

 Scenario Outline: Calculate

    When I enter "<number1>"
    And I also enter "<number2>"
    And I chose "<operation>"
    Then I expect "<result>"

        Examples:
    |number1|operation|number2|result|
    |9      |+        |2      |11    |
    |10     |-        |4      |6     |
    |3      |*        |4      |12    |
    |18     |/        |3      |6     |