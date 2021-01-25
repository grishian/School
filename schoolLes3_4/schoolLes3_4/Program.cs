using System;

namespace schoolLes3_4
{

	public class Program
	{
		public static void Main()
		{

			//variables
			bool student;
			bool groep;                 //gratis huurschaatsen
			bool schoolTijdensLesuren;  //gratis huurschaatsen
			bool schoolBuitenLesuren;   //gratis huurschaatsen
			double tienBeurtenkaartPlus = 60;
			double tienBeurtenkaartMin = 50;
			double seizoensAboPlus = 230;
			double seizoensAboMin = 180;
			double seizoensAboStudent = 190;
			double huurSchaatsen = 3;
			double slijpenTraag = 6;
			double slijpenSnel = 8;
			double schaatsLes = 11;
			double funHokeySessie = 375;
			double totaalPrijs = 0;
			int keuzeAbo;   //de eerste if-loop
			int keuzeAbo2;  //de tweede if-loop
			int keuzeAbo3;  //de derde if -loop
			string keuzeBest = "";	//de vierde if-loop
							//einde variables


			Console.WriteLine("Wilt u een abonnement of beurtenkaart kopen?(ja/nee)");
			string antwoordAbonnement = Console.ReadLine();

			Console.WriteLine("\n\n*******************************************\n\n");
			if (antwoordAbonnement == "ja")
			{
				Console.WriteLine("Welk type wilt u kopen? Typ het getal: \n1: Abonnement\n2: BeurtenKaart");
				keuzeAbo = int.Parse(Console.ReadLine());

				//De klant wilt een abonnement kopen
				if (keuzeAbo == 1)
				{
					Console.WriteLine("Welke abonnement wilt u kopen? Typ het getal: \n1: abonnement 12+\n2: abonnement 12-\n3: abonnement student");
					keuzeAbo2 = int.Parse(Console.ReadLine());
					if (keuzeAbo2 == 1)
					{
						totaalPrijs += seizoensAboPlus;
						Console.WriteLine("U hebt gekozen voor een abbonement 12+(230 euro)");
					}
					else if (keuzeAbo2 == 2)
					{
						totaalPrijs += seizoensAboMin;
						Console.WriteLine("U hebt gekozen voor een abbonement 12-(180 euro)");
					}
					else if (keuzeAbo2 == 3)
					{
						totaalPrijs += seizoensAboStudent;
						Console.WriteLine("U hebt gekozen voor een abbonement student(190 euro)");
					}

					//De klant wilt een beurtenkaart kopen
				} else

					Console.WriteLine("Welke tienbeurtenkaart wilt u kopen? Typ het getal: \n1: tienbeurtenkaart 12+\n2: tienbeurtenkaart 12-");
						keuzeAbo3 = int.Parse(Console.ReadLine());
						if (keuzeAbo3 == 1)
						{
							totaalPrijs += tienBeurtenkaartPlus;
							Console.WriteLine("U hebt gekozen voor een beurtenkaart 12+(60 euro)");
						}
						else if (keuzeAbo3 == 2)
						{
							totaalPrijs += tienBeurtenkaartMin;
							Console.WriteLine("U hebt gekozen voor een beurtenkaart 12-(50 euro)");
						}

				Console.WriteLine("Wilt u (nog) iets bestellen? (ja/nee)");

				while (keuzeBest == "ja")
                {
					Console.WriteLine("U kunt kiezen tussen:\n" +
						"1:" +
						"2:" +
						"3:" +
						"4:" +
						"5:" +
						"6:" +
						"7: ");



					Console.WriteLine("U koos voor: ");


					Console.WriteLine("Wilt u nog iets kiezen?(ja/nee)");
					keuzeBest = Console.ReadLine();

				}




						Console.WriteLine("De totaal prijs is: " + totaalPrijs + " euro.");
					
				



			}
		}
	}


}
