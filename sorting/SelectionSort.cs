        static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int imin = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[imin]) imin = j;
                }

                if (imin != array[i])
                {
                    int temp = array[i];
                    array[i] = array[imin];
                    array[imin] = temp;
                }
            }
        }

        static void Tryit()
        {
            int[] array = { 8, 2, 4, 9, 1, 10 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            SelectionSort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }