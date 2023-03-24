namespace ExercicioSobreArray
{
    internal class Program
    {
        static int[] numbers = new int[10] { 1, 2, 4, 5, 6, 7, -3, 8, 10, 9 };
        static int valorNegativo = -3;
        static int maiorValor = 10;
        static int menorValor = 1;
        static int segundoMaior = 9;
        static int terceiroMaior = 8;
        static int valorMedio = numbers[valorMedio];
       
            
            
            
        static void OrdenarOsNumeros()
        {
            Console.WriteLine("1° valor: " + numbers[0]);
            Console.WriteLine("2° valor: " + numbers[1]);
            Console.WriteLine("3° valor: " + numbers[2]);
            Console.WriteLine("4° valor: " + numbers[3]);
            Console.WriteLine("5° valor: " + numbers[4]);
            Console.WriteLine("6° valor: " + numbers[5]);
            Console.WriteLine("7° valor: " + numbers[6]);
            Console.WriteLine("8° valor: " + numbers[7]);
            Console.WriteLine("9° valor: " + numbers[8]);
            Console.WriteLine("10° valor: " + numbers[9]);
        }

        static void RemoverUmNumeroDaSequencia()
        {
            Console.WriteLine("1° valor: " + numbers[0]);
            Console.WriteLine("2° valor: " + numbers[1]);
            Console.WriteLine("3° valor: " + numbers[2]);
            Console.WriteLine("4° valor: " + numbers[3]);
            Console.WriteLine("5° valor: " + numbers[4]);
            Console.WriteLine("6° valor: " + numbers[5]);           
            Console.WriteLine("8° valor: " + numbers[7]);
            Console.WriteLine("9° valor: " + numbers[8]);
            Console.WriteLine("10° valor: " + numbers[9]);

            Console.WriteLine("O número negativo foi removido!");  

        }



        static void EncontrarMenorValor()
        {
            Console.WriteLine("O menor valor é " + menorValor);

        }


        static void EncontrarMaiorValor()
        {
            Console.WriteLine("O maior valor é " + maiorValor);

        }



        static void EncontrarOs3MaioresValores()
        {
            Console.WriteLine("Maior valor: " + maiorValor);
            Console.WriteLine("Segundo maior: " + segundoMaior);
            Console.WriteLine("Terceiro maior: " + terceiroMaior);
        }

        static int ValoresNegativos()
        {
         
            Console.WriteLine("Valores negativos são: " + valorNegativo);
            return valorNegativo;
        }

        static int ValorMedio()
        {
            int valorMedio = (numbers.Length - 1) / 2;
           
            Console.WriteLine("O valor médio desses valores é: "+valorMedio);
            
            return valorMedio;

        }


        static void Main(string[] args)
        {
            
            OrdenarOsNumeros();
            Console.WriteLine();
            EncontrarMaiorValor();
            Console.WriteLine();
            EncontrarMenorValor();
            Console.WriteLine( );
            ValorMedio();
            Console.WriteLine();
            EncontrarOs3MaioresValores();
            Console.WriteLine();
            ValoresNegativos();
            Console.WriteLine();
            RemoverUmNumeroDaSequencia();
            
        }
    }
}