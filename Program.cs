// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
////*Kui eesnimi on Juku siis lähme Jukuga kinno. Lisa valiku, kus Juku vanuse alusel otsustate mis pilet talle vaja osta.
//Console.WriteLine("Write your name!");
//var eesnimi = Console.ReadLine();
//if (eesnimi.ToUpper() == "JUKU")
//{
//    Console.WriteLine("Lahme kinno!!");
//    Console.WriteLine(" Kui vana sa oled, JUKU:  ");
//    int vanus = Convert.ToInt32(Console.ReadLine());
//    if (vanus < 0 || vanus > 120) //&&
//    {
//        Console.WriteLine("Vanus ei saa olla {0}", vanus);
//    }
//    if (vanus < 6)
//    {
//        Console.WriteLine("Sulle on Tasuta");
//    }
//    else if (6 <= vanus && vanus <= 14)
//    {
//        Console.WriteLine("Sulle on lastepilet");
//    }
//    else if (15 <= vanus && vanus <= 65)
//    {
//        Console.WriteLine("Sulle täispilet");
//    }
//    else if (vanus > 65)
//    {
//        Console.WriteLine("Sulle sooduspilet");
//    }
//}
//else
//{
//    Console.WriteLine("Täna mind kodus pole!");
//}
//Console.Clear();
//Random rnd = new Random();
//int hinne = rnd.Next(1, 5);
//Console.WriteLine("Täna sai hinne {0}", hinne);
//string reaktsioon = "";
//switch (hinne)
//{
//    case 1: reaktsioon="Kehv"; break;
//    case 2: reaktsioon = "Opi veel"; break;
//    case 3: reaktsioon = "Raheuldav"; break;
//    case 4: Console.WriteLine("Oled Hea"); break;
//    case 5: Console.WriteLine("Tubli"); break;
//    default:
//        Console.WriteLine("Viga!");
//        break;
//}
//for (int i = 0; i < hinne; i++) //i++ uveli4ivaem na +1 kazdqi raz (i=i+3)
//{
//    Console.WriteLine(reaktsioon);
//}

//int hinne_test = hinne;
//while (hinne>0)
//{
//    hinne--; //umenwaem hinne na 1 (5-1:4-1:3-1 i td) hinne=hinne-1
//    Console.WriteLine(reaktsioon);
//}

//Console.WriteLine("do while");
//do
//{

//    Console.WriteLine(reaktsioon);
//    hinne_test--;
//} while (hinne_test!=0);
//Console.Clear();

//var komm = "";
//do
//{
//    Console.WriteLine("Tahan kommi");
//    komm = Console.ReadLine();
//} while (komm!="KOMM");


//Console.WriteLine("Arv 1:  ");
//int arv1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Arv 2:  ");
//int arv2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Tehe :  ");
//char tehe = Convert.ToChar(Console.ReadLine()[0]); // Convert.ToChar  beret tolko pervoj simvol v stroke ili Console.ReadLine()[0])
//double vastus=0;
//if (tehe == '+')
//{
//    vastus = arv1 + arv2;
//}
//else if (tehe == '-')
//{
//    vastus = arv1 - arv2;
//}
//else if (tehe == '/')
//{
//    vastus = arv1 / arv2;

//}
//else
//{
//    Console.WriteLine("{0} - tundmatu tehe", tehe);
//}
//Console.WriteLine("Arvude {0} ja {1} vahe vordub {2}", arv1, arv2, vastus);



Random rnd = new Random();
//int kogus = rnd.Next(1, 10);
//string[] Nimed = new string[kogus];
//string nimi = "";
//for (int i = 0; i < kogus; i++)
//{
//    Console.WriteLine("Sisesta {0}. nimi:", i+1);
//    nimi = Console.ReadLine();
//    Nimed[i] = nimi;
//}

//    for (int i = 0; i < Nimed.Length; i++)
//{
//    Console.WriteLine("Tere {0}", Nimed[i]);
//}


////*Mis arv mõtles välja arvuti? Kasuta vähemalt 5 katset, et seda teada. 
//int katse = 0;
//int arv = rnd.Next(1,10);
//int inimene;
//do
//{
//    Console.WriteLine("Sisesta arv:");
//    inimene=Convert.ToInt32(Console.ReadLine());
//    katse++;
//} while (inimene!=arv && katse!=5);


////Korrutustabel väljata ekraanile sellisel kujul:
//for (int i = 1; i < 11; i++)
//{
//    for (int j = 1; j < 11; j++)
//    {
//        Console.Write("{0,4}", i * j); //i*j piwetsa vmesto 0 a 4 eto probelq mezdu 
//    }
//    Console.WriteLine();
//}


//Küsi kasutajalt viis arvu, salvesta neid massiivi ning väljasta nende summa, aritmeetiline keskmine ja korrutis
int[]Arvud = new int[5];
for (int i = 0; i < 5; i++)
{
    Arvud[i] = Convert.ToInt32(Console.ReadLine());
}
int summa=0,korrutis=1;
double keskmine;

foreach (int arv in Arvud)
{
    Console.Write("{0,5}", arv);
    summa = summa + arv;
    korrutis = korrutis * arv;

}
Console.WriteLine();
keskmine = summa / Arvud.Length;
Console.WriteLine("Summa={0},\nKorrutis={1},\nKeskmine={2}", summa, korrutis, keskmine);