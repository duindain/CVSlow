namespace CVSlow
{
    public partial class ListPage : ContentPage
    {
        private ListVM VM => BindingContext as ListVM;

        public ListPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await VM?.OnAppearing();
        }

        protected override async void OnDisappearing()
        {
            base.OnDisappearing();
            await VM?.OnDisappearing();
        }
    }
}