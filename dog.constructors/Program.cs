using System;

namespace dog.constructors
{

	//kuidas saame lühidalt teha, seda on hea teha, kui on palju objekte
	
	//seal kus on new.dog-seal saab kergemalt teha

	//public static- mis on static?
	//kui ma tahan kokku lugeda, mitu looma ma olen teinud
	//ma tahan, et neid koeri loendataks ja kuvatataks ja selleks ongi static
	//iga kord kui loon konstr koera kirjutan count ++

	class Animal
	{
		public static int Count = 0; //alguses meil objekti ei ole

		public string name;
		public string color;

		public void PrintInfo()
		{
			Console.WriteLine($"Name: {name}");
			Console.WriteLine($"Color: {color}");
		}
	}

	class Dog : Animal

	//kuidas ma loon oma objekti
	//anname koerale tõu
	{
		public string breed; //breed- tõug

		//loob koera vaikimisi, ei pea kõiki neid nimesid vanuseid mainis välja kirjutama
		public Dog(string _name, string _color, string _breed) //see on konstruktor
		{
			name = _name; //salvestab üleval olevad name, color sellega siin
			color = _color;
			breed = _breed;
			//need väärtused, mida olen klassis kirjeldanud ühendab neid nende minu väärtustega
			Count++; //et seda kätte saada kasutan staticut, kasutan klassi puhul
			//kirjutan maini, et counti kätte saada
		}

		public void PrintInfoAboutDog()
		{
			Console.WriteLine($"Dog's name: {name}");
			Console.WriteLine($"Dog's color: {color}");
			Console.WriteLine($"Dog's breed: {breed}");

		}

	}

	class Program
	{
		static void Main(string[] args)
		{
			Dog rex = new Dog("Rex", "black and white", "bulldog");
			rex.PrintInfoAboutDog();

			//kutsun välja selle klassi animal ja ta näitab mis omadus on mul kättesaadav
			Console.WriteLine($"{Animal.Count} has/have created."); //loob kõik loomad kokku
			//ma ei vaja objekti selle staticu puhul, kasutan klassi
			Console.ReadLine();
		}
	}
}

