using System;

namespace CS.Impl._01_Basic
{
    public class Sentence
    {
        public string Reverse(string sentence)
        {
            string[] cut = sentence.Split(" ");
            Array.Reverse(cut);
            return String.Join(" ",cut);
        }
    }
}