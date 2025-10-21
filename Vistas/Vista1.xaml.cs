namespace otacoss3.Vistas;

public partial class Vista1 : ContentPage
{
    //VARIABLES GLOBALES
    string usuarioglobal = "uisrael";
    string contrasenaglobal = "1234";
    public Vista1()
	{
		InitializeComponent();
	}
    public Vista1(string usuarioacceso, string contrasenaacceso)
    {
        InitializeComponent();
        usuarioglobal= usuarioacceso;
        contrasenaglobal= contrasenaacceso;
    }
    
    private void btnAbrir_Clicked(object sender, EventArgs e)
    {
       try
        {
            //Datos de acceso
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;
            if (usuario == usuarioglobal &&contrasena == contrasenaglobal)
            {
                Navigation.PushAsync(new Vista2(usuario, contrasena));
            }
            else 
            {
                DisplayAlert("Error", "Uusuario o Contraseña incorrectos", "ok");
            }
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.Message);
        }
    }
    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Vista3());
    }
}