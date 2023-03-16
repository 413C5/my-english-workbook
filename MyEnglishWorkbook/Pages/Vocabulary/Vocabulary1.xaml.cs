using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyEnglishWorkbook.DataModel;

namespace MyEnglishWorkbook.Pages.Vocabulary
{
    /*Autor: Matias Julian Perez May
    Descripción: Esta clase permite hacer visibles o invisibles los listview de la página de la lección de vocabulario
    así como permite mostrar en el label un ejemplo de cualquier palabra*/
    public partial class Vocabulary1 : ContentPage
    {
        ObservableCollection<Word> grupo, grupo2, grupo3, grupo4;
        public Vocabulary1()
        {
            InitializeComponent();
            //Se vuelve a cada listview invisible al cargar la página
            lsvDic1.IsVisible = false;
            lsvDic2.IsVisible = false;
            lsvDic3.IsVisible = false;
            lsvDic4.IsVisible = false;
            //Objetos tipo colección "grupo" que guardan todos los elementos Word que contienen la información a mostrar en pantalla
            grupo = new ObservableCollection<Word>
            {
                new Word{ Nombre="Belt - Cinturón", Definicion="A narrow piece of leather, cloth, etc. that you wear around your waist.",Imagen="Belt.jpg",Ejemplo="She was wearing a beautiful brown belt for the party."},
                new Word{ Nombre="Glove - Guante", Definicion="A piece of clothing that covers your fingers and hands.",Imagen="Glove.jpg",Ejemplo="If you go to Canada, don’t forget to buy a pair of gloves."},
                new Word{ Nombre="Pocket - Bolsillo", Definicion="A small bag that forms part of a piece of clothing.",Imagen="Pocket.jpg",Ejemplo="I must sew the pocket of my shirt, it has a hole."},
                new Word{ Nombre="Tights - Mallas", Definicion="A piece of women’s clothing that tightly covers the feet and legs up to the waist.",Imagen="Tight.jpg",Ejemplo="I need to buy a pair of black thights for my blue dress."},
                new Word{ Nombre="Uniform - Uniforme", Definicion="A set of clothes that you wear to show that you are part of a particular organization or school.",Imagen="Uniform.jpg",Ejemplo="In this school it is mandatory to wear uniform."},
                new Word{ Nombre="Bracelet - Brazalete", Definicion="A piece of jewelery that you wear around your wrist.",Imagen="Bracelet.jpg",Ejemplo="My mother lost her bracelet at the beach, and she couldn’t find it."},
                new Word{ Nombre="Handbag - Bolsa de mano", Definicion="A small bag used by women for carrying personal things.",Imagen="Handbag.jpg",Ejemplo="Have you got a pen? Look inside my handbag, there must be one."},
                new Word{ Nombre="Hat - Sombrero", Definicion="A piece of clothing that you wear on your head.",Imagen="Hat.jpg",Ejemplo="Hunters wear hats when they go hunting to protect themselves from the sun."},
                new Word{ Nombre="High-heeled shoes - Zapatos de tacón alto", Definicion="Women shoes that have high heels.",Imagen="Highheels.jpg",Ejemplo="I can’t walk with this high-heeled shoes, I prefer my tennis shoes."},
                new Word{ Nombre="Jacket - Chaqueta", Definicion="A short coat that covers the upper part of the body and is made in many styles for different occasions and weather.",Imagen="Jacket.jpg",Ejemplo="He was wearing jeans and a laeather jacket in the morning."},
                new Word{ Nombre="Necklace - Collar", Definicion="A piece of jewelry that hangs round your neck.",Imagen="Necklace.jpg",Ejemplo="My father gave a pearl necklace to my mother as an anniversary present."},
                new Word{ Nombre="Skirt - Falda", Definicion="A piece of clothing for a woman or girl.",Imagen="Skirt.jpg",Ejemplo="I love to see my mother when she wears that red skirt."},
                new Word{ Nombre="Suit - Traje", Definicion="A set of clothes made of the same cloth, usually a jacket with trousers or a skirt.",Imagen="Suit.png",Ejemplo="Michelle wore a suit and a tie to the Christmas party."},
                new Word{ Nombre="Tie - Corbata", Definicion="A long narrow piece of cloth that a man wears around his neck under the collar of a shirt.",Imagen="Tie.jpg",Ejemplo="For work, you should wear a collar and a tie."},
                new Word{ Nombre="Trousers - Pantalón", Definicion="A piece of clothing covering the body from the waist to the feet, divided into separate parts for each leg.",Imagen="Trousers.jpg",Ejemplo="Oh no! I poured some paint on my new trousers and I’m late for work."},
                new Word{ Nombre="Dungarees - Overol de tirantes", Definicion="A piece of clothing consisting of trousers and a square piece of cloth that fits over your chest.",Imagen="Dungarees.jpg",Ejemplo="Carpenters always wear dungarees when they work."},
                new Word{ Nombre="Jeans - Pantalón de mezclilla", Definicion="Informal trousers made of heavy cotton cloth called denim.",Imagen="Jeans.jpg",Ejemplo="Levi’s jeans are very well known because they are comfortable."},
                new Word{ Nombre="Jumper - Suéter", Definicion="A warm piece of clothing, usually made of wool that covers your upper body and arms.",Imagen="Jumper.jpg",Ejemplo="Don’t forget to bring your jumper, it’s cold outside."},
                new Word{ Nombre="Leggings - Mallones", Definicion="Trousers worn by women and girls that stretches and fit very closely to their legs.",Imagen="Leggings.png",Ejemplo="I don’t like to wear jeans, I prefer to wear leggings because they fit me better."},
                new Word{ Nombre="Raincoat - Impermeable", Definicion="A long coat made of light material that you wear when it’s raining.",Imagen="Raincoat.jpg",Ejemplo="What a rain! Fortunately, I brought my raincoat."}
            };
            grupo2 = new ObservableCollection<Word>
            {
                new Word{ Nombre="Take a shower – Ducharse",Definicion="To wash yourself in a shower",Imagen="TakeShower.jpg",Ejemplo="He played football now he needs to take a shower"},
                new Word{ Nombre="Brush your teeth – Cepillarse los dientes",Definicion="To clean your teeth with water and toothpaste",Imagen="BrushTeeth.jpg",Ejemplo="Before you go to bed, you have to brush your teeth"},
                new Word{ Nombre="Change the sheets – Cambiar las sábanas",Definicion="To take, have, or use other sheets on your bed.",Imagen="ChangeSheet.jpg",Ejemplo="My bed looks beautiful, because I charged the sheets and put new cushions on it."},
                new Word{ Nombre="Wash your hands – Lavarse las manos",Definicion="To make your hands clean using soap and water",Imagen="WashHands.jpg",Ejemplo="Wash your hands before having meal."},
                new Word{ Nombre="Take a nap – Tomar una siesta",Definicion="To sleep for a short time",Imagen="TakeNap.jpg",Ejemplo="Laura loves to take a nap after having lunch."},
                new Word{ Nombre="Tidy your room – Arreglar tu cuarto",Definicion="To keep your room clean and in order",Imagen="TidyRoom.jpg",Ejemplo="Helen tidies her room before going to school"},
                new Word{ Nombre="Clean up your room – Limpiar tu cuarto",Definicion="To remove dirt or other bad things from your room",Imagen="CleanRoom.jpg",Ejemplo="You should clean up your room! It is a mess!"},
                new Word{ Nombre="Fasten your seat belt – Abrocharse el cinturón de seguridad",Definicion="Wear the seat belt of any car, bus or airplane.",Imagen="FastenSeatbelt.jpg",Ejemplo="You always have to fasten your seat belt when you are in a car."},
                new Word{ Nombre="Sweep the floor – Barrer el piso",Definicion="To clean the floor by moving dust or dirt away with a broom",Imagen="SweepFloor.jpg",Ejemplo="After dinner I sweep the floor of the kitchen."},
                new Word{ Nombre="Mop the floor – Trapear el piso",Definicion="To clean a floor with water and a mop.",Imagen="MopFloor.jpg",Ejemplo="Jolianna mops her bedroom floor on weekends."},
                new Word{ Nombre="Mow the lawn – Podar el césped",Definicion="To cut plants, such as grass or wheat",Imagen="MowLawn.jpg",Ejemplo="The gardener comes twice a week to mow the lawn."},
                new Word{ Nombre="Brush my hair – Cepillarme el Cabello",Definicion="The action of tidying the hair",Imagen="BrushHair.jpg",Ejemplo="You should brush your hair after taking a shower"},
                new Word{ Nombre="Go to bed – Ir a la cama",Definicion="The time you go to sleep",Imagen="GoBed.jpg",Ejemplo="What time do you usually go to bed?"},
                new Word{ Nombre="Catch the bus – Tomar el autobús",Definicion="The action of catching the bus to go somewhere",Imagen="CatchBus.jpg",Ejemplo="It’s late! I don’t have time to catch the bus, I will take a taxi"},
                new Word{ Nombre="Get home – Llegar a casa",Definicion="When you arrive home from somewhere else",Imagen="GetHome.jpg",Ejemplo="Dad always gets home when I’m sleeping"},
                new Word{ Nombre="Do the laundry – Lavar la ropa",Definicion="To clean clothes, sheets, etc. Usually in a washing machine.",Imagen="DoLaundry.jpg",Ejemplo="My maid does the laundry on Saturdays"},
                new Word{ Nombre="Make lunch – Hacer el almuerzo",Definicion="To prepare food to be eaten in a particular place not at home.",Imagen="MakeLunch.jpg",Ejemplo="Who makes your lunch? My mother."},
                new Word{ Nombre="Leave school – Irse de la escuela",Definicion="The time you abandon the school to go somewhere else.",Imagen="LeaveSchool.jpg",Ejemplo="I would like to leave school earlier."},
                new Word{ Nombre="Walk the dog – Pasear al perro",Definicion="When you take your dog out of your house to run, play, etc.",Imagen="WalkDog.jpg",Ejemplo="Have you seen how many people walk their dogs in the park on Sundays?"},
                new Word{ Nombre="Make the bed – Hacer la cama",Definicion="To arrange the sheets of your bed.",Imagen="MakeBed.jpg",Ejemplo="My mother said I have to make the bed before going to school."}
            };
            grupo3 = new ObservableCollection<Word>
            {
                new Word{ Nombre="Scarf - Bufanda", Definicion="A piece of cloth that you wear round your neck or head to keep you warm.", Imagen="Scarf.jpg", Ejemplo="Let’s put a scar around the snowman’s neck."},
                new Word{ Nombre="Sock - Calcetin", Definicion="A soft piece of clothing that you wear on your foot inside your show.", Imagen="Sock.jpg", Ejemplo="The Physical Education teacher was wearing a pair of yellow socks."},
                new Word{ Nombre="Sweatshirt - Sudadera", Definicion="A piece of clothing made of thick cotton that you wear on the upper part of the body for exercising or informal activities.", Imagen="Sweatshirt.jpg", Ejemplo="I always carry a sweatshirt in my schoolbag for my gymnastics class."},
                new Word{ Nombre="Vest - Chaleco", Definicion="A type of underwear, with no sleeves, which covers the upper part of the body and which is worn for extra warmth.", Imagen="Vest.jpg", Ejemplo="She always wore a thermal vest in winter"},
                new Word{ Nombre="Ring - Anillo", Definicion="A circular piece of jewelery worn especially on your finger.", Imagen="Ring.jpg", Ejemplo="He bought her a diamond ring for her birthday."},
                new Word{ Nombre="Spotted - A lunares", Definicion="Decorated or covered with a pattern of spots.", Imagen="Spotted.jpg", Ejemplo="My cousin had a spotted shirt."},
                new Word{ Nombre="Striped - A rayas", Definicion="With stripes or a pattern of stripes.", Imagen="Stripped.jpg", Ejemplo="Do you prefer plain or stiped shirts?"},
                new Word{ Nombre="Polka dot - De bolitas", Definicion="One of a large number of small round spots that are printed in a regular pattern on cloth.", Imagen="PolkaDot.jpg", Ejemplo="I’ll never wear a polka dot bow tie in my life"},
                new Word{ Nombre="Flowered - Floreado", Definicion="Decorated with a pattern of flowers.", Imagen="Flowered.jpg", Ejemplo="My little sister likes wearing flowered shirts."},
                new Word{ Nombre="Chequered - A cuadros", Definicion="Having a pattern of squares in two or more colours.", Imagen="Chequered.jpg", Ejemplo="At the end of the road there were two black and white chequered flags"},
                new Word{ Nombre="Helmet - Casco", Definicion="A hard hat that protects your head.", Imagen="Helmet.jpg", Ejemplo="Engineers wear a helmet when they are on site."},
                new Word{ Nombre="Blazer – Saco,chaqueta", Definicion="A type of jacket, often with the symbol of a school or organization.", Imagen="Blazer.jpg", Ejemplo="My new school blazer is blue"},
                new Word{ Nombre="Slippers - Pantuflas", Definicion="A type of soft comfortable show for wearing inside the house.", Imagen="Slippers.jpg", Ejemplo="Put on your slippers! The floor is very cold."},
                new Word{ Nombre="Dinner jacket - Esmoquin", Definicion="A man’s black or white jacket worn at formal social events, with matching trousers and a bow tie.", Imagen="DinnerJacket.jpg", Ejemplo="For this party, it is necessary to wear a dinner jacket."},
                new Word{ Nombre="Bow tie - Moño", Definicion="A special type of tie in the shape of a bow, worn by men on formal occasions.", Imagen="BowTie.jpg", Ejemplo="The businessman was using a bow tie for the presentation of his new project."},
                new Word{ Nombre="Cap - Gorra", Definicion="A soft flat hat that has a curved part sticking out at the front.", Imagen="Cap.jpg", Ejemplo="The baseball team wears a yellow and white stripped cap."},
                new Word{ Nombre="Windbreaker - Rompeviento", Definicion="A jacket , which is made of a material that protects you from the wind.", Imagen="Windbreaker.jpg", Ejemplo="You should put on your windbreaker , there is a lot of wind outside."},
                new Word{ Nombre="Glasses - Lentes", Definicion="Two small pieces of special glass or plastic in a frame worn in front of the eyes to improve sight.", Imagen="Glasses.jpg", Ejemplo="My grandmother wears glasses for reading her books."},
                new Word{ Nombre="Rain boots - Botas impermeables", Definicion="A type of shoe especially for rain that covers the whole foot and the lower part of the leg.", Imagen="RainBoots.jpg", Ejemplo="It was raining so hard that I had to use my rain boots."},
                new Word{ Nombre="Mittens - Guantes para frío", Definicion="A type of glove either with a single part for all the fingers and a separate part for the thum.", Imagen="Mittens.jpg", Ejemplo="Let’s go skiing! Ok but let me put on my mittens. I have my hands cold."}
            };
            grupo4 = new ObservableCollection<Word>
            {
                new Word{ Nombre="Play - Obra", Definicion="A story that is written for actors to perform, usually in a theatre.", Imagen="Play.jpg", Ejemplo="Most schools usually put on a play at Christmas."},
                new Word{ Nombre="Plot - Trama", Definicion="The series of events which form the storyof a novel, film, etc.", Imagen="Plot.jpg", Ejemplo="I can’t follow the plot of this novel. It’s confusing."},
                new Word{ Nombre="Sitcom - Comedia", Definicion="A regular programme on television that shows the same characters in different amusing situations.", Imagen="Sitcom.jpg", Ejemplo="The show iCarly is not a horror serie, it is a sitcom show."},
                new Word{ Nombre="Soap opera - Novela", Definicion="A television programme about the lives of a group of people that is broadcasted several times every week.", Imagen="SoapOpera.jpg", Ejemplo="Children shouldn’t watch soap operas."},
                new Word{ Nombre="Host - Anfitrión/anfitriona", Definicion="A person who introduces and talks to guests on a television or radio show.", Imagen="Host.jpg", Ejemplo="Adrian Uribe “el Vitor” is the hosts in the TV game show “Cien mexicanos dijeron”."},
                new Word{ Nombre="Character - Personaje", Definicion="A person in a book, film, etc.", Imagen="Character.png", Ejemplo="Who are the main characters of the story?"},
                new Word{ Nombre="Stage - Escenario", Definicion="The raised area in a theatre where actors perform.", Imagen="Stage.jpg", Ejemplo="He’s on stage most of the play."},
                new Word{ Nombre="Broadcasting - Transmisión", Definicion="The business of making and sending out radio and television programmes.", Imagen="Broadcasting.jpg", Ejemplo="If you want to watch the WWW special events, you have to pay for this special broadcasting."},
                new Word{ Nombre="Satellite - Satétlite", Definicion="An artificial object sent up into space for collecting information or communicating by radio, television, etc.", Imagen="Satellite.jpg", Ejemplo="The World Cup was transmitted around the world by satellite."},
                new Word{ Nombre="Surf the net - Navegar en internet", Definicion="To use the internet.", Imagen="SurfTheNet.jpg", Ejemplo="I was surfing the net to look for information about Indian music."},
                new Word{ Nombre="Web site - Sitio en / de internet", Definicion="Internet page where a company, etc. has information about itself.", Imagen="Website.jpg", Ejemplo="Many products on TV invite viewers to visit their web site to win prizes."},
                new Word{ Nombre="Web address - Dirección de internet", Definicion="The details where an organization is situated on the web.", Imagen="WebAddress.jpg", Ejemplo="Type the web address www.google.com to search for different topics."},
                new Word{ Nombre="Home page - Página de inicio", Definicion="A person’s or organization’s main page created on the internet from which connections to other pages can be made.", Imagen="HomePage.png", Ejemplo="I created my own homepage."},
                new Word{ Nombre="Social network - Red social", Definicion="A closely connected group of people, companies, etc. that exchange information on the internet.", Imagen="SocialNetwork.png", Ejemplo="Facebook is the most important social network to share photos and comments with friends."},
                new Word{ Nombre="Chat room - Sala de plática", Definicion="An area on the Internet where people can communicate with each other, usually about one particular topic.", Imagen="ChatRoom.png", Ejemplo="I met many friends in a chat room for Harry Potter’s fans."},
                new Word{ Nombre="Log in / out - Iniciar / terminar session", Definicion="To perform the actions that allow you to begin or finish using a computer system.", Imagen="LogIn.png", Ejemplo="You have to log in to view your friends’ photos on Facebook."},
                new Word{ Nombre="At - Arroba", Definicion="The symbol or sign used in internet to introduce the e-mail address.", Imagen="At.png", Ejemplo="Send the photos to my e-mail address: stars@yahoo.com."},
                new Word{ Nombre="Dot - Punto", Definicion="A small round mark or point.", Imagen="Dot.png", Ejemplo="Every e-mail address has a dot."},
                new Word{ Nombre="Screen - Pantalla", Definicion="The flat surface at the front of a television or computer, on which you see pictures or information.", Imagen="Screen.png", Ejemplo="Move your cursor on the top of the screen."},
                new Word{ Nombre="Keyboard - Teclado", Definicion="The set of keys for operating a computer.", Imagen="Keyboard.jpg", Ejemplo="Use the keyboard to type your password and access your e-mail."}
            };
            //Asignación de las colecciones a los listView
            lsvDic1.ItemsSource = grupo;
            lsvDic2.ItemsSource = grupo2;
            lsvDic3.ItemsSource = grupo3;
            lsvDic4.ItemsSource = grupo4;
        }

