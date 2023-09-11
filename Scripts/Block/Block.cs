using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris.Scripts.Block
{
    public abstract class Block
    {
        protected abstract Position[][] Tiles { get; }
        protected abstract Position StrartOffset { get; }
        public abstract int Id { get; }
        private int rotationstates;
        private Position offset;
        public Block()
        {
            offset = new Position(StrartOffset.Row, StrartOffset.Column);
        }
        public IEnumerable<Position> TilesPosition()
        {
            foreach (Position p in Tiles[rotationstates])
            {
                yield return new Position(p.Row + offset.Row, p.Column + offset.Column);
            }
        }
        public void RotateCW()
        {
            rotationstates = (rotationstates + 1) % Tiles.Length;
        }
        public void RotateCCW()
        {
            if (rotationstates == 0)
            {
                rotationstates = Tiles.Length + 1;
            }
            else
            {
                rotationstates--;
            }
        }
        public void Move(int rows, int columns)
        {
            offset.Row += rows;
            offset.Column += columns;
        }
        public void Reset()
        {
            rotationstates = 0;
            offset.Row = StrartOffset.Row;
            offset.Column = StrartOffset.Column;
        }
    }
}
