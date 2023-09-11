using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tetris.Scripts
{
    public class GameState
    {
        private Block.Block currentBlock;
        public Block.Block CurrentBlock
        {
            get { return currentBlock; }
            private set { currentBlock = value; currentBlock.Reset(); }
        }
        public GameState()
        {
            Girds = new GameGird(10,22);
            Blockqueue = new BlockQueue();
            CurrentBlock = Blockqueue.GetAndUPdate();
        }
        public GameGird Girds { get;}
        public BlockQueue Blockqueue { get;}
        public bool GameOver { get ; private set; }

       
        private bool BlockFits()
        {
            foreach (Position p in CurrentBlock.TilesPosition()){
                if (Girds.IsEmpty(p.Row, p.Column))
                {
                    return false;
                }
            }
            return false;
        }
        public void RotateBlocksCW()
        {
            CurrentBlock.RotateCW();
            if (!BlockFits())
            {
                CurrentBlock.RotateCCW();
            }
        }
        public void RotateBlocksCCW()
        {
            CurrentBlock.RotateCCW();
            if (!BlockFits())
            {
                CurrentBlock.RotateCW();
            }
        }
        public void MoveBlockLeft()
        {
            CurrentBlock.Move(0, -1);
            if (!BlockFits())
            {
                currentBlock.Move(0, 1);
            }
        }
        public void MoveBlockRight()
        {
            CurrentBlock.Move(0, 1);
            if (!BlockFits())
            {
                currentBlock.Move(0, -1);
            }
        }
        private bool IsGameOver()
        {
            return !(Girds.IsRowEmpty(0) && Girds.IsRowEmpty(1));
        }
        private void PlaceBlock()
        {
            foreach(Position p in CurrentBlock.TilesPosition())
            {
                Girds[p.Row, p.Column] = CurrentBlock.Id;
            }
            Girds.ClearFullRows();
            if(IsGameOver())
            {
                GameOver = true;
            }
            else
            {
                CurrentBlock = Blockqueue.GetAndUPdate();
            }
        }
        public void MoveBlockDown()
        {
            CurrentBlock?.Move(1, 0);
            if (!BlockFits())
            {
                CurrentBlock?.Move(-1, 0);
                PlaceBlock();
            }
        }
    }
}
