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
    class Dezimalzahl
    {
        //Deklaration und Kapselung des Attributs
        private double wert;

        //Standardkonstruktor
        public Dezimalzahl()
        {
            wert = 1.0;
        }
        //zweiter Konstruktor mit dem Attribut Anfangswert
        public Dezimalzahl(double Anfangswert)
            //das Attribut wert wird auf den Anfangswert gesetzt
        {
            wert = Anfangswert;
        }
        //Eingabemethode für wert
        public void Eingabe()
        {
            //Eingabeaufforderung (alt)
            Console.Write("Bitte eine Dezimalzahl eingeben: ");
            wert = Convert.ToDouble(Console.ReadLine());
            while (wert < 0)
            {
                Console.WriteLine("Bitte eine positive Dezimalzahl eingeben: ");
                wert = Convert.ToDouble(Console.ReadLine());                                //Speichern der Benutzereingabe, wenn Eingabe > 0

            }
        }
        public void setWert(double newWert)
        {
            //Eingabeaufforderung NEU -> wert wird auf newWert gesetzt
                wert = newWert;
        }

        //Verschiedene Ausgabemethoden

        //Rückgabe des Werts
        public double getWert()
        {
            return (wert);
        }
        // Wert wird zum String konvertiert
        override public string ToString()
        {
            string ausgabe = "";
            ausgabe = Convert.ToString(wert);
            return (ausgabe);
        }
        //Wert wird zurückgegeben
        public double To15()
        {
            return (wert);
        }
        //Wert wird zurückgegeben
        public double ToExp()
        {
            return (wert);
        }
        //Wert wird als int zurückgegeben
        public long ToHex()
        {
            return Convert.ToInt64(wert);
        }
        //Wert wird im oktalen System zurückgegeben
        public String ToOKT()
        {
            //Deklaration und Initialisierung von xDez/xOkt
            ulong xDez = Convert.ToUInt64(wert);
            string xOkt = "";

            do
            {
                //privates Attrivut zwischenspeicher deklariert um den Rest dort zu speichern
                string zwischenspeicher = Convert.ToString(xDez % 8);
                //dem String xOkt wird ein Stelle hinzugefügt
                xOkt = zwischenspeicher + xOkt;
                //xDez wird durch 8 geteilt um den Wert oktal darstellen zu können
                xDez = xDez / 8;                                                                

            }
            //solange xDez >=1, weil 0/8= 0 Rest 0 ->sonst endlos
            while (xDez >= 1); 
            //Rückgabe des Attributs xOkt
            return (xOkt);                                       

        }
        //Ausgabe im binären System
        public string ToBin()
        {
            //Deklaration und Initialisierung von xDez/xBin
            ulong xDez = Convert.ToUInt64(wert);
            string xBin = "";

            do
            {
                //wenn der Rest von xDez/2 ungelich 0 ist, dann....
                if (xDez % 2 != 0)                                                              
                {
                    //Dem String xBin wird die "1" hinzugefügt
                    xBin = "1" + xBin;                                                         
                }
                else
                {
                    //Dem String xBin wird die "0" hinzugefügt
                    xBin = "0" + xBin;                                                          
                }
                //xDez/2 da man so die Dezimalzahl binär darstellen kann
                xDez = xDez / 2;                                                                

            }
            //solange xDez >=1, weil 0/2= 0 Rest 0 ->sonst endlos (Abbruchbedinung)
            while (xDez >= 1);
            //xBin wird zurückgegeben
            return (xBin);                                                                       

        }
        //Ausgabe ganzzahliger Quadratwuurzel (, falls vorhanden)
        public int WurzelGanz()
        {
            //Deklaration und Initialisierung von i
            int i = 1;

            //solange Eingabewert > i*i, dann... (Abbruchbedingung)
            while (wert > i * i)                                                                
            {
                //i um 1 erhöhen
                i++;                                                                            
            }
            //wenn Eingabewert gleich i*i, dann...
            if (wert == i * i)                                                                  
            {
                //i wird zurückgegeben (wenn vorhanden), was in der if- Bedinung geprüft wird
                return (i);                                                                      
            }
            //andernfalls, also wenn i*i nie gleich dem Eingabewert wird, dann wird -1 zurückgegeben
            else
            {
                return (-1);                                                                    
            }

        }
        // Ausgabe der Quadratwurzel durchs Heron-Verfahren
        public double Heron()
        {
            //Deklaration und Initialisierung von x und y

            //als float, um die Dezimalstellen (hier:Nachkommastellen) zu begrenzen und keine Endlosschleife zu erhalten
            float y = 1;                                                                        
            double x = wert;

            //Abbruchbedingung
            while (x > y)                                                                       
            {
                //x wird gleich dem Ergebnis von (x+y)/2 gesetzt
                x = (x + y) / 2;                                                                
                y = Convert.ToSingle(wert / x);
            }
            //Rückgabe der Quadratwurzel (x)
            return (x);                                                                          
        }
        //Ausgabe des größten gemeinsamen Teilers, nach Eingabe von zwei Werten
        public int ToGGT(int op2)
        {
            //Deklaration und Initialisierung von A, B, T und G
            int A = 0;
            int B = 0;
            double T = 2;
            double G = 1;

            //A wird gleich dem anfangs eingegenen Wert gesetzt und zum int konvertiert
            A = Convert.ToInt32(wert);     
            //B wird gleich dem zweiten operanden gesetzt, also einer zweioten beliebigen Zahl
            B = op2;                                                            
            do
            {
                //wenn der Rest von A/T gleich null ist, dann...
                if ((A % T == 0))                                                                                
                {
                    //wenn der Rest von A/B gleich null ist, dann...
                    if (B % T == 0)                                                                               
                    {
                        //setze G gleich T
                        G = T;                                                                                   
                    }
                }
                //T um 1 erhöhen
                T++;                     
            }
            //Abbruchbedingung
            while (T <= A && T <= B);                     
            //Rückgabe des gemeinsamen Teilers "G"
            return (Convert.ToInt32(G));                                                                                          
        }
        //Methode, die errechnet, ob der anfangs eingegebene Wert eine Primzahl ist
        public bool IstPrim()
        {
            //Initialieren und Deklarieren der Attribute
            long x = Convert.ToInt64(wert);
            long p = 3;
            bool Primzahl = false;

            //Bedingung, um Laufzeit zu verkürzen
            if (x % 2 == 0)
            {
                Primzahl = false;
            }
            else
            {

                while (Primzahl == false)
                {
                    //um die Laufzeit weiter zu verkürzern, wird geguckt ,ob p größer gleich der Wurzel lt. Heron Verfahren
                    if (p >= Heron())
                    {
                        Primzahl = true;
                        return Primzahl;
                    }
                    else if (x % p == 0)
                    {
                        Primzahl = false;
                        return Primzahl;
                    }
                    p = p+2;
                }
            }
            //Bool wird zurückgegeben
            return (Primzahl);
        }
        //Methode, die die Differenz des anfangs eingegebenen und beliebigen zweiten Wert errechnet
        public int Differenz(int op3)
        {
            //C wird initialisiert und deklariert
            int C = 0;
            //D wird initialisiert und deklariert
            int D = 0;
            //C wird gleich op3 gesetzt
            C = op3;
            //D wird gleich dem Ergebnis der Rechung zweiter beliebiger Wert - anfangs eingegebener Wert gesetzt
            D = (op3 - Convert.ToInt32(wert));
            //solange D kleiner als 0, dann...
            while (D < 0)
            {
                //rechne D * (-1)
                D = (D*(-1));
            }
            return (D);
        }
        public bool istWert(int op4)
        { 
            //Wahrheitswert "Gleichheit" wird auf falsch gesetzt
            bool Gleichheit = false;
            //wenn der anfangs eingegebene Wert gleich dem Operanden 4 also, dem zweiten beliebigen Wert, den man eingegeben hat, dann...
            if (wert == op4)
            {
                //Wahrheitswert wird auf "true" gesetzt.
                Gleichheit = true;
            }
            else
            {
                //Wahrheitswert wird auf false gesetzt"
                Gleichheit = false;
            }
            //Rückgabe des Wahrheitswertes
            return (Gleichheit);
        }
    }
}