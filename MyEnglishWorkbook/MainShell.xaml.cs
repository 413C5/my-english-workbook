using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MyEnglishWorkbook.Pages;
//Autor: Marco Antonio García Hernández

/*Autores de la aplicación:Marco Antonio García Hernández
                           Alejandro González Zárate
                           Matías Julian Pérez May

 Aplicacion que permite al usuario poder aprender la lengua Inglés, a través de una seria de modulos de aprendizaje y ejercicios
 Entre los módulos se encuentran Vocabulary, Verbs (Regulares e Irregulares) y Reading; mientras que algunos de los ejercicios presentes son
 el elegir el verbo o la palabra correcta, escribir la palabra correcta en base a la definción o el unir enunciados basados en una lectura.
 Para ello se emplean controles de Xamarin.Forms como lo son el entry, picker o radioButton*/
                            
namespace MyEnglishWorkbook
{
    public partial class MainShell : Shell //se cambio a shell para poder emplear shell y flyout
    {
        public MainShell()
        {
            InitializeComponent();
        }
    }
}
