using Repositories;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
                
                Console.WriteLine("Escolha uma opção e acesse uma parte específica dos meus estudos:");
                Console.WriteLine("DIGITE: 1 - PARA O PROGRAMA LISTAR DADOS SOBRE CACHORROS | 2 - FUNCIONALIDADE INDA NÃO DESENVOLVIDA");

                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        List<Dog> dogs = DogRepository.GetDogs();
                        
                        foreach (var dog in dogs)
                        {
                            Console.WriteLine($"Cachorro: {dog.Name} ");
                            dog.Sound();
                            dog.Run();

                        }
                        break;
                    case 2:
                        Console.WriteLine("========== L O A D I N G ==========");
                            break;
                    default:
                        Console.WriteLine("Erro Capturado: Opção inválida");
                        break;
                }
        }
        
    } 
}