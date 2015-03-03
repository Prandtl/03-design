using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Threading;
using Ninject;

namespace battleships
{
	public class Program
	{
		private static void Main(string[] args)
		{
			Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
			if (args.Length == 0)
			{
				Console.WriteLine("Usage: {0} <ai.exe>", Process.GetCurrentProcess().ProcessName);
				return;
			}
			var aiPath = args[0];



			/*
			var kernel = new StandardKernel();
			kernel.Bind<Settings>().To<Settings>().WithConstructorArgument("settings.txt");
			var monitor = kernel.Get<ProcessMonitor>();
			kernel.Bind<Ai>().To<Ai>().WithConstructorArgument(aiPath, monitor);
			var settings = kernel.Get<Settings>();

			var newGame = new Func<Map, Ai, Game>((map, ai) => new Game(map, ai));
			var getAi = new Func<Map, Ai, Game>();

			/*
			var settings = new Settings("settings.txt");
			var tester = tester();
			if (File.Exists(aiPath))
				tester.TestSingleFile();
			else
				Console.WriteLine("No AI exe-file " + aiPath);
			 */
		}
	}
}