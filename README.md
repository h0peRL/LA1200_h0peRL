# NumberGuesser Game in C# / Wie ertselle ich if/else statements?
### Aufgabenstellung und Ziele 
##### Aufgabenstellung :
1. Der Computer generiert eine Zufallszahl zwischen 1 - 100 und speichert diese.
2. Der Benutzer soll die Zahl erraten können.
3. Für jede geratene Zahl wird etwas ausgegeben:
    a) Die geratene Zahl ist niedriger als die Geheimzahl.  
    b) Die geratene Zahl ist grösser als die Geheimzahl.
    c) Die Geheimzahl wurde erraten. 
4. Wenn die Zahl erraten wurde, soll die Anzahl versuche ausgegeben werden.
5. Das Programm soll mit Fehleingaben umgehen oder sie vermeiden können.

##### Ziele : 
1. Der Leser soll if/else Codes verstehen können und wissen wofür man sie verwendet.
2. Dem Leser zeigen, wie man if/else Codes korrekt schreibt.
3. Der Leser soll nach diesem Eintrag wissen wie man if/else Codes verwendet.

### Inhalt 1
If/else statements werden verwendet um eine Verweigungungen in einem Proghramm zu erstellen. Sie sind die meistverwendeten Codes für Verzweigungen. Andere Arten um Verzweigungen zu schreiben ist z.B ein switch/case, jedoch sind if/else statements einfacher zu verstehen.

Da wir nun Wissen wie man sie verwendet, kommen wir nun zum Aufbau:
```
_______________________________________________________________________________________________

if (dashier zu triffft)
{
    //mach dashier
}

_______________________________________________________________________________________________

else if (dashier zu trifft) //wenn das obere nicht zutrifft
{
    // mach dashier
}

_______________________________________________________________________________________________

else   //wenn alles obere nicht zutrifft
{
    //mach dashier
}
_______________________________________________________________________________________________
```

So sieht der Aufbau eines if/else statements aus.
### Inhalt 2    
Um einen weiteren Einblick zu erhalten wie dies aussieht, ist hier ein Bild aus einer praktischen Anwendung.
![](https://cdn.discordapp.com/attachments/669155152468377610/890141946700496936/Screen_Portfolio.png)
So sieht es in der Konsole aus:

Im 1. wird überprüft, ob eine Eingabe Zahlen enthält.
Im 2. wird überprüft, ob die eingegebene Zahl kleiner ist als die Zufallszahl.
Im 3. wird überprüft, ob die eingegebene Zahl grösser ist als die Zufallszahl.
Im 4. kann nur noch überprüft werden, ob die eingegebene Zahl gleich ist wie die Zufallszahl. Deswegen ist diese in einem else statement.

Je nach statement, werden andere Texte ausgegeben.

### Inhalt 3
Ein Video könnte helfen:
[Video](https://www.youtube.com/watch?v=sc96iSCEwok)
### Verifikation + Reflektion
Ziel 1,2 und 3: Dominik hat meinen Eintrag verstanden und konnte in einem eigenen Programm if/else statements verwenden.

--> Das Projekt ist ziemlich gut gelaufen. Ich hatte keine Probleme während des Projektes mit if/else statements. Das einzige negaive ist, das ich go to Befehle in meinem Projekt verwendet habe, jedoch betrifft das nicht die if/else statements.
