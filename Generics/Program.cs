using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
        {
            static int?[] buffer;
            static int?[] finallyArray;
            static int index = 0;
            static int finallyIndex = 0;

            static void Main(string[] args)
            {
                int[] array = { 1, 1, 3, 2, 1, 2, 2, 8, 12, 12, 44, 12, 2, 3, 4, 1, 2, 3, 4, 3, 2, 3, 1, 2, 3, 1, 2, 3, 2, 1, 2, 3, 5, 7 };
                buffer = new int?[array.Length];
                finallyArray = new int?[array.Length];
                int?[] deleted = new int?[array.Length];
                int delIndex = 0;
                foreach (int n in array)
                    if (isBuffer(n))
                    {
                        deleted[delIndex] = n;
                        delIndex++;
                    }
                delete(deleted, array);
                foreach (int? n in finallyArray) Console.Write(n + " ");
                Console.ReadKey();
            }

            static bool isBuffer(int n)
            {
                foreach (int? buff in buffer)
                    if (buff == n)
                        return true;
                buffer[index] = n;
                index++;
                return false;
            }

            static void delete(int?[] deleted, int[] array)
            {
                foreach (int n in array)
                {
                    bool add = true;
                    foreach (int? del in deleted)
                    {
                        if (del == n)
                        {
                            add = false;
                            break;
                        }
                    }
                    if (add)
                    {
                        finallyArray[finallyIndex] = n;
                        finallyIndex++;
                    }
                }
            }
        }
    }