using System;
using System.Collections.Generic;

namespace CS.Impl._02_Intermediate
{
    public class Recursion
    {
        private List<int> naturalNumber = new List<int>();

        public IEnumerable<int> GetNaturalNumbers(int n)
        {
            naturalNumber.Add(n);
            if (n <= 1) return naturalNumber;
            return GetNaturalNumbers(n - 1);
        }

        private IEnumerable<int> GetNaturalNumbers(List<int> naturalNumbers, int current, int max)
        {
            throw new NotImplementedException();
        }

        public int SumNaturalNumbers(int n)
        {
            throw new NotImplementedException();
        }

        private int ComputeSum(int min, int current)
        {
            throw new NotImplementedException();
        }

        public bool IsPrime(int n)
        {
            throw new NotImplementedException();
        }

        private bool IsPrime(int n, int current)
        {
            throw new NotImplementedException();
        }

        public bool IsPalindrome(string text)
        {
            throw new NotImplementedException();
        }
    }
}
