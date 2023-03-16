using MyEnglishWorkbook.DataModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyEnglishWorkbook.Pages.Vocabulary
{
    /*Autor: Matias Julian Perez May
    Descripción: Esta clase solo cuenta la cantidad de respuestas seleccionadas correctas y las muestra en pantalla*/
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VocabularyEx2 : ContentPage
    {
        ObservableCollection<PregOpMu> grupo;
        int aciertos;
        public VocabularyEx2()
        {
            aciertos = 0;
            InitializeComponent();

            grupo = new ObservableCollection<PregOpMu>
            {
                new PregOpMu{ Enunciado="1.-To arrange the sheets of your bed", Respuesta="Change the sheets", ResSel=""},
                new PregOpMu{ Enunciado="2.-To prepare food to be eaten in a particular place not at home", Respuesta="Make lunch", ResSel=""},
                new PregOpMu{ Enunciado="3.-To cut plants such as grass or wheat", Respuesta="Mow the lawn", ResSel=""},
                new PregOpMu{ Enunciado="4.-To keep your room clean and in order", Respuesta="Tidy your room", ResSel=""},
                new PregOpMu{ Enunciado="5.-To clean your teeth with water and toothpaste", Respuesta="Brush your teeth", ResSel=""}
            };
            lsvQuestions.ItemsSource = grupo;

        }
        //El siguiente código checa cada elemento en la colección y compara la propiedad de la respuesta elegida en la pregunta con la
        //propiedad de la respuesta correcta
        private void Checker_Clicked(object sender, EventArgs e)
        {
            aciertos = 0;
            foreach(PregOpMu n in grupo)
            {
                if((n.ResSel).ToLower() == (n.Respuesta).ToLower())
                {
                    aciertos += 1;
                }
            }
            lblResultado.Text = $"Score {aciertos}/{grupo.Count}";
        }
    }
}