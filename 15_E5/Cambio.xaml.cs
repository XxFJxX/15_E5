namespace _15_E5;

public partial class Cambio : ContentPage
{
	public Cambio()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        int P = Convert.ToInt32(Pr.Text);
        int C = Convert.ToInt32(Ca.Text);

        int ca = P - C;

        Cam.Text = "Su cambio es de :  $" + ca;
    }
}