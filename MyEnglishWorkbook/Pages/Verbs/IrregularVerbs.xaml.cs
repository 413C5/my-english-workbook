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
    /*Clase que contiene el code behind de los verbos iregulares al contener a las formas de estos*/
    public partial class IrregularVerbs : ContentPage
    {
        //Para los ListView se utiliza una coleccion
        //de tipo ObservableCollection
        ObservableCollection<Verb> grupoIR;
        public IrregularVerbs()
        {
            InitializeComponent();
            grupoIR = new ObservableCollection<Verb>
            {
                //V1
                new Verb{SimpleForm="arise",ThirdPerson="arises",PastTense="arose",PastParticiple="arisen",Gerund="arising",Meaning="surgir"},
                new Verb{SimpleForm="abide",ThirdPerson="abides",PastTense="abode",PastParticiple="abode",Gerund="abidding",Meaning="tolerar"},
                new Verb{SimpleForm="awake",ThirdPerson="awakes",PastTense="awoke",PastParticiple="awoken",Gerund="awaking",Meaning="despertar"},
                new Verb{SimpleForm="be",ThirdPerson="is",PastTense="was/were",PastParticiple="been",Gerund="being",Meaning="ser/estar"},
                new Verb{SimpleForm="bear",ThirdPerson="bears",PastTense="bore",PastParticiple="borne",Gerund="bearing",Meaning="soportar"},

                //V2
                new Verb{SimpleForm="beat",ThirdPerson="beats",PastTense="beat",PastParticiple="beaten",Gerund="beating",Meaning="golpear"},
                new Verb{SimpleForm="become",ThirdPerson="becomes",PastTense="became",PastParticiple="become",Gerund="becoming",Meaning="llegar a ser"},
                new Verb{SimpleForm="beget",ThirdPerson="begets",PastTense="begot",PastParticiple="beggoten",Gerund="begetting",Meaning="engendrar"},
                new Verb{SimpleForm="begin",ThirdPerson="begins",PastTense="began",PastParticiple="begun",Gerund="beginning",Meaning="empezar"},
                new Verb{SimpleForm="bend",ThirdPerson="bends",PastTense="bent",PastParticiple="bent",Gerund="bending",Meaning="doblar"},

                //V3
                new Verb{SimpleForm="bet",ThirdPerson="bets",PastTense="bet",PastParticiple="bets",Gerund="betting",Meaning="apostar"},
                new Verb{SimpleForm="bind",ThirdPerson="binds",PastTense="bound",PastParticiple="bound",Gerund="binding",Meaning="amarrar"},
                new Verb{SimpleForm="bite",ThirdPerson="bites",PastTense="bit",PastParticiple="bitten",Gerund="biting",Meaning="morder"},
                new Verb{SimpleForm="bleed",ThirdPerson="bleeds",PastTense="bled",PastParticiple="bled",Gerund="bleeding",Meaning="sangrar"},
                new Verb{SimpleForm="blend",ThirdPerson="blends",PastTense="blent",PastParticiple="blent",Gerund="blending",Meaning="mezclar"},

                //V4
                new Verb{SimpleForm="bless",ThirdPerson="blesses",PastTense="blest",PastParticiple="blest",Gerund="blessing",Meaning="bendecir"},
                new Verb{SimpleForm="blow",ThirdPerson="blows",PastTense="blew",PastParticiple="blown",Gerund="blowing",Meaning="soplar"},
                new Verb{SimpleForm="break",ThirdPerson="breaks",PastTense="broke",PastParticiple="broken",Gerund="breaking",Meaning="romper"},
                new Verb{SimpleForm="breed",ThirdPerson="breeds",PastTense="bred",PastParticiple="bred",Gerund="breeding",Meaning="criar"},
                new Verb{SimpleForm="bring",ThirdPerson="brings",PastTense="brought",PastParticiple="brought",Gerund="bringing",Meaning="traer"},

                //V5
                new Verb{SimpleForm="broadcast",ThirdPerson="broadcasts",PastTense="broadcast",PastParticiple="broadcast",Gerund="broadcasting",Meaning="transmitir"},
                new Verb{SimpleForm="build",ThirdPerson="builds",PastTense="built",PastParticiple="built",Gerund="building",Meaning="construir"},
                new Verb{SimpleForm="burn",ThirdPerson="burns",PastTense="burnt",PastParticiple="burnt",Gerund="burning",Meaning="quemar"},
                new Verb{SimpleForm="burst",ThirdPerson="bursts",PastTense="burst",PastParticiple="burst",Gerund="bursting",Meaning="explotar"},
                new Verb{SimpleForm="buy",ThirdPerson="buys",PastTense="bought",PastParticiple="bought",Gerund="buying",Meaning="comprar"},

                //V6
                new Verb{SimpleForm="can",ThirdPerson="can",PastTense="could",PastParticiple="been able to",Gerund="-",Meaning="poder"},
                new Verb{SimpleForm="catch",ThirdPerson="catches",PastTense="caught",PastParticiple="caught",Gerund="catching",Meaning="atrapar"},
                new Verb{SimpleForm="chide",ThirdPerson="chides",PastTense="chid",PastParticiple="chidden",Gerund="chiding",Meaning="reprender"},
                new Verb{SimpleForm="choose",ThirdPerson="chooses",PastTense="chose",PastParticiple="chosen",Gerund="choosing",Meaning="elegir"},
                new Verb{SimpleForm="cling",ThirdPerson="clings",PastTense="clung",PastParticiple="clung",Gerund="clinging",Meaning="aferrar"},

                //V7
                new Verb{SimpleForm="come",ThirdPerson="comes",PastTense="came",PastParticiple="come",Gerund="coming",Meaning="venir"},
                new Verb{SimpleForm="cost",ThirdPerson="costs",PastTense="cost",PastParticiple="cost",Gerund="costing",Meaning="costar"},
                new Verb{SimpleForm="creep",ThirdPerson="creeps",PastTense="crept",PastParticiple="crept",Gerund="creeping",Meaning="arrastrar"},
                new Verb{SimpleForm="cut",ThirdPerson="cuts",PastTense="cut",PastParticiple="cut",Gerund="cutting",Meaning="cortar"},
                new Verb{SimpleForm="deal",ThirdPerson="dealt",PastTense="dealt",PastParticiple="dealt",Gerund="dealing",Meaning="comerciar"}
            };
            lsvGrupoIR.ItemsSource = grupoIR;

        }
    }
}