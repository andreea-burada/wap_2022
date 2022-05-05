
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_events
{
	//public delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);

	//internal class Stock
	//{
	//	private string _symbol;
	//	private decimal _price;

	//	public Stock(string symbol)
	//	{
	//		_symbol = symbol;
	//	}

	//	public event PriceChangedHandler PriceChanged;

	//	public decimal Price
	//	{
	//		get { return _price; }
	//		set
	//		{
	//			if (_price == value) return; // Exit if nothing has changed
	//			decimal oldPrice = _price;
	//			_price = value;
	//			if (PriceChanged != null) // If invocation list not
	//				PriceChanged(oldPrice, _price); // empty, fire event.
	//		}
	//	}
	//}

	//internal class Program
	//   {
	//	private static void Main()
	//	{
	//		var stock = new Stock("MSFT");
	//		stock.PriceChanged += Stock_PriceChanged;
	//		stock.Price = 30;
	//		stock.Price = 60;
	//		stock.Price = 90;
	//	}

	//	private static void Stock_PriceChanged(decimal oldPrice, decimal newPrice)
	//	{
	//		Console.WriteLine("MSFT: {0} {1}", oldPrice, newPrice);
	//	}
	//}



	//public class PriceChangedEventArgs : EventArgs
	//{
	//	public readonly decimal LastPrice;
	//	public readonly decimal NewPrice;
	//	public PriceChangedEventArgs(decimal lastPrice, decimal newPrice)
	//	{
	//		LastPrice = lastPrice;
	//		NewPrice = newPrice;
	//	}
	//}

	//public class Stock
	//{
	//	private string _symbol;
	//	private decimal _price;

	//	public Stock(string symbol)
	//	{
	//		_symbol = symbol;
	//	}

	//	public event EventHandler<PriceChangedEventArgs> PriceChanged;
	//	protected virtual void OnPriceChanged(PriceChangedEventArgs e)
	//	{
	//		if (PriceChanged != null) PriceChanged(this, e);
	//	}
	//	public decimal Price
	//	{
	//		get { return _price; }
	//		set
	//		{
	//			if (_price == value) return;
	//			decimal oldPrice = _price;
	//			_price = value;

	//			OnPriceChanged(new PriceChangedEventArgs(oldPrice, _price));
	//		}
	//	}
	//}

	//internal class Program
	//{
	//	private static void Main()
	//	{
	//		var stock = new Stock("MSFT");
	//		stock.PriceChanged += Stock_PriceChanged1; ;
	//		stock.Price = 30;
	//		stock.Price = 60;
	//		stock.Price = 90;
	//	}

	//	private static void Stock_PriceChanged1(object sender, PriceChangedEventArgs e)
	//	{
	//		Console.WriteLine("MSFT: {0} {1}", e.LastPrice, e.NewPrice);
	//	}
	//}



	internal class Program
	{
		private static void IncrementNormal(int i)
		{
			i = i + 1;
		}

		private static void IncrementRef(ref int i)
		{
			i = i + 1;
		}

		private static void IncrementOut(int i, out int result)
		{
			result = i + 1;
		}

		private static void Main()
		{
			//Normal
			var val = 1;
			IncrementNormal(val);
			Console.WriteLine(val);

			//Ref
			val = 1;
			IncrementRef(ref val);
			Console.WriteLine(val); // Output: 2

			//out
			val = 1;
			int result;
			IncrementOut(val, out result);
			Console.WriteLine(result); // Output: 2
		}
	}
}
