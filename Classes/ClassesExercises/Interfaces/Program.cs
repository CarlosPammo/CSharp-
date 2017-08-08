namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Two contexts following different strategies.
            SortedList studentRecords = new SortedList();

            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            // Sets AscendingSort Strategy.
            studentRecords.SetSortStrategy(new AscendingSort());
            studentRecords.Sort();

            // Sets AscendingSort Strategy.
            studentRecords.SetSortStrategy(new DescendingSort());
            studentRecords.Sort();
        }
    }
}
