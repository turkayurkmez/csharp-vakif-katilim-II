namespace ConsoleApp1
{
    public static class FilterHelper
    {
        //Değer dönürüyorsa -> Func
        //void ise -> Action
        // public delegate bool Criteria(int number);
        public static int[] Filter(int[] numbers, Func<int, bool> criteria)
        {
            List<int> result = new List<int>();
            foreach (var item in numbers)
            {
                if (criteria(item))
                {
                    result.Add(item);
                }
            }

            return result.ToArray();
        }
    }
}
