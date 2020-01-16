using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaPOOCSharpParte2
{
   public class Funcionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Salario { get; set; }
        public Funcionario(string nome, int idade, double salario)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Salario = salario;
        }
        public double Bonificacao()
        {
            Console.WriteLine(this.Salario);
            return Salario;

        }
    }
}
