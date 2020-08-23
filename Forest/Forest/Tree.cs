using System;
using System.Collections.Generic;
using System.Text;

namespace Forest
{
    public enum TreeState 
    {
        health = 'o',
        burned = 'x',
        dead = '.'
    }
    public class Tree
    {
        public TreeState State { get; set; }
        public int Health { get; set; }
        public Tree Connected { get; set; }
        public Tree()
        {
            State = TreeState.health;
            Health = 3;
        }
        public void Burn()
        {
            State = TreeState.burned;
        }
    }
}
