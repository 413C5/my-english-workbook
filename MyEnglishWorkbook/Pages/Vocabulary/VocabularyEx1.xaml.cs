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
    Descripción: Esta clase permite devolver los resultados de los groupRadio a la colección de datos para registrar respuestas
    seleccionadas así como permite contar el número de respuestas correctas*/
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VocabularyEx1 : ContentPage
    {
        ObservableCollection<PregOpMu> grupo;
        int aciertos;
        public VocabularyEx1()
        {
            aciertos = 0;
            InitializeComponent();

            grupo = new ObservableCollection<PregOpMu>
            {
                new PregOpMu{ Enunciado="1.-Trousers made of a heavy cotton named Lenin", Respuesta="Jeans",Res1="Blouse",Res2="Jeans",Res3="Shirt",ResSel="",Numero="0"},
                new PregOpMu{ Enunciado="2.-A piece of clothing for a woman or girl", Respuesta="Skirt",Res1="Shoes",Res2="Kilt",Res3="Skirt",ResSel="",Numero="1"},
                new PregOpMu{ Enunciado="3.-A long coat, which is made of a material that protects you from the wind", Respuesta="Windbreaker",Res1="Windbreaker",Res2="Raincoat",Res3="Trousers",ResSel="",Numero="2"},
                new PregOpMu{ Enunciado="4.-A piece of clothing that you wear on your head", Respuesta="Hat",Res1="Hat",Res2="Flippers",Res3="Crocs",ResSel="",Numero="3"}
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
                if (n.ResSel == n.Respuesta)
                {
                    aciertos += 1;
                }
            }
            lblResultado.Text = $"Score {aciertos}/{grupo.Count}";
        }
        //La siguiente función utiliza el nombre del grupo de radioButtons como índice para buscar el objeto de la pregunta y cambiar la propiedad
        //de la respuesta seleccionada al valor del radioButton
        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            (grupo.ElementAt(Convert.ToInt32(radioButton.GroupName))).ResSel = Convert.ToString(radioButton.Value);
        }
    }
}