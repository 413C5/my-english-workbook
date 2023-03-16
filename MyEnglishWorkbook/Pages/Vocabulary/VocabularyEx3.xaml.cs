using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MyEnglishWorkbook.DataModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyEnglishWorkbook.Pages.Vocabulary
{
    /*Autor: Matias Julian Perez May
    Descripción: Esta clase solo cuenta la cantidad de respuestas seleccionadas correctas y las muestra en pantalla*/
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VocabularyEx3 : ContentPage
    {
        ObservableCollection<PregOpMu> grupo;
        int aciertos;
        public VocabularyEx3()
        {
            aciertos = 0;
            InitializeComponent();

            grupo = new ObservableCollection<PregOpMu>
            {
                new PregOpMu{ Enunciado="1.-I had to change the seets of my bedroom for washing them", Respuesta="Sheets", ResSel=""},
                new PregOpMu{ Enunciado="2.-Don't forget to fasten your setbelt before starting up the car", Respuesta="Seatbelt", ResSel=""},
                new PregOpMu{ Enunciado="3.-The inverviewer asked me about my habits and hobis", Respuesta="Hobbies", ResSel=""},
                new PregOpMu{ Enunciado="4.-I always sweep the flor on Saturdays", Respuesta="Floor", ResSel=""},
                new PregOpMu{ Enunciado="5.-Could you ak the dog tomorrow in the morning", Respuesta="Walk", ResSel=""}
            };
            lsvQuestions.ItemsSource = grupo;

        }
        //El siguiente código checa cada elemento en la colección y compara la propiedad de la respuesta elegida en la pregunta con la
        //propiedad de la respuesta correcta
        private void Checker_Clicked(object sender, EventArgs e)
        {
            aciertos = 0;
            foreach (PregOpMu n in grupo)
            {
                if ((n.ResSel).ToLower() == (n.Respuesta).ToLower())
                {
                    aciertos += 1;
                }
            }
            lblResultado.Text = $"Score {aciertos}/{grupo.Count}";
        }
    }
}