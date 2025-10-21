namespace otacoss3.Vistas;

public partial class Vista3 : ContentPage
{
	public Vista3()
	{
		InitializeComponent();
	}

    private void btnSalir_Clicked(object sender, EventArgs e)
    {
		try
		{
			string usuario = txtUsuario.Text;
			string contrasena = txtContrasena.Text;
			Navigation.PushAsync(new Vista1(usuario, contrasena));
		}
		catch (Exception ex) 
		{
			Console.WriteLine(ex.ToString());
		}
    }

    
}