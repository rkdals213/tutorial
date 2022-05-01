using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace tutorial;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Foo1 foo1 = new Foo1() { Num = 10 };
        Assert.AreEqual(10, foo1.Num);
        foo1.Num = 101;
        Assert.AreEqual(99, foo1.Num);
    }

    [Test]
    public void Test2()
    {
        Bar1 bar1 = new Foo2();
        bar1.Print();
        bar1.PrintBar();
    }

    [Test]
    public void Test3()
    {
        Console.WriteLine(Constant.ONE);
    }

    [Test]
    public void Test4()
    {
        int[] intArray = { 1, 2, 3, 4, 5 };
        List<int> intList = intArray.ToList();
        Console.WriteLine(String.Join(",", intArray));
        Console.WriteLine(String.Join(",", intList));
        
        intList.Add(6);
        Console.WriteLine(String.Join(",", intArray));
        Console.WriteLine(String.Join(",", intList));
        
        intList.ForEach(Console.Write);
        Console.WriteLine();
        
        List<int> intList2 = intList.Select(i => i + 1)
            .Where(i => i > 3)
            .ToList();
        Console.WriteLine(String.Join(",", intList2));
        
        int sum = intList2.Aggregate((i, j) => i + j);
        Console.WriteLine(sum);
    }

    [Test]
    public void Test5()
    {
        int a = 10;
        int b = 20;

        String c = "abc";
        String d = "qwe";
        String e = c;
        String f = "qwe";
        
        Console.WriteLine(a == b);
        Console.WriteLine(c == d);
        Console.WriteLine(c == e);
        Console.WriteLine(d == f);
    }
}