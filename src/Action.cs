using System;
using System.Collections.Generic;

namespace CodetasyCliGetStarted
{
    public class Action
    {
        [Command("hello")]
        public void Hello(Dictionary<string, string> args)
        {
            Console.WriteLine($"Hello {args["name"]} {args["lastname"]}");
        }
    }
}
