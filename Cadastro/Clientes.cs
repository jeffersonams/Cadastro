using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro
{
    class Clientes
    {
        // ATRIBUTOS DA CLASSE CLIENTES
        string Nome;
        string Sobremenome;
        int Cpf;
        string Rua;
        string Bairro;
        int Numero;


        //CONTRUTOR COM PARAMETRO
        public Clientes(string nome, string sobrenome, int CPF, string rua, string bairro, int numero)
        {
            Nome = nome;
            Sobremenome = sobrenome;
            Cpf = CPF;
            Rua = rua;
            Bairro = bairro;
            Numero = numero;
                                 
        }





        //CRIANDO UM METODO PARA LER
        public override string ToString()
        {
            return "CADASTRO REALIZADO COM SUCESSO"
                + Nome
                + ", "
                + Sobremenome
                + ", "
                + Cpf
                + ", "
                + Rua
                + ", "
                + Bairro
                + ", "
                + Numero;
        }








    }
}
