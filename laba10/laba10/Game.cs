using System;

namespace laba10
{
    class Game
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("Name is empty");
                }
                name = value;
            }
        }
        public Game(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
