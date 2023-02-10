using System;
using System.Collections.Generic;
using System.Linq;
using MyPoint.Test;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace MyPoint
{
    namespace Test
    {
        /*public class employee
        {
            public string FIO { get; set; }
            public static string birth { get; set; }
            public string email { get; set; }
            public string job { get; set; }
            public string descrp { get; set; }
            public int contact { get; set; }
            public int zp { get; set; }
            //public int zp2 { get; set; }

            public employee() { }
            public static string GetBirth()
            {
                return birth;
            }
            public static void SetBirth(string k)
            {
                birth = k;
            }
            static employee()
            {
                Console.WriteLine("Введите дату рождения: ");
                birth = Console.ReadLine();
            }
            public void Input()
            {
                Console.WriteLine("Введите ФИО: ");
                FIO = Console.ReadLine();
                Console.WriteLine("Введите телефон: ");
                contact = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите email: ");
                email = Console.ReadLine();
                Console.WriteLine("Введите должность: ");
                job = Console.ReadLine();
                Console.WriteLine("Введите описание служебных обязаностей: ");
                descrp = Console.ReadLine();
                WriteLine("Введите zp: ");
                zp = Convert.ToInt32(ReadLine());
            }

            public void Print()
            {
                Console.WriteLine($"ФИО: { FIO}\n датa рождения: {birth}\n  телефон: {contact}\n email: {email}\n должность: {job}\n описание служебных обязаностей:{descrp}\nzp: {zp}");
            }
            public override string ToString()
            {
                return $"ФИО: { FIO}\n датa рождения: {birth}\n  телефон: {contact}\n email: {email}\n должность: {job}\n описание служебных обязаностей:{descrp}";
            }

            public static employee operator +(employee op1, int op2)
            {
                employee result = new employee();
                result.zp = op1.zp + op2;
                return result;
            }
            public static employee operator -(employee op1, int op2)
            {
                employee result = new employee();
                result.zp = op1.zp - op2;
                return result;
            }

            //== !=
            public static bool operator ==(employee op1, employee op2)
            {
                if (op1.zp == op2.zp)
                    return true;
                else
                    return false;
            }
            public static bool operator !=(employee op1, employee op2)
            {
                return !(op1.zp == op2.zp);
            }

            //< >
            public static bool operator >(employee op1, employee op2)
            {
                if (op1.zp >= op2.zp) 
                    return true;
                else
                    return false;
            }
            public static bool operator <(employee op1, employee op2)
            {
                return !(op1.zp >= op2.zp);
            }

            public void show()
            {
                WriteLine(zp + " " );
            }
        }*/

        /*public class Matrix
        {
            int [,] m ;
            int n;


            public Matrix(int n)
            {
                this.n = n;
                m = new int[n, n];

            }
            public void InputMatrix()
            {
                Random rnd = new Random();
                for (int i = 0; i < m.GetLength(0); i++)
                {
                    for (int j = 0; j < m.GetLength(1); j++)
                    {
                        m[i, j] = rnd.Next(1, 10);
                    }
                }
            }
            public static Matrix operator +(Matrix A, Matrix B)
            {
                Matrix C = new Matrix(A.n);
                for (int i = 0; i < A.n; i++)
                {
                    for (int j = 0; j < A.n; j++)
                    {
                        C.m[i, j] = A.m[i, j] + B.m[i, j];
                    }
                }
                return C;
            }
            public static Matrix operator -(Matrix A, Matrix B)
            {
                Matrix D = new Matrix(A.n);
                for (int i = 0; i < A.n; i++)
                {
                    for (int j = 0; j < A.n; j++)
                    {
                        D.m[i, j] = A.m[i, j] - B.m[i, j];
                    }
                }
                return D;
            }
            public static Matrix operator *(Matrix A, Matrix B)
            {
                Matrix E = new Matrix(A.n);
                for (int i = 0; i < A.n; i++)
                {
                    for (int j = 0; j < A.n; j++)
                    {
                        E.m[i, j] = 0;
                        for (int k = 0; k < A.n; k++)
                        {
                            E.m[i, j] = E.m[i, j] + A.m[k, j] * B.m[i, k];
                        }
                    }
                }
                return E;
            }
             public static bool operator ==(Matrix A, Matrix B)
            {
                for(int i=0;i<A.n;i++)
                {
                    for(int j=0;j<A.n;j++)
                    {
                        if (A.m[i, j] == A.m[i, j])
                        {
                            return true;
                        }
                        else
                            return false;
                    }
                }
                return true;
            }
            public static bool operator !=(Matrix A, Matrix B)
            {
                for (int i = 0; i < A.n; i++)
                {
                    for (int j = 0; j < A.n; j++)
                    {
                        return !(A.m[i,j] == A.m[i, j]);
                    }
                }
                return true;
            }
            public void Print()
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Write(m[i, j] + "\t");
                    }
                    WriteLine();
                }

            }
        }*/

        /*public class Plane
        {
            public string name { get; set; }
            public string namepr { get; set; }
            public static int year { get; set; }
            public string type { get; set; }
            public int kolvo { get; set; }

            public static int GetYear()
            {
                return year;
            }
            public static void SetYear(int k)
            {
                year = k;
            }
            static Plane()
            {
                Console.WriteLine("Введите год выпуска: ");
                year = Convert.ToInt32(Console.ReadLine());
            }
            public void Input()
            {
                Console.WriteLine("Введите название самолета: ");
                name = Console.ReadLine();
                Console.WriteLine("Введите название производителя самолета: ");
                namepr = Console.ReadLine();
                Console.WriteLine("Введите тип самолета: ");
                type = Console.ReadLine();
                WriteLine("Введите кол-во самолетов: ");
                kolvo = Convert.ToInt32(ReadLine());
            }

            public void Print()
            {
                Console.WriteLine($"название самолета: {name}\n название производителя самолета: {namepr}\n  тип самолета {type}\nГод выпуска: {year}\n Кол-во самолетов: { kolvo} ");
            }

            public static Plane operator +(Plane ob1, int ob2)
            {
                Plane result = new Plane();
                result.kolvo = ob1.kolvo + ob2;
                return result;
            }

            public static Plane operator -(Plane ob1, int ob2)
            {
                Plane result = new Plane();
                result.kolvo = ob1.kolvo - ob2;
                return result;
            }
            public static bool operator ==(Plane op1, Plane op2)
            {
                if (op1.kolvo == op2.kolvo)
                    return true;
                else
                    return false;
            }
            public static bool operator !=(Plane op1, Plane op2)
            {
                return !(op1.kolvo == op2.kolvo);
            }
            public static bool operator >(Plane op1, Plane op2)
            {
                if (op1.kolvo >= op2.kolvo)
                    return true;
                else
                    return false;
            }
            public static bool operator <(Plane op1, Plane op2)
            {
                return !(op1.kolvo >= op2.kolvo);
            }
            public void show()
            {
                WriteLine(kolvo + " ");
            }

        }*/

        public class Credit
        {
            public string CreditCard { get; set; }
            public string FIO { get; set; }
            public string Deadline { get; set; }
            public string CVC { get; set; }
            public int money { get; set; }
            public static Credit operator +(Credit ob1, int ob2)
            {
                Credit result = new Credit();
                result.money = ob1.money + ob2;
                return result;
            }

            public static Credit operator -(Credit ob1, int ob2)
            {
                Credit result = new Credit();
                result.money = ob1.money - ob2;
                return result;
            }
            public static bool operator ==(Credit op1, Credit op2)
            {
                if (op1.money == op2.money)
                    return true;
                else
                    return false;
            }
            public static bool operator !=(Credit op1, Credit op2)
            {
                return !(op1.money == op2.money);
            }
            public static bool operator >(Credit op1, Credit op2)
            {
                if (op1.money >= op2.money)
                    return true;
                else
                    return false;
            }
            public static bool operator <(Credit op1, Credit op2)
            {
                return !(op1.money >= op2.money);
            }
            public void show()
            {
                WriteLine(money + " ");
            }

            public void Input()
            {
                Console.WriteLine("Введите ФИО: ");
                FIO = Console.ReadLine();
                Console.WriteLine("Введите карточку: ");
                CreditCard = Console.ReadLine();
                Console.WriteLine("Введите год срока карты: ");
                Deadline = Console.ReadLine();
                Console.WriteLine("Введите CVC: ");
                CVC = Console.ReadLine();
                WriteLine("Введите кол-во денег на карте: ");
                money = Convert.ToInt32(ReadLine());
            }
            public void Print()
            {
                Console.WriteLine($"ФИО: { FIO}\n карточка: {CreditCard}\n  срок карты: {Deadline}\n код: {CVC}\n кол-во дененг на карте: {money}");
            }
        }

        class Program
        {

            public static void Main()
            {
                #region задание 1
                /*employee a = new employee();
                a.FIO = "Naima Bilal";
                a.email = "bilalnaima1911@gmail.com";
                a.job = "Developer";
                a.descrp = "Codding";
                a.contact = 0934561234;
                a.zp = 12000;

                WriteLine();

                a.Print();
                WriteLine();

                employee b = new employee();
                b.FIO = "Sasha ";
                b.email = "fkfkfkkf.com";
                b.job = "Developer";
                b.descrp = "Codding";
                b.contact = 0934561234;
                b.zp = 12000;

                b.Print();
                WriteLine();

                int plus = 0, minus = 0;
                WriteLine("Ввндите желаемое сумму для увеличения зп: ");
                plus = Convert.ToInt32(ReadLine());
                a = a + plus;
                WriteLine("Увеличенная зарплата: ");
                a.show();


                WriteLine("Ввндите желаемое сумму для уменьшения зп: ");
                minus = Convert.ToInt32(ReadLine());
                a = a - minus;
                WriteLine("Уменьшенная зарплата: ");
                b.show();

                if (a.zp == b.zp)
                    Console.WriteLine("Зарплата сотрудников одинаковая");
                else
                {
                    WriteLine("Зарплата сотрудников не одинаковая");
                }

                if (a.zp >= b.zp)
                    Console.WriteLine("Зарплата сотрудников не одинаковая");
                else
                {
                    WriteLine("Зарплата сотрудников одинаковая");
                }*/
                #endregion

                #region задание 2   
                /*WriteLine("Введите размерность массива");
                int n = Convert.ToInt32(ReadLine());
                Matrix A = new Matrix(n);
                A.InputMatrix();
                WriteLine("Первая матрица");
                A.Print();
                WriteLine("---------------------------------------");
                Matrix B = new Matrix(n);
                B.InputMatrix();
                WriteLine("Вторая матрица");
                B.Print();
                WriteLine("---------------------------------------");

                Matrix C = A + B;
                WriteLine("Сложение матриц");
                C.Print();
                WriteLine();

                C = A - B;
                WriteLine("ВЫЧИТАНИЕ матриц");
                C.Print();
                WriteLine();

                C = A * B;
                WriteLine("Умножение матриц");
                C.Print();
                WriteLine();
                if ( A == B) WriteLine("Матрицы равны ");*/

                #endregion

                #region задание 3
                /*Plane p = new Plane();
                p.Input();
                Console.WriteLine();
                p.Print();
                Console.WriteLine();

                Plane p1 = new Plane();
                p1.Input();
                Console.WriteLine();
                p1.Print();
                WriteLine();

                int pl;
                WriteLine("Ввндите количество для увел 2 самолета: ");
                pl = Convert.ToInt32(ReadLine());
                p = p - pl;
                WriteLine("Кол-во: ");
                p1.show();

                if (p.kolvo == p1.kolvo)
                    Console.WriteLine("Кол-во одинаковое");
                else
                {
                    WriteLine("Кол-во не одинаковая");
                }

                if (p.kolvo >= p1.kolvo)
                    Console.WriteLine("Кол-во одинаковое");
                else
                {
                    WriteLine("Кол-во одинаковое");
                }*/
                #endregion

                #region Задание 4
                
                Credit c = new Credit();
                c.Input();
                WriteLine();
                c.Print();

                Credit v = new Credit();
                v.Input();
                WriteLine();
                v.Print();

                WriteLine();

                int plus = 0, minus = 0;
                WriteLine("Ввндите желаемую сумму для увеличения денег: ");
                plus = Convert.ToInt32(ReadLine());
                v = v + plus;
                WriteLine("Увеличенная сумма денег: ");
                v.show();

                if (c.CVC == v.CVC)
                    Console.WriteLine("Код равен");
                else
                {
                    WriteLine("Код не равен");
                }

                if (c.money >= v.money)
                    Console.WriteLine("Кол-во суммы не одинаковое");
                else
                {
                    WriteLine("Кол-во суммы одинаковое");
                }
                #endregion


            }
        }
    }
}
        
    


