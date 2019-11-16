using System;

namespace dog_read_enum
{
	//enum- see et mul oleks kergem lugeda, see ongi enum
	enum Breed
	{   //see on nimekiri ja nende taga on numbrid. Kui ma kirjutaks lihtsalt numbrid, siis me ei saaks aru
		// mis tõuga on tegemist
		Bulldog, //need on tegelikult numbrid, need in int tüüpi andmed
		Boxer, //neid numbreid on raskem lugeda
		Chihuahua,
	}
	
	//loome dog klassi
	class Dog
	{
		public static int Count = 0;

		public string name;
		public int age;
		public Breed dogBreed; //neid tõuge võib olla sadades// see Breed on ülevalt võetud


		//loon konstruktor

		public Dog(string _name, int _age, Breed _breed) //sama nimi mis klaasil- see on konstruktor
		{
			name = _name;
			age = _age;
			dogBreed = _breed;
			Count++;
		}

		//nüüd tahame kuvada

		public void PrintDogInfo()
		{
			Console.WriteLine($"Name: {name}");
			Console.WriteLine($"Age: {age}");
			Console.WriteLine($"Breed: {dogBreed}");			
		}
	}
	class Program
	{
				
		static void Main(string[] args)
		{
			//loon koera
			Dog sass = new Dog("Sass", 10, Breed.Chihuahua); //arvuti pakub ise siin tõu automaatselt välja, 
			//võtan selle tõu, mida mul vaja on
			sass.PrintDogInfo();
			
			Dog pontu = new Dog("Pontu", 5, Breed.Bulldog);
			pontu.PrintDogInfo();

			Console.WriteLine($"{Dog.Count} has/have created.");
			Console.WriteLine((int)Breed.Bulldog); //siin ta näitab mis on selle bulldogi number, nr on üleval
			                                      //seda nimetatakse castinguks
			Console.ReadLine();

		}
	}
}
