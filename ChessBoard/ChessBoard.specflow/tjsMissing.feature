Feature: Missing Features

Scenario: Actually Move a Knight
Given I have a Black knight at D4
When I move the Knight to F5
Then the knight should be at F5

Scenario: Do not move a Knight twice in succession
Given I have a Black knight at D4
When I move the Knight to F5
And I move the Knight to H3
Then the knight should be at F5
And I should be shown "Not your turn"

Scenario: Do not move a Pawn twice in succession
Given the Pawn is on A1
When I move the Pawn to A2
And I move the Pawn to A3
Then the pawn should be at A2
And I should be shown "Not your turn"

Scenario: timeout
Given I have a Black knight at D4
And the Pawn is on A1
When I move the Pawn to A2
And I move the Knight to F5
And I move the Pawn to A3
And I move the Knight to H3
Then I should be shown "Draw - timeout"

Scenario: pawn out of space
Given the Pawn is on B8
When I move the Pawn to A1
Then I should be shown "Draw - no pawn move possible"




