using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araay
{
	internal class Arithmetic
	{

		public void Addition()
		{
			Console.WriteLine("Enter How Many Number You Print");
			int PrintNumber = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter Number");

			int[] num = new int[PrintNumber];

			for(int i = 0; i<PrintNumber; i++)
			{
				num[i] = Convert.ToInt32(Console.ReadLine());
			}

			int Result = 0;
			for(int i = 0; i<PrintNumber; i++)
			{
				Result= Result + num[i];
			}
			Console.Write("Addition Of Number is " + Result);
		}

		public void OddEvenNumber()
		{
			Console.WriteLine("Enter How Many Number You Print");
			int PrintNumber = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter Number");
			int[] num = new int[PrintNumber];

			for(int i = 0;i<PrintNumber; i++)
			{
				num[i]= Convert.ToInt32(Console.ReadLine());
			}

			Console.WriteLine("Odd Number");
			// Print Odd Number
			for(int i = 0; i< PrintNumber; i++)
			{
				if(num[i] % 2 == 1)
				{
					Console.WriteLine(" "+ num[i]);
				}
			}

			Console.WriteLine("Even Number");
			// Print Even Number
			for (int i = 0;i < PrintNumber; i++)
			{
				if(num[i] % 2 == 0)
				{
					Console.WriteLine(" "+ num[i]);
				}
			}
		}

		public void Reverse()
		{
			Console.WriteLine("Enter How Many Number You Print");
			int PrintNumber = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter Number");
			int[] num= new int[PrintNumber];

			for(int i = 0; i< PrintNumber; i++)
			{
				num[i] = Convert.ToInt32(Console.ReadLine());
			}

			Console.WriteLine("Reverse Number");
			for(int i = PrintNumber-1; i>=0; i--)
			{
				Console.WriteLine(num[i]);
			}
		}
	}
}
