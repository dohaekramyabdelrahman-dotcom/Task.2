namespace Task._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> chars = new List<int> { };
            string menu = "P:Print numbers\r\nA:Add a number\r\nM:Display mean of the numbers\r\nS:Display the smallest number\r\nL:Display the largest number\r\nC:Clear screen\r\ni:Search for a number \r\ng:Sort Ascending\r\no:Count Even / Odd \r\nQ:Quit\r\nEnter your choice:  ";
            int number;
            double sum = 0;
            double avg;
            int smallest;
            double largest;
            Console.WriteLine(menu);
            string character = Console.ReadLine();
            character = character.ToLower();
            do
            {

                switch (character)
                {
                    #region print
                    case "p":
                        if (chars.Count == 0)
                        {
                            Console.WriteLine("[] - the list is empty");
                        }
                        else
                        {
                            Console.Write("[ ");
                            for (int i = 0; i < chars.Count; i++)
                            {
                                Console.Write(chars[i] + " ");
                            }

                            Console.Write(" ]");
                        }
                        break;
                    #endregion
                    #region add number
                    case "a":
                        Console.WriteLine("Enter an integer to add to the list: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        bool exists = false;
                        for (int i = 0; i < chars.Count; i++)
                        {
                            if (chars[i] == number)
                            {
                                exists = true;
                                break;
                            }
                        }
                        if (exists)
                        {
                            Console.WriteLine($"{number} already exists in the list");
                        }
                        else
                        {
                            chars.Add(number);
                            Console.WriteLine($"{number} added");
                        }
                        break;
                    #endregion
                    #region mean
                    case "m":

                        if (chars.Count == 0)
                        {

                            Console.WriteLine("Unable to calculate the mean - no data");
                        }
                        else
                        {
                            sum = 0;
                            for (int i = 0; i < chars.Count; i++)
                            {
                                sum += chars[i];
                            }
                            avg = sum / chars.Count;
                            Console.WriteLine($"The mean is: {avg}");

                        }
                        break;
                    #endregion
                    #region smallest
                    case "s":
                        if (chars.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the smallest number - list is empty");
                        }
                        else
                        {
                            smallest = chars[0];
                            for (int i = 0; i < chars.Count; i++)
                            {

                                if (chars[i] < smallest)
                                {

                                    smallest = chars[i];

                                }
                            }
                            Console.Write("The smallest number is:" + smallest);

                        }

                        break;
                    #endregion
                    #region largest

                    case "l":
                        if (chars.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the largest number - list is empty");
                        }
                        else
                        {
                            largest = chars[0];
                            for (int i = 0; i < chars.Count; i++)
                            {
                                if (chars[i] > largest)
                                {
                                    largest = chars[i];
                                }
                            }
                            Console.WriteLine($"The largest number is: {largest}");


                        }
                        break;
                    #endregion
                    #region clear
                    case "c":
                        Console.Clear();
                        break;
                    #endregion
                    #region identical number

                    case "i":
                        int l = Convert.ToInt16(Console.ReadLine());

                        if (chars.Count == 0)
                        {
                            Console.WriteLine("Unable to determine identical numbers - list is empty");
                        }
                        else
                        {
                            bool found = false;

                            for (int i = 0; i < chars.Count; i++)
                            {
                                if (chars[i] == l)
                                {
                                    Console.WriteLine($"The number {l} is found at index {i}");
                                    found = true;
                                }
                            }

                            if (!found)
                            {
                                Console.WriteLine($"The number {l} does not exist");
                            }
                        }
                        break;
                    #endregion
                    #region sort ascending
                    case "g":
                        if (chars.Count == 0)
                        {
                            Console.WriteLine("Unable to sort Ascending - list is empty");
                        }
                        else
                        {
                            for (int i = 0; i < chars.Count; i++)
                            {
                                for (int j = i + 1; j < chars.Count; j++)
                                {

                                    if (chars[i] > chars[j])
                                    {
                                        int temp = chars[i];
                                        chars[i] = chars[j];
                                        chars[j] = temp;
                                    }
                                }
                            }

                            for (int i = 0; i < chars.Count; i++)
                            {
                                Console.WriteLine(chars[i]);
                            }
                        }
                        break;
                    #endregion
                    #region Count Even/Odd

                    case "o":
                        if (chars.Count == 0)
                        {
                            Console.WriteLine("Unable to count even/odd - list is empty");
                        }
                        else
                        {
                            int evenCount = 0;
                            int oddCount = 0;

                            for (int i = 0; i < chars.Count; i++)
                            {
                                if (chars[i] % 2 == 0)
                                {
                                    evenCount++;
                                }
                                else
                                {
                                    oddCount++;
                                }
                            }

                            Console.WriteLine($"Even numbers: {evenCount}");
                            Console.WriteLine($"Odd numbers: {oddCount}");
                        }
                        break;
                    #endregion

                    default:
                        Console.WriteLine("Unknown selection, please try again");
                        break;
                }
                Console.WriteLine(menu);
                character = Console.ReadLine();

            }
            while (character != "q");
                Console.WriteLine("Goodbye!");

            

        }
    }
}