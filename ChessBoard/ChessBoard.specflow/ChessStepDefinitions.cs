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

        [Given(@"I have a White [Pp]awn at (..)")]
        public void GivenIHaveAWhitePawnAt(string pos)
        {
            myGame.addPawn(pos);
        }

        [Given(@"I have a Black [Kk]night at (..)")]
        public void GivenIHaveABlackKnightAt(string pos)
        {
            myGame.addKnight(pos);
        }

        [When(@"I move the Pawn to (..)")]
        [Given(@"I move the Pawn to (..)")]
        public void MoveThePawnTo(string pos)
        {
            myGame.movePawnTo(pos);
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
