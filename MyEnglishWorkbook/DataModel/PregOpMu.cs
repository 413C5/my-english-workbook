using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

/*Autor:Matías Julian Pérez May*/
namespace MyEnglishWorkbook.DataModel
{
    /*Clase que permite la generacion de un objeto tipo PregOpMu,con la que
     se puede generar facilmente preguntas y respuestas, para todo tipo
    de ejercicio*/
    public class PregOpMu
    {
        public String Enunciado { get; set; }
        public String Enunciado2 { get; set; }
        public String Respuesta { get; set; }
        public String Respuesta2 { get; set; }
        public String Res1 { get; set; }
        public String Res2 { get; set; }
        public String Res3 { get; set; }
        public String ResSel { get; set; }
        public String ResSel2 { get; set; }
        public String Numero { get; set; }
        public String Foto { get; set; }
    }
}