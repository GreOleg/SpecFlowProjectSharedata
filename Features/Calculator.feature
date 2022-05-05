Feature: Calculator

 Scenario Outline: Opreations

    When I ennter "<num1>" use "<operation>" and enter "<num2>"
    Then I expect number "<result>"

    Examples:
    |num1|operation|num2| result|
    |2   |+        |2   |4      |
    |6   |-        |4   |2      |
    |2   |*        |4   |8      |
    |18  |/        |2   |9      |