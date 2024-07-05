class MergeSequences
{
    static void Main()
    {
        
        string[] input1 = Console.ReadLine().Split(' ');
        List<int> sequence1 = new List<int>();

        foreach (string num in input1)
        {
            sequence1.Add(int.Parse(num));
        }

        
        string[] input2 = Console.ReadLine().Split(' ');
        List<int> sequence2 = new List<int>();

        foreach (string num in input2)
        {
            sequence2.Add(int.Parse(num));
        }

        List<int> resultList = new List<int>();

        int maxLength = Math.Max(sequence1.Count, sequence2.Count);

        for (int i = 0; i < maxLength; i++)
        {
            if (i < sequence1.Count)
            {
                resultList.Add(sequence1[i]);
            }

            if (i < sequence2.Count)
            {
                resultList.Add(sequence2[i]);
            }
        }

        
        foreach (int num in resultList)
        {
            Console.Write(num + " ");
        }
    }
}