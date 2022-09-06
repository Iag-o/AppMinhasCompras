using AppMinhasCompras.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMinhasCompras.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Listagem : ContentPage
    {
        public Listagem()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked_Novo(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new NovoProduto());
            } catch(Exception ex)
            {
                DisplayAlert("Erro", ex.Message, "ok");
            }
            
        }

        private void ToolbarItem_Clicked_Somar(object sender, EventArgs e)
        {

        }

        protected override void OnAppearing()
        {
            System.Threading.Tasks.Task.Run(async () =>
            {
                List<Produto> temp = await App.Database.GetAll();
            });
        }

    }
}