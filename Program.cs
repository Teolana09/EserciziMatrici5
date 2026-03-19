using System;

namespace EserciziMatrici5
{
    internal class Program
    {
        static int[,] MatriciSommate2(int[,] matrice)
        {
            int[,] MN2 = new int[3, 3];
            int[] arrayRighe = new int[3];
            int[] arrayColonne = new int[3];
            int sommaGriglia = 0;
            for (int i = 0; i < MN2.GetLength(0); i++)
            {
                for (int j = 0; j < MN2.GetLength(1); j++)
                {
                    sommaGriglia += matrice[i, j];
                }
            }
            Console.WriteLine(sommaGriglia);
           
            for (int i = 0; i < MN2.GetLength(0); i++)
            {
                for (int j = 0;j < MN2.GetLength(1);j++)
                {
                    arrayColonne[i] = arrayColonne[i] + matrice[i,j];
                    
                }
                Console.Write(arrayColonne[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
            for (int i = 0; i < MN2.GetLength(0); i++)
            {
                for (int j = 0; j < MN2.GetLength(1); j++)
                {
                    arrayRighe[i] = arrayRighe[i] + matrice[j, i];
                    
                }
                Console.Write(arrayRighe[i]);
                Console.Write(" ");
                
            }
            Console.WriteLine();
            for (int i = 0;i < MN2.GetLength(0);i++)
            {
                for (int j = 0;j < MN2.GetLength(1);j++)
                {
                    MN2[i,j] = sommaGriglia - arrayColonne[i] - arrayRighe[j] + matrice[i, j];
                    
                }
            }
            return MN2;
        }
        static int[,] MatriciSommate(int[,] matrice)
        {
            int[,] MN = new int[3, 3];
            
            for (int i = 0; i < MN.GetLength(0); i++)
            {
                for (int j = 0; j < MN.GetLength(1); j++)
                {
                    for (int k = 0; k < matrice.GetLength(0); k++)
                    {                        
                        for (int l = 0; l < matrice.GetLength(1); l++)
                        {
                            if (k != i && l != j)
                            {
                                MN[k,l] += matrice[i,j];
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
            Console.WriteLine("Progetto Matrici 5.1 19/03/2026");
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
                int[,] matriceSommata2 = MatriciSommate2(matrice);
                for (int i = 0; i < matriceSommata2.GetLength(0); i++)
                {
                    for (int j = 0; j< matriceSommata2.GetLength (1); j++)
                    {
                        Console.Write(matriceSommata2[i, j] + " ");
                    }
                    Console.WriteLine();
                }
        }
    }
}
