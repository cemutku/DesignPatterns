namespace BuilderPattern
{
    public class FurnitureItem
    {
        public FurnitureItem(string name, double price, double height, double width, double weight)
        {
            Name = name;
            Price = price;
            Height = height;
            Width = width;
            Weight = weight;
        }

        public string Name { get; internal set; }
        public double Price { get; internal set; }
        public double Height { get; internal set; }
        public double Width { get; internal set; }
        public double Weight { get; internal set; }
    }
}