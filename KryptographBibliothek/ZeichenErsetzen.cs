using System;
using System.Collections.Generic;

namespace KryptographBibliothek
{
    public class ZeichenErsetzen
    {
        public static void Ersetzen()
        {
            string chiffre = "Kly ulbl KbhsZluzl Jvuayvssly pza pu Mburapvuzbtmhun buk Clyhyilpabun lpul rshyl Clyilzzlybun gbt KbhsZovjr 4, hsslykpunz mpls tpy kpl nlypunl Hrrb-Shbmglpa däoyluk klz Alzaz ulnhapc hbm, kpl cvy hsslt Jvyl Nhtly zaöylu küymal. Lilumhssz upjoa glpanltäß pza kpl Nyößl kly pualyulu Mlzawshaal, dlsjol upjoa 1 AI, zvuklyu uby 825 NI nyvß pza, cvu klulu dplklybt uby 667 NI nlubaga dlyklu röuulu, kh kly Ylza cvt Zfzalt ilslna dpyk. Pu Glpalu, pu klulu Zwplsl hbjo zjovuths ipz gb 100 NI nyvß zpuk, dlyklu oply zjoulss Wshagwyvisltl luazalolu. Kpl Rvuzvsl bualyzaüaga lydlpalyal Zwlpjolytönspjorlpalu pu Mvyt cvu BZI-Shbmdlyrlu, hsslykpunz röuulu oply uby WZ4-Zwplsl hbznlshnlya dlyklu. Kly pualyul Zwlpjoly rhuu müy WZ5-Zwplsl tpa ZZK-Lydlpalybunzrhyalu (khur T.2.-Zjoupaazalssl) clynyößlya dlyklu, hsslykpunz dpyk kplzlz Mlahbyl ilp Ylslhzl uvjo upjoa gby Clymünbunz zalolu, kluu lz pza lyza müy lpu gbrüumapnlz Bwkhal nlwshua. Lz islpia higbdhyalu, dpl zpjo kpl WZ5 pt Shunglpaalza zjoshnlu dpyk. Khur Hidäyazrvtwhapipspaäa, klu Shbujo-Apalsu buk klu Lersbzpc-Zwplslu khym hily qlaga zjovu nlyul tpa Zvufz Ulea-Nlu-Rvuzvsl nlspliäbnlsa dlyklu. ";
            
            
            Dictionary<string, double> tabellezeichen = new Dictionary<string, double>();

            Console.WriteLine("Deutsch Wahrschenilichkeiten buchstaben");

            tabellezeichen.Add("A",0.0558);
            tabellezeichen.Add("Ä", 0.0054);
            tabellezeichen.Add("B", 0.0196);
            tabellezeichen.Add("C", 0.0316);
            tabellezeichen.Add("D", 0.0498);
            tabellezeichen.Add("E", 0.1693);
            tabellezeichen.Add("F", 0.0149);
            tabellezeichen.Add("G", 0.0302);
            tabellezeichen.Add("H", 0.0498);
            tabellezeichen.Add("I", 0.0802);
            tabellezeichen.Add("J", 0.0024);
            tabellezeichen.Add("K", 0.0132);
            tabellezeichen.Add("L", 0.0360);
            tabellezeichen.Add("M", 0.0255);
            tabellezeichen.Add("N", 0.1053);
            tabellezeichen.Add("O", 0.0224);
            tabellezeichen.Add("Ö", 0.0030);
            tabellezeichen.Add("P", 0.0067);
            tabellezeichen.Add("Q", 0.0002);
            tabellezeichen.Add("R", 0.0689);
            tabellezeichen.Add("ß", 0.0037);
            tabellezeichen.Add("S", 0.0642);
            tabellezeichen.Add("T", 0.0579);
            tabellezeichen.Add("U", 0.0383);
            tabellezeichen.Add("Ü", 0.0065);
            tabellezeichen.Add("V", 0.0084);
            tabellezeichen.Add("W", 0.0178);
            tabellezeichen.Add("X", 0.0005);
            tabellezeichen.Add("Y", 0.0005);
            tabellezeichen.Add("Z", 0.0121);

            Console.WriteLine("Englich Wahrschenilichkeiten buchstaben");

            tabellezeichen.Add("A", 0.0834);
            tabellezeichen.Add("B", 0.0154);
            tabellezeichen.Add("C", 0.0273);
            tabellezeichen.Add("D", 0.0414);
            tabellezeichen.Add("E", 0.1260);
            tabellezeichen.Add("F", 0.0203);
            tabellezeichen.Add("G", 0.0192);
            tabellezeichen.Add("H", 0.0611);
            tabellezeichen.Add("I", 0.0671);
            tabellezeichen.Add("J", 0.0023);
            tabellezeichen.Add("K", 0.0087);
            tabellezeichen.Add("L", 0.0424);
            tabellezeichen.Add("M", 0.0253);
            tabellezeichen.Add("N", 0.0680);
            tabellezeichen.Add("O", 0.0770);
            tabellezeichen.Add("P", 0.0166);
            tabellezeichen.Add("Q", 0.0009);
            tabellezeichen.Add("R", 0.0568);
            tabellezeichen.Add("S", 0.0611);
            tabellezeichen.Add("T", 0.0937);
            tabellezeichen.Add("U", 0.0285);
            tabellezeichen.Add("V", 0.0106);
            tabellezeichen.Add("W", 0.0234);
            tabellezeichen.Add("X", 0.0020);
            tabellezeichen.Add("Y", 0.0204);
            tabellezeichen.Add("Z", 0.0006);

        }
    }
}
