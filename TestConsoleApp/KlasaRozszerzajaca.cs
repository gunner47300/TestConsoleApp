﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    static class KlasaRozszerzajaca
    {
        public static bool isFirstLetterCapitalized(this string a)
        {
            Console.WriteLine("GitHub Test");
            return Char.IsUpper(a[0]);
        }
    }
}
