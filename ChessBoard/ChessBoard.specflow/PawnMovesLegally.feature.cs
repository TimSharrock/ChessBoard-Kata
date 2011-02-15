// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.5.0.0
//      Runtime Version:4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace ChessBoard.specflow
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.5.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class MovingThePawn_Feature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PawnMovesLegally.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Moving the Pawn.", "In order to play chess\r\nAs a Player\r\nI want to move the Pawn legally.", GenerationTargetLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn Starts on home row.")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnStartsOnHomeRow_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Pawn Starts on home row.", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
testRunner.Given("the game has just started");
#line 8
testRunner.And("the Pawn is on B2");
#line 9
testRunner.And("the Knight is at G8");
#line 10
testRunner.When("I move the Pawn to B3");
#line 11
testRunner.Then("I should be shown \"Pawn to B3\"");
#line 12
testRunner.And("Pawn should be at B3");
#line 14
testRunner.Given("the game has just started");
#line 15
testRunner.And("the Pawn is on E2");
#line 16
testRunner.And("the Knight is at G8");
#line 17
testRunner.When("I move the Pawn to E4");
#line 18
testRunner.Then("I should be shown \"Pawn to E4\"");
#line 19
testRunner.And("Pawn should be at E4");
#line 21
testRunner.Given("the game has not just started");
#line 22
testRunner.And("the Pawn is on D2");
#line 23
testRunner.And("the Knight is at G8");
#line 24
testRunner.When("I move the Pawn to D4");
#line 25
testRunner.Then("I should be shown \"Pawn cannot move 2 spaces unless it in the first round and is " +
                    "on the home row.\"");
#line 26
testRunner.And("Pawn should be at D2");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn tries taking move when nothing to capture")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnTriesTakingMoveWhenNothingToCapture()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Pawn tries taking move when nothing to capture", ((string[])(null)));
#line 28
this.ScenarioSetup(scenarioInfo);
#line 29
testRunner.Given("I have a White Pawn at D7");
#line 30
testRunner.And("I have a Black knight at G8");
#line 31
testRunner.When("I move the Pawn to C8");
#line 32
testRunner.Then("I should be shown \"Pawn cannot diagonally unless it is capturing a piece.\"");
#line 33
testRunner.And("Pawn should be at D7");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void PawnMovesIllegally(string position)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Pawn moves illegally", ((string[])(null)));
#line 35
this.ScenarioSetup(scenarioInfo);
#line 36
testRunner.Given("I have a White Pawn at D7");
#line 37
testRunner.And("I have a Black knight at G8");
#line 38
testRunner.And("the valid moves are D8");
#line 39
testRunner.When(string.Format("I move the Pawn to {0}", position));
#line 40
testRunner.Then("I should be shown \"illegal move\"");
#line 41
testRunner.And("Pawn should be at D7");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_A1()
        {
            this.PawnMovesIllegally("A1");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_A2()
        {
            this.PawnMovesIllegally("A2");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_A3()
        {
            this.PawnMovesIllegally("A3");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_A4()
        {
            this.PawnMovesIllegally("A4");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_A5()
        {
            this.PawnMovesIllegally("A5");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_A6()
        {
            this.PawnMovesIllegally("A6");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_A7()
        {
            this.PawnMovesIllegally("A7");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_A8()
        {
            this.PawnMovesIllegally("A8");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_B1()
        {
            this.PawnMovesIllegally("B1");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_B2()
        {
            this.PawnMovesIllegally("B2");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_B3()
        {
            this.PawnMovesIllegally("B3");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_B4()
        {
            this.PawnMovesIllegally("B4");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_B5()
        {
            this.PawnMovesIllegally("B5");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_B6()
        {
            this.PawnMovesIllegally("B6");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_B7()
        {
            this.PawnMovesIllegally("B7");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_B8()
        {
            this.PawnMovesIllegally("B8");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_C1()
        {
            this.PawnMovesIllegally("C1");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_C2()
        {
            this.PawnMovesIllegally("C2");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_C3()
        {
            this.PawnMovesIllegally("C3");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_C4()
        {
            this.PawnMovesIllegally("C4");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_C5()
        {
            this.PawnMovesIllegally("C5");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_C6()
        {
            this.PawnMovesIllegally("C6");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_C7()
        {
            this.PawnMovesIllegally("C7");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_C8()
        {
            this.PawnMovesIllegally("C8");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_D1()
        {
            this.PawnMovesIllegally("D1");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_D2()
        {
            this.PawnMovesIllegally("D2");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_D3()
        {
            this.PawnMovesIllegally("D3");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_D4()
        {
            this.PawnMovesIllegally("D4");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_D5()
        {
            this.PawnMovesIllegally("D5");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_D6()
        {
            this.PawnMovesIllegally("D6");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_D7()
        {
            this.PawnMovesIllegally("D7");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_D8()
        {
            this.PawnMovesIllegally("D8");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_E1()
        {
            this.PawnMovesIllegally("E1");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_E2()
        {
            this.PawnMovesIllegally("E2");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_E3()
        {
            this.PawnMovesIllegally("E3");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_E4()
        {
            this.PawnMovesIllegally("E4");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_E5()
        {
            this.PawnMovesIllegally("E5");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_E7()
        {
            this.PawnMovesIllegally("E7");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_E8()
        {
            this.PawnMovesIllegally("E8");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_F1()
        {
            this.PawnMovesIllegally("F1");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_F2()
        {
            this.PawnMovesIllegally("F2");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_F3()
        {
            this.PawnMovesIllegally("F3");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_F4()
        {
            this.PawnMovesIllegally("F4");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_F5()
        {
            this.PawnMovesIllegally("F5");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_F6()
        {
            this.PawnMovesIllegally("F6");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_F7()
        {
            this.PawnMovesIllegally("F7");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_F8()
        {
            this.PawnMovesIllegally("F8");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_G1()
        {
            this.PawnMovesIllegally("G1");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_G2()
        {
            this.PawnMovesIllegally("G2");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_G3()
        {
            this.PawnMovesIllegally("G3");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_G4()
        {
            this.PawnMovesIllegally("G4");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_G5()
        {
            this.PawnMovesIllegally("G5");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_G6()
        {
            this.PawnMovesIllegally("G6");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_G7()
        {
            this.PawnMovesIllegally("G7");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_G8()
        {
            this.PawnMovesIllegally("G8");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_H1()
        {
            this.PawnMovesIllegally("H1");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_H2()
        {
            this.PawnMovesIllegally("H2");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_H3()
        {
            this.PawnMovesIllegally("H3");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_H4()
        {
            this.PawnMovesIllegally("H4");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_H5()
        {
            this.PawnMovesIllegally("H5");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_H6()
        {
            this.PawnMovesIllegally("H6");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_H7()
        {
            this.PawnMovesIllegally("H7");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Pawn moves illegally")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Moving the Pawn.")]
        public virtual void PawnMovesIllegally_Positions_H8()
        {
            this.PawnMovesIllegally("H8");
        }
    }
}
#endregion
