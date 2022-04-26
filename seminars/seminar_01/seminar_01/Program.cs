using System; //referenced namespace

namespace NameSpaceProgram
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.WriteLine(args.Length);
			foreach (string arg in args)
			{
				Console.WriteLine("Argument: {0}", arg);
			}

		} //end main
	}//end class
} //end namespace