namespace Moda
{
    internal class Program
    {
        static void Main()
        {
            int numeroIngresado;

            do
            {
                Console.Write("Ingrese cantidad de valores que desea ingresar: ");
                int.TryParse(Console.ReadLine(), out numeroIngresado);

                if (numeroIngresado <= 0) Console.WriteLine("Ingrese un valor valido.");

            } while (numeroIngresado <= 0);

            int[] valores = new int[numeroIngresado];

            for (int i = 0; i < valores.Length; i++)
            {
                do
                {
                    Console.Write("Ingrese valor: ");
                    int.TryParse(Console.ReadLine(), out numeroIngresado);

                    if (numeroIngresado <= 0) Console.WriteLine("Ingrese un valor valido.");

                } while (numeroIngresado <= 0);

                valores[i] = numeroIngresado;
            }


            Moda(valores);
        }

        public static void Moda(int[] valores)
        {
            int minimo = valores[0];
            int maximo = valores[0];

            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] < minimo)
                { 
                    minimo = valores[i];
                }

                if (valores[i] > maximo)
                { 
                    maximo = valores[i];
                }
            }

            int cont1 = 0, cont2 = 0;
            int moda = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                for (int j = 0; j < valores.Length; j++)
                {
                    if (valores[i] == valores[j] && i != j) cont1++;
                }

                if (cont1 > cont2)
                { 
                    cont2 = cont1;
                    moda = valores[i];
                }

                cont1 = 0;
            }

            Console.WriteLine("Moda: " + moda);
            Console.WriteLine("Valor minimo: " + minimo);
            Console.WriteLine("Valor maximo: " + maximo);
        }
    } 
}
