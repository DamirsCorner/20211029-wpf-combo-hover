using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Collections.Generic;
using System.Linq;

namespace WpfComboHover
{
    public class MainViewModel : ObservableObject
    {
        private Item? selectedItem;
        private Item? highlightedItem;

        public MainViewModel()
        {
            Items = Enumerable.Range(1, 5)
                .Select(index => new Item($"{index}", $"Item {index}", $"Description {index}"))
                .ToList();
        }

        public IList<Item> Items { get; set; }

        public Item? SelectedItem
        {
            get => selectedItem;
            set
            {
                SetProperty(ref selectedItem, value);
                HighlightedItem = SelectedItem;
            }
        }

        public Item? HighlightedItem
        {
            get => highlightedItem;
            set => SetProperty(ref highlightedItem, value);
        }
    }
}
