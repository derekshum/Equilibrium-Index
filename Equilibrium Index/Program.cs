using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Given an array of ints A, find the index if any where sum(A[0]...A[i-1]) = sum(A[i+1]...A[N-1]), where N is the length of the array, in O(n) time

namespace Equilibrium_Index
{
	class Program
	{
		static void Main(string[] args)
		{
			
		}

		public int solution(int[] A)
		{
			long rightSum = 0;
			long leftSum = 0;
			long a = 0;
			for (int i = 0; i < A.Length; i++)
			{
				rightSum += (long)A[i];
			}
			for (int i = 0; i < A.Length; i++)
			{
				a = (long)A[i];
				rightSum -= a;
				if (leftSum == rightSum)
				{
					return i;
				}
				leftSum += a;
			}
			return -1;
			/*
			long countSum = 0;
			long aSum = 0;
			for (int i = 0; i < A.Length; i++)
			{
				aSum += (long)A[i];
			}

			for (int i = 0; i < A.Length; i++)
			{
				if (2 * countSum == (aSum - (long)A[i]))
				{
					return i;
				}
				countSum += (long)A[i];
			}
			return -1; 
			*/
		}
	}
}
