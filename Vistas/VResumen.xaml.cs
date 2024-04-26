namespace aharoExamen.Vistas;


public partial class VResumen : ContentPage
{
    public VResumen(string Usuario, string nombre, string apellido, int edad, string fecha, string ciudad, string pais, double minicial, double pagomensual, double pagototal)
    {

        InitializeComponent();
        lblUsuario.Text =  Usuario;

        // Usar los datos recibidos para inicializar los componentes
        lbNombre.Text = nombre;
        lbApellido.Text = apellido;
        lbEdad.Text = edad.ToString();
        lbFecha.Text = fecha;
        lbCiudad.Text = ciudad.ToString();
        lbPais.Text = pais;
        lbMontoInicial.Text = minicial.ToString();
        lbPagoMensual.Text = pagomensual.ToString();
        lbPagoTotal.Text = pagototal.ToString();    

    }

 

    private void btnCerrar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new VLogin());
    }
}