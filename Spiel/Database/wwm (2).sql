-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 10. Dez 2023 um 22:22
-- Server-Version: 10.4.27-MariaDB
-- PHP-Version: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `wwm`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `fragen`
--

CREATE TABLE `fragen` (
  `ID` int(11) NOT NULL,
  `Frage` varchar(255) NOT NULL,
  `Antwort 1` varchar(60) NOT NULL,
  `Antwort 2` varchar(60) NOT NULL,
  `Antwort 3` varchar(60) NOT NULL,
  `Antwort 4` varchar(60) NOT NULL,
  `Richtige Antwort` int(2) NOT NULL,
  `Schwierigkeit` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `fragen`
--

INSERT INTO `fragen` (`ID`, `Frage`, `Antwort 1`, `Antwort 2`, `Antwort 3`, `Antwort 4`, `Richtige Antwort`, `Schwierigkeit`) VALUES
(1, 'Wie viele Bundesländer hat Deutschland?', '16', '8', '17', '18', 1, 1),
(2, 'Welche Farbe hat der Himmel an einem klaren Tag?', 'Rot', 'Grün', 'Blau', 'Gelb', 3, 1),
(3, 'Welche Zahl kommt nach der 3?', '2', '4', '6', '8', 2, 1),
(4, 'Welches Tier kann fliegen?', 'Hund', 'Katze', 'Vogel', 'Fisch', 3, 1),
(5, 'Was ist 2 + 2 *2?', '8', '6', '16', '4', 2, 1),
(6, 'Welche Jahreszeit kommt nach dem Sommer?', 'Frühling', 'Winter', 'Herbst', 'Sommer', 3, 1),
(7, 'Wie viele Finger hat eine Hand?', '3', '4', '5', '6', 3, 1),
(8, 'Welche der folgenden Tiere ist ein Reptil?', 'Elefant', 'Schlange', 'Delfin', 'Affe', 2, 1),
(9, 'Was ist die Hauptstadt von Frankreich?', 'Berlin', 'London', 'Paris', 'Rom', 3, 1),
(10, 'Welche Farbe haben Rosen normalerweise?', 'Blau', 'Gelb', 'Rot', 'Grün', 3, 1),
(11, 'Welches Instrument wird mit den Füßen gespielt?', 'Klavier', 'Geige', 'Schlagzeug', 'Flöte', 3, 1),
(12, 'Welches Gas benötigen Pflanzen für die Photosynthese?', 'Sauerstoff', 'Stickstoff', 'Wasserstoff', 'Kohlendioxid', 4, 2),
(13, 'Welches Tier wird oft als \"König des Dschungels\" bezeichnet?', 'Elefant', 'Löwe', 'Zebra', 'Giraffe', 2, 2),
(14, 'Wie viele Monate haben 28 Tage?', 'Nur 1', 'Alle 12', 'Keiner', 'Nur Februar', 2, 2),
(15, 'Welche Farbe hat die Null auf einem Standard-Rouletterad?', 'Rot', 'Grün', 'Blau', 'Keine Farbe ', 4, 2),
(16, 'Welches Land wird oft als \"Land der aufgehenden Sonne\" ', 'China', 'Indien', 'Japan', 'Australien', 3, 2),
(17, 'Welches Element hat die chemische Abkürzung \"Fe\"?', 'Eisen', 'Silber', 'Kupfer', 'Zink', 1, 2),
(18, 'Welcher Planet ist der vierte in unserem Sonnensystem?', 'Erde', 'Mars', 'Venus', 'Jupiter', 2, 2),
(19, 'Wer schrieb das Buch \"Romeo und Julia\"?', 'Charles Dickens', 'Mark Twain', 'William Shakespeare', 'Homer', 3, 2),
(20, 'Welches Tier ist ein Symbol für Weisheit?', 'Eule', 'Adler', 'Schlange', 'Löwe', 1, 2),
(21, 'Welche Farbe hat die Nationalflagge der Vereinigten Staaten ', 'Blau', 'Weiß', 'Rot', 'Blau, Weiß und Rot', 4, 2),
(22, 'Welches Land liegt südlich der USA?', 'Kanada', 'Mexiko', 'Kuba', 'Brasilien', 2, 3),
(23, 'Wie nennt man die festen Schichten der Erde, die aus Erdkrus', 'Ozonschicht', 'Litosphäre', 'Atmosphäre', 'Hydrosphäre', 2, 3),
(24, 'Wer war der erste Mensch im Weltraum?', 'Neil Armstrong', 'Yuri Gagarin', 'Buzz Aldrin', 'John Glenn', 2, 3),
(25, 'Wie nennt man die Studie von Sternen und dem Universum?', 'Geographie', 'Biologie', 'Astronomie', 'Geologie', 3, 3),
(26, 'Welches Tier ist das größte auf der Erde?', 'Elefant', 'Blauwal', 'Giraffe', 'Nashorn', 2, 3),
(27, 'In welchem Jahr wurde die Berliner Mauer errichtet?', '1945', '1955', '1961', '1971', 3, 3),
(28, 'Was ist die Hauptstadt von Kanada?', 'Vancouver', 'Montreal', 'Ottawa', 'Toronto', 3, 3),
(29, 'Welches chemische Element hat das Symbol \"Na\" im Periodensys', 'Natrium', 'Nickel', 'Neon', 'Kalzium', 1, 3),
(30, 'Welcher Planet wird oft als \"Morgenstern\" oder \"Abendstern\" ', 'Mars', 'Venus', 'Merkur', 'Jupiter', 2, 3),
(31, 'Welcher Fluss ist der längste auf der Welt?', 'Nil', 'Amazonas', 'Mississippi', 'Jangtsekiang', 1, 3),
(32, 'Welches chemische Element hat die Ordnungszahl 92 im Periodensystem?', 'Uran', 'Kalzium', 'Gold', 'Silber', 1, 4),
(33, 'Welche Hauptstadt liegt am Zusammenfluss der Flüsse Rhein und Main?', 'Paris', 'London', 'Berlin', 'Frankfurt am Main', 4, 4),
(34, 'Welcher Künstler schuf das berühmte Gemälde \"Die Nachtwache\"?', 'Leonardo da Vinci', 'Vincent van Gogh', 'Rembrandt van Rijn', 'Pablo Picasso', 3, 4),
(35, 'Welcher berühmte Physiker formulierte die Relativitätstheorie?', 'Isaac Newton', 'Galileo Galilei', 'Albert Einstein', 'Niels Bohr', 3, 4),
(36, 'Welcher Fluss fließt durch Kairo, die Hauptstadt Ägyptens?', 'Nil', 'Tigris', 'Euphrat', 'Jordan', 1, 4),
(37, 'Welches chemische Element hat das Symbol \"K\" im Periodensystem?', 'Kalium', 'Kupfer', 'Kohlenstoff', 'Krypton', 1, 4),
(38, 'In welcher Stadt befindet sich das Kolosseum?', 'Athen', 'Rom', 'Paris', 'Istanbul', 2, 4),
(39, 'Welches Buch beginnt mit den Worten \"Es war einmal in Amerika\" und wurde später verfilmt?', 'Moby-Dick', 'Der große Gatsby', 'Der Pate', 'Der Herr der Ringe', 3, 4),
(40, 'Welche Gase sind am häufigsten in der Erdatmosphäre?', 'Sauerstoff und Stickstoff', 'Kohlendioxid und Helium', 'Methan und Wasserstoff', 'Argon und Kohlenstoffdioxid', 1, 4),
(41, 'Wer war der erste Mensch, der offiziell den Südpol erreichte?', 'Roald Amundsen', 'Ernest Shackleton', 'Robert Falcon Scott', 'Edmund Hillary', 1, 4),
(42, 'Welche Wissenschaft befasst sich mit der Untersuchung von Fossilien?', 'Astronomie', 'Archäologie', 'Geologie', 'Botanik', 2, 5),
(43, 'Welches chemische Element hat das Symbol \"Pb\" im Periodensystem?', 'Blei', 'Phosphor', 'Bor', 'Beryllium', 1, 5),
(44, 'Wer schrieb das Buch \"Stolz und Vorurteil\"?', 'Charlotte Brontë', 'Emily Brontë', 'Jane Austen', 'Charles Dickens', 3, 5),
(45, 'Welcher Planet hat die größte Anzahl von Monden in unserem Sonnensystem?', 'Venus', 'Mars', 'Saturn', 'Uranus', 3, 5),
(46, 'Welche berühmte mathematische Konstante wird oft mit dem griechischen Buchstaben \"π\" dargestellt?', 'Euler\'sche Zahl', 'Goldener Schnitt', 'Pi', 'Quadratwurzel von 2', 3, 5),
(47, 'Welcher chemische Stoff ist für die Rostbildung an Eisen verantwortlich?', 'Wasser', 'Kohlendioxid', 'Sauerstoff', 'Salz', 3, 5),
(48, 'In welchem Jahr wurde die Unabhängigkeit der Vereinigten Staaten von Amerika erklärt?', '1769', '1776', '1789', '1812', 2, 5),
(49, 'Welcher berühmte Maler schuf das Gemälde \"Die Sternennacht\"?', 'Leonardo da Vinci', 'Michelangelo', 'Vincent van Gogh', 'Pablo Picasso', 3, 5),
(50, 'Welche chemische Verbindung ist für den Geruch von verfaulten Eiern verantwortlich?', 'Schwefelwasserstoff', 'Kohlendioxid', 'Methan', 'Ammoniak', 1, 5),
(51, 'Welcher US-Präsident ist auf dem Mount Rushmore verewigt?', 'Abraham Lincoln', 'Theodore Roosevelt', 'George Washington', 'Thomas Jefferson', 4, 5),
(52, 'Welches chemische Element hat die Ordnungszahl 53 im Periodensystem?', 'Iod', 'Eisen', 'Gold', 'Zinn', 1, 6),
(53, 'Welche berühmte Inselgruppe wurde im Zweiten Weltkrieg stark umkämpft und als \"Blutige Insel\" bekannt?', 'Hawaii', 'Falklandinseln', 'Guadalcanal', 'Bermuda', 3, 6),
(54, 'Wer schrieb das Buch \"Der Große Gatsby\"?', 'Ernest Hemingway', 'F. Scott Fitzgerald', 'Mark Twain', 'John Steinbeck', 2, 6),
(55, 'Wie nennt man die Studie der Vögel?', 'Herpetologie', 'Ornithologie', 'Ichthyologie', 'Entomologie', 2, 6),
(56, 'Welches chemische Element hat das Symbol \"Au\" im Periodensystem?', 'Silber', 'Gold', 'Aluminium', 'Kupfer', 3, 6),
(57, 'Welche Nation war die erste, die eine bemannte Raumsonde zum Mars schickte?', 'USA', 'Russland', 'China', 'Indien', 3, 6),
(58, 'Welches Tier ist das größte auf dem Land?', 'Elefant', 'Giraffe', 'Nashorn', 'Nilpferd', 2, 6),
(59, 'Welche chemische Verbindung ist für den sauren Geschmack von Zitronen verantwortlich?', 'Zitronensäure', 'Salzsäure', 'Essigsäure', 'Schwefelsäure', 1, 6),
(60, 'In welchem Jahr wurde die Berliner Mauer fallengelassen?', '1987', '1989', '1991', '1993', 2, 6),
(61, 'Wer war der erste Mensch, der den Mount Everest erfolgreich bestiegen hat?', 'Reinhold Messner', 'Sir Edmund Hillary', 'Tenzing Norgay', 'Maurice Herzog', 2, 6),
(62, 'Wer schrieb das epische Gedicht \"Die Ilias\"?', 'Ovid', 'Vergil', 'Homer', 'Herodot', 3, 7),
(63, 'Welcher Chemiker entwickelte das Periodensystem der Elemente?', 'Isaac Newton', 'Antoine Lavoisier', 'Dmitri Mendelejew', 'Linus Pauling', 3, 7),
(64, 'In welchem Jahr wurde die Europäische Union gegründet?', '1945', '1957', '1963', '1971', 2, 7),
(65, 'Welches Gas ist am häufigsten in der Erdatmosphäre?', 'Sauerstoff', 'Stickstoff', 'Kohlendioxid', 'Argon', 2, 7),
(66, 'Wer schrieb das Buch \"Der Steppenwolf\"?', 'Franz Kafka', 'Fyodor Dostoevsky', 'Hermann Hesse', 'James Joyce', 3, 7),
(67, 'Welcher Fluss fließt durch die Stadt Istanbul?', 'Tigris', 'Nil', 'Bosporus', 'Jordan', 3, 7),
(68, 'Welche wissenschaftliche Theorie besagt, dass alle Lebewesen sich durch natürliche Selektion entwickeln?', 'Mendelsche Vererbung', 'Darwin\'sche Evolutionstheorie', 'Relativitätstheorie', 'Quantenmechanik', 2, 7),
(69, 'Welcher Planet ist als der \"rote Planet\" bekannt?', 'Mars', 'Venus', 'Merkur', 'Jupiter', 1, 7),
(70, 'Welcher berühmte Maler schuf das Gemälde \"Die Geburt der Venus\"?', 'Sandro Botticelli', 'Leonardo da Vinci', 'Michelangelo', 'Raphael', 1, 7),
(71, 'Welche Nation war die erste, die eine Raumsonde auf die Rückseite des Mondes geschickt hat?', 'USA', 'Russland', 'China', 'Indien', 3, 7),
(72, 'Welches Element hat die chemische Ordnungszahl 79?', 'Silber', 'Gold', 'Quecksilber', 'Blei', 2, 8),
(73, 'Welcher Schriftsteller ist für sein Buch \"Krieg und Frieden\" bekannt?', 'Fjodor Dostojewski', 'Leo Tolstoi', 'Anton Tschechow', 'Ivan Turgenjew', 2, 8),
(74, 'Welches Land ist das größte der Welt nach Landfläche?', 'China', 'USA', 'Russland', 'Kanada', 3, 8),
(75, 'Welche der folgenden Elemente ist ein Edelgas?', 'Neon', 'Chlor', 'Schwefel', 'Eisen', 1, 8),
(76, 'Wer war der erste Mensch im Weltraum, der zweimal die Erde umkreiste?', 'Yuri Gagarin', 'Alan Shepard', 'John Glenn', 'Valentina Tereshkova', 2, 8),
(77, 'Welcher Fluss fließt durch Paris?', 'Themse', 'Seine', 'Donau', 'Rhein', 2, 8),
(78, 'Welches Buch beginnt mit den Worten \"In einem Loch im Boden, da lebte ein Hobbit\"?', '\"Harry Potter und der Stein der Weisen\"', '\"Die unendliche Geschichte\"', '\"Der Hobbit\"', '\"Der Herr der Ringe\"', 3, 8),
(79, 'Welcher US-Präsident war in der Zeit des Kalten Krieges maßgeblich an der Kubakrise beteiligt?', 'John F. Kennedy', 'Lyndon B. Johnson', 'Richard Nixon', 'Ronald Reagan', 1, 8),
(80, 'Welche Hauptstadt Europas wird auch als \"Stadt der Liebe\" bezeichnet?', 'Wien', 'Rom', 'Paris', 'Madrid', 3, 8),
(81, 'Welches chemische Element hat das Symbol \"Ag\" im Periodensystem?', 'Silizium', 'Argon', 'Silber', 'Aluminium', 3, 8),
(82, 'Welches Gas ist am hauptsächlichsten für den Treibhauseffekt auf der Erde verantwortlich?', 'Kohlendioxid', 'Methan', 'Stickstoffdioxid', 'Wasserdampf', 1, 9),
(83, 'Wer war der erste Mensch, der die Theorie der Relativität aufstellte?', 'Sir Isaac Newton', 'Albert Einstein', 'Niels Bohr', 'Max Planck', 2, 9),
(84, 'Welches Buch ist bekannt für seinen berühmten ersten Satz: \"Es war die beste der Zeiten, es war die schlechteste der Zeiten\"?', '\"Oliver Twist\"', '\"Jane Eyre\"', '\"Eine Weihnachtsgeschichte\"', '\"Eine Geschichte aus zwei Städten\"', 4, 9),
(85, 'Welcher Planet ist der größte in unserem Sonnensystem?', 'Venus', 'Jupiter', 'Saturn', 'Uranus', 2, 9),
(86, 'Welcher Chemiker wurde für seine Entdeckung des Periodensystems der Elemente mit dem Nobelpreis für Chemie ausgezeichnet?', 'Antoine Lavoisier', 'Dmitri Mendelejew', 'Linus Pauling', 'Marie Curie', 2, 9),
(87, 'Welches chemische Element hat die Ordnungszahl 6 im Periodensystem?', 'Kohlenstoff', 'Sauerstoff', 'Stickstoff', 'Wasserstoff', 1, 9),
(88, 'Welcher berühmte Astronom formulierte die nach ihm benannten Keplerschen Gesetze?', 'Galileo Galilei', 'Nicolaus Copernicus', 'Johannes Kepler', 'Isaac Newton', 3, 9),
(89, 'Welches Tier ist ein Symbol für Weisheit und wird oft als Eule dargestellt?', 'Adler', 'Falke', 'Eule', 'Uhu', 3, 9),
(90, 'Welcher berühmte Physiker entwickelte die allgemeine Relativitätstheorie?', 'Isaac Newton', 'Niels Bohr', 'Albert Einstein', 'Werner Heisenberg', 3, 9),
(91, 'Welches chemische Element hat die Ordnungszahl 92 im Periodensystem?', 'Uran', 'Thorium', 'Radium', 'Plutonium', 1, 9),
(92, 'Wer war der erste Mensch, der den Mount Everest ohne zusätzlichen Sauerstoff erfolgreich bestieg?', 'Reinhold Messner', 'Tenzing Norgay', 'Sir Edmund Hillary', 'Reinhold Messner', 1, 10),
(93, 'Welcher berühmte Astronom entwickelte das Hubble-Teleskop, das nach ihm benannt ist?', 'Edwin Hubble', 'Carl Sagan', 'Galileo Galilei', 'Johannes Kepler', 1, 10),
(94, 'Welcher Planet in unserem Sonnensystem hat die kürzeste Umlaufzeit um die Sonne?', 'Merkur', 'Venus', 'Erde', 'Mars', 1, 10),
(95, 'Welcher bekannte Naturforscher entwickelte die Theorie der natürlichen Auslese?', 'Charles Darwin', 'Gregor Mendel', 'Louis Pasteur', 'Alfred Wegener', 1, 10),
(96, 'Welche Hauptstadt wird oft als \"Stadt der sieben Hügel\" bezeichnet?', 'Rom', 'Athen', 'Istanbul', 'Lissabon', 1, 10),
(97, 'Welches Buch ist bekannt für den berühmten Satz \"Am Anfang schuf Gott Himmel und Erde\"?', '\"Die Bibel\"', '\"Der Koran\"', '\"Die Bhagavad Gita\"', '\"Der Talmud\"', 1, 10),
(98, 'Welches chemische Element hat die Ordnungszahl 29 im Periodensystem?', 'Silber', 'Zinn', 'Kupfer', 'Gold', 3, 10),
(99, 'Welches Tier ist der größte Primat der Welt?', 'Gorilla', 'Orang-Utan', 'Schimpanse', 'Mensch', 4, 10),
(100, 'Wer war der erste Mensch, der offiziell den Nordpol erreichte?', 'Roald Amundsen', 'Robert Peary', 'Frederick Cook', 'Ernest Shackleton', 2, 10),
(101, 'Welcher Chemiker ist für die Entwicklung des Periodensystems der Elemente bekannt?', 'Antoine Lavoisier', 'Dmitri Mendelejew', 'Linus Pauling', 'Marie Curie', 2, 10);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `highscore`
--

CREATE TABLE `highscore` (
  `ID` int(11) NOT NULL,
  `Stufe` int(11) NOT NULL,
  `username` varchar(255) NOT NULL,
  `Time` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `spieler`
--

CREATE TABLE `spieler` (
  `ID` int(11) NOT NULL,
  `name` varchar(30) NOT NULL,
  `nachname` varchar(30) NOT NULL,
  `username` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL,
  `email` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `fragen`
--
ALTER TABLE `fragen`
  ADD PRIMARY KEY (`ID`);

--
-- Indizes für die Tabelle `highscore`
--
ALTER TABLE `highscore`
  ADD PRIMARY KEY (`ID`);

--
-- Indizes für die Tabelle `spieler`
--
ALTER TABLE `spieler`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `fragen`
--
ALTER TABLE `fragen`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=102;

--
-- AUTO_INCREMENT für Tabelle `highscore`
--
ALTER TABLE `highscore`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=55;

--
-- AUTO_INCREMENT für Tabelle `spieler`
--
ALTER TABLE `spieler`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
