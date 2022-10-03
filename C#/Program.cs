        public static List<T> Singleton<T>(T element)
        {
            return new List<T> { element };
        }

        public static bool Null<T>(List<T> elements)
            {
            int k = 0;
            foreach (T element in elements)
            {
                k++;
            }
            return k == 0 ? true : false;
            }

        public static void Snoc<T>(List<T> elements, T element) => elements.Add(element);

        public static int Length<T>(List<T> elements)
        {
            int k = 0;
            foreach (var item in elements)
            {
                k++;
            }
            return k;
        }
 
