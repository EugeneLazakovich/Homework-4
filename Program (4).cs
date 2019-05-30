using System;

namespace _4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array = {'@','_', '_', '_', '_', '_', '_', '_', '_', '_' };
            Random medRnd = new Random();
            Random bombRnd = new Random();
            int med = medRnd.Next(1,9);
            int bomb = bombRnd.Next(1,9);
            char[] medAr = { '+' };
            char[] bombAr = { '*' };
            for(int i = 0; i < 100; i++)
            {
                if (med == bomb)
                {
                    bomb = bombRnd.Next(1, 9);
                }
                else
                {
                    break;
                }
            }
            System.Array.Copy(medAr, 0, array, med, medAr.Length);
            System.Array.Copy(bombAr, 0, array, bomb, medAr.Length);
            char temp;
            Boolean flag = true;
            int hp = 100;
            Console.Write(array);
            Console.WriteLine(" hp=" + hp);
            for (int i = 0; i < 100; i++)
            {
                string button = Console.ReadLine();
                if (button == "d")
                {
                    for(int j = 0; j < array.Length-1; j++)
                    {
                        if (array[j] == '@')
                        {
                            if (array[j + 1] == '+')
                            {
                                array[j + 1] = '_';
                                hp += 40;
                            }
                            if(array[j+1]=='*')
                            {
                                array[j + 1] = '_';
                                hp -= 40;
                            }
                            temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                            if (j == array.Length-2)
                            {
                                Console.WriteLine("GAME OVER!");
                                flag = false;
                            }
                            break;
                        }
                    }
                    hp -= 5;
                }
                if (button == "a")
                {
                    for (int j = 1; j < array.Length; j++)
                    {
                        if (array[j] == '@')
                        {
                            temp = array[j];
                            array[j] = array[j - 1];
                            array[j - 1] = temp;                            
                            break;
                        }
                    }
                    hp -= 5;
                }
                if (hp > 100)
                {
                    hp = 100;
                }
                if (hp <= 0)
                {
                    Console.WriteLine("GAME OVER!");
                    flag = false;

                }
                if (flag == false)
                {
                    break;
                }
                Console.Write(array);
                Console.WriteLine(" hp=" + hp);
            }
        }
    }
}
