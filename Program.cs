using System;

namespace Task1
{
    class Program
    { 
           
            
        static void Main(string[] args)
        {
            //сума від'ємних елементів масиву 
            int A[50];
            int suma;// змінна цієї суми
            int i;//додаткова змінна
                  // вивід масиву
                  //...
                  //обчисленння суми 
            suma = 0;//обнулити суму
            for (i = 0; i < 50; i++)
                if (A[i] > 0)
                    suma = suma + A[i];

        }
    }
}
