namespace EserciziMatrici5
{
    internal class Program
    {
        static int[,] MatriciSommate(int[,] matrice)
        {
            int[,] MN = new int[3, 3];
            int somma = 0;
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    for (int k = 0; k < matrice.GetLength(0); k++)
                    {
                        
                        for (int l = 0; l < matrice.GetLength(1); l++)
                        {
                            if (i != k && j != l)
                            {
                                MN[i,j] = somma + matrice[i,j];
                            }
                            
                        }
                    }                    
                }
            }

            return MN;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Progetto Matrici 5 18/03/2026");
                int[,] matrice = new int[3, 3]
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 },
                    { 7, 8, 9 }
                };
                int[,] matriceSommata = MatriciSommate(matrice);                
                for (int i = 0; i < matriceSommata.GetLength(0); i++)
                {
                    for (int j = 0; j < matriceSommata.GetLength(1); j++)
                    {
                        Console.Write(matriceSommata[i, j] + " ");
                    }
                    Console.WriteLine();
            }
        }
    }
}
