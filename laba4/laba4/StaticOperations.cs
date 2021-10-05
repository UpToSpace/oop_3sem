namespace laba4
{
    static class StaticOperations
    {
        public static int Count(List list)
        {
            int count = 0;
            Node curr = list.Head;
            while(curr != null)
            {
                count++;
                curr = curr.Next;
            }
            return count;
        }
        public static string ListString(List list)
        {
            string str = "";
            Node curr = list.Head;
            while(curr != null)
            {
                str = str + curr.Info + ", ";
                curr = curr.Next;
            }
            return str;
        }
        public static string LongestInfo(List list)
        {
            Node curr = list.Head;
            string str = curr.Info;
            while (curr != null)
            {
                if (curr.Info.Length > str.Length)
                {
                    str = curr.Info;
                }
                curr = curr.Next;
            }
            return str;
        }
        public static string FormatText(this string str)
        {
            return char.ToUpper(str[0]) + str.Substring(1).ToLower();
        }
    }
}
