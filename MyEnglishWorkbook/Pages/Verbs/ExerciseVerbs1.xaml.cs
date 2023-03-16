using MyEnglishWorkbook.DataModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

//Autor: Alejandro González Zárate
namespace MyEnglishWorkbook.Pages.Verbs
{
    /*Descripción: Esta clase permite obtener resultados de los groupRadio a la colección de datos para registrar respuestas
    seleccionadas así como permite contar el número de respuestas correctas*/
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExerciseVerbs1 : ContentPage
    {
        ObservableCollection<PregOpMu> grupoV;
        int score;
        public ExerciseVerbs1()
        {
            score = 0;
            InitializeComponent();

            grupoV = new ObservableCollection<PregOpMu>
            {
                new PregOpMu{ Enunciado="1.-My brother was ____ in the military school", Respuesta="admitted",Res1="admitted",Res2="admit",ResSel="",Numero="0"},
                new PregOpMu{ Enunciado="2.-Julio ____ a classmate, he will have a report.", Respuesta="beat",Res1="beat",Res2="beats",ResSel="",Numero="1"},
                new PregOpMu{ Enunciado="3. The teacher ____ me because i failed the exams.", Respuesta="advised",Res1="advised",Res2="advises",ResSel="",Numero="2"},
                new PregOpMu{ Enunciado="4.-My brother was ____ in the military school.", Respuesta="admitted",Res1="admitted",Res2="admit",ResSel="",Numero="3"},
                new PregOpMu{ Enunciado="5.-That problema didn’t ____ his behaviour.", Respuesta="affect",Res1="affect",Res2="affected",ResSel="",Numero="4"}
            };
            lsvQuestionsV.ItemsSource = grupoV;

        }
        /*Se compara el elemento en la colección y se compara respuesta elegida-correcta*/
        private void Checker_Clicked(object sender, EventArgs e)
        {
            score = 0;
            foreach (PregOpMu n in grupoV)
            {
                if (n.ResSel == n.Respuesta)
                {
                    score += 1;
                }
            }
            lblResultado.Text = $"Score {score}/{grupoV.Count}";
        }
        /*La siguiente función utiliza el nombre del grupo de radioButtons como índice para buscar el objeto de la pregunta y cambiar la propiedad
        de la respuesta seleccionada al valor del radioButton*/
        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            (grupoV.ElementAt(Convert.ToInt32(radioButton.GroupName))).ResSel = Convert.ToString(radioButton.Value);
        }
    }
}