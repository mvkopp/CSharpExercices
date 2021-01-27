using System;

namespace CS.Impl._01_Basic
{
    public class Sentence
    {
        public string Reverse(string sentence)
        {
            char[] charArray = sentence.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
