namespace PrintHouse
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/* Passo 1
			Quarto quarto;
			Sala sala;
			Cozinha cozinha;
			Banheiro banheiro;
			Dispensa dispensa;
			Corredor corredor;
			*/

			/* Passo 2
			Quarto quarto = new Quarto();
			Sala sala = new Sala();
			Cozinha cozinha = new Cozinha();
			Banheiro banheiro = new Banheiro();
			Dispensa dispensa = new Dispensa();
			Corredor corredor = new Corredor();
			*/

			// Passo 3
			Quarto quartoKarlos = new Quarto("Karlos", 5);
			Quarto quartoLucas = new Quarto("Lucas", 5);
			Sala salaTV = new Sala(true, 20);
			Sala salaEscritorio = new Sala(false, 15);
			Cozinha cozinha = new Cozinha(true, 5);
			Banheiro banheiroChuveiro = new Banheiro(true, 3);
			Banheiro banheiroCorredor = new Banheiro(false, 2);
			Dispensa dispensa = new Dispensa(3, 2);
			Corredor corredor = new Corredor(8, 2.5);

			// Passo 4
			Console.Write("Quarto de ");
			Console.WriteLine(quartoKarlos.Dono);
			Console.Write("Tamanho: ");
			Console.WriteLine(quartoKarlos.Tamanho);

			Console.WriteLine("Hello, World!");
		}
	}
}
