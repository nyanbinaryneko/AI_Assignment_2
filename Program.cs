﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesmanSolver solve = new SalesmanSolver(2000, 50);
            solve.Run();
            //Console.Write(solve);
            //Console.ReadKey();
        }
    }
}
