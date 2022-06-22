

namespace Exercicio3
{
    public class ContaBancaria
    {
        private double numeroCC;
        private string nomeCliente;
        private double saldo;

        public double NumeroCC { get; set; }
        public string NomeCliente { get; set; }
        public double Saldo { get; set; }


        public ContaBancaria(double numeroCC, string nomeCliente)
        {
            this.Saldo = saldo = 0;
            this.NomeCliente = nomeCliente;
            this.NumeroCC = numeroCC;

            Menu();          
      
        }

        public void Menu()
        {
            int continuar = 1;
            do
            {
                Console.WriteLine("\n====MENU====\n1-Sacar\n2-Depositar\n3-Extrato\n4-Alterar Nome\n\nQual operação deseja realizar?");
                int opcao = int.Parse(Console.ReadLine());
                if (opcao > 0 && opcao < 5)
                {
                    switch (opcao)
                    {
                        case 1:
                            Sacar();
                            break;
                        case 2:
                            Depositar();
                            break;
                        case 3:
                            Extrato();
                            break;
                        default:
                            AlterarNome();
                            break;
                    }
                    Console.WriteLine("\n-------------------\n1-Continuar\n2-Sair\nDigite: ");
                    continuar = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Opção Inválida!");
                    Menu();
                }
            }
            while (continuar == 1);
            
            
        }

        public void AlterarNome()
        {
            Console.WriteLine("Digite o novo nome: ");
            NomeCliente = Console.ReadLine();
        }

        public void Depositar()
        {
            Console.WriteLine("Quanto deseja depositar? ");
            double deposito = Double.Parse(Console.ReadLine());            
            Saldo = +deposito;
            Console.WriteLine($"OPERACAÇÃO REALIZADA\nSaldo atual: R$ {Saldo:00.00}");
        }
                

        public void Sacar()
        {
            Console.WriteLine("Quanto deseja sacar? ");
            double saque = Double.Parse(Console.ReadLine());
            if (Saldo < saque)
            {
                Console.WriteLine($"\nOPERAÇÃO NÃO AUTORIZADA\nSaldo de R$ {Saldo:00.00} é menor do que o saque de R$ {saque:00.00}");
            }
            else
            {
                Saldo = Saldo - saque;
                Console.WriteLine($"\nOPERAÇÃO REALIZADA\nValor do saque: R$ {saque:00.00}\nSaldo atual: R$ {Saldo:00.00}");
            }
        }

        public void Extrato()
        {
            Console.WriteLine($"\nNúmero da conta: {NumeroCC}");
            Console.WriteLine($"Cliente: {NomeCliente}");
            Console.WriteLine($"Saldo: {Saldo}");
        }
    }
}
