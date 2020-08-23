using System;
using System.Collections.Generic;
using System.Text;

namespace Forest
{
    public class Forest
    {
        public Tree[,] Trees { get; set; }
        public Forest(int length, int weight, int milisecondsIterrations)
        {
            Trees = new Tree[weight, length];
            for (int i = 0; i < weight; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Trees[i, j] = new Tree();
                }
            }
        }

        public void MAkeConnection(double chance)
        {
            for (int i = 0; i < Trees.GetLength(0); i++)
            {
                for (int j = 0; j < Trees.GetLength(1); j++)
                {
                    Random rander = new Random();
                    int rand = rander.Next(1, 101);
                    if (chance >= rand)
                    {
                        Trees[i, j].Connected = Trees[i, j + 1]; //ToDo: make validation on array index
                    }
                }
            }
        }
    }
}
