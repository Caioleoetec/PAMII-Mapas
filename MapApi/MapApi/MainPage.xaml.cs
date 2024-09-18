using Microsoft.Maui.Maps;

namespace MapApi
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            var location = new Location(-23.545047817230532, -46.474154103611134); //<- Neo Química Arena
            var mapSpan = new MapSpan(location, 0.01, 0.01);
            map.MoveToRegion(mapSpan);
        }

    }

}
