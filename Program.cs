namespace OperacionesMatematicas
{
	public class OperacionesMatematica
	{
		public static string nom1;
		public static string nom2;
		public static int resultado;

		public static void Main(string[] args)
		{
			Console.WriteLine("Digite primer numero");
			nom1 = Console.ReadLine();  
			Console.WriteLine("Digite segundo numero");
			nom2 = Console.ReadLine();
  
			

			Suma suma1 = new Suma(nom1, nom2);
			Console.WriteLine($"el resultado de la suma es: {suma1.resultadoSuma}");

			Resta resta1 = new Resta(nom1, nom2);
			Console.WriteLine($"el resultado de la resta es: {resta1.resultadoResta}");

			Multiplicar multiplicar1 = new Multiplicar(nom1, nom2);
			Console.WriteLine($"el resultado de la multiplicacion es: {multiplicar1.resultadoMultiplicar}");

			Division division1 = new Division(nom1, nom2);
			Console.WriteLine($"el resultado de la division es: {division1.resultadoDivision}");
		}
	}
}