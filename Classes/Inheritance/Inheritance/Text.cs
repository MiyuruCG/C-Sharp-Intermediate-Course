﻿using System;

namespace Inheritance
{
    public class Text : Presentation
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperLink(string url)
        {
            Console.WriteLine("We added a link to "+url);
        }
    }
}
