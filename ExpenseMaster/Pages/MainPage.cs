using CommunityToolkit.Maui.Markup;
using ExpenseMaster.Models;

namespace ExpenseMaster.Pages
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            Frame frame = new Frame
            {
                BorderColor = Colors.Gray,
                CornerRadius = 10,
                Content = new Label { Text="123"}
            };
        }
    }
}
