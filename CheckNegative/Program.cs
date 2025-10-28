namespace CheckNegative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> numbers = new List<int>() { 1, 2, 3, -4, 5, -6, 7, -8, 9, -10 };
            bool containsNegative = ContainsNegative2(numbers);
            Console.WriteLine(containsNegative);
        }
        public static bool ContainsNegative(IEnumerable<int> enumerator)
        {
            foreach (var i in enumerator)
            {
                if (i < 0)
                {
                    return true;
                }
            }
            return false;
        }
        // 同样的功能，使用Linq的Any方法
        public static bool ContainsNegative2(IEnumerable<int> enumerator)
        {
            return enumerator.Any(e => e < 0);//使用Any方法判断是否存在负数
        }
    }
}
