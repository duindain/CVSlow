using CVSlow.Helpers;
using System.Windows.Input;

namespace CVSlow
{
    public class Item : BaseVM
    {
        public ICommand ShowHideCmd { get; set; }

        public string Name { get; set; }
        public ImageSource ImageSource { get; set; }
        public string ImageName { get; set; }
        public List<ImageSource> Badges { get; set; } = new List<ImageSource>();
        public DateTime DateTime { get; set; }

        private bool _showHide;
        public bool ShowHide 
        { 
            get => _showHide; 
            set => SetProperty(ref _showHide, value); 
        }        

        public Item()
        {
            ShowHideCmd = new Command(() => ShowHide = !ShowHide);
            Name = Utilities.RandomWords();
            ImageName = Utilities.RandomImage();
            ImageSource = ImageSource.FromFile(ImageName);
            DateTime = Utilities.RandomDateTime();
            ShowHide = Utilities.RandomBool();

            var badgesToCreate = Constants.Random.Next(0, 4);
            for (var i = 0; i < badgesToCreate; i++)
            {
                var image = Utilities.RandomImage();
                if(image != ImageName)
                {
                    Badges.Add(ImageSource.FromFile(image));
                }                
            }
        }
    }
}
