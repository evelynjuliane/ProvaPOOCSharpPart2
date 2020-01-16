using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaPOOCSharpParte2
{
   public class Gerente : Funcionario
    {
		public Gerente(string nome, int idade, double salario):base(nome, idade, salario)
		{
			
		}

		public double Bonificacao()
		{
			this.Salario += 10000.00;
			base.Bonificacao();
			return this.Salario;
		}
	}
}
