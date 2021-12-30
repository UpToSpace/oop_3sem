using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Threading;

namespace laba15
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Определите и выведите на консоль/в файл все запущенные процессы:id, имя, приоритет,
            //время запуска, текущее состояние, сколько всего времени использовал процессор и т.д.
            foreach (var item in Process.GetProcesses())
            {
                Console.WriteLine($"Name: {item.ProcessName}\nId: {item.Id}\nPriority: {item.BasePriority}\nVirtual memory size: {item.VirtualMemorySize64}\n");
            }

            //2. Исследуйте текущий домен вашего приложения: имя, детали конфигурации, все сборки,
            //загруженные в домен. Создайте новый домен. Загрузите туда сборку. Выгрузите домен
            AppDomain domain = AppDomain.CurrentDomain;
            Console.WriteLine($"Name: {domain.FriendlyName}\nBase Directory: {domain.BaseDirectory}\nSetup Information: {domain.SetupInformation}\n\n\n");

            foreach (Assembly x in domain.GetAssemblies())
            {
                Console.WriteLine(x.ToString());
            }
            AppDomain mydomain = AppDomain.CreateDomain("domain");
            mydomain.Load(Assembly.GetExecutingAssembly().GetName());
            AppDomain.Unload(mydomain);

            // 3. Создайте в отдельном потоке следующую задачу расчета (можно сделать sleep для
            // задержки) и записи в файл и на консоль простых чисел от 1 до n (задает пользователь).
            // Вызовите методы управления потоком (запуск, приостановка, возобновление и т.д.) Во
            // время выполнения выведите информацию о статусе потока, имени, приоритете, числовой
            // идентификатор и т.д.
            var first = new Thread(ShowSimpleNumbers); // delegate
            first.Start();
            first.Name = "SimpleNumbersThread";
            first.Join();

            //             Создайте два потока. Первый выводит четные числа, второй нечетные до n и 
            //записывают их в общий файл и на консоль. Скорость расчета чисел у потоков – разная.
            //a. Поменяйте приоритет одного из потоков. 
            //b. Используя средства синхронизации организуйте работу потоков, таким образом, 
            //чтобы
            //i. выводились сначала четные, потом нечетные числа
            //ii. последовательно выводились одно четное, другое нечетное.

            var even = new Thread(ShowEvenNumbers) { Priority = ThreadPriority.Highest };
            var odd = new Thread(ShowOddNumbers);
            Console.WriteLine();
            FirstlyEvenSecondlyOdd();
            Console.WriteLine();
            ShowOneByOne();

            // Придумайте и реализуйте повторяющуюся задачу на основе класса Timer
            Console.WriteLine();
            TimerCallback timerCallback = new TimerCallback(CurrentTime);
            Timer timer = new Timer(timerCallback, null, 0, 1000);
            Thread.Sleep(5000);
            void CurrentTime(object obj)
            {
                Console.WriteLine(DateTime.Now);
            }
        
    }
        private static void ShowThreadInfo(object thread) 
        {
            var currentThread = thread as Thread;
            Console.WriteLine($"Name: {currentThread.Name}");
            Console.WriteLine($"Id: {currentThread.ManagedThreadId}");
            Console.WriteLine($"Priority: {currentThread.Priority}");
            Console.WriteLine($"Status: {currentThread.ThreadState}");
        }
        private static void ShowSimpleNumbers()
        {
            Console.WriteLine("-------------");
            var first = new Thread(ShowThreadInfo);
            first.Start(Thread.CurrentThread);
            first.Join();

            Console.WriteLine("Enter n");
            int n = int.Parse(Console.ReadLine());
            for (var i = 1; i <= n; i++)
            {
                bool isSimple = true;
                for (var j = 2; j <= i / 2; j++)
                    if (i % j == 0)
                    {
                        isSimple = false;
                        break;
                    }

                if (isSimple)
                {
                    Console.WriteLine($"{i} ");
                    Thread.Sleep(200);
                }
            }
        }
        private static void ShowOneByOne()
        {
            var mutex = new Mutex();
            var even = new Thread(ShowEvenNumbers);
            var odd = new Thread(ShowOddNumbers);
            odd.Start();
            even.Start();
            even.Join();
            odd.Join();

            void ShowEvenNumbers()
            {
                for (var i = 0; i < 20; i++)
                {
                    mutex.WaitOne();
                    if (i % 2 == 0)
                        Console.Write(i + " ");
                    mutex.ReleaseMutex();
                }
            }

            void ShowOddNumbers()
            {
                for (var i = 0; i < 20; i++)
                {
                    mutex.WaitOne();
                    Thread.Sleep(200);
                    if (i % 2 != 0)
                        Console.Write(i + " ");
                    mutex.ReleaseMutex();
                }
            }
        }
        private static void FirstlyEvenSecondlyOdd()
        {
            var objectToLock = new object();
            var even = new Thread(ShowEvenNumbers);
            var odd = new Thread(ShowOddNumbers);
            even.Start();
            odd.Start();
            even.Join();
            odd.Join();

            void ShowEvenNumbers()
            {
                lock (objectToLock)
                {
                    for (var i = 0; i < 20; i++)
                    {
                        if (i % 2 == 0)
                            Console.Write(i + " ");
                    }
                }
            }

            void ShowOddNumbers()
            {
                for (var i = 0; i < 20; i++)
                {
                    Thread.Sleep(200);
                    if (i % 2 != 0)
                        Console.Write(i + " ");
                }
            }
        }
        private static void ShowEvenNumbers()
        {
            for (var i = 0; i < 20; i++)
            {
                Thread.Sleep(100);
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }
        }
        private static void ShowOddNumbers()
        {
            for (var i = 0; i < 20; i++)
            {
                Thread.Sleep(200);
                if (i % 2 != 0)
                    Console.Write(i + " ");
            }
        }

    }
}
