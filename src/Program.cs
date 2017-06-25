using System;
using Codetasy.Cli;

namespace CodetasyCliGetStarted
{
    class Program
    {
        static void Main(string[] args)
        {
            new Cli(args).Run(new Action());
        }
    }
}
