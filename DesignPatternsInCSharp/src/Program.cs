using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsInCSharp.src.Builder;

namespace DesignPatternsInCSharp {
	class Program {
		static void Main(string[] args) {
			Burger b1 = new BurgerBuilder(Size.large).AddCheese()
											.AddLettuce()
											.build();
			Burger b2 = new BurgerBuilder(Size.small).build();
			Burger b3 = new BurgerBuilder(Size.medium).AddTomato()
											.AddLettuce()
											.build();
			Console.WriteLine("Burger1:\n" + b1.ToString());
			Console.WriteLine("Burger2:\n" + b2.ToString());
			Console.WriteLine("Burger3:\n" + b3.ToString());

			Console.Read();
		}
	}
}
