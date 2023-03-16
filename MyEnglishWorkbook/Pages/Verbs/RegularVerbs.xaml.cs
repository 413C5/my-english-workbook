using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyEnglishWorkbook.DataModel;

//Autor:Alejandro González Zárate
namespace MyEnglishWorkbook.Pages.Verbs
{
    /*Clase que contiene el code behind de los verbos regulares al contener a las formas de estos*/
    public partial class RegularVerbs : ContentPage
    {
        //Para los ListView se utiliza una coleccion
        //de tipo ObservableCollection
        ObservableCollection<Verb> grupoR;
        public RegularVerbs()
        {
            InitializeComponent();
            grupoR = new ObservableCollection<Verb>
            {
                //V1
                new Verb{SimpleForm="accept",ThirdPerson="accepts",PastTense="accepted",PastParticiple="accepted",Gerund="accepting",Meaning="aceptar"},
                new Verb{SimpleForm="achieve",ThirdPerson="achives",PastTense="achived",PastParticiple="achived",Gerund="achieving",Meaning="lograr"},
                new Verb{SimpleForm="act",ThirdPerson="acts",PastTense="acted",PastParticiple="acted",Gerund="acting",Meaning="actuar"},
                new Verb{SimpleForm="adapt",ThirdPerson="adapts",PastTense="adapted",PastParticiple="adapted",Gerund="adapting",Meaning="adaptar"},
                new Verb{SimpleForm="add",ThirdPerson="adds",PastTense="added",PastParticiple="added",Gerund="adding",Meaning="agregar"},

                //V2
                new Verb{SimpleForm="admit",ThirdPerson="admits",PastTense="admitted",PastParticiple="admitted",Gerund="admitting",Meaning="admitir"},
                new Verb{SimpleForm="advise",ThirdPerson="advises",PastTense="advised",PastParticiple="advised",Gerund="advising",Meaning="aconsejar"},
                new Verb{SimpleForm="affect",ThirdPerson="affects",PastTense="affected",PastParticiple="affected",Gerund="affecting",Meaning="afectar"},
                new Verb{SimpleForm="agree",ThirdPerson="agrees",PastTense="agreed",PastParticiple="agreed",Gerund="agreeing",Meaning="estar de acuerdo"},
                new Verb{SimpleForm="allow",ThirdPerson="allows",PastTense="allowed",PastParticiple="allowed",Gerund="allowing",Meaning="permitir"},

                //V3
                new Verb{SimpleForm="analyse",ThirdPerson="analyses",PastTense="analysed",PastParticiple="analysed",Gerund="analysing",Meaning="analizar"},
                new Verb{SimpleForm="annoy",ThirdPerson="annoys",PastTense="annoyed",PastParticiple="annoyed",Gerund="annoying",Meaning="irritar"},
                new Verb{SimpleForm="answer",ThirdPerson="answers",PastTense="answered",PastParticiple="answered",Gerund="answering",Meaning="contestar"},
                new Verb{SimpleForm="appear",ThirdPerson="appears",PastTense="appeared",PastParticiple="appeared",Gerund="appearing",Meaning="aparece"},
                new Verb{SimpleForm="argue",ThirdPerson="argues",PastTense="argued",PastParticiple="argued",Gerund="arguing",Meaning="discutir"},

                //V4
                new Verb{SimpleForm="arrange",ThirdPerson="arranges",PastTense="arranged",PastParticiple="arranged",Gerund="arranging",Meaning="arreglar"},
                new Verb{SimpleForm="arrive",ThirdPerson="arrives",PastTense="arrived",PastParticiple="arrived",Gerund="arriving",Meaning="llegar"},
                new Verb{SimpleForm="ask",ThirdPerson="asks",PastTense="asked",PastParticiple="asked",Gerund="asking",Meaning="preguntar"},
                new Verb{SimpleForm="attack",ThirdPerson="attacks",PastTense="attacked",PastParticiple="attacked",Gerund="acting",Meaning="atacar"},
                new Verb{SimpleForm="avoid",ThirdPerson="avoids",PastTense="avoided",PastParticiple="avoided",Gerund="avoiding",Meaning="evitar"},

                //V5
                new Verb{SimpleForm="bake",ThirdPerson="bakes",PastTense="baked",PastParticiple="baked",Gerund="baking",Meaning="hornear"},
                new Verb{SimpleForm="believe",ThirdPerson="believes",PastTense="believed",PastParticiple="believed",Gerund="believing",Meaning="creer"},
                new Verb{SimpleForm="belong",ThirdPerson="belongs",PastTense="belonged",PastParticiple="belonged",Gerund="belonging",Meaning="pertenecer"},
                new Verb{SimpleForm="book",ThirdPerson="books",PastTense="booked",PastParticiple="booked",Gerund="booking",Meaning="reservar"},
                new Verb{SimpleForm="borrow",ThirdPerson="borrows",PastTense="borrowed",PastParticiple="borrowed",Gerund="borrowing",Meaning="pedir prestado"},

                //V6
                new Verb{SimpleForm="bother",ThirdPerson="bothers",PastTense="bothered",PastParticiple="bothered",Gerund="bothering",Meaning="molestar"},
                new Verb{SimpleForm="bounce",ThirdPerson="bounces",PastTense="bounced",PastParticiple="bounced",Gerund="bouncing",Meaning="rebotar"},
                new Verb{SimpleForm="brush",ThirdPerson="brushes",PastTense="brushed",PastParticiple="brushed",Gerund="brushing",Meaning="cepillar"},
                new Verb{SimpleForm="bury",ThirdPerson="buries",PastTense="buried",PastParticiple="buried",Gerund="burying",Meaning="enterrar"},
                new Verb{SimpleForm="call",ThirdPerson="calls",PastTense="called",PastParticiple="called",Gerund="calling",Meaning="llamar"},

                //V7
                new Verb{SimpleForm="carry",ThirdPerson="carries",PastTense="carried",PastParticiple="carried",Gerund="carrying",Meaning="llevar"},
                new Verb{SimpleForm="change",ThirdPerson="changes",PastTense="changed",PastParticiple="changed",Gerund="changing",Meaning="cambiar"},
                new Verb{SimpleForm="chop",ThirdPerson="chops",PastTense="chopped",PastParticiple="chopped",Gerund="chopping",Meaning="picar"},
                new Verb{SimpleForm="clean",ThirdPerson="cleans",PastTense="cleaned",PastParticiple="cleaned",Gerund="cleaning",Meaning="limpiar"},
                new Verb{SimpleForm="clear",ThirdPerson="clears",PastTense="cleared",PastParticiple="cleared",Gerund="clearing",Meaning="aclarar"}
            };
            lsvGrupoR.ItemsSource = grupoR;

        }
    }
}