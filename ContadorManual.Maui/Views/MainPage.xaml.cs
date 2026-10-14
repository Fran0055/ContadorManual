using ContadorManual.Maui.Models;

namespace ContadorManual.Maui.Views;

public partial class MainPage : ContentPage
{
    private Contador _contador;
	public MainPage()
	{
		InitializeComponent();
        _contador = new Contador();
        BindingContext = _contador;
	}

    private void OnContarButtonClicked(object sender, EventArgs e)
    {
        _contador.contar();

    }

    private void OnReiniciarButtonClicked(object sender, EventArgs e)
    {
        _contador.Reiniciar();

    }
}