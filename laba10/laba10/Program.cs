using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace laba10
{
    class Program
    {
        static void Main(string[] args)
        {
            Game chess = new Game("Chess");
            Game spider = new Game("Spider");
            Game solitaire = new Game("Solitaire");
            Game klondike = new Game("Klondike");
            Collection<Game> game = new Collection<Game>() { chess, spider, solitaire, klondike };
            game.ShowCollection();
            game.Delete(chess);
            game.ShowCollection();
            game.Search(spider);

            BlockingCollection<int> bc = new BlockingCollection<int>(boundedCapacity: 5);
            bc.Add(10);
            bc.Add(20);
            bc.Add(30);
            bc.Add(40);
            bc.Add(50);
            if (bc.TryAdd(6, TimeSpan.FromSeconds(2)))
            {
                Console.WriteLine("Item added");
            }
            else
            {
                Console.WriteLine("Item not added");
            }
            foreach (var item in bc)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Enter a number of elemrnts to delete");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                bc.Take(); // delete from beginning
            }
            foreach (var item in bc)
            {
                Console.WriteLine(item);
            }

            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var item in bc)
            {
                dict.Add(item, item);
            }
            Console.WriteLine("Enter a number to find");
            number = Convert.ToInt32(Console.ReadLine());
            foreach (var item in dict)
            {
                if (item.Value == number)
                {
                    Console.WriteLine($"An element {number} was found");
                }
            }

            ObservableCollection<Game> obsGame = new ObservableCollection<Game>() { chess, spider, solitaire, klondike };
            obsGame.CollectionChanged += ObsGameChanged;
            Game newGame = new Game("just a game");
            obsGame.Add(newGame);
            obsGame.Remove(spider);
        }
        private static void ObsGameChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch(e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    {
                        Game game = e.NewItems[0] as Game;
                        Console.WriteLine($"An element {game.Name} was added");
                        break;
                    };
                case NotifyCollectionChangedAction.Remove:
                    {
                        Game game = e.OldItems[0] as Game;
                        Console.WriteLine($"An element {game.Name} was deleted");
                        break;
                    }
            }
        }
    }
}
