using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ17
{
    internal class Bill<T>
    {
        public T Num {get;set;}
        public int Balance {get;set;}
        public string Name {get;set;}

        public void SetInfo()
        {
            Console.Write("Введите номер счета: ");
            Num = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));

            Console.Write("Введите ФИО владельца: ");
            Name = Console.ReadLine();

            Console.Write("Введите балан: ");
            Balance = Convert.ToInt32(Console.ReadLine());
        }

        public string GetInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Номер счеа: {Num} Фамилия:  {Name} Баланс: {Balance}");
            Console.WriteLine();
            return $"Номер счета: {Num} Фамилия:  {Name} Баланс: {Balance}";
        }
    }
}
