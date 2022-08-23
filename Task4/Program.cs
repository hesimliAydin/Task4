using System;

namespace Task4
{
	public class Program
    {
        static void Main()
        {
			//Point point = new Point(5, 2);
			//Console.WriteLine("Point");
			//Console.WriteLine($"{point}");
			//Console.WriteLine();


			//Counter counter = new Counter(9, 25);
			//Console.WriteLine("Counter");

			//counter.Increment();
			//counter.Increment();
			//Console.WriteLine(counter.getCurrent());

			//counter.Decrement();
			//counter.Decrement();
			//counter.Decrement();
			//Console.WriteLine(counter.getCurrent());
			//Console.WriteLine();



			Fraction f = new Fraction(1, 13);
			Fraction f1 = new Fraction(20, 0);
			Console.WriteLine("Fraction");

			Console.WriteLine(f.Sum(f1).ToString());
			Console.WriteLine(f.Diff(f1).ToString());
			Console.WriteLine(f.Mult(f1).ToString());
			Console.WriteLine(f.Div(f1).ToString());
		}
    }
}
