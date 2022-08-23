
namespace Task4
{
    public class Fraction
    {
		private int Numerator { get; set; }
		private int Denominator { get; set; }

		public Fraction()
		{
			Numerator = 0;
			Denominator = 0;
		}

		public Fraction(int numerator, int denominator)
		{
			Numerator = numerator;
			Denominator = denominator;
		}

		public Fraction Sum(in Fraction other)
		{
			Fraction result = new Fraction(Numerator + other.Numerator, Denominator + other.Denominator);

			return result;
		}

		public Fraction Diff(in Fraction other)
		{
			Fraction result = new Fraction(Numerator - other.Numerator, Denominator - other.Denominator);

			return result;
		}

		public Fraction Mult(in Fraction other)
		{
			Fraction result = new Fraction(Numerator * other.Numerator, Denominator * other.Denominator);

			return result;
		}

		public Fraction Div(in Fraction other)
		{
			if (Denominator != 0)
			{
				Fraction result = new Fraction(Numerator / other.Numerator, Denominator / other.Denominator);

				return result;
			}

			return this;
		}

		public override string ToString()
		{
			return $"{Numerator} / {Denominator}";
		}
	}
}
