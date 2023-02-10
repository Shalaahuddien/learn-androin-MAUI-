namespace cflk.View.Kotak;

public partial class KotakPage : ContentPage
{
    public KotakPage()
    {
        InitializeComponent();
        arrowRight.Text = $">";
        arrowLeft.Text = $"<";
        Jump.Text = $"Jump";
        Kotak.Text = "Test";
        Kotak.HeightRequest = 30;
        Kotak.WidthRequest = 100;
    }

    private void handleJump(object sender, EventArgs e)
    {
        AbsoluteLayout.SetLayoutBounds(Kotak, new Rect(0.5, 0.3, 110, 25));
    }
    // private void handleJump(object sender, EventArgs e)
    // {
    //     AbsoluteLayout.SetLayoutBounds(Kotak, new Rect(0.5, 0.3, 110, 25));
    // }
}