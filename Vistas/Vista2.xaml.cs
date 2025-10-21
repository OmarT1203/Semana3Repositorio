namespace otacoss3.Vistas;

public partial class Vista2 : ContentPage
{
	public Vista2(string dato1, string dato2)
	{
		InitializeComponent();
		lbldato1.Text = "El Dato 1 es: " + dato1;
		lbldato2.Text = "El Dato 2 es: " + dato2;
	}
}