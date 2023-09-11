using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris.Scripts
{
    public class GameGird
    {
        private readonly int[,] Girds;

        private int Rows { get; }
        private int Columns { get; }
        
        public int this[int r , int c]
        {
            get => Girds[r , c];
            set => Girds[r , c] = value;
        }
        public GameGird(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            Girds = new int[Rows, Columns];
        }
        public bool Isinsize(int r, int c)
        {
            return r >=0 && r < Rows && c>=0 && r<Columns;
        }
        public bool IsEmpty(int r, int c)
        {
            return Isinsize(r, c) && Girds[r, c] == 0;
        }
        public bool Isrowfull(int r)
        {
            for(int i = 0; i < Columns; i++)
            {
                if (Girds[r, i] == 0) return false;
            }
            return true;
        }
        public bool IsRowEmpty(int r)
        {
            for(int i = 0 ; i < Columns; i++)
            {
                if (Girds[r, i] != 0) return false;
            }
            return true;
        }
        public void ClearRow(int r)
        {
            for(int i = 0; i < Columns ; i++)
            {
                Girds[r, i] = 0;
            }
        }
        public void MoveRowDown(int r , int numRows)
        {
            for(int i = 0; i < Columns; i++)
            {
                Girds[r + numRows,i] = Girds[r, i];
                Girds[r, i] = 0;
            }
        }
        public int ClearFullRows()
        {
            int cleared = 0 ;
            for(int r = Rows-1; r >= 0 ; r--)
            {
                if (Isrowfull(r))
                {
                    ClearRow(r);
                    cleared++;
                }else if (cleared > 0)
                {
                    MoveRowDown(r, cleared);
                }
            }
            return cleared;
        }

    }
}
