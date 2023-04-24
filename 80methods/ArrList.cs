using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _80methods
{
    internal class ArrList
    {

        private enum Alpha { m1, m2, m3, m4,m5,m6,m7,m8,exit};
        int button_count;
        private Alpha current_Button;

        private string[] button_Name;


        ArrayList arrayList;

        public ArrList()
        {


            button_count = Enum.GetValues(typeof(Alpha)).Length;
            button_Name = new string[button_count];

            button_Name[0] = " Reverse ";
            button_Name[1] = " RemoveAt ";
            button_Name[2] = " IndexOf ";
            button_Name[3] = " Sort ";
            button_Name[4] = " Insert ";
            button_Name[5] = " Remove ";
            button_Name[6] = " Clear ";
            button_Name[7] = " Contains ";
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
            Console.WriteLine("Методы для ArrayList!");
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
            arrayList.Add(2);
            arrayList.Add(6);
            arrayList.Add(3);
            arrayList.Add(1);

            Console.SetCursorPosition(2, 1);
            Console.Write($"{button_Name[Convert.ToInt32(current_Button)]}");
            Console.SetCursorPosition(2, 2);
            Console.Write($"ArrayList сейчас такой: ");
            foreach (var v in arrayList)
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

            arrayList = new ArrayList();
            before();

            arrayList.Reverse();

            Console.SetCursorPosition(2, 4);
            Console.Write($"Результат после Reverse(): ");
            foreach (var v in arrayList)
            {
                Console.Write($"{v} ");
            }

            cont(5);
        }

        private void meth2()
        {
            Console.Clear();

            arrayList = new ArrayList();
            before();

            int down = 4;

            Console.SetCursorPosition(2, down++);
            Console.Write("Введите аргумент: ");
            arrayList.RemoveAt(int.Parse(Console.ReadLine()));

            Console.SetCursorPosition(2, down++);
            Console.Write($"Результат после RemoveAt(int): ");
            foreach (var v in arrayList)
            {
                Console.Write($"{v} ");
            }

            cont(++down);
        }

        private void meth3()
        {
            Console.Clear();

            arrayList = new ArrayList();
            before();

            int down = 4;

            Console.SetCursorPosition(2, down++);
            Console.Write("Введите аргумент: ");
            int f = arrayList.IndexOf(int.Parse(Console.ReadLine()));

            Console.SetCursorPosition(2, down++);
            Console.Write($"После IndexOf(int) такой: ");
            
                Console.Write($"{f} ");
            

            cont(++down);
        }

        private void meth4()
        {
            Console.Clear();

            arrayList = new ArrayList();
            before();

            int down = 4;


            arrayList.Sort();

            Console.SetCursorPosition(2, down++);
            Console.Write($"Результат после Sort(): ");
            foreach (var v in arrayList)
            {
                Console.Write($"{v} ");
            }

            cont(++down);
        }

        private void meth5()
        {
            Console.Clear();

            arrayList = new ArrayList();
            before();

            int down = 4;

            Console.SetCursorPosition(2, down++);
            Console.Write("Введите аргумент: ");
            int a = int.Parse(Console.ReadLine());

            Console.SetCursorPosition(2, down++);
            Console.Write("Введите значение: ");
            int b = int.Parse(Console.ReadLine());

            arrayList.Insert(a,b);

            Console.SetCursorPosition(2, down++);
            Console.Write($"Результат после Insert(int, object): ");
            foreach (var v in arrayList)
            {
                Console.Write($"{v} ");
            }

            cont(++down);
        }

        private void meth6()
        {
            Console.Clear();

            arrayList = new ArrayList();
            before();

            int down = 4;

            Console.SetCursorPosition(2, down++);
            Console.Write("Введите значение: ");
            int b = int.Parse(Console.ReadLine());

            arrayList.Remove(b);

            Console.SetCursorPosition(2, down++);
            Console.Write($"Результат после Remove(object): ");
            foreach (var v in arrayList)
            {
                Console.Write($"{v} ");
            }

            cont(++down);
        }

        private void meth7()
        {
            Console.Clear();

            arrayList = new ArrayList();
            before();

            int down = 4;

            arrayList.Clear();

            Console.SetCursorPosition(2, down++);
            Console.Write($"Результат после Clear(): ");
            foreach (var v in arrayList)
            {
                Console.Write($"{v} ");
            }

            cont(++down);
        }

        private void meth8()
        {
            Console.Clear();

            arrayList = new ArrayList();
            before();

            int down = 4;

            Console.SetCursorPosition(2, down++);
            Console.Write("Введите значение: ");
            int b = int.Parse(Console.ReadLine());

            Console.SetCursorPosition(2, down++);
            Console.Write($"После Contains(object) такой: ");
            
            Console.Write(arrayList.Contains(b));


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
