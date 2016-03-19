using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_Game
{
    public class ItemStack
    {
        public Item item;
        
        public int count; 
        public ItemStack()
        {
            item = new Item();
            count = 1; 
        }
    }

}
