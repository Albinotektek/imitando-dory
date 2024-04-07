Console.WriteLine();

﻿string frase;
string traduzido;

Console.Write("Escreva uma frase a ser traduzida: ");
frase = Console.ReadLine()!;

Console.WriteLine();

traduzido = frase
.Replace("a", "aaa")
.Replace("A", "AAA")
.Replace("e", "eee")
.Replace("E", "EEE")
.Replace("i", "iii")
.Replace("I", "III")
.Replace("o", "ooo")
.Replace("O", "OOO")
.Replace("u", "uuu")
.Replace("U", "UUU");
            
Console.WriteLine($"Em baleiês: {traduzido}");

Console.WriteLine();