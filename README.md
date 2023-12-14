# WerWirdMillionaer

Es soll ein Wer Wird Millionär Spiel sein, mit einer Datenbankanbindung.

NuGet Pakete um das Spiel zu Starten:
- MySql.Data

# Vorraussetzungen um das Spiel zu starten
- XAMPP Herunterladen (https://www.apachefriends.org/de/index.html)
- Über Localhost eine neue Datenbank mit dem Namen "wwm" Erstellen
- Die Datei aus dem Ordner "Database" Herunterladen
- Auf "wwm" drauf gehen, unter SQL oder Importieren den Inhalt oder Datei einfügen und ausführen

# Wie Funktioniert das Programm:
- Man loggt sich ein, Regristriert sich oder geht als Gast rein
  - Wenn man Gast ist wird man nicht in die Rangliste mit aufgenommen
- Wenn man auf dem Startbildschirm ist kann man zwischen "Neues Spiel, Optionen, Rangliste und Ausloggen" Entscheiden
  -   Neues Spiel: Man Startet eine Runde Wer Wird Millionär
  -   Optionen: Kann man nichts machen
  -   Rangliste: Man sieht die Besten Drei Spieler mit einem Namen, Einer Stufe und einer Zeit. Zudem Sieht man seine Eigene Platzierung
      -   Die Stufe ist wie Weit der Spieler gekommen ist
  -   Ausloggen: Man kommt zurück zum Einloggen, Regristieren oder als Gast Spielen
-   Wenn man eine Runde durch hat wird man Automatisch in die Rangliste integriert.
    -   Es wird zudem geguckt ob der höhere Highscore in die Rangliste eingetragen wird
  
