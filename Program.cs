/* MAX && MIN elements - 1
 int n;
int[] a=new int[100];
Console.Write(" Variantlar sonini kiriting:");
n = int.Parse(Console.ReadLine());
int maxelement = a[0];
int minelement = a[0];
for (int i = 1; i <= n; i++)
{
        a[i]= int.Parse(Console.ReadLine());

    if (a[i] > a[0])
        maxelement = a[i];


    if (a[i] < a[0])
        minelement = a[i];

}
Console.WriteLine(" MaxElement :" + maxelement);
Console.WriteLine(" MinElement :" + minelement);*/


/* REVERSE -2
int[] array = { 1, 2, 5, 8, 9, 11 };
Array.Reverse(array);
Console.WriteLine(" Reverse :{0}",string.Join("," , array));*/

/* OCCUR NUMBER -3
int[] arr = { 1, 9, 8, 56, 78, 1564, 0 };
int num;
num = int.Parse(Console.ReadLine());
int n = arr.Length;
for(int i = 0; i < n; i++)
{

    if (arr[i] == num)
        Console.WriteLine(" OCCUR Element in Arr - " + num);
    else
        Console.WriteLine(" NOT OCCUR Element ");
    break;
}*/
/* TOQ INDEX -4
int[] arr = new int[100];
Console.Write(" Input Number ");
int n = int.Parse(Console.ReadLine());
for(int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
    if (i % 2 == 1)
    
        Console.WriteLine(i+"- Toq index : "+ arr[i]+",");
    
}*/


/*SUM of Array -5
int[] arr = new int[100];
Console.Write(" Variantlar sonini kiriting :");
int n = int.Parse(Console.ReadLine());
int sum = 0;
for(int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
    sum += arr[i];
}
Console.WriteLine(" SUM of Array =" + sum);*/

/* PALINDROM Number -6
int n, t, r = 0;
Console.Write(" sonni kiriting ");
n = int.Parse(Console.ReadLine());
t = n;
while (t != 0)
{
    r = r * 10;
    r = r + t % 10;
    t = t / 10;
}
if (r == n)
    Console.WriteLine(" PALINDROM Number - " + n);
else
    Console.WriteLine(" NOT Palindrom ");*/

/*ARRAY 7-1
int[] arr = { 1, 8, 9, 6, 7, 10 };
int n = arr.Length;
int i = 0,sum=0;
while (i < n)
{
    sum += arr[i];
    i++;
}
Console.WriteLine(" SUM = " + sum);*/
/*RECURSIVE 7-2
class sumofnumber
{
    static int[] arr = { 1, 5, 8, 9, 10 };
 static int sumnumber(int[]A,int n)
    {
        if (n == 0)
            return 0;
        return (sumnumber(A, n - 1) + A[n-1]);
    }
    public static void Main()
    {
       
        Console.Write(" SUM = "+sumnumber(arr,arr.Length));
    }

}*/


/*KVADRAT SON -8
    int[] a = new int[100];
    int m = int.Parse(Console.ReadLine());
    for (int i = 0; i < m; i++)
    {
        a[i] = int.Parse(Console.ReadLine());
        if (a[i] % Math.Sqrt(a[i]) == 0)
            Console.WriteLine(" KVadrat Son ");
        else
            Console.WriteLine(" NOT KVadrat Son ");
    }
        */
/* CONCAT -9
object[]a = { 1, 2, 3 };
object[] b = { 'A','B'};
object[] c = a.Concat(b).ToArray();
Console.WriteLine(string.Join(",", c));*/

/* MERGING - 10
 object[] a = { 1, 2, 3 };
object[] b = { 'a','b','c' };
object[] result = new object[a.Length + b.Length];
result[0] = a[0];
for(int i = 1, j = 1; i < a.Length; i++)
{
    result[j++] = b[i-1];
    result[j++] = a[i];
}
Console.WriteLine(string.Join(",", result));*/


/* SORTING -11
object[] arr = { 5, 7, 1, 3, 9, 8 };
Array.Sort(arr);
Console.WriteLine(string.Join(",", arr));
*/
/* ROTATION-12
public class rotationofarray {
    static void Main(string[] args)
    {
        int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
        int position = 0, k = 0;
        Console.Write(" Enter rotate of number :");
        position = int.Parse(Console.ReadLine());
        rotationofarray obj = new rotationofarray();
        while (position > k)
        {
            obj.LeftRotate(array);
            k++;
        }
        Console.WriteLine(" Rotate of position " + position) ;
        for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + ",");
        }
    }
        void LeftRotate(int[] array)
        {
            int x = array[0];
            for(int i=0;i<(array.Length-1);i++)
            {
                array[i] = array[i + 1];
            }
            array[(array.Length - 1)] = x;
        }
    
}*/


/* FIBONACCI NUMBER -13
int n = 100,s=2;
for(int i = 1; i <= n; i++)
{
    s += i;
    Console.WriteLine(i+"- Fibonacci Number " + s);
}*/

/*  SEPARATING -14
int n,m;
n = int.Parse(Console.ReadLine());
while (n > 0)
{
    m = n % 10;
    n = n / 10;
    Console.Write(m + ",");
}
*/





