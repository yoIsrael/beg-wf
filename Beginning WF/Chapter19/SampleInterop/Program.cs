﻿using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

namespace SampleInterop
{

    class Program
    {
        static void Main(string[] args)
        {
            WorkflowInvoker.Invoke(new Workflow1());

            Console.WriteLine("Press ENTER to exit");
            Console.ReadLine();
        }
    }
}
