namespace L01
{
    internal class Item
    {
        public int v;
        public int w;

        public Item(int v, int w)
        {
            this.v = v;
            this.w = w;
        }
    }

    internal class Problem
    {
        public List<Item> items;

        public Problem(int seed, int numItems)
        {
            Random r = new Random(seed);
            this.items = new List<Item>(numItems);
            for (int i = 0; i < numItems; i++)
            {
                items.Add(new Item(r.Next(29) + 1, r.Next(29) + 1));
            }
        }

        public string solveFor(int maxWeight)
        {
            int value = 0;
            int weight = 0;

            items.Sort((p, q) => (p.v / p.w).CompareTo(q.v / q.w));

            int index = 0;
            string result = "";

            while(weight + items[index].w <= maxWeight)
            {
                value += items[index].v;
                weight += items[index].w;
                result += index + 1 + ": [ v: " + items[index].v + " | w: " + items[index].w + " ]\n";
                index++;
            }

            return result;
        }

        public override string ToString()
        {
            string result = "";

            items.ForEach(item =>
            {
                result += item.v + " | " + item.w + "\n";
            });

            return result;
        }
    }
}
