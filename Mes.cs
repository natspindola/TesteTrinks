using System;
using System.Globalization;

namespace TesteTrinks
{
    public class Mes
    {
        static public void Main()
        {
            Console.WriteLine("Digite o número do mês: ");
            var numeroDigitado = Convert.ToInt32(Console.ReadLine());

            var nomeMes = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(numeroDigitado);
            Console.WriteLine($"Nome do mês: {nomeMes}");
        }
    }
}