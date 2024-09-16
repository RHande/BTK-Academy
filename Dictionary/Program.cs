// See https://aka.ms/new-console-template for more information



//Dictionary
//Dictionary is a collection of key-value pairs.
//It is a generic collection.
//It is present in System.Collections.Generic namespace.
//It is used when we want to store data in key-value pair.
//It is faster than List.
//It is used when we want to access data using key.
//It is used when we want to store data in unique key.

using System;
using System.Collections.Generic;

Dictionary<int, string> dictionary = new Dictionary<int, string>();
dictionary.Add(41, "Kocaeli");
dictionary.Add(34, "Istanbul");
dictionary.Add(6, "Ankara");

Dictionary<int, string> bumbers = new Dictionary<int, string>()
{
    { 1, "One" },
    { 2, "Two" },
    { 3, "Three" }
};

Console.WriteLine(dictionary[41]);//output: Kocaeli
Console.WriteLine(dictionary[34]);//output: Istanbul

if(dictionary.ContainsKey(41))
{
    Console.WriteLine(dictionary[41]);//This will not throw exception
}


foreach (var item in bumbers)
{
    Console.WriteLine(item.Key + " " + item.Value);
}

//Update
dictionary[41] = "Izmir";
Console.WriteLine(dictionary[41]);//output: Izmir

//Remove
dictionary.Remove(41);
Console.WriteLine(dictionary.ContainsKey(41));//output: False

//Clear : Removes all the elements from the dictionary

foreach (var item in dictionary)
{
    Console.WriteLine(item.Key + " " + item.Value);
}

