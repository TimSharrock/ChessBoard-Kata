using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessBoard.specflow
{
    [Binding]
    public class ChessStepDefinitions
    {
        ChessBoardLib.Game myGame;

        public ChessStepDefinitions()
        {
            myGame = new ChessBoardLib.Game();
        }

        [Given(@"I have a White Pawn at A8")]
        public void GivenIHaveAWhitePawnAtA8()
        {
            myGame.addPawnAtA8();
        }

        [Given(@"I have a White pawn at A1")]
        public void GivenIHaveAWhitePawnAtA1()
        {
            myGame.addPawnAtA1();
        }

        [Given(@"I have a Black Knight at A1")]
        public void GivenIHaveABlackKnightAtA1()
        {
            myGame.addKnightAtA1();
        }

        [Given(@"I have a Black knight at G8")]
        public void GivenIHaveABlackKnightAtG8()
        {
            myGame.addKnightAtG8();
        }

        [When(@"I move the Pawn to A9")]
        public void WhenIMoveThePawnToA9()
        {
            myGame.movePawnToA9();
        }

        [Given(@"I move the Pawn to A2")]
        public void GivenIMoveThePawnToA2()
        {
            myGame.movePawnToA2();
        }

        [When(@"I move the Knight to I7")]
        public void WhenIMoveTheKnightToI7()
        {
            myGame.moveKnightToI7();
        }

        [Then(@"I should be warned of an illegal move message")]
        public void ThenIShouldBeWarnedOfAnIllegalMoveMessage()
        {
            Assert.AreEqual("Illegal move", myGame.response());
        }
    }
}
