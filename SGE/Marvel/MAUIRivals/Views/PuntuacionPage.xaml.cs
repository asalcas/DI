using System.Collections.ObjectModel;
using System.Collections.Specialized;
using DTO;
using MAUIRivals.VM;

namespace MAUIRivals.Views;

public partial class PuntuacionPage : ContentPage
{
    ListadoHeroesVillanosConPuntosVM miVM;


    public PuntuacionPage()
	{
		InitializeComponent();

        miVM = BindingContext as ListadoHeroesVillanosConPuntosVM;

    }

    /// <summary>
    /// Evento programado para que cuando la Vista Aparezca en pantalla recargue la lista que tenemos en MEMORIA
    /// </summary>
    protected override async void OnAppearing()
	{
		base.OnAppearing();


		if (miVM != null)
		{
			await miVM.actualizacionLista();

        }

	}
	
}