using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyEnglishWorkbook.DataModel;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
//Autor: Marco Antonio García Hernández
namespace MyEnglishWorkbook.Pages.Reading
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReadingEx2 : ContentPage
    {
        ObservableCollection<PregOpMu> grupo;
        int aciertos;
        public ReadingEx2()
        {
            InitializeComponent();
            aciertos = 0; //numero de aciertos
            //se crea una collecion para los enunciados y las respuestas correctas
            grupo = new ObservableCollection<PregOpMu>
            {
                new PregOpMu{ Enunciado="Olive branches…",  Enunciado2="1.the UN emblem was appoved.", Respuesta="5", ResSel="", Numero="0"},  //5
                new PregOpMu{ Enunciado="The UN emblem design…", Enunciado2="2.is to achieve peace and security.", Respuesta="6", ResSel="", Numero="1"},//6
                new PregOpMu{ Enunciado="On 7 December 1946", Enunciado2="3.extends to 60 degrees.", Respuesta="1", ResSel="", Numero="2"},  //1
                new PregOpMu{ Enunciado="The purpose of the world map… ", Enunciado2="4.five concentric circles.", Respuesta="2", ResSel="", Numero="3"}, //2
                new PregOpMu{ Enunciado="The projection of the map", Enunciado2="5.means peace.", Respuesta="3", ResSel="", Numero="4"}, //3
                new PregOpMu{ Enunciado="It includes", Enunciado2="6.is a map.", Respuesta="4", ResSel="", Numero="5"}, //4
                new PregOpMu{ Enunciado="The map representing…", Enunciado2="7.in color White.", Respuesta="8", ResSel="", Numero="6"}, //8
                new PregOpMu{ Enunciado="Water areas in this emblem are…", Enunciado2="8.Projection of the North Pole.", Respuesta="7", ResSel="", Numero="7"}, //7
            };

            clvQuestions.ItemsSource = grupo;

        }
        private void Checker_Clicked(object sender, EventArgs e) //checa los datos que manda el boton al ser presionado
        {
            aciertos = 0;
            //permite calcular el numero de aciertos en la actividad
            foreach (PregOpMu n in grupo)
            {
                if (String.Equals(n.ResSel, n.Respuesta))
                {
                    aciertos += 1;
                }
            }
            lblResultado.Text = $"Score {aciertos}/{grupo.Count}"; //manda el numero de aciertos al label lblResultado
        }
    }
}