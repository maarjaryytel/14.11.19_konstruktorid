using System;

namespace _14._11._19_constructors_enum
{
	class Animal

	{
		public string name;
		public int age;
		public int levelOfHappiness;
		//nüüd tahaks neid kuvada- selleks peab olema meetod//


		public void PrintBasicInfo() //soovituslik on märkida tegusõna
		{
			Console.WriteLine($"Name: {name}");
			Console.WriteLine($"Age: {age}");
			Console.WriteLine($"level of happiness: {levelOfHappiness}");

			//ma tahan luua koera, kes saaks kõik need omadused
		}

		class Dog : Animal
		{
			public int numberOfBarks;
			//peab õpetama oma koera saba liputama
			//iga kord kui liputab saba, siis tema õnnetase suureneb
			public void WaveTail()   //saba liputama
			{
				levelOfHappiness++;
			}

			//tahan, et koer hakkaks haukuma, kui level of happiness on 5, 10

			public void Bark()
			{
				Console.WriteLine("Auhh");
				//mitu korda koer on haukunud- tuleb luua omadus- public int number of Barks
				numberOfBarks++;
			}

		}

		class Program
		{
			static void Main(string[] args)
			{
				//kuidas ma koera loon- loon uue objekti
				Dog rex = new Dog();
				rex.name = "Scooby";
				rex.age = 5;
				rex.levelOfHappiness = 0; //alguses on 0, kui tuleme koju siis hakkab alles saba liputama

				for (int i = 0; i < 12; i++) //liputab saba 12 korda- for loopiga, //4 korda hakkab haukuma
				{
					//mis ta teeb siin sees
					rex.WaveTail(); //liputab saba
					if (rex.levelOfHappiness % 3 == 0) //iga neljas kord haugub //annab jäägi
													   //nt 5%3=2, st 5: 3= 2
					{
						rex.Bark();
					}
				}

				//kuvame basic info
				rex.PrintBasicInfo();
				//mitu korda on haukunud
				Console.WriteLine($"{rex.name} has barked {rex.numberOfBarks} times");
				//funktsioon on omaette, meetod töötab ainult siis kui on objekt loodud
				//protseduurid ei tagasta väärtust

				Console.ReadLine();
			}
		}
	}
}
