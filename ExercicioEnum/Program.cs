using System;
using ExercicioEnum.Entities;
namespace ExercicioEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a cor do carro:");
            string cor = Console.ReadLine();

            Console.WriteLine("Informe o ano do carro");
            string anoData = Console.ReadLine();

            Carros car = new Carros(cor, anoData);

            Console.WriteLine("informe o digito referente ao tipo de Cambio: \n 0 - MecanicoManual \n 1- Automacico \n 2- Automacico \n 3 - CVT");
            int optCambio = int.Parse(Console.ReadLine());

            car.Cambio(optCambio);

            Console.WriteLine("informe o digito referente ao tipo de Combustivel: \n 0 - GasolinaComum \n 1- Etanol \n 2- GNV \n 3 - Diesel");
            int optCombustivel = int.Parse(Console.ReadLine());
            car.Combustivel(optCombustivel);
          

            Console.WriteLine("informe o digito referente ao Modelo: \n 0 - Sedan \n 1- Minivan \n 2- Picape \n 3 - Conversível \n 4 - Utilitario ");
            int optModelo = int.Parse(Console.ReadLine());
            car.Modelo(optModelo);


            Console.WriteLine(car);

            
        }
    }
}
