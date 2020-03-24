using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsInCSharp.src.Builder;

namespace DesignPatternsInCSharp.src.Factory {
	class SpecialtyBurgerFactory {
		public static BurgerBuilder makeKidsCheeseBurger() {
			BurgerBuilder b = new BurgerBuilder(Size.small);
			b.AddCheese().AddKetchup().AddPickles();
			return b;
		}

		public static BurgerBuilder makeKidsBurger() {
			BurgerBuilder b = new BurgerBuilder(Size.small);
			b.AddKetchup().AddPickles();
			return b;
		}

		public static BurgerBuilder makeDeluxeBurger(Size size) {
			BurgerBuilder b = new BurgerBuilder(size);
			b.AddCheese().AddLettuce().AddTomato().AddPickles().AddKetchup().AddTomato();
			return b;
		}
	}
}
