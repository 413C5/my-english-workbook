using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyEnglishWorkbook.DataModel;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

//Autor: Alejandro González Zárate
namespace MyEnglishWorkbook.Pages.Verbs
{
    /*Descripción: Esta clase permite comparar la  respuesta colocada en el entry
     y de esa forma evaluar un score*/
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExerciseVerbs3 : ContentPage
    {
        ObservableCollection<PregOpMu> grupoV;
        int score;
        public ExerciseVerbs3()
        {
            InitializeComponent();
            score = 0;

            grupoV = new ObservableCollection<PregOpMu>
            {
                new PregOpMu{ Enunciado="1.-bleed", Enunciado2="contestar", Respuesta="5", ResSel="", Numero="0"},
                new PregOpMu{ Enunciado="2.-argue",Enunciado2="aparecer", Respuesta="3", ResSel="", Numero="1"},
                new PregOpMu{ Enunciado="3.-appear",Enunciado2="sangrar", Respuesta="1", ResSel="", Numero="2"},
                new PregOpMu{ Enunciado="4.-bind",Enunciado2="discutir", Respuesta="2", ResSel="", Numero="3"},
                new PregOpMu{ Enunciado="5.-answer",Enunciado2="amarrar", Respuesta="4", ResSel="", Numero="4"}
            };
            lsvQuestionsV.ItemsSource = grupoV;

        }
        //El siguiente código compara que ambas respuestas de la pregunta sean correctas
        //acorde a la respuesta en la propiedad
        private void Checker_Clicked(object sender, EventArgs e)
        {
            score = 0;
            foreach (PregOpMu n in grupoV)
            {
                //No es necesario hacer conversion a double, con equals se logra el mismo efecto al no hacerse algun calculo numerico
                if (String.Equals(n.ResSel, n.Respuesta))
                {
                    score += 1;
                }
            }
            lblResultado.Text = $"Score {score}/{grupoV.Count}";
        }
    }
}