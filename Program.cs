//using OperacionesMatematicas;

namespace OperacionesMatematicas
{
	public class OperacionesMatematica
	{
		public static int numero1;
		public static int numero2;
		public static int resultado;
		public static void Main(string[] args)
		{
			// se le pide al usuario dos numeros
			Console.WriteLine("Digite primer numero");
			string? num1 = Console.ReadLine();
			bool esNumero1 = int.TryParse(num1, out numero1);

			Console.WriteLine("Digite segundo numero");
			string? num2 = Console.ReadLine();
			bool esNumero2 = int.TryParse(num2, out numero2);
			
			if (esNumero1 == true && esNumero2 == true)
			{
				// se realizar la diferentes operaciones matematicas con los 2 numeros proporcionado por el usuario

				Operaciones operacion = new Operaciones();
                Console.WriteLine($"El resultado de la Suma es: {operacion.Suma(numero1, numero2)}");
                Console.WriteLine($"El resultado de la Resta es: {operacion.Resta(numero1, numero2)}");
                Console.WriteLine($"El resultado de la Multiplicacion es: {operacion.Multiplicacion(numero1, numero2)}");
                Console.WriteLine($"El resultado de la Division es: {operacion.Division(numero1, numero2)}");

			}
			else
			{
				Console.WriteLine("alguno de los digitos no es un numero!");
			}
		}
	}
}