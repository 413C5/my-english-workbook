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
    public partial class ReadingEx1 : ContentPage
    {
        ObservableCollection<PregOpMu> grupo;
        int aciertos;
        public ReadingEx1()
        {
            InitializeComponent();
            aciertos = 0; //numero de aciertos
            //se crea una collecion para los enunciados y las respuestas correctas
            grupo = new ObservableCollection<PregOpMu>
            {
                new PregOpMu{ Enunciado="1.The UN do not take place in any issue related to the Worlds quality", Respuesta="False", ResSel="", Numero="0"},  //falso
                new PregOpMu{ Enunciado="2.There are 193 State Members in the UN Organization.", Respuesta="True", ResSel="", Numero="1"},//verdadero
                new PregOpMu{ Enunciado="3.The States express their views , through the General Assembly, the Security Council, the Economic and Social Council.", Respuesta="True", ResSel="", Numero="2"},  //verdadero
                new PregOpMu{ Enunciado="4.The UN  is best known for being peacekeeping, peacebuilding, conflicto prevention and for its humanitarian assistance.", Respuesta="True", ResSel="", Numero="3"}, //verdadero
                new PregOpMu{ Enunciado="5. The United Nations works individually without other countries help.", Respuesta="False", ResSel="", Numero="4"} //falso
            };
            clvQuestions.ItemsSource = grupo;

        }
        private void Checker_Clicked(object sender, EventArgs e) //checa los datos que manda el boton al ser presionado
        {
            aciertos = 0;
            //permite calcular el numero de aciertos en la actividad
            foreach (PregOpMu n in grupo)
            {
                if ((n.ResSel).ToLower() == (n.Respuesta).ToLower())
                {
                    aciertos += 1;
                }
            }
            lblResultado.Text = $"Score {aciertos}/{grupo.Count}"; //manda el numero de aciertos al label lblResultado
        }
    }
}