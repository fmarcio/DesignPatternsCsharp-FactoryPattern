using FacthoryMethod.ConcreteCreator;
using FacthoryMethod.Creator;
using FacthoryMethod.Product;
using System;

namespace FacthoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            GuitarFactory guitarFactory = null;
            Console.WriteLine("Modelos de guitarra disponíveis: \nGiannini Sonic \nEpiphone Les Paul \nFender Jaguar\n");

            Console.Write("Entre as opções acima, digite a que você deseja saber mais informações: ");

            string userInput = Console.ReadLine();
    

            if(userInput.ToLower().Contains("giannini") || userInput.ToLower().Contains("sonic"))
            {
                guitarFactory = new BasicGuitFactory(400, 50);
            }
            else if (userInput.ToLower().Contains("epiphone") || userInput.ToLower().Contains("les paul")) 
            {
                guitarFactory = new IntermediateGuitFactory(2500, 200);
            }
            else if (userInput.ToLower().Contains("fender") || userInput.ToLower().Contains("jaguar"))
            {
                guitarFactory = new AdvancedGuitFactory(8000, 650);
            }
            else
            {
                guitarFactory = new NotValidGuitFactory(0, 0);
            }


            Guitar guitar = guitarFactory.SearchGuitar();
            Console.WriteLine("\nConfira as características do instrumento escolhido: \n");

            Console.WriteLine("Modelo da guitarra: {0}\nPreço: {1}\nCusto médio anual de manutenção:  {2}",
                guitar.GuitarModel, guitar.GuitarPrice, guitar.AvgMaintenancePrice);

            Console.ReadKey();
        }
    }
}
