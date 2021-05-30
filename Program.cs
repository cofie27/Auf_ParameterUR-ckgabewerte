//------------------------------------------------------------------------------------------------------------------------------------
//Dateiname	    : Auf_ParameterURückgabewerte
//Projekt	    : Auf_ParameterURückgabewerte
//Beschreibung  :
//Autoren	    : Paul A.
//Erstellung	: 21.01.2021
//letzte Änd.	: 25.01.2021
//Fehler	    : 
//Dokument	    : auf_Parameter & auf_Rückgabewerte
//------------------------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objekt "d1" der Klasse Dezimalahl erzeugt
            Dezimalzahl d1 = new Dezimalzahl();             

            //Menü
            //Solange diese schleife wahr ist--> immer, dann...
            Console.Write("Bitte einen Wert eingeben: ");
            d1.setWert(Convert.ToInt32(Console.ReadLine()));
            while (d1.getWert() < 0)
            {
                Console.WriteLine("Bitte geben Sie ein POSITIVE Dezimahl ein:");
                d1.setWert(Convert.ToDouble(Console.ReadLine()));
            }
            while (true) 
           {
                //Auswahlanweisung, die einen einzelnen switch-Abschnitt zum Ausführen aus einer Liste von Kandidaten auswählt, die auf einem Mustertreffer mit dem Vergleichsausdruck basiert
                switch (menue()) //Methode menue wird hier aufgerufen. dh. hier: das Menü Overlay wird ausgegeben
                {
                    //Fall 1: die Methode setWert setzt das Attribut "Wert" auf die Eingabe der Konsole
                    case 1:
                        d1.setWert(Convert.ToInt32(Console.ReadLine()));
                        //solange dieser Wert kleiner als 0 ist wird der Anwender aufgefordert eine POSITIVE Zahl einzugeben
                        while (d1.getWert() < 0) 
                        {
                            Console.WriteLine("Bitte geben Sie ein POSITIVE Dezimahl ein:");
                            d1.setWert(Convert.ToDouble(Console.ReadLine()));
                        }
                        break;
                    //Fall 2: Die Methode getWert wird genutzt, um den eingegebenen Wert nochmals auszugeben
                    case 2:
                        Console.WriteLine("Wert: "+d1.getWert());
                        break;
                    //Fall 3: Der anfangs eingegebene Wert wird mit 15 Nachkommastellen ausgegeben, indem an den Rückgabewert der Methode getWert 15 Nachkommastellen angehangen werden
                    case 3:
                        Console.WriteLine(d1.getWert());
                        Console.WriteLine("Wert mit 15 Nachkommastellen: " + "{0:F15}", d1.getWert());
                        break;
                    //Fall 4: Der anfangs eingegebene Wert wird in wissenschaftlicher Schreibweise ausgegeben, indem der Rückgabewert der Methode ToExp ausgegeben wird
                    case 4:
                        Console.WriteLine(d1.getWert());
                        Console.WriteLine("Wissenschaftliche Schreibweise: " + "{0:E}", d1.ToExp());
                        break;
                    //Fall 5: Der anfangs eingegebene Wert wird in hexadezimaler Darstellung ausgegeben, indem der Rückgabewert der Methode ToHex ausgegeben wird und zusätzlich dem Compiler gesagt wird, dass er in hexadezimaler Schreibweise ausgeben soll
                    case 5:
                        Console.WriteLine(d1.getWert());
                        Console.WriteLine("Hexadezimal: "+ "{0:X}", d1.ToHex());
                        break;
                    //Fall 6: Der anfangs eingegebene Wert wird in binärer Darstellung ausgegeben, indem der Rückgabewert der Methode ToBin ausgegeben wird
                    case 6:
                        Console.WriteLine(d1.getWert());
                        Console.WriteLine("Binär: " + d1.ToBin());
                        break;
                    //Fall 7: Der anfangs eingegebene Wert wird in oktaler Darstellung ausgegeben, indem der Rückgabewert der Methode ToOkt ausgegeben wird
                    case 7:
                        Console.WriteLine(d1.getWert());
                        Console.WriteLine("Oktal: "+ d1.ToOKT());
                        break;
                    //Fall 8: Die Wurzel des anfangs eingegebnen Wertes wird mit Hilfe des Heronverfahrens ausgegeben, indem der Rückgabewert der Methdoe Heron ausgegeben wird
                    case 8:
                        Console.WriteLine(d1.getWert());
                        Console.WriteLine("Wurzel lt Heron: "+d1.Heron());
                        break;
                    //Fall 9: Die Wurzel des anfangs eingegebnen Wertes wird ausgegeben, indem der Rückgabewert der Methdoe WurzelGanz ausgegeben wird
                    case 9:
                        Console.WriteLine(d1.getWert());
                        Console.WriteLine("Ganzzahlige Wurzel: " + d1.WurzelGanz());
                        break;
                    //Fall 10: Es wird mit Hilfe der Methode IstPrim geprüft, ob der eingegebene Wert eine Primzahl ist. Die Methode istPrim gibt bei Primzahl "true" und bei keiner Primzahl "false" zurück. Dieser Rückgabewert wird dann auf der Konsole ausgegeben
                    case 10:
                        Console.WriteLine(d1.getWert());
                        Console.WriteLine("Primzahl? " +d1.IstPrim());
                        break;
                    //Fall 11: Die Differenz des anfangs eingegebenen Wertes und eines weiteren beliebigen Wertes wird mit Hilfe der Methode Differenz berechnet. Der Wert den diese Methode zurück gibt wird hier auf der Konsole ausgegeben
                    case 11:
                        Console.WriteLine(d1.getWert());
                        Console.Write("Geben Sie einen zweiten Wert ein: ");
                        Console.WriteLine("Differenz der beiden Eingaben: " + d1.Differenz(Convert.ToInt32(Console.ReadLine())));
                        break;
                    //Fall 12: Mit der Methode istWert wird geprüft, ob der anfangs eingegebene Wert gleich einem beliebigen Zweiten Wert ist. Der Rückgabewert "true" -> ist gleich oder "false" ist ungleich wird hier auf der Konsole ausgegeben
                    case 12:
                        Console.WriteLine(d1.getWert());
                        Console.Write("Geben Sie einen zweiten Wert ein: ");
                        Console.WriteLine("Sind die Eingaben gleich?" + d1.istWert(Convert.ToInt32(Console.ReadLine())));
                        break;
                    //Fall 13: Mit der Methode toGGT wird der größte gemeinsame Teiler des anfangs eingegebenen Wertes und einen beliebigen zweiten Wertes ermittelt. Der Rückgabewert dieser Methode wird hier ausgegeben
                    case 13:
                        Console.WriteLine(d1.getWert());
                        Console.Write("Geben Sie einen zweiten Wert ein: ");
                        Console.WriteLine("Größter gemeinsamer Teiler: "+d1.ToGGT(Convert.ToInt32(Console.ReadLine())));
                        break;
                    //Fall 14: Hier wird das Programm beendet. Mit einem weiteren Tastendruck (Enter) in der Konsole, wird diese dann geschlossen
                    case 14:
                        System.Environment.Exit(1);
                        break;
                    //wenn keiner dieser 14 Fälle angesprochen wird, dh wenn zum Beispiel eine Zahl eingegeben wird die außerhalb des Bereichs 1-14 eingegeben wird, wird der Anwender explizit aufgefordert eine Zahl zwischen 1 und 14 einzugeben
                    default:
                        Console.WriteLine("Eingabe bitte zuwischen 1 und 14");
                        break;
                }
            }
        }
        //Methode, die das Menü auf der Console ausgibt
        public static int menue()
        {
            //Menü Overlay wird auf der Konsole ausgegeben
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("1) Wert eingeben");
            Console.WriteLine("2) Wert ausgeben");
            Console.WriteLine("3) Wert mit 15 Nachkommastellen ausgeben");
            Console.WriteLine("4) In wissenschaftlicher Schreibweise ausgeben");
            Console.WriteLine("5) Hexadezimal ausgeben");
            Console.WriteLine("6) Binär ausgeben");
            Console.WriteLine("7) Oktal ausgeben");
            Console.WriteLine("8) Wurzel lt. Heron ausgeben");
            Console.WriteLine("9) Ganzzahlige Wurzel ausgeben");
            Console.WriteLine("10) Primzahl?");
            Console.WriteLine("11) Differenz");
            Console.WriteLine("12) Wert verlgeichen");
            Console.WriteLine("13) Größter gemeinsamer Teiler:");
            Console.WriteLine("14) Programm beenden");
            Console.WriteLine("------------------------------------------------------");
            Console.Write("Menue-Auswahl: ");
            int i = Convert.ToInt32(Console.ReadLine());
            return (i);
            
        }
    }

}
