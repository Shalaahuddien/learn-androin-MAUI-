namespace cflk.View.Count;

public partial class CountPage : ContentPage
{
    int count = 0;
    public CountPage()
    {
        InitializeComponent();
        countLabel.Text = $"Hitungan anda {count}";
    }

    private void countPlus(object sender, EventArgs e)
    {
        count++;
        if (count >= 0) countLabel.Text = $"hitungan {count}";
    }

    async void countMinus(object sender, EventArgs e)
    {

        count--;
        if (count <= 0)
        {
            count = 0;
            countLabel.Text = $"Hitungan anda {count}";
            await DisplayAlert("msg", "hitungan mu kurang dari 0", "OK");
        }
        else countLabel.Text = $"hitungan {count}";
    }
}