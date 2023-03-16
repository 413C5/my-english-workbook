using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

/*Autor:Matías Julian Pérez May*/
namespace MyEnglishWorkbook.DataModel
{
    /*Clase que permite la generacion de un objeto tipo Word, para de esa forma
     poder recuperar su información más adelante*/
    public class Word
    {
        public String Nombre { get; set; }
        public String Significado { get; set; }
        public String Definicion { get; set; }
        public String Imagen { get; set; }
        public String Ejemplo { get; set; }
    }
}
