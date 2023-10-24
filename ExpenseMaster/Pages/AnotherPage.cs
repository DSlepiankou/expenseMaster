using CommunityToolkit.Maui.Markup;
using ExpenseMaster.Models;

namespace ExpenseMaster.Pages
{
    public class AnotherPage : ContentPage
    {
        public AnotherPage()
        {
            ToolbarItems.Add(new ToolbarItem
            {
                IconImageSource = "add.png",
                Text = "Elfkbnm"
            });

            Content = new StackLayout{
               new Label()
               .Bind(Label.TextProperty, nameof(TotalInfo.TotalSpent))
               .Bold()
               .Bottom()
               .Column(1)
               .Row(0),
                new Label()
               .Bind(Label.TextProperty, nameof(TotalInfo.SavedMoney))
               .Bold()
               .Bottom()
               .Column(1)
               .Row(1)
            }.Padding(10, 10);
        }
    }
}
