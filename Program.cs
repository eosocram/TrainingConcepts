using Repositories;

namespace AnimalApp
{
    class Program
    {
        static void Main()
        {
                
                Console.WriteLine("Escolha uma opção e acesse uma parte específica dos meus estudos:");
                Console.WriteLine("DIGITE: 1 - PARA O PROGRAMA LISTAR DADOS SOBRE CACHORROS | 2 - FUNCIONALIDADE INDA NÃO DESENVOLVIDA");

                string? input = Console.ReadLine();
                if (short.TryParse(input, out short opcao))
                {
                    Console.WriteLine($"Opção: {opcao} selecionado com sucesso!");
                }
                else
                {
                    Console.WriteLine($"Número: {input} inválido");
                }
                

                switch (opcao)
                {
                    case 1: CachorrosMock(); break;

                    case 2: GatosMock(); break;
                    default:
                        Console.WriteLine("Erro Capturado: Opção inválida");
                        break;
                }
        }

        static void CachorrosMock()
        {
            List<Dog> dogs = DogRepository.GetDogs();
                        
            foreach (var dog in dogs)
            {
                Console.WriteLine($"Cachorro: {dog.Name} ");
                dog.Sound();
                dog.Run();
                            
            }   
        }

        static void GatosMock()
        {
            Cat gatos = new Cat();
            gatos.Name = Console.ReadLine() ?? string.Empty;
            Console.WriteLine($"Nome do gato(a): {gatos.Name} ");
            
            gatos.Sound();
            gatos.Run();
        }
    } 
}