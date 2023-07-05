using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CVSlow
{
    public class ListVM : BaseVM
    {
        public ICommand AddMoreCmd { get; private set; }

        private ObservableCollection<Item> _items;
        public ObservableCollection<Item> Items
        {
            get => _items;
            set
            {
                if (SetProperty(ref _items, value))
                {
                    OnPropertyChanged(nameof(ItemCount));
                }
            }
        }

        public string ItemCount => $"{Items?.Count() ?? 0}";

        public ListVM()
        {
            AddMoreCmd = new Command(async () => await AddMore());
        }

        public override async Task OnAppearing()
        {
            var items = new List<Item>();
            for (var i = 0; i < 250; i++)
            {
                items.Add(new Item());
            }
            Items = new ObservableCollection<Item>(items);
            OnPropertyChanged(nameof(Items));
            OnPropertyChanged(nameof(ItemCount));
        }

        private async Task AddMore()
        {
            await Task.Delay(500);

            for(var i = 0; i < 1000; i++)
            {
                Items.Add(new Item());
            }
            OnPropertyChanged(nameof(Items));
            OnPropertyChanged(nameof(ItemCount));
        }
    }
}
