namespace Projeto
{
    public class Calculadora
    {
       
        
        public double Soma(params double[] numeros)
        {
            double resultado = 0.0;
            foreach (double numero in numeros)
            {
                resultado += numero;
            }
            return resultado;
        }
    }
}