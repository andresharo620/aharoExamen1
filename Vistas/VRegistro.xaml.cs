namespace aharoExamen.Vistas;

public partial class VRegistro : ContentPage
{
	public VRegistro(string nombreUsuario)
	{
		InitializeComponent();
        lblUsuario.Text = "Usuario Conectado: "+ nombreUsuario;
        
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
       
        double ncuotas = 4;
        double mtotal = 1500;
        double interes = (mtotal * 0.04);
        double minicial = Convert.ToDouble(txtmontoInicial.Text);

        double deuda = (mtotal-minicial);
        double cuota = (deuda + interes);
        double total = (cuota / ncuotas);
              

        txtpagomensual.Text = total.ToString("0.00");

    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        string Usuario = lblUsuario.Text;
        
        
        string nombre = txtNombre.Text;
        string apellido = txtApellido.Text;
        int edad = Convert.ToInt32(txtEdad.Text);
        string fecha = dpFecha.Date.ToString("MM/dd/yyyy");
        var ciudad = (string)pkCiudad.SelectedItem;
        var pais = (string)pkPais.SelectedItem;
        double minicial = Convert.ToDouble(txtmontoInicial.Text);
        double pagomensual = Convert.ToDouble(txtpagomensual.Text);

        double pagototal = (pagomensual * 4) + minicial;



        Navigation.PushAsync(new VResumen(Usuario, nombre, apellido, edad, fecha,ciudad, pais, minicial, pagomensual, pagototal));
    }

    private void txtmontoInicial_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (!int.TryParse(txtmontoInicial.Text, out int monto))
        {
            txtmontoInicial.Text = "";
            return;
        }

        if (monto < 1 || monto > 1500)
        {
            monto = Math.Min(Math.Max(monto, 1), 1500);

            txtmontoInicial.Text = monto.ToString();
        }
    }
}