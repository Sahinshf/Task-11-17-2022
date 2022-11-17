

#region Verilen 2 eded arasindaki ededleri ekrana yazdiran alqoritm. 

//string num_1_STR = Console.ReadLine();
//string num_2_STR = Console.ReadLine();

//int num1 = Convert.ToInt32(num_1_STR);
//int num2 = Convert.ToInt32(num_2_STR);

//for (int i = num1 + 1; i < num2; i++)
//{
//	Console.WriteLine(i);
//} 
#endregion

#region Verilen eded 70-den boyukdurse, 70-le arasindaki ferqin 3 qatini ekrana yazdiran, eger kicikdirse ferqin ozunu ekrana yazdiran 

//string num_str = Console.ReadLine();
//int num = Convert.ToInt32(num_str);

//if (num > 70)
//{
//	Console.WriteLine((num - 70) * 3);
//}
//else
//{
//	Console.WriteLine(70 - num);
//}    
#endregion

#region Verilmiş n və m (n<m) ədədləri arasında neçə tək ədəd olduğunu tapın.

//string nStr = Console.ReadLine();
//string mStr = Console.ReadLine();

//int n = Convert.ToInt32(nStr);
//int m = Convert.ToInt32(mStr);
//int k = 0;

//for (int i = n + 1; i < m; i++)
//{
//    if (i % 2 == 1)
//    {
//        k++;
//    }
//}

//Console.WriteLine(k); 

#endregion

#region X, Y və Z ədədləri verilir. Hansı ədədin böyük olduğunu ekrana çıxardan bir alqoritm yazırsız.
//string zStr = Console.ReadLine();
//string yStr = Console.ReadLine();
//string xStr = Console.ReadLine();

//int x = Convert.ToInt32(zStr);
//int y = Convert.ToInt32(yStr);
//int z = Convert.ToInt32(xStr);

//if ( x>=y && x>=z )
//{
//    Console.WriteLine(x);
//}

//else if ( y>=x && y>=z)
//{
//    Console.WriteLine( y);
//}

//else
//{
//    Console.WriteLine(z);
//} 
#endregion

#region Ədədin 2-nin qüvvəti olub olmadığı tapan alqoritm.


string numStr = Console.ReadLine();
Double num = Convert.ToDouble(numStr);


if (num == 0)
{
    Console.WriteLine("2`nin quvveti deyil");
}

else if (num >= 1)
{

    if (num == 1)
    {
        Console.WriteLine("2`nin quvvetidir");
    }

    else if (num % 2 == 1)
    {
        Console.WriteLine("2`nin quvveti deyil");

    }

    else if (num % 2 == 0)
    {
        while (num > 1)
        {
            num = num / 2;
        }

        if (num == 1)
        {
            Console.WriteLine("2`nin quvvetidir");
        }

        else
        {
            Console.WriteLine("2`nin quvveti deyil");
        }
    }

}

else if (num < 1)
{
    while (num < 1)
    {
        num = num * 2;
    }
    if (num == 1)
    {
        Console.WriteLine("2`nin quvvetidir");
    }
    else
    {
        Console.WriteLine("2`nin quvveti deyil");
    }
} 
#endregion






