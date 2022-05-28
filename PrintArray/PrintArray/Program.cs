int[] intArray = new int[5] { 1, 2, 3, 4, 5 };
double[] doubleArray = new double[6] { 1.0, 2.0, 4.50, 34.56, 590.25, 6.1 };
char[] chars = new char[3] { 'h', 'e', 'm' };

PrintArray.PrintArray print = new PrintArray.PrintArray();
Console.WriteLine("-------Int Array----------------");
print.ToPrintArray(intArray);
Console.WriteLine("-------DoubleArray--------------");
print.ToPrintArray(doubleArray);
Console.WriteLine("-------Char Array---------------");
print.ToPrintArray(chars);
