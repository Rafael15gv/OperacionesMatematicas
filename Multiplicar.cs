public class Multiplicar
{
    public int resultadoMultiplicar;
    private int numero1;
    private int numero2;

    public Multiplicar(string num1, string num2)
    {
        numero1 = Convert.ToInt32(num1);
        numero2 = Convert.ToInt32(num2);

        resultadoMultiplicar = numero1 * numero2;
    }
}