using System.Globalization;

namespace ExercicioSobreArray
{
    internal class Program
    {
        static int[] sequencianumbers = new int[10] { 1, 2, 4, 5, 6, 7, -3, 8, 10, 9 };
        
        static int maiorValor = sequencianumbers[0];
        static int menorValor = sequencianumbers[0];
        
        
       
            
            
            
        static void OrdenarOsNumeros()
        {
            for ( int i = 0; i < sequencianumbers.Length; i++ )
            {
                Console.Write(" " + sequencianumbers[i] );             
                             
            }
        }

        static void RemoverUmNumeroDaSequencia()
        {
            Console.WriteLine("Digite o número para remover: "); 
            int numeroParaRemover = int.Parse( Console.ReadLine() );

            int qtdNumerosParaRemover = 0;

            for ( int i = 0; i < sequencianumbers.Length; i++ )
            {
                if (sequencianumbers[i] == numeroParaRemover )
                {
                    qtdNumerosParaRemover++;
                }
           
            }
            int[] novaSequenciaNumbers = new int[sequencianumbers.Length - qtdNumerosParaRemover];
            int j = 0;
            for ( int i = 0; i < sequencianumbers.Length; i++)
            {
                if ( sequencianumbers[i] != numeroParaRemover)
                {
                    novaSequenciaNumbers[i] = sequencianumbers[i];
                    j++;
                }

            }
            Console.WriteLine("Nova sequência: ");


            for (int i = 0; i < novaSequenciaNumbers.Length; i++)
            {
                Console.Write(" " + novaSequenciaNumbers[i]);

            }
        }




        static void EncontrarMenorValor()
        {
            for ( int i = 0; i < sequencianumbers.Length;i++ )
            {
                if (sequencianumbers[i] < menorValor)
                {
                    menorValor = sequencianumbers[i];
                }

            }
            Console.WriteLine();
            Console.WriteLine("O menor valor é: " + menorValor);

        }


        static void EncontrarMaiorValor()
        {
            
           for ( int i = 0; i < sequencianumbers.Length;i++ )
           {
               if (sequencianumbers[i] > maiorValor)
               {
                    maiorValor = sequencianumbers[i];
               }

           }
            Console.WriteLine();
            Console.WriteLine("O maior valor é: " + maiorValor);
        }



        static void EncontrarOs3MaioresValores()
        {
            Array.Sort(sequencianumbers);
            Array.Reverse(sequencianumbers);
            int[] tresMaiores = new int[3];

            for ( int i = 0; i < tresMaiores.Length;i++)
            {
                tresMaiores[i] = sequencianumbers[i];      
            }
            Console.WriteLine();
            
            Console.WriteLine("Os três maiores: ");
                
                for (int i = 0; i < tresMaiores.Length; i++)
            {
                Console.Write(" " + tresMaiores[i]);
                
           } 
            Console.ReadLine();
        }



        static int[] ValoresNegativos()
        {
            Array.Reverse (sequencianumbers);
            int qtdNumerosNegativos = 0;

            for ( int i  = 0 ; i < sequencianumbers.Length; ++i )
            {
                if (sequencianumbers[i] < 0)
                    qtdNumerosNegativos++;
            }

            int[] valoresNegativos = new int[qtdNumerosNegativos];

            for (int i = 0; i < sequencianumbers.Length; ++i)
            {

                if (sequencianumbers[i] < 0)
                {
                    valoresNegativos[i] = sequencianumbers[i];
                }

            }
            Console.WriteLine();
            Console.WriteLine("Os valores negativos são: ");
            

            for (int i = 0; i < valoresNegativos.Length; i++)
            {
                Console.Write(" " + valoresNegativos[i]);

            }

            return valoresNegativos;
        }

        static decimal ValorMedio()
        {
            int valortotal = 0;
            for ( int i = 0; i < sequencianumbers.Length; i++)
            {
                valortotal = valortotal + sequencianumbers[i];
            }
            decimal valorMedio = valortotal / sequencianumbers.Length;
            Console.WriteLine();
            Console.WriteLine("O valor médio desses valores é: " + valorMedio);
            
            return valorMedio;
        }


        static void Main(string[] args)
        {
            
            OrdenarOsNumeros();
            Console.WriteLine();
            EncontrarMaiorValor();           
            EncontrarMenorValor();           
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