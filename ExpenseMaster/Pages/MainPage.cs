using CommunityToolkit.Maui.Markup;
using ExpenseMaster.Models;
using Microsoft.Maui.Controls;

namespace ExpenseMaster.Pages
{
    public partial class MainPage : ContentPage
    {
        public class MainPageFrame : ViewCell
        {
            public MainPageFrame()
            {
                View = new Frame
                {
                    BorderColor = Colors.Gray,
                    CornerRadius = 10,
                    Content = new StackLayout
                    {
                        Children =
                        {
                            new Label()
                            .Bind(Label.TextProperty, nameof(TotalInfo.TotalSpent), stringFormat : "Total money spent: {0}")
                            .Bold(),
                            new Label()
                            .Bind(Label.TextProperty, nameof(TotalInfo.SavedMoney), stringFormat : "Total saved money: {0}")
                            .Bold()
                        }
                    }
                };
            }
        }

        public MainPage()
        {
            var listView = new ListView(ListViewCachingStrategy.RecycleElement);
            listView.HasUnevenRows = true;
            listView.SelectionMode = ListViewSelectionMode.None;
            listView.ItemsSource = new[]
            {
                new TotalInfo
                {
                    SavedMoney = 100,
                    TotalSpent = 120
                }
            };

            

            listView.ItemTemplate = new DataTemplate(typeof(MainPageFrame));
            

            Content = listView;
        }
            
    }
}
