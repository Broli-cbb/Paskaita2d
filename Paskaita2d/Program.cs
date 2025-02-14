using System;



namespace PirmaPaskaita

{

    public class Program

    {

        public static void Main()

        {

            SpausdintiIEkrana("Pasirinkite veiksmą (sudetis, atimtis, daugyba, dalyba): ");

            string veiksmas = Console.ReadLine();



            SpausdintiIEkrana("Iveskite X: ");

            double x = GautiDoubleReiksme();



            SpausdintiIEkrana("Iveskite Y: ");

            double y = GautiDoubleReiksme();



            double? rezultatas = null;



            //Variantas su 

            rezultatas = veiksmas.ToLower() switch

            {

                "sudetis" => Sudeti(x,y),

                "atimtis" => Atimti(x,y),

                "daugyba" => Daugyba(x,y),

                "dalyba" => Dalyba(x,y),

                _ => null

            };



            if (rezultatas == null)

            {

                SpausdintiIEkrana($"{veiksmas.ToUpper()} yra neapibreztas programoje");

                return;

            }



            SpausdintiIEkrana($"Atliktas veiksmas {veiksmas.ToUpper()} \nRezultatas: {rezultatas}");

        }

        public static double Sudeti(double x, double y)

        {

            return x + y;

        }

        public static double Atimti(double x, double y)

        {

            return x - y;

        }
        
        public static double Daugyba(double x, double y)

        {

            return x * y;

        }
        
        public static double Dalyba(double x, double y)

        {

            return x / y;

        }

        public static void SpausdintiIEkrana(string tekstas)

        {

            Console.WriteLine(tekstas);

        }



        public static double GautiDoubleReiksme()

        {

            string ivestis = Console.ReadLine();

            return double.Parse(ivestis);

        }



    }



}
