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
                    for (int k = i-1; k < i+2; k++)
                    {
                        for (int p = j-1; p < j+2; p++)
                        {
                            try
                            {
                                Random rander = new Random();
                                int rand = rander.Next(1, 101);
                                if (chance >= rand)
                                {
                                    Trees[i, j].Connected = Trees[k, p];
                                }
                            }
                            catch (IndexOutOfRangeException) { }
                            catch (NullReferenceException) 
                            {
                                if(Trees[i,j]==null)
                                {
                                    Trees[i, j] = new Tree();
                                    if(--j == -1) 
                                    {
                                        i--;
                                        j = Trees.GetLength(1);
                                    }

                                }
                                else 
                                {
                                    Trees[k, p] = new Tree();
                                    if (--p == -1)
                                    {
                                        k--;
                                        p = Trees.GetLength(1);
                                    }


                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
