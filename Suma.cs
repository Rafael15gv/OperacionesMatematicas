public class Suma
{
    public int resultadoSuma;
    private int numero1;
    private int numero2;

    public Suma(string num1, string num2)
    {
        numero1 = Convert.ToInt32(num1);
        numero2 = Convert.ToInt32(num2);

        resultadoSuma = numero1 + numero2;
    }
}
