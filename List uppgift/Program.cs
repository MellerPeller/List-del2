namespace List_uppgift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] intersectionSet1 = { "a", "b", "c", "d", "e", "l" };
            string[] intersectionSet2 = { "h", "d", "w", "s", "a", "i" };
            Console.WriteLine("Demonstration av Intersection:");
            Console.WriteLine("Set 1: " + string.Join(",", intersectionSet1));
            Console.WriteLine("Set 2: " + string.Join(",", intersectionSet2));
            List<string> intersectionResult = Intersection(intersectionSet1, intersectionSet2);
            Console.WriteLine("Resultat: " + string.Join(",", intersectionResult));
            Console.WriteLine();


            string[] uniqueTestData = { "a", "b", "c", "d", "a", "a", "c" };
            Console.WriteLine("Demonstration av Unique:");
            Console.WriteLine("Testdata: " + string.Join(",", uniqueTestData));
            List<string> uniqueResult = Unique(uniqueTestData);
            Console.WriteLine("Resultat: " + string.Join(",", uniqueResult));
            Console.WriteLine();

        }


        public static List<string> Intersection(string[] set1, string[] set2)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < set1.Length; i++) 
            {
                for (int j = 0; j < set2.Length; j++)
                {
                    if (set1[i] == set2[j])
                    {
                        result.Add(set1[i]);
                    }                
                }
            }

            return result;
        }


        public static List<string> Unique(string[] strings)
        {
            List<string> result = new List<string>();
           
            for (int i = 0; i < strings.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < strings.Length; j++)
                {
                    if (strings[i] == strings[j])
                    {
                        count++;
                    }
                }
              
                if (count == 1)
                {
                    result.Add(strings[i]);
                }
            }
            return result;
        }
    }
}
