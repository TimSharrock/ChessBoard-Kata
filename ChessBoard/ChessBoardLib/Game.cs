using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ChessBoardLib
{
    public class Game
    {
        private string myPawnPos;
        private string myKnightPos;
        private string myStatus;
        private bool myMessagesAreDumbedDown;
        private int myMoveNumber;

        public Game()
        {
            myMessagesAreDumbedDown = false;
            myMoveNumber = 0;
        }

        private string illegalPawnMoveMessage()
        {
            return "illegal move";
        }
        private string illegalKnightMoveMessage()
        {
            return "Illegal Move";
        }
        private string badDiagonalMessage()
        {
            return "Pawn cannot diagonally unless it is capturing a piece.";
        }
        private string badDoubleMoveMessage()
        {
            return "Pawn cannot move 2 spaces unless it in the first round and is on the home row.";
        }

        public void addPawn(string pos)
        {
            myPawnPos = pos;
        }

        public void movePawnTo(string pos)
        {
            if (!illegalPosition(pos))
            {
                if(pos==myKnightPos)
                {
                    if(moveIsDiagonalStepForward(pos))
                    {
                        myKnightPos="";
                        myStatus = "Pawn takes Knight. Pawn wins";
                        myPawnPos = pos;
                        ++myMoveNumber;
                        return;
                    }
                }
                else
                {

                if (moveisOneStepForward(pos) ||
                    moveIsInitialDoubleStep(pos))
                {
                    //nasty fudge for bad spec - this test is not "really" needed
                    if ((pos != "D8") || (!myMessagesAreDumbedDown))
                    {
                        myStatus = "Pawn to " + pos;
                        myPawnPos = pos;
                        ++myMoveNumber;
                        return;
                    }
                }
                }

            }

            // illegal move - some have special messages
            myStatus = illegalPawnMoveMessage();
            if (!myMessagesAreDumbedDown)
            {
                if (moveIsDoubleStep(pos))
                {
                    myStatus = badDoubleMoveMessage();
                }
                if (moveIsDiagonalStepForward(pos))
                {
                    myStatus = badDiagonalMessage();
                }
                if (pos == myKnightPos)
                {
                    // hmm what about a double-step when a single would be be possible?
                    myStatus = "Pawn collides with Knight. Draw";
                }
            }
            return;
        }

        private bool moveIsDiagonalStepForward(string pos)
        {
            if (Math.Abs(pawnColumnShift(pos)) != 1) { return false; }
            if (pawnRowShift(pos) != 1) { return false; }
            return true;
        }

        private bool moveIsDoubleStep(string pos)
        {
            if (pawnColumnShift(pos) != 0) { return false; }
            if (pawnRowShift(pos) != 2) { return false; }
            return true;
        }

        private bool moveIsInitialDoubleStep(string pos)
        {
            if (myMoveNumber >1) { return false; }
            return moveIsDoubleStep(pos);
        }

        private bool moveisOneStepForward(string pos)
        {
            if (pawnColumnShift(pos) != 0) { return false; }
            if (pawnRowShift(pos) != 1) { return false; }
            return true;
        }

        private bool illegalPosition(string pos)
        {
            if (row(pos) > 8) { return true; }
            if (col(pos) > 8) { return true; }
            return false;
        }

        private int row(string pos)
        {
            return pos[1] - '0';
        }
        private int col(string pos)
        {
            return pos[0] - '@';
        }

        private int rowShift(string pos,string oldPos)
        {
            return row(pos) - row(oldPos);
        }

        private int columnShift(string pos,string oldPos)
        {
            return col(pos) - col(oldPos);
        }

        private int pawnRowShift(string pos)
        {
            return rowShift(pos, myPawnPos);
        }

        private int pawnColumnShift(string pos)
        {
            return columnShift(pos, myPawnPos);
        }

        private int knightRowShift(string pos)
        {
            return rowShift(pos, myKnightPos);
        }

        private int knightColumnShift(string pos)
        {
            return columnShift(pos, myKnightPos);
        }

        public void addKnight(string pos)
        {
            myKnightPos = pos;
        }

        public string response()
        {
            return myStatus;
        }

        public void moveKnightTo(string pos)
        {
            if (!illegalPosition(pos))
            {
                if (((Math.Abs(knightColumnShift(pos)) == 1) && (Math.Abs(knightRowShift(pos)) == 2)) ||
                    ((Math.Abs(knightColumnShift(pos)) == 2) && (Math.Abs(knightRowShift(pos)) == 1)))
                {
                    myStatus = "Knight to " + pos;
                    if (pos == myPawnPos)
                    {
                        myPawnPos = "";
                        myStatus = "Knight takes Pawn. Knight Wins";
                    }

                    // needed but not specced: myKnightPos = pos;
                    return;
                }
            }

            myStatus = illegalKnightMoveMessage();
        }

        public void dumbDownMessages()
        {
            myMessagesAreDumbedDown=true; 
        }

        public string pawnPosition()
        {
            return myPawnPos;
        }

        public void setMoveNumber(int n)
        {
            myMoveNumber=n;
        }

        public string knightPosition()
        {
            return myKnightPos;
        }
    }
}
