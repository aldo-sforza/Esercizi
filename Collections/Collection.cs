namespace Collections
{
    public class Collection
    {
        public static IEnumerable<int> GetEvenNumbers(IEnumerable<int> numbersList)
        {
            var evenNumbers = new List<int>();
            foreach (int number in numbersList)
            {
                if (number % 2 == 0 & number > 0)
                {
                    evenNumbers.Add(number);
                }
            }

            return evenNumbers;
        }

        public static IEnumerable<int> GetEvenNumbersLinq(IEnumerable<int> numbersList)
            => numbersList.Where(i => i % 2 == 0);

        public static int GetMax(IEnumerable<int> numberList)
        {
            int max = int.MinValue;
            foreach (int number in numberList)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            return max;
        }

        public static IEnumerable<int> GetOddIndexNumbers(List<int> numberList)
        {
            var oddIndexNumber = new List<int>();
            for (int i = 1; i < numberList.Count; i++)
            {
                oddIndexNumber.Add(numberList[i]);
                i++;
            }
            return oddIndexNumber;
        }

        public static IEnumerable<int> GetInvertedList(List<int> numberList)
        {
            var invertedList = new List<int>();
            for (int i = numberList.Count; i > 0; i--)
            {
                invertedList.Add(numberList[i - 1]);
            }

            return invertedList;
        }
    }
}