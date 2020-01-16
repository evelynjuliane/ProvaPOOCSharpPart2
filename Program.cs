using System;

namespace ProvaPOOCSharpParte2
{
    class Program
    {
        public static void Main(string[] args)
        {
			
			Gerente gerente = new Gerente("Ana", 25, 1000);
			gerente.Bonificacao();

			Supervisor supervisor = new Supervisor("João", 35, 2000);
			supervisor.Bonificacao();

			Vendedor vendedor = new Vendedor("Leonardo", 20, 1000);
			vendedor.Bonificacao();
			
		}
	
    }
}
