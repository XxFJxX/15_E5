namespace _15_E5;

public partial class Superficie : ContentPage
{
	public Superficie()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        int B = Convert.ToInt32(Ba.Text);
        int A = Convert.ToInt32(Al.Text);

        int r = (B * A) / 2;


        la.Text = "La superficie del triangulo es " + r;
    }
}