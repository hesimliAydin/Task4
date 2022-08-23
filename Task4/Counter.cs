
namespace Task4
{
    public class Counter
    {
		private int Min;
		private int Max;
		private int Current;

		public Counter(int min, int max)
		{
			Min = min;
			Max = max;
			Current = min;
		}

		public void Increment()
		{
			if (Current < Max)
				Current++;
			else
				Current = Min;
		}

		public void Decrement()
		{
			if (Current > Min)
				Current--;
			else
				Current = Max;
		}

		public int getCurrent()
		{
			return Current;
		}
	}
}
