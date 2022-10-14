//Value Type
//int,decimal,float,double,bool(0&1)
int sayi1 = 10;
int sayi2 = 30;
sayi1 = sayi2;
sayi2 = 65;
Console.WriteLine(sayi1);
Console.WriteLine(sayi2);

Console.WriteLine();

//Reference Type
//Array-Class-Interface
int[] sayilar1 = new int[] { 10, 20, 30 };
int[] sayilar2 = new int[] { 100, 200, 300 };
sayilar1 = sayilar2;
sayilar2[0] = 999;
Console.WriteLine(sayilar1[0]);
Console.WriteLine(sayilar2[0]);