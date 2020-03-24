using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsInCSharp.src.Builder;

namespace DesignPatternsInCSharp.src.Factory {
	class SpecialtyBurgerFactory {
		//Makes a small cheese burger with ketchup and pickles
		public static BurgerBuilder makeKidsCheeseBurger() {
			BurgerBuilder b = new BurgerBuilder(Size.small);
			b.AddCheese().AddKetchup().AddPickles();
			return b;
		}

		//Makes a small burger with Ketchup and Pickles
		public static BurgerBuilder makeKidsBurger() {
			BurgerBuilder b = new BurgerBuilder(Size.small);
			b.AddKetchup().AddPickles();
			return b;
		}

		//Requires an input of size
		//Makes a burger with cheese, lettuce, tomato, pickles, ketchup
		public static BurgerBuilder makeDeluxeBurger(Size size) {
			BurgerBuilder b = new BurgerBuilder(size);
			b.AddCheese().AddLettuce().AddTomato().AddPickles().AddKetchup();
			return b;
		}
	}
}
