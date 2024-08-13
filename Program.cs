namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número da conta: "); 
            int numConta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o nome do titular da conta: ");
            string nomeConta = Console.ReadLine();

            ContaBancaria cb = new ContaBancaria(numConta, nomeConta);

            Console.WriteLine("");

            Console.WriteLine("Deseja realizar um depósito? (s/n)");
            var option = Console.ReadLine();
            switch (option)
            {
                case "s":
                    //depósito
                    Console.Write("Digite o valor do depósito: ");
                    double dep = double.Parse(Console.ReadLine());
                    cb.DepositoConta(dep);
                    Console.WriteLine(cb);

                    //saque
                    Console.WriteLine("");
                    Console.WriteLine("Você gostaria de realizar um saque? (s/n)");
                    var option2 = Console.ReadLine();
                    switch (option2)
                    {
                        case "s":
                            Console.Write("Digite o valor do saque: ");
                            double saq = double.Parse(Console.ReadLine());
                            cb.SaqueConta(saq);
                            Console.WriteLine(cb);
                            break;

                        case "n":
                            Console.WriteLine(cb);
                            break;

                        default:
                            Console.WriteLine("Opção inválida");
                            break;
                    }
                     break;
                
                    case "n":
                    Console.WriteLine(cb)
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }

    }
}
