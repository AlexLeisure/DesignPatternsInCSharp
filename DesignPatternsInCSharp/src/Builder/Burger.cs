using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.src.Builder {
	enum Size { small, medium, large}

	class Burger {

		/* Properties for a Burger.
		 * Should not be able to mutate these Properties, creation of
		 * burgers is delagated to a Builder instead.
		 */
		public Size BurgerSize { get; }
		public bool Cheese { get; }
		public bool Lettuce { get; }
		public bool Tomato { get; }
		public bool Ketchup { get; }
		public bool Mustard { get; }
		public bool Mayo { get; }
		public bool Pickles { get; }

		/* Constructor
		 * Requires: BurgerBuilder
		 * Sets the properties of this Burger to the corresponding
		 * properties in the builder instance.
		 */
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

		/* Returns a string that has each property of the
		 * burger on it's own line.
		 */
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
		public Size BurgerSize { get; set; } //Required
		public bool Cheese { get; set; } //Optional
		public bool Lettuce { get; set; } //Optional
		public bool Tomato { get; set; } //Optional
		public bool Ketchup { get; set; } //Optional
		public bool Mustard { get; set; } //Optional
		public bool Mayo { get; set; } //Optional
		public bool Pickles { get; set; } //Optional

		/* Consttructor for Builder
		 * Size is only required parameter, sets other properties to false as default
		 */
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

		// Builder methods, returns the instance of itself so you 
		// can chain together method calls
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

		//returns a new burger passing in the current instance
		public Burger build() {
			return new Burger(this);
		}

	}
}
