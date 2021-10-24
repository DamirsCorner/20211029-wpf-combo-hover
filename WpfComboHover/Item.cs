namespace WpfComboHover
{
    public class Item
    {
        public Item(string id, string label, string description)
        {
            Id = id;
            Label = label;
            Description = description;
        }

        public string Id { get; private set; }
        public string Label { get; private set; }
        public string Description { get; private set; }
    }
}
