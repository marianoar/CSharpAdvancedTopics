﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExthensionMethods
{
    public static class StringExtensions
    {
        public static string Shorten(this string str, int numberOfWords)
        {
            if(numberOfWords < 0)
                throw new ArgumentOutOfRangeException("number of word must be greater than zero");

            if (numberOfWords == 0)
                return string.Empty;

            var words = str.Split(' ');
            if (words.Length <= numberOfWords)
                return str;

            return string.Join("-", words.Take(numberOfWords));
        }
    }
}
