using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Заказчик просит написать программу «Записная книжка». Оплата фиксированная - $ 120.

            // В данной программе, должна быть возможность изменения значений нескольких переменных для того,
            // чтобы персонифецировать вывод данных, под конкретного пользователя.

            // Для этого нужно: 
            // 1. Создать несколько переменных разных типов, в которых могут храниться данные
            //    - имя;
            //    - возраст;
            //    - рост;
            //    - баллы по трем предметам: история, математика, русский язык;

            // 2. Реализовать в системе автоматический подсчёт среднего балла по трем предметам, 
            //    указанным в пункте 1.

            // 3. Реализовать возможность печатки информации на консоли при помощи 
            //    - обычного вывода;
            //    - форматированного вывода;
            //    - использования интерполяции строк;

            // 4. Весь код должен быть откомментирован с использованием обычных и хml-комментариев

            // **
            // 5. В качестве бонусной части, за дополнительную оплату $50, заказчик просит реализовать 
            //    возможность вывода данных в центре консоли.

            //User's Data
            string name = "TIERE";
            int age = 26;
            float height = 174F;
            float scoreHistory = 2F;
            float scoreMath = 4.5F;
            float scoreRussian = 3F;

            // average of all scores
            float averageScore = scoreHistory + scoreMath + scoreRussian / 3;

            // All output line by line 
            string[] output = new string[]
            {
                $"_NAME_: {name}",
                $"_AGE_: {age}",
                $"_HEIGHT_: {height}",
                $"__HISTORY SCORE__: {scoreHistory}",
                $"__RUSSIAN SCORE__: {scoreRussian}",
                string.Format(
                    "YOUR AVERAGE SCORE OF {0} , {1}, {2}   IS:   {3}",
                    scoreHistory,
                    scoreRussian,
                    scoreMath,
                    averageScore
                )
            };
            
            /*
                center the outout to the screen
                find other methods of centered output: <a  https://stackoverflow.com/questions/12847960/centering-text-in-c-sharp-console-app-only-working-with-some-input  />
            */
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            for (int i = 0; i < output.Length; i++)
            {
                Console.Write(new string(' ', (Console.WindowWidth - output[i].Length) / 2));
                Console.WriteLine(output[i]);
            }
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");

            Console.ReadKey();

        }
    }
}