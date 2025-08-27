using Repositories;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma opção e acesse uma parte específica dos meus estudos:");
            Console.WriteLine("DIGITE: 1 - PARA O PROGRAMA DAR LISTA DE SONS DOS ANIMAIS | 2 - AINDA NÃO CRIADO ;(");
            int opcao = int.Parse(Console.ReadLine()!);

            switch (opcao)
            {
                case 1:
                    var dogs = DogRepository.GetDogs();
                    foreach (var dog in dogs)
                    {
                        Console.WriteLine($"Cachorro: {dog.Name} ");
                        dog.Sound();
                        dog.Run();
                    }

                    break;
            }
            
        }
    } 
}