﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;
using System.IO;
using System.Threading;

namespace Lab15
{
    class Program
    {
        public static void NumberOf()
        {
            try
            {
                Console.WriteLine("\nGet in count of numbers");
                int m = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[m];
                int s = 0, k;
                arr[s++] = 1;
                for (int i = 2; i <= m; i++)
                {
                    k = 0;
                    for (int j = 2; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            k += 1;
                        }
                    }
                    if (k == 1)
                    {
                        arr[s++] = i;
                    }
                }
                for (int i = 0; i < s; i++)
                {
                    Console.WriteLine(arr[i] + " ");

                    using (StreamWriter file = new StreamWriter("D:\\Документы\\Университет\\3 семестр\\ООТП\\Лабораторные\\Lab15\\Info.txt", true, System.Text.Encoding.Default))
                    {
                        file.WriteLine();
                    }
                    Console.Write(arr[i] + " ");
                    Console.WriteLine("Write in File");
                    Thread.Sleep(100);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Main(string[] args)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("D:\\Документы\\Университет\\3 семестр\\ООТП\\Лабораторные\\Lab15\\Process.txt"))
                {
                    Process[] allProcess = Process.GetProcesses();
                    foreach (Process proc in allProcess)
                    {
                        if (proc.ProcessName != "Idle")
                        {
                            sw.WriteLine("Id: " + proc.Id);
                            sw.WriteLine("Process name: " + proc.ProcessName);
                            sw.WriteLine("Start at: " + proc.StartTime);
                            sw.WriteLine();
                        }
                    }
                }


                Console.WriteLine("\nCurrent domain: ");
                AppDomain domain = AppDomain.CurrentDomain;
                Console.WriteLine("Name: " + domain.FriendlyName + "\nConfiguration: " + domain.SetupInformation);
                Console.WriteLine("Assemblies of current domain: ");
                Assembly[] assembly = domain.GetAssemblies();
                foreach (Assembly ass in assembly)
                {
                    Console.WriteLine(ass.GetName().Name);
                }
                AppDomain domain2 = AppDomain.CreateDomain("Second domain");
                string assemblyPath = domain.BaseDirectory + "Lab15_1.exe";
                domain2.ExecuteAssembly(assemblyPath);
                AppDomain.Unload(domain2);


                Console.WriteLine("\nPrime number: ");
                Thread thread = new Thread(NumberOf);
                thread.Start();
                Console.WriteLine("Thread №1 is " + (thread.IsAlive ? "alive" : "not alive"));
                thread.Name = "Write numbers in file and console";
                Console.WriteLine("Name: " + thread.Name + "\nPriority: " + thread.Priority + "\nStatus: " + thread.ThreadState + "\nId: " + thread.ManagedThreadId);
                thread.Join();


                Console.WriteLine("\n\nEven and Odd");
                Thread_Handler thrhan = new Thread_Handler(10);
                thrhan.myThread.Start();
                thrhan.myThread.Join();
                thrhan.myThread1.Start();
                thrhan.myThread1.Join();
                Console.WriteLine();
                Thread_Handler thrhan1 = new Thread_Handler(10);
                thrhan1.myThread.Start();
                thrhan1.myThread1.Start();
                thrhan1.myThread.Join();
                thrhan1.myThread1.Join();
                Console.WriteLine();


                int num = 10;
                // устанавливаем метод обратного вызова
                TimerCallback tm = new TimerCallback(thrhan.Count);
                // создаем таймер
                Timer timer = new Timer(tm, num, 150, 10000);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}