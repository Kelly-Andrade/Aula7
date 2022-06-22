namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------\nEXERCÍCIO 1\n-----------\n");

            //Aluno aluno1 = new Aluno();

            List<Aluno> lista = new List<Aluno>();
            lista.Add(new Aluno());
            lista.Add(new Aluno());

            
            Console.WriteLine($"\nDigite o código do aluno (referente a ordem de cadastro, começando por 0.): ");
            int i = int.Parse(Console.ReadLine());
            lista[i].Imprimir();

            
        }
    }
}