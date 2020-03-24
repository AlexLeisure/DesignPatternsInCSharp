using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsInCSharp.src.Builder;
using DesignPatternsInCSharp.src.Factory;

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
			Burger b4 = new Burger(SpecialtyBurgerFactory.makeDeluxeBurger(Size.large));
			Burger b5 = new Burger(SpecialtyBurgerFactory.makeKidsCheeseBurger().AddPickles().AddMustard());

			Console.WriteLine("Burger1:\n" + b1.ToString());
			Console.WriteLine("Burger2:\n" + b2.ToString());
			Console.WriteLine("Burger3:\n" + b3.ToString());
			Console.WriteLine("Burger4:\n" + b4.ToString());
			Console.WriteLine("Burger5:\n" + b5.ToString());

			Console.Read();
		}
	}
}
