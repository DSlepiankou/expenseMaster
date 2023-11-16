using CommunityToolkit.Maui.Markup;
using ExpenseMaster.Models;
using ExpenseMaster.Repositories;
using static CommunityToolkit.Maui.Markup.GridRowsColumns;

namespace ExpenseMaster.Pages
{
    public partial class ExpensesCategory : ContentPage
    {
        IExpenseItemRepository _repository;
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

        ImageButton buttnImg = new ImageButton
        {
            Source = "gift.png",
            BorderColor = Colors.Red,
            WidthRequest = 100,
            HeightRequest = 100,
            Aspect = Aspect.AspectFill,
            IsEnabled = true,
            IsVisible = true
        };

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
                Children = { label, picker, addNewOptionButton, newOptionsGrid, buttnImg },
                Padding = 15,
                Spacing = 10,
            };
        }

        private async void NewOptionsApplied_Clicked(object sender, EventArgs e)
        {
            addNewOptionButton.IsVisible = !addNewOptionButton.IsVisible;
            newOptionsGrid.IsVisible = !newOptionsGrid.IsVisible;
            picker.Items.Add(textEntry.Text);
            textEntry.Text = null;

            var newExpense = new Expense
            {
                Currency = "Dollar",
                ExpenseCategory = "Shopping",
                ExpenseDay = DateTime.Today,
                ExpenseNote = "SomeNote",
                ExpensesName = "Food",
                ExpenseSum = 100.00
            };

            _repository = DependencyService.Get<IExpenseItemRepository>();

            await _repository.AddAsync(newExpense);
            var a = await _repository.GetAll();
            //string folderPath = Environment.GetFolderPath(FileSystem.AppDataDirectory);

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
