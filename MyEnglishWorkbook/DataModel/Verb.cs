using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

/*Autor:Alejandro González Zárate*/
namespace MyEnglishWorkbook.DataModel
{
    /*Clase que permite la generacion de un objeto tipo Verbo, para de esa forma
     poder recuperar su información más adelante*/
    public class Verb
    {
        public string SimpleForm { get; set; }
        public string ThirdPerson { get; set; }
        public string PastTense { get; set; }
        public string PastParticiple { get; set; }
        public string Gerund { get; set; }
        public string Meaning { get; set; }
    }
}