        //Funciones de control de listview, cada una hace que solo sea visible el listView correspondiente
        //haciendo invisible al resto (respectivamente del 1 al 4)
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            lsvDic1.IsVisible = true;
            lsvDic2.IsVisible = false;
            lsvDic3.IsVisible = false;
            lsvDic4.IsVisible = false;
        }
        
        private void TapGestureRecognizer_Tapped2(object sender, EventArgs e)
        {
            lsvDic1.IsVisible = false;
            lsvDic2.IsVisible = true;
            lsvDic3.IsVisible = false;
            lsvDic4.IsVisible = false;
        }
        
        private void TapGestureRecognizer_Tapped3(object sender, EventArgs e)
        {
            lsvDic1.IsVisible = false;
            lsvDic2.IsVisible = false;
            lsvDic3.IsVisible = true;
            lsvDic4.IsVisible = false;
        }
        
        private void TapGestureRecognizer_Tapped4(object sender, EventArgs e)
        {
            lsvDic1.IsVisible = false;
            lsvDic2.IsVisible = false;
            lsvDic3.IsVisible = false;
            lsvDic4.IsVisible = true;
        }
        //Funcion de texto para labelDescripcion, muestra en el label el string ejemplo del objeto Word
        //correspondiente.
        private void lsvDic_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Word p = (Word)e.SelectedItem;
            lblEjemplo.Text = p.Ejemplo;
        }
    }
}