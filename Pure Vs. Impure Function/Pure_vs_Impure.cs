using System;
using System.Collections.Generic;



/*
    Saf Fonksiyon (Pure Function):
        Aynı girdi ile her zaman aynı çıktıyı üretir.
        Dış dünyadan herhangi bir yan etki (side effect) içermez, yani fonksiyon dışında herhangi bir 
        durumu değiştirmez.
        
    
    Saf Olmayan Fonksiyon (Impure Function):
        Aynı girdi ile farklı çıktılar üretebilir.
        Dış dünya ile etkileşime girer veya fonksiyon dışındaki durumu değiştirebilir. 

    Pure Function
        -Robust And Testable Code
        -Prefer Declarative over imparative coding
    
    Functional Programming
        -Programming paradigm for developing software using functions
        -Functional programming is the key part of functional programming
*/
internal class Pure_vs_Impure
{
    static List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

    static void Function1()
    {

        numbers.Add(15); // impure mutate gloabal variable
    }

    static void Function2(ref int number)
    {
        // sayinin uzerinde degisiklik yapildi
        number++;  // impure mutate parameter
        numbers.Add(number);
    }

    static void Function3()
    {
        // eklenen deger tahmin edilmesi zordur bunun icin saf bir fonksiyon sayilamaz    
        numbers.Add(new Random().Next()); // impure interation with outside world
    }

    static List<int> Function4(List<int>lst, int number)
    {
        // pure function

        var result = new List<int>(lst);
        result.Add(number);
        return result;
    }
    public static void run()
    {
        Action<List<int>> print = (List<int> nums) => Console.WriteLine(string.Join(", ", nums));

        print(numbers);

        Function1();

        print(numbers);

        int num = 15;
        Function2(ref num);

        print(numbers);

        var result = Function4(numbers, 54);

        print(numbers);
        print(result);
    }
}
