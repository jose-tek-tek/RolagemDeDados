﻿using System.Security.Cryptography;

Console.WriteLine("Rolagem de dados");

Console.WriteLine("Quantas faces tem o dado?");

int faces = Convert.ToInt32(Console.ReadLine());

int rolagem = RandomNumberGenerator.GetInt32(1, faces);

Console.WriteLine("");

Console.WriteLine($"A rolagem do dado resultou em {rolagem}");
