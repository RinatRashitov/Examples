﻿Console.Clear();
//Console.SetCursorPosition(10,4);
//Console.WriteLine("+");

int xa = new Random().Next(1, 30);
int ya = 1;
int xb = 1;
int yb = new Random().Next(5, 30);
int xc = new Random().Next(50, 80);
int yc = new Random().Next(20, 40);

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa;
int y = ya;
int count = 0;
while (count < 10000)
{
    int what = new Random().Next(0, 3); // 0 1 2
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1;
}