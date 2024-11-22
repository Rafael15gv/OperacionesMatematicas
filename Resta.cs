public class Resta
{
	public int resultadoResta;
	private int numero1;
	private int numero2;

	public Resta(string num1, string num2)
	{
		numero1 = Convert.ToInt32(num1);
		numero2 = Convert.ToInt32(num2);

        resultadoResta = numero1 - numero2;
	}
}
