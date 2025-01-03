﻿// Chapter 1, Creating a simple App

namespace L1_MyApp;

class Program
{
    static void Main(string[] args)
    {
        Box<int> box = new Box<int>();

        box.content = 1;
        Console.WriteLine(box.Log());
        
        Box<string> boxStr = new Box<string>();
        boxStr.content = "Hello World";

        Console.WriteLine(boxStr.Log());
    }
}