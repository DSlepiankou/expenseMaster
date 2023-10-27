namespace ExpenseMaster.Pages
{
    public partial class AnotherPage : ContentPage
    {
        Label label = new Label
        {
            Text = "Choose option",
        };

        Picker picker = new Picker { Title = "Option" };
        public AnotherPage()
        {
            picker.Items.Add("1");
            picker.Items.Add("2");
            picker.Items.Add("3");

            picker.SelectedIndexChanged += PickerSelectedIndexChanged;
            Content = new StackLayout
            {
                Children = { label, picker },
                Padding = 8
            };
        }

        void PickerSelectedIndexChanged(object sender, EventArgs e)
        {
            label.Text = $"Choosen: {picker.SelectedItem}";
        }
    }
}
