using System;

namespace HomeWork4_OTUS_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Основное задание: MyStack - через List, MyStack2 - через StackItem            

            var s1 = new MyStack("a1", "b1", "c1");
            var s2 = new MyStack2("a2", "b2", "c2");
            // size = 3, Top = 'c'
            Console.WriteLine($"size s1 = {s1.Size}, Top s1 = '{s1.Top}'");
            Console.WriteLine($"size s2 = {s2.Size}, Top s2 = '{s2.Top}'");

            var deleted1 = s1.Pop();
            var deleted2 = s2.Pop();
            // Извлек верхний элемент 'c' Size = 2
            Console.WriteLine($"Извлек верхний элемент из s1 '{deleted1}' Size = {s1.Size}");
            Console.WriteLine($"Извлек верхний элемент из s2 '{deleted2}' Size = {s2.Size}");

            s1.Add("d1");
            s2.Add("d2");
            // size = 3, Top = 'd'
            Console.WriteLine($"size s1 = {s1.Size}, Top = s1 '{s1.Top}'");
            Console.WriteLine($"size s2 = {s2.Size}, Top = s2 '{s2.Top}'");

            s1.Pop();
            s1.Pop();
            s1.Pop();

            s2.Pop();
            s2.Pop();
            s2.Pop();
            // size = 0, Top = null
            Console.WriteLine($"size s1 = {s1.Size}, Top s1 = {(s1.Top == null ? "null" : s1.Top)}");
            Console.WriteLine($"size s2 = {s2.Size}, Top s2 = {(s2.Top == null ? "null" : s2.Top)}");

            try
            {
                s1.Pop();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                s2.Pop();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //--------------------------------

            //Доп. задание 1
            var s = new MyStack("a", "b", "c");
            s.Merge(new MyStack("1", "2", "3"));
            // в стеке s теперь элементы - "a", "b", "c", "3", "2", "1" <- верхний
            Console.WriteLine("Извлекаем все элементы из s");
            int sizeS = s.Size;
            
            for (int i = 0; i < sizeS; i++)
            {
                Console.Write(s.Pop() + " ");
            }
            Console.WriteLine();
            //---------------------------------

            // Доп. задание 2
            var s3 = MyStack.Concat(new MyStack("a", "b", "c"), new MyStack("1", "2", "3"), new MyStack("А", "Б", "В"));
            // в стеке s3 теперь элементы - "c", "b", "a" "3", "2", "1", "В", "Б", "А" <- верхний
            Console.WriteLine("Извлекаем все элементы из s3");
            int sizeS3 = s3.Size;

            for (int i = 0; i < sizeS3; i++)
            {
                Console.Write(s3.Pop() + " ");
            }
            Console.WriteLine();
        }
    }
}
