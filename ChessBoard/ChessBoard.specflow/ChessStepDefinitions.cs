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

        [Given(@"the game has just started")]
        public void GivenTheGameHasJustStarted()
        {
            myGame.setMoveNumber(0);
        }

        [Given(@"the game has not just started")]
        public void GivenTheGameHasNotJustStarted()
        {
            myGame.setMoveNumber(2);
        }

        [Given(@"I have a White [Pp]awn at (..)")]
        [Given(@"the Pawn is on (..)")]
        public void GivenIHaveAWhitePawnAt(string pos)
        {
            myGame.addPawn(pos);
        }

        [Given(@"I have a Black [Kk]night at (..)")]
        [Given(@"the Knight is at (..)")]
        public void GivenIHaveABlackKnightAt(string pos)
        {
            myGame.addKnight(pos);
        }

        [Given(@"the valid moves are")]
        public void GivenTheValidMovesAre(Table table)
        {
            // ignore them
        }

        [When(@"I move the Pawn to (..)")]
        [Given(@"I move the Pawn to (..)")]
        [When(@"the pawn moves to (..)")]
        [Given(@"the Pawn moves to (..)")]
        public void MoveThePawnTo(string pos)
        {
            myGame.movePawnTo(pos);
        }

        [When(@"I move the Knight to (..)")]
        public void WhenIMoveTheKnightTo(string pos)
        {
            myGame.moveKnightTo(pos);
        }

        [Then(@"Pawn should be at (..)")]
        [Then(@"the pawn should be at (..)")]
        public void ThenPawnShouldBeAt(string pos)
        {
            Assert.AreEqual(pos, myGame.pawnPosition());
        }

        [Then(@"the knight should be at (..)")]
        public void ThenTheKnightShouldBeAt(string pos)
        {
            Assert.AreEqual(pos, myGame.knightPosition());
        }

        [Then(@"I should be shown ""(.*)""")]
        public void ThenIShouldBeShownMessage(string message)
        {
            string response = myGame.response();
            Assert.IsTrue(response.Contains(message),"\""+message+"\" not found in \""+response+"\"");
        }

        [Then(@"I should be warned of an illegal move message")]
        public void ThenIShouldBeWarnedOfAnIllegalMoveMessage()
        {
            Assert.AreEqual("illegal move", myGame.response(), true);
        }

        [Then(@"the pawn should be taken")]
        public void ThenThePawnShouldBeTaken()
        {
            Assert.AreEqual("", myGame.pawnPosition(), true);
        }

        [Then(@"the knight should be taken")]
        public void ThenTheKnightShouldBeTaken()
        {
           Assert.AreEqual("", myGame.knightPosition(), true);
        }

        [Given(@"the valid moves are (..)")]
        public void GivenTheValidMovesAre(string pos)
        {
            // ignore
        }
    }
}
