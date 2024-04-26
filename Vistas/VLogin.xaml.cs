namespace aharoExamen.Vistas;

public partial class VLogin : ContentPage
{
	public VLogin()
	{
		InitializeComponent();
	}



    private void btnContinuar_Clicked(object sender, EventArgs e)
    {
        Dictionary<string, string> usuario = new Dictionary<string, string>
    {
        {"estudiante2024", "uisrael2024"},
        {"examen1", "parcial1"},
        {"aharo", "2024"}
        // Agrega m�s usuarios y contrase�as seg�n sea necesario
    };

        string nombreUsuario = txtUsuario.Text;
        string contrase�a = txtContrase�a.Text;

        if (usuario.ContainsKey(nombreUsuario) && usuario[nombreUsuario] == contrase�a)
        {
            Navigation.PushAsync(new VRegistro(nombreUsuario));
        }
        else
        {
            DisplayAlert("Alerta", "Usuario o Contrase�a incorrecta", "Cerrar");
        }

    }

    private void btnAcercade_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new VAcercade());
    }
}