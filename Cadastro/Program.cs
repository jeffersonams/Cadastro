using System;

namespace Cadastro
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("BEM VINDO AO SISTEMA DE CADASTRO");

            Console.Write("Nome do paciente: ");
            string nome = Console.ReadLine(); //VARIAVEIS AUXILIARES PARA COLOCAR DENTRO DO OBJETO

            Console.Write("Sobrenome do paciente: ");
            string sobrenome = Console.ReadLine();  //VARIAVEIS AUXILIARES PARA COLOCAR DENTRO DO OBJETOv

            Console.Write("CPF: ");
            int cpf = int.Parse(Console.ReadLine());

            Console.Write("Rua: ");
            string rua = Console.ReadLine();

            Console.Write("Bairro: ");
            string bairro = Console.ReadLine();

            Console.Write("Numero: ");
            int  numero = int.Parse (Console.ReadLine());


            //CRIANDO UM OBJETO DA CLASSE CLIENTES
            Clientes cli = new Clientes(nome, sobrenome, cpf, rua, bairro, numero);

            Console.WriteLine(cli);

            Console.ReadKey();


        }
    }
}
