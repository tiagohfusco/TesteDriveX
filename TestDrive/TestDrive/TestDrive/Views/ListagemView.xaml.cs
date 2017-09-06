using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace TestDrive.Views
{
    public class Veiculo
    {
        public string nome { get; set; }
        public decimal preco { get; set; }
        public string PrecoFormatado
        {
            get
            {
                return string.Format("R$ {0}", preco);
            }
        }

        public FormattedString VeiculoLabel
        {
            get
            {
                return new FormattedString
                {
                    Spans =
                    {
                        new Span {Text = nome },
                        new Span {Text = " - " },
                        new Span {Text = PrecoFormatado, FontAttributes.Bold } }
                };
            }
            set { }
        }
    }


        public partial class ListagemView : ContentPage
        {
            public List<Veiculo> Veiculos { get; set; }
        }
            public ListagemView()
            {
               InitializeComponent();

               this.Veiculos = new List<Veiculo>()
               {
                   new Veiculo {nome= "Azera v6", preco = 85000 },
               }


            }
   

    
}


