/*
string[] isimler = new string[] { "Yusuf", "Nadir", "İbrahim", "Salih"};
Console.WriteLine(isimler[0]);
Console.WriteLine(isimler[1]);
Console.WriteLine(isimler[2]);
Console.WriteLine(isimler[3]);
Console.WriteLine(isimler[4]);

Console.WriteLine();

isimler = new string[5];
isimler[4] = "Denizcan";
Console.WriteLine(isimler[4]);
Console.WriteLine(isimler[0]);
*/

List<string> isimler2 = new List<string> { "Yusuf", "Nadir", "İbrahim", "Salih"};
Console.WriteLine(isimler2[0]);
Console.WriteLine(isimler2[1]);
Console.WriteLine(isimler2[2]);
Console.WriteLine(isimler2[3]);

Console.WriteLine();

isimler2.Add("Selim");
Console.WriteLine(isimler2[4]);
Console.WriteLine(isimler2[0]);