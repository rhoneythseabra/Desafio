using System;

namespace 
{
    public class DesafioEstagio
    {
        string texto = "O rato roeu a roupa do Rei de Roma";
        
        Console.WriteLine($"Texto Normal : {texto}");

        string textoInvertido = new string(texto.Reverse().ToArray());

        Console.WriteLine($"Texto Convertido : {textoInvertido}");

    }
}