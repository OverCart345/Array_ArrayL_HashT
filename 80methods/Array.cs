using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _80methods
{
    internal class Arra
    {

        private enum Alpha { m1, m2, m3, m4, m5, m6, m7, m8, exit };
        int button_count;
        private Alpha current_Button;

        private string[] button_Name;


        Array array;

        public Arra()
        {


            button_count = Enum.GetValues(typeof(Alpha)).Length;
            button_Name = new string[button_count];

            button_Name[0] = " Reverse ";
            button_Name[1] = " Length ";
            button_Name[2] = " Rank ";
            button_Name[3] = " Clear ";
            button_Name[4] = " Sort ";
            button_Name[5] = " GetValue ";
            button_Name[6] = " indexOf ";
            button_Name[7] = " setValue ";
            button_Name[8] = " Назад ";


        }

        public void ini()
        {
            current_Button = (int)Alpha.m1;
            Choise();
        }

        private void Start()
        {
            Console.Clear();


            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Методы для Array!");
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("");
            int down = 4;

            for (int i = 0; i < button_count; i++)
            {

                int centerX = 3;
                int centerY = down;

                int eValue = (int)current_Button;

                Console.SetCursorPosition(centerX, centerY);
                if (eValue == i)
                {
                    Console.Write(button_Name[i], Console.BackgroundColor = ConsoleColor.White,
                    Console.ForegroundColor = ConsoleColor.Black);
                }
                else
                {
                    Console.Write(button_Name[i], Console.BackgroundColor = ConsoleColor.Black,
                    Console.ForegroundColor = ConsoleColor.White);
                }

                down += 2;
            }
            Console.ResetColor();
        }

        private void before()
        {
            array = Array.CreateInstance(typeof(string), 4);
            array.SetValue("1",0);
            array.SetValue("3", 1);
            array.SetValue("9", 2);
            array.SetValue("2", 3);

            Console.SetCursorPosition(2, 1);
            Console.Write($"{button_Name[Convert.ToInt32(current_Button)]}");
            Console.SetCursorPosition(2, 2);
            Console.Write($"Array сейчас такой: ");
            foreach (var v in array)
            {
                Console.Write($"{v} ");
            }

        }

        private void cont(int down)
        {
            Console.SetCursorPosition(3, down);
            Console.WriteLine(" Для продолжение нажмите на любую кнопку ", Console.BackgroundColor = ConsoleColor.White,
                Console.ForegroundColor = ConsoleColor.Black);

            Console.ReadKey();
            Console.ResetColor();
            Choise();
        }

        private void meth1()
        {
            Console.Clear();

            before();
            int down = 4;

            Array.Reverse(array);

            Console.SetCursorPosition(2, down++);
            Console.Write($"Результат после Reverse(): ");
            foreach (var v in array)
            {
                Console.Write($"{v} ");
            }

            cont(++down);
        }

        private void meth2()
        {
            Console.Clear();

            before();

            int down = 4;



            Console.SetCursorPosition(2, down++);
            Console.Write($"Результат после Length: ");          
            Console.Write(array.Length);
            

            cont(++down);
        }

        private void meth3()
        {
            Console.Clear();

            before();

            int down = 4;
 

            Console.SetCursorPosition(2, down++);
            Console.Write($"После Rank такой: ");

            Console.Write(array.Rank);


            cont(++down);
        }

        private void meth4()
        {
            Console.Clear();

            before();

            int down = 4;

            Console.SetCursorPosition(2, down++);
            Console.Write("Введите индекс: ");
            int a = int.Parse(Console.ReadLine());

            Console.SetCursorPosition(2, down++);
            Console.Write("Введите кол-во элементов, которые нужно удалить, начиная с этого индекса: ");
            int b = int.Parse(Console.ReadLine());

            Console.SetCursorPosition(2, down++);
            Console.Write($"Результат после Clear(Array, int, int): ");

            Array.Clear(array,a,b);
            foreach (var v in array)
            {
                Console.Write($"{v} ");
            }

            cont(++down);
        }

        private void meth5()
        {
            Console.Clear();

            before();

            int down = 4;


            Array.Sort(array);

            Console.SetCursorPosition(2, down++);
            Console.Write($"Результат после Sort(Array): ");
            foreach (var v in array)
            {
                Console.Write($"{v} ");
            }

            cont(++down);
        }

        private void meth6()
        {
            Console.Clear();

            before();

            int down = 4;

            Console.SetCursorPosition(2, down++);
            Console.Write("Введите индекс: ");
            int b = int.Parse(Console.ReadLine());


            Console.SetCursorPosition(2, down++);
            Console.Write($"Результат после GetValue(int): ");

                Console.Write(array.GetValue(b));
            

            cont(++down);
        }

        private void meth7()
        {
            Console.Clear();

            before();

            int down = 4;

            Console.SetCursorPosition(2, down++);
            Console.Write("Введите элемент: ");
            int b = int.Parse(Console.ReadLine());

            Console.SetCursorPosition(2, down++);
            Console.Write($"Результат после indexOf(Array, int)   : ");
            
                Console.Write(Array.IndexOf(array,b));
            

            cont(++down);
        }

        private void meth8()
        {
            Console.Clear();

            before();

            int down = 4;

            Console.SetCursorPosition(2, down++);
            Console.Write("Введите индекс: ");
            int a = int.Parse(Console.ReadLine());

            Console.SetCursorPosition(2, down++);
            Console.Write("Введите значение: ");
            string b = Console.ReadLine();

            array.SetValue(b, a);

            Console.SetCursorPosition(2, down++);
            Console.Write($"После setValue(object, int) такой: ");

            foreach (var v in array)
            {
                Console.Write($"{v} ");
            }


            cont(++down);
        }

        private void Choise()
        {
            Start();
            ConsoleKeyInfo chose_Button;

            Console.ResetColor();
            do
            {
                chose_Button = Console.ReadKey();

                if (chose_Button.Key == ConsoleKey.UpArrow)
                {

                    if (current_Button > 0)
                    {
                        current_Button--;
                        Start();
                    }
                }

                if (chose_Button.Key == ConsoleKey.DownArrow)
                {
                    if ((int)current_Button < button_count - 1)
                    {
                        current_Button++;
                        Start();
                    }
                }

                if (chose_Button.Key == ConsoleKey.Enter)
                {

                    switch (current_Button)
                    {
                        case Alpha.m1: meth1(); break;
                        case Alpha.m2: meth2(); break;
                        case Alpha.m3: meth3(); break;
                        case Alpha.m4: meth4(); break;
                        case Alpha.m5: meth5(); break;
                        case Alpha.m6: meth6(); break;
                        case Alpha.m7: meth7(); break;
                        case Alpha.m8: meth8(); break;

                        case Alpha.exit: Controller.switch_to_Main(); break;
                    }
                }



            } while (chose_Button.Key != ConsoleKey.Escape);

        }

    }
}
