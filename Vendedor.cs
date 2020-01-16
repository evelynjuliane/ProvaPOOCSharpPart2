using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaPOOCSharpParte2
{
    public class Vendedor : Funcionario
    {
		public Vendedor(String nome, int idade, double salario):base(nome, idade, salario)
		{
			
		}

		public double Bonificacao()
		{
			Salario += 3000.00;
			base.Bonificacao();
			return this.Salario;
		}
	}
}
