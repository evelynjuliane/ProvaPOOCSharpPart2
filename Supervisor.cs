using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaPOOCSharpParte2
{
    public class Supervisor : Funcionario
    {
		public Supervisor(String nome, int idade, double salario):base(nome, idade, salario)
		{
			
		}

		public double Bonificacao()
		{
			this.Salario += 5000.00;
			base.Bonificacao();
			return Salario;
		}

	}
}
