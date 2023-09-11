using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris.Scripts
{
    public class BlockQueue
    {
        private readonly Block.Block[] blocks = new Block.Block[]
        {
              new Block.IBlock(),
              new Block.JBlock(),
              new Block.OBlock(),
              new Block.ZBlock(),
              new Block.TBlock(),
              new Block.ZBlock(),
              new Block.LBlock(),
        };
        private readonly Random random= new Random();
        public Block.Block NextBlock { get; set; }
        public BlockQueue() {
            NextBlock = RandomBlock();
        }
        private Block.Block RandomBlock()
        {
            return blocks[random.Next(blocks.Length)];
        }
        public Block.Block GetAndUPdate()
        {
            Block.Block block = NextBlock;
            do
            {
                block = RandomBlock();
            } while (block.Id == NextBlock.Id);
            return block;
        }

    }
}
