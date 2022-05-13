using System;

namespace KryptographBibliothek
{
    public class ZeichenEntfernen
    {
        public static void Entfernen()
        {
            bool wiederholen = false;
            do
            {
                string chiffre = "Kly ulbl KbhsZluzl Jvuayvssly pza pu Mburapvuzbtmhun buk Clyhyilpabun lpul rshyl Clyilzzlybun gbt KbhsZovjr 4, hsslykpunz mpls tpy kpl nlypunl Hrrb-Shbmglpa däoyluk klz Alzaz ulnhapc hbm, kpl cvy hsslt Jvyl Nhtly zaöylu küymal. Lilumhssz upjoa glpanltäß pza kpl Nyößl kly pualyulu Mlzawshaal, dlsjol upjoa 1 AI, zvuklyu uby 825 NI nyvß pza, cvu klulu dplklybt uby 667 NI nlubaga dlyklu röuulu, kh kly Ylza cvt Zfzalt ilslna dpyk. Pu Glpalu, pu klulu Zwplsl hbjo zjovuths ipz gb 100 NI nyvß zpuk, dlyklu oply zjoulss Wshagwyvisltl luazalolu. Kpl Rvuzvsl bualyzaüaga lydlpalyal Zwlpjolytönspjorlpalu pu Mvyt cvu BZI-Shbmdlyrlu, hsslykpunz röuulu oply uby WZ4-Zwplsl hbznlshnlya dlyklu. Kly pualyul Zwlpjoly rhuu müy WZ5-Zwplsl tpa ZZK-Lydlpalybunzrhyalu (khur T.2.-Zjoupaazalssl) clynyößlya dlyklu, hsslykpunz dpyk kplzlz Mlahbyl ilp Ylslhzl uvjo upjoa gby Clymünbunz zalolu, kluu lz pza lyza müy lpu gbrüumapnlz Bwkhal nlwshua. Lz islpia higbdhyalu, dpl zpjo kpl WZ5 pt Shunglpaalza zjoshnlu dpyk. Khur Hidäyazrvtwhapipspaäa, klu Shbujo-Apalsu buk klu Lersbzpc-Zwplslu khym hily qlaga zjovu nlyul tpa Zvufz Ulea-Nlu-Rvuzvsl nlspliäbnlsa dlyklu. ";
                Console.WriteLine("Das ist Ihre aktuelle chiffre.\n");
                Console.WriteLine(chiffre);
                Console.WriteLine("\nACHTUNG!!\nGeben Sie ein, welche Zeichen von der Dechiffrierung ausgeschlossen werden sollen. Beispiel: Leerzeile, Komma usw.");
                Console.WriteLine("Ihr Zeichen eintippen, anschließend 'Enter' drücken, um Ihre Eingabe zu speichern.");
                string Eingabe = Console.ReadLine();

                chiffre = chiffre.Replace(Eingabe.ToLower(), "");
                chiffre = chiffre.Replace(Eingabe.ToUpper(), "");
                Console.WriteLine(chiffre);

                Console.WriteLine("\n\nWenn Sie weitere Zeichen ausschließen wollen, tippen Sie 'Ja' ein. Wenn sie zum nächsten Verfahren gehen möchten, schreiben Sie 'Nein'.");
                string str_wiederholen = Console.ReadLine();
                switch (str_wiederholen)
                {
                    case "Ja":
                        Console.Clear();
                        wiederholen = true;
                        break;
                    default:
                        break;
                }
                // Problem, dass beim Wiederholen der normale Text da ist

            } while (wiederholen == true);
        }
    }
}
