using System;
namespace _04._Arrays
{
    class Program
    {
        static  void Main(string[] args)
        {
            #region HW1 

            // Месяц      Доход, тыс. руб.  Расход, тыс. руб.     Прибыль, тыс. руб.
            //     1              100 000             80 000                 20 000
            //     2              120 000             90 000                 30 000
            //     3               80 000             70 000                 10 000
            //     4               70 000             70 000                      0
            //     5              100 000             80 000                 20 000
            //     6              200 000            120 000                 80 000
            //     7              130 000            140 000                -10 000
            //     8              150 000             65 000                 85 000
            //     9              190 000             90 000                100 000
            //    10              110 000             70 000                 40 000
            //    11              150 000            120 000                 30 000
            //    12              100 000             80 000                 20 000

            #endregion 

            # region Solution HW1
            // int[] Income = new int[]
            // {100_000 , 120_000, 80_000, 70_000, 100_000, 200_000,
            // 130_000, 150_000, 190_000, 110_000, 150_000, 100_000};

            // int[] Outcome = new int[]
            // {80_000, 90_000, 70_000, 70_000, 80_000, 120_000,
            // 140_000, 65_000, 90_000, 70_000, 120_000, 80_000};
            

            // int[] Profit = new int[12];
            // int[] worstProfitIndex = new int[12] ;
            // int numberOfProfit = 0 ;

            // for(int i = 0 ; i < Income.Length ; i++)
            // {
            //     Profit[i] = Income[i] - Outcome[i];
            //     if( Profit[i] > 0){
            //         numberOfProfit++;
            //     }
            // }

            // int index_min = 0 ;

            // for(int i = 0 ; i < Profit.Length; i++)
            // {
            //     index_min = i ;
            //     for(int j = i+1 ; j <Profit.Length; j++)
            //     {
            //         if(Profit[j] < Profit[index_min]){
            //             index_min = j ;
            //         }
            //     }

            //     // swap
            //     int temp = Profit[i];
            //     Profit[i] = Profit[index_min];
            //     Profit[index_min] = temp;
            //     worstProfitIndex[i] = index_min + 1;

            // }

            // for(int i = 0 ; i<Income.Length ; i++){
            //     Console.WriteLine(worstProfitIndex[i]);
            // }

            // print the 5 first worst profit 

            // Console.WriteLine($"Worst Profit Month are : {worstProfitIndex[0]}, {worstProfitIndex[1]}, {worstProfitIndex[2]}, {worstProfitIndex[3]}, {worstProfitIndex[4]}");
            // Console.WriteLine($"You have {numberOfProfit} Positive Income");
            // Console.ReadKey();
        #endregion

        #region HW 2
        // * Задание 2
        // Заказчику требуется приложение строящее первых N строк треугольника паскаля. N < 25
        // 
        // При N = 9. Треугольник выглядит следующим образом:
        //                                 1
        //                             1       1
        //                         1       2       1
        //                     1       3       3       1
        //                 1       4       6       4       1
        //             1       5      10      10       5       1
        //         1       6      15      20      15       6       1
        //     1       7      21      35      35       21      7       1
        //   1     8      28      56      70      56       28     8       1
        //                                                              
        //                                                              
        // Простое решение:                                                             
        // 1
        // 1       1
        // 1       2       1
        // 1       3       3       1
        // 1       4       6       4       1
        // 1       5      10      10       5       1
        // 1       6      15      20      15       6       1
        // 1       7      21      35      35       21      7       1
        // 
        // Справка: https://ru.wikipedia.org/wiki/Треугольник_Паскаля
        #endregion


        # region Solutin HW2
        // int N = 25;
        // int [][] pascalTriangle = new int[N][];
        // for(int  i=0 ; i<pascalTriangle.Length ; i++){
        //     pascalTriangle[i] = new int[i+1];
        //     for(int j = 0 ; j<pascalTriangle[i].Length ; j++){
        //         if( j == 0 ||  j == pascalTriangle[i].Length -1 ){
        //             pascalTriangle[i][j] = 1;
        //         } else{
        //             pascalTriangle[i][j] = pascalTriangle[i-1][j-1] + pascalTriangle[i-1][j];
        //         }
        //         if(j == 0 )
        //             Console.Write($"{pascalTriangle[i][j]}");
        //         else 
        //             Console.Write($"{pascalTriangle[i][j], 8}");
        //     }
        //     Console.WriteLine();
        // }
        //console.key();
        #endregion

        #region HW 3
        // 
        // * Задание 3.1
        // Заказчику требуется приложение позволяющщее умножать математическую матрицу на число
        // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
        // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матрицы_на_число
        // Добавить возможность ввода количество строк и столцов матрицы и число,
        // на которое будет производиться умножение.
        // Матрицы заполняются автоматически. 
        // Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
        //
        // Пример
        //
        //      |  1  3  5  |   |  5  15  25  |
        //  5 х |  4  5  7  | = | 20  25  35  |
        //      |  5  3  1  |   | 25  15   5  |
        //
        #endregion

        #region Solution HW3

        // int rows ;
        // int cols;
        // int coefficient;

        // Console.Write("numbers of rows: ");
        // rows =  Convert.ToInt32(Console.ReadLine());

        // Console.Write("numbers of columns: ");
        // cols =  Convert.ToInt32(Console.ReadLine());

        // Console.Write("Coefficient for multiplication: ");
        // coefficient =  Convert.ToInt32(Console.ReadLine());

        // Random rand = new Random();

        // int [,] matrix = new int[rows,cols]; 
        // for(int i = 0 ; i<rows; i++){
        //     for(int j = 0 ; j<cols; j++){
        //         matrix[i,j] = rand.Next(1,10);
        //     }
        // }
        // Console.WriteLine("Matrix before Multiplication: ");
        // for(int i = 0 ; i<rows; i++){
        //     for(int j = 0 ; j<cols; j++){
        //         Console.Write($"{matrix[i,j], 5}");
        //     }
        //     Console.WriteLine();
        // }
        // // Performation of mutliplication 
        // for(int i = 0 ; i<rows; i++){
        //     for(int j = 0 ; j<cols; j++){
        //         matrix[i,j]  *= coefficient   ;
        //     }
        // }
        // Console.WriteLine("Matrix After Multiplication: ");
        // for(int i = 0 ; i<rows; i++){
        //     for(int j = 0 ; j<cols; j++){
        //         Console.Write($"{matrix[i,j],5}");
        //     }
        //     Console.WriteLine();
        // }
        // Console.ReadKey();

        #endregion

        #region ТЗ 3.3
        // *** Задание 3.3
        // Заказчику требуется приложение позволяющщее перемножать математические матрицы
        // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
        // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матриц
        // Добавить возможность ввода количество строк и столцов матрицы.
        // Матрицы заполняются автоматически
        // Если по введённым пользователем данным действие произвести нельзя - сообщить об этом
        //  
        //  |  1  3  5  |   |  1  3  4  |   | 22  48  57  |
        //  |  4  5  7  | х |  2  5  6  | = | 35  79  95  |
        //  |  5  3  1  |   |  3  6  7  |   | 14  36  45  |
        //
        //  
        //                  | 4 |   
        //  |  1  2  3  | х | 5 | = | 32 |
        //                  | 6 |  
        //
        #endregion

        #region Solution HW3

        // Matrix A
        int rowsA ;
        int colsA;
        Console.WriteLine("Matrix A:");
        Console.Write("numbers of rows A : ");
        rowsA =  Convert.ToInt32(Console.ReadLine());

        Console.Write("numbers of columns A: ");
        colsA =  Convert.ToInt32(Console.ReadLine());

        Random rand = new Random();
        int [,] matrixA = new int[rowsA,colsA]; 

        for(int i = 0 ; i<rowsA; i++){
            for(int j = 0 ; j<colsA; j++){
                matrixA[i,j] = rand.Next(1,10);
            }
        }

        Console.WriteLine("Matrix before Multiplication: ");
        for(int i = 0 ; i<rowsA; i++){
            for(int j = 0 ; j<colsA; j++){
                Console.Write($"{matrixA[i,j], 5}");
            }
            Console.WriteLine();
        }

        // Matrix B
        int rowsB ;
        int colsB;

        Console.WriteLine("Matrix B:");
        Console.Write("numbers of rows B: ");
        rowsB =  Convert.ToInt32(Console.ReadLine());

        Console.Write("numbers of columns B: ");
        colsB =  Convert.ToInt32(Console.ReadLine());

        int [,] matrixB = new int[rowsB,colsB]; 

        for(int i = 0 ; i<rowsB; i++){
            for(int j = 0 ; j<colsB; j++){
                matrixB[i,j] = rand.Next(1,10);
            }
        }

        Console.WriteLine("Matrix before Multiplication: ");
        for(int i = 0 ; i<rowsB; i++){
            for(int j = 0 ; j<colsB; j++){
                Console.Write($"{matrixB[i,j], 5}");
            }
            Console.WriteLine();
        }

        int [,] matrix_result = new int[rowsA, colsB];
        if(colsA == rowsB){
            for(int i = 0 ; i<rowsA; i++){
                for(int j = 0 ; j<colsB; j++){
                    matrix_result[i,j]= 0;
                    for(int k = 0 ; k<rowsB; k++){
                        matrix_result[i,j] += matrixA[i,k] * matrixB[k,j] ;
                    }
                }
            }
        }else{
            Console.WriteLine("Impossible to Compute \n");
            return ;
        }


        Console.WriteLine("Matrix After Multiplication: ");
        for(int i = 0 ; i<rowsA; i++){
            for(int j = 0 ; j<colsB; j++){
                Console.Write($"{matrix_result[i,j],5}");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
        #endregion

        }
    }
}
