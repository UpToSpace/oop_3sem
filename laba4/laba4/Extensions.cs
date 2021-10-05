/*
Методы расширения:
1) Подсчет количества слов с заглавной буквы
2) Проверка на повторяющиеся элементы в списке  */

namespace laba4
{
    static class Extensions
    {
        public static int CountFirstCapitalLetters(this List list)
        {
            Node curr = list.Head;
            int count = 0;
            while(curr != null)
            {
                if (char.IsUpper(curr.Info[0]))
                {
                    count++;
                }
                curr = curr.Next;
            }
            return count;
        }
        public static bool CheckRepeatings(this List list)
        {
            Node curr = list.Head;
            while(curr != null)
            {
                Node node = curr.Next;
                while (node != null)
                {
                    if (node.Info == curr.Info)
                    {
                        return true;
                    }
                    else
                    {
                        node = node.Next;
                    }
                }
                curr = curr.Next;
            }
            return false;
        }
    }
}
