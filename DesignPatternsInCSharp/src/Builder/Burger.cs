using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.src.Builder {
	enum Size { small, medium, large}

	class Burger {
		public Size BurgerSize { get; }
		public bool Cheese { get; }
		public bool Lettuce { get; }
		public bool Tomato { get; }
		public bool Ketchup { get; }
		public bool Mustard { get; }
		public bool Mayo { get; }
		public bool Pickles { get; }

		public Burger(BurgerBuilder builder) {
			BurgerSize = builder.BurgerSize;
			Cheese = builder.Cheese;
			Lettuce = builder.Lettuce;
			Tomato = builder.Tomato;
			Ketchup = builder.Ketchup;
			Mustard = builder.Mustard;
			Mayo = builder.Mayo;
			Pickles = builder.Pickles;

		}

		public override string ToString() {
			string s = "Size: " + BurgerSize.ToString() + "\n"
				+ "Cheese: " + Cheese + "\n"
				+ "Lettuce: " + Lettuce + "\n"
				+ "Tomato: " + Tomato + "\n"
				+ "Ketchup: " + Ketchup + "\n"
				+ "Mustard: " + Mustard + "\n"
				+ "Mayo: " + Mayo + "\n"
				+ "Pickles: " + Pickles + "\n";

			return s;
		}

	}

	class BurgerBuilder {
		public Size BurgerSize { get; set; }
		public bool Cheese { get; set; }
		public bool Lettuce { get; set; }
		public bool Tomato { get; set; }
		public bool Ketchup { get; set; }
		public bool Mustard { get; set; }
		public bool Mayo { get; set; }
		public bool Pickles { get; set; }

		public BurgerBuilder(Size size) {
			BurgerSize = size;
			Cheese = false;
			Lettuce = false;
			Tomato = false;
			Ketchup = false;
			Mustard = false;
			Mayo = false;
			Pickles = false;
		}

		public BurgerBuilder AddCheese() {
			Cheese = true;
			return this;
		}

		public BurgerBuilder AddLettuce() {
			Lettuce = true;
			return this;
		}

		public BurgerBuilder AddTomato() {
			Tomato = true;
			return this;
		}

		public BurgerBuilder AddKetchup() {
			Ketchup = true;
			return this;
		}
		public BurgerBuilder AddMustard() {
			Mustard = true;
			return this;
		}
		public BurgerBuilder AddMayo() {
			Mayo = true;
			return this;
		}
		public BurgerBuilder AddPickles() {
			Pickles = true;
			return this;
		}

		public Burger build() {
			return new Burger(this);
		}

	}
}
