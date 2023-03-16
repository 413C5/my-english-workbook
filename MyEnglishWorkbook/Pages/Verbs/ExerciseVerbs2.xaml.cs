using MyEnglishWorkbook.DataModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

//Autor:Alejandro González Zárate
namespace MyEnglishWorkbook.Pages.Verbs
{
    /*Descripción: Esta clase permite compara las 2 respuestas colocadas en los entries
     y de esa forma evaluar un score*/
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExerciseVerbs2 : ContentPage
    {
        ObservableCollection<PregOpMu> grupoV;
        int score;
        public ExerciseVerbs2()
        {
            score = 0;
            InitializeComponent();

            grupoV = new ObservableCollection<PregOpMu>
            {
                new PregOpMu{ Enunciado="1.-tegbe", Respuesta="beget",Respuesta2="engendrar", ResSel="",ResSel2=""},
                new PregOpMu{ Enunciado="2.-regae", Respuesta="agree",Respuesta2="estar de acuerdo", ResSel="",ResSel2=""},
                new PregOpMu{ Enunciado="3.-nigeb", Respuesta="begin",Respuesta2="empezar", ResSel="",ResSel2=""},
                new PregOpMu{ Enunciado="4.-wolla", Respuesta="allow",Respuesta2="permitir", ResSel="",ResSel2=""},
                new PregOpMu{ Enunciado="5.-dneb", Respuesta="bend",Respuesta2="doblar", ResSel="",ResSel2=""}
            };
            lsvQuestionsV.ItemsSource = grupoV;

        }
        //El siguiente código compara que ambas respuestas de la pregunta sean correctas, acorde a las respuestas
        //en las 2 propiedades
        private void Checker_Clicked(object sender, EventArgs e)
        {
            score = 0;
            foreach (PregOpMu n in grupoV)
            {
                if (n.ResSel.ToLower() == n.Respuesta.ToLower() && n.ResSel2.ToLower() == n.Respuesta2.ToLower())
                {
                    score += 1;
                }
            }
            lblResultado.Text = $"Score {score}/{grupoV.Count}";
        }
    }
}