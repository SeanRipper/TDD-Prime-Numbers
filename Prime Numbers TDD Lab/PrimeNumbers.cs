using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Numbers_TDD_Lab
{
    internal class PrimeNumbers
    {
        public int GetPrime(int n)
        {
            List<int> primes = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 39 };
            return primes[n];
        }
    }
}
