// See https://aka.ms/new-console-template for more information

using System.Collections;

ArrayList array1 = new ArrayList() { 1, 5, 8, 10, 11, 52, 22, 21 };
var value = "1";


for(int i =0 ; i < array1.Count; i++)
{
    string item = array1[i].ToString();
    if (item.Contains(value))
    Console.WriteLine(i);
}
   
