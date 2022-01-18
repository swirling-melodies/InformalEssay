﻿// See https://aka.ms/new-console-template for more information

using TestCode;
using TestCode.TestAbstract;
using TestCode.TestCopy;
using TestCode.TestDelegation;
using TestCode.TestDependencyInjection;
using TestCode.TestList;
using TestCode.TestNewFunction;
using TestCode.TestProperty;
using TestCode.TestThreaded;

test();
Console.WriteLine("------------------Test Complete---------------");
Console.ReadKey();

static void test()
{
    BaseTest data = new DataWork();
    data.Action();

    BaseTest dataAbstract = new DataWork();
    dataAbstract.Action();

    BaseTest copy = new Copy();
    copy.Action();

    BaseTest list = new WorkList();
    list.Action();

    BaseTest dependency = new DependencyInjection();
    dependency.Action();

    BaseTest run = new RunTest();
    run.Action();

    BaseTest threaded = new Threaded();
    threaded.Action();

    BaseTest delegates = new DelegateWork();
    delegates.Action();

    BaseTest property = new PropertyWork();
    property.Action();
}