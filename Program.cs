using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinAvgTwoSlice
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //string S = "CAGCCTA";
            //int[] P = { 2, 5, 0 };
            //int[] Q = { 4, 5, 6 };
            int[] A = { 4, 2, 2, 5, 1, 5, 8 };
            Console.WriteLine(s.solution(A));
            Console.ReadLine();
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            int result = 0;
            int min = 10001;
            int N = A.Length;
            for (int i = 1; i < N; i++) {
                if ((i < N - 1) && (A[i] + A[i + 1]) / 2 < min) {
                    min = (A[i] + A[i + 1]) / 2;
                    result = i;
                }
                if ((i < N - 2) && (A[i] + A[i + 1] + A[i + 2]) / 3 < min) {
                    min=(A[i] + A[i + 1]+A[i+2]) / 3;
                    result = i;
                }
            }
            
            return result;
        }
    }
}
