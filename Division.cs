public class Division
{
    public double resultadoDivision;
    private double numero1;
    private double numero2;

    public Division(string num1, string num2)
    {
        numero1 = Convert.ToDouble(num1);
        numero2 = Convert.ToDouble(num2);

        resultadoDivision = numero1 / numero2;
    }
}