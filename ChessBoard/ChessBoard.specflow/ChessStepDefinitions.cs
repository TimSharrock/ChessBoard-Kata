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
        public void ThenPawnShouldBeAt(string pos)
        {
            Assert.AreEqual(pos, myGame.pawnPosition());
        }

        [Then(@"I should be shown ""(.*)""")]
        public void ThenIShouldBeShownMessage(string message)
        {
            Assert.AreEqual(message, myGame.response());
        }

        [Then(@"I should be warned of an illegal move message")]
        public void ThenIShouldBeWarnedOfAnIllegalMoveMessage()
        {
            Assert.AreEqual("illegal move", myGame.response(),true);
        }



        [Given(@"the valid moves are (..)")]
        public void GivenTheValidMovesAre(string pos)
        {
            myGame.dumbDownMessages();
        }
    }
}
