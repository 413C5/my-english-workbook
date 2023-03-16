using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyEnglishWorkbook.DataModel;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyEnglishWorkbook.Pages.Vocabulary
{
    /*Autor: Matias Julian Perez May
    Descripción: Esta clase solo cuenta la cantidad de respuestas seleccionadas correctas y las muestra en pantalla*/
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VocabularyEx4 : ContentPage
    {
        ObservableCollection<PregOpMu> grupo;
        int aciertos;
        public VocabularyEx4()
        {
            InitializeComponent();
            aciertos = 0;

            grupo = new ObservableCollection<PregOpMu>
            {
                new PregOpMu{ Enunciado="1.-A hard hat that protects your head", Respuesta="Helmet", ResSel="", Numero="0"},
                new PregOpMu{ Enunciado="2.-Having a pattern of squares in two or more colours", Respuesta="Chequered", ResSel="", Numero="1"},
                new PregOpMu{ Enunciado="3.-Decorated with a pattern of flowers", Respuesta="Flowered", ResSel="", Numero="2"},
                new PregOpMu{ Enunciado="4.-With stripes or a pattern of stripes", Respuesta="Striped", ResSel="", Numero="3"},
                new PregOpMu{ Enunciado="5.-Decorated or covered with a pattern of spots", Respuesta="Spotted", ResSel="", Numero="4"}
            };
            clvQuestions.ItemsSource = grupo;

        }
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