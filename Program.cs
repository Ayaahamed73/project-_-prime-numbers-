﻿using System;
class program
{
	static void Main(string[] args)
	{

		Console.WriteLine("please enter n1");
		int n1 = int.Parse(Console.ReadLine());
		Console.WriteLine("please enter n2");
		int n2 = int.Parse(Console.ReadLine());
		int i, j;
		for (i = n1; i < n2; i++)
		{

			for (j = 2; j < n2; j++)
			{

				if (i != j && i % j == 0)
				{
					break;
				}


			}
			if (i % j != 0 && i > 1)
				Console.WriteLine(i);
		}



	}
}











