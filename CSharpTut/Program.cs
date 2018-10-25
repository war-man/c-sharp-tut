﻿using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace CSharpTut
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Thread t = new Thread(Print1);

            //t.Start();

            //for (int i = 0; i < 1000; i++)
            //{
            //    Console.Write(0);
            //}


            //int num = 1;

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(num);
            //    Thread.Sleep(1000);
            //    num++;
            //}

            //Console.WriteLine("Thread Ends");


            //BankAcct acct = new BankAcct(10);
            //Thread[] threads = new Thread[15];

            //Thread.CurrentThread.Name = "main";

            //for (int i = 0; i < 15; i++)
            //{
            //    Thread t = new Thread(new ThreadStart(acct.IssueWithdraw));
            //    t.Name = i.ToString();
            //    threads[i] = t;
            //}

            //for (int i = 0; i < 15; i++)
            //{
            //    Console.WriteLine(
            //        "Thread {0} Alive : {1}",
            //        threads[i].Name,
            //        threads[i].IsAlive
            //    );

            //    threads[i].Start();

            //    Console.WriteLine(
            //        "Thread {0} Alive : {1}",
            //        threads[i].Name,
            //        threads[i].IsAlive
            //    );
            //}

            //Console.WriteLine(
            //    "Current Priority : {0}",
            //    Thread.CurrentThread.Priority
            //);

            //Console.WriteLine(
            //    "Thread {0} Ending",
            //    Thread.CurrentThread.Name
            //);


            Thread t = new Thread(() => CountTo(10));
            t.Start();

            new Thread(() =>
            {
                CountTo(5);
                CountTo(6);
            }).Start();
        }

        static void Print1()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(1);
            }
        }

        static void CountTo(int maxNum)
        {
            for (int i = 0; i <= maxNum; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

class BankAcct
{
    private Object acctLock = new Object();
    double Balance { get; set; }

    public BankAcct(double bal)
    {
        Balance = bal;
    }

    public double Withdraw(double amt)
    {
        if ((Balance - amt) < 0)
        {
            Console.WriteLine($"Sorry ${Balance} in Account");
            return Balance;
        }

        lock (acctLock)
        {
            if (Balance >= amt)
            {
                Console.WriteLine(
                    "Removed {0} and {1} left in Account",
                    amt,
                    (Balance - amt)
                );
                Balance -= amt;
            }
            return Balance;
        }
    }

    public void IssueWithdraw()
    {
        Withdraw(1);
    }
}
