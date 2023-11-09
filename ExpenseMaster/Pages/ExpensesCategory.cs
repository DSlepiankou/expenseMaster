using CommunityToolkit.Maui.Markup;
using static CommunityToolkit.Maui.Markup.GridRowsColumns;

namespace ExpenseMaster.Pages
{
    public partial class ExpensesCategory : ContentPage
    {
        Grid newOptionsGrid;

        Label label = new Label
        {
            Text = "Choose option",
        };

        Entry textEntry = new Entry
        {
            Placeholder = "input your option",
        }
        .Bold()
        .Height(33)
        .BackgroundColor(Colors.Transparent)
        .TextColor(Colors.Black);

        Picker picker = new Picker { Title = "Option" };

        Button addNewOptionButton = new Button
        {
            Text = "Add new option",
            FontSize = 22,
            BorderColor = Colors.Black,
            Margin = 10,
        };

        Button newOptionsApplied = new Button
        {
            Text = "Save",
            FontSize = 22,
            BorderColor = Colors.Black,
            Margin = 10,
        }
        .Padding(20, 0)
        .Height(33);

        public ExpensesCategory()
        {
            picker.Items.Add("1");
            picker.Items.Add("2");
            picker.Items.Add("3");

            picker.SelectedIndexChanged += PickerSelectedIndexChanged;

            newOptionsGrid = new Grid
            {
                //ColumnDefinitions = Columns.Define(Auto, Star, Auto),
                RowDefinitions = Rows.Define(Auto, Auto, Auto),
                ColumnSpacing = 10,
                RowSpacing = 4,
                IsVisible = false,
                Children =
                {
                    textEntry
                    .Row(0)
                    .Height(50),
                    newOptionsApplied
                    .Row(1),
                }
            };

            addNewOptionButton.Clicked += ButtonForAddNewOption;
            newOptionsApplied.Clicked += NewOptionsApplied_Clicked;
            Content = new StackLayout
            {
                Children = { label, picker, addNewOptionButton, newOptionsGrid },
                Padding = 15,
                Spacing = 10,
            };
        }

        private void NewOptionsApplied_Clicked(object sender, EventArgs e)
        {
            addNewOptionButton.IsVisible = !addNewOptionButton.IsVisible;
            newOptionsGrid.IsVisible = !newOptionsGrid.IsVisible;
            picker.Items.Add(textEntry.Text);
            textEntry.Text = null;
        }

        private void ButtonForAddNewOption(object sender, EventArgs e)
        {
            addNewOptionButton.IsVisible = !addNewOptionButton.IsVisible;
            newOptionsGrid.IsVisible = !newOptionsGrid.IsVisible;
        }

        void PickerSelectedIndexChanged(object sender, EventArgs e)
        {
            label.Text = $"Choosen: {picker.SelectedItem}";
        }
    }
}
