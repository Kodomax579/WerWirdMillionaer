
-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 01. Nov 2023 um 11:53
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
-- Tabellenstruktur fÃ¼r Tabelle `fragen`
--

CREATE TABLE `fragen` (
  `ID` int(11) NOT NULL,
  `Frage` varchar(60) NOT NULL,
  `Antowrt 1` varchar(60) NOT NULL,
  `Antwort 2` varchar(60) NOT NULL,
  `Antwort 3` varchar(60) NOT NULL,
  `Antwort 4` varchar(60) NOT NULL,
  `Richtige Antwort` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tabellenstruktur fÃ¼r Tabelle `highscore`
--

CREATE TABLE `highscore` (
  `ID` int(11) NOT NULL,
  `Zeit` varchar(10) NOT NULL,
  `Stufe` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tabellenstruktur fÃ¼r Tabelle `spieler`
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
-- Daten fÃ¼r Tabelle `spieler`
--

INSERT INTO `spieler` (`ID`, `name`, `nachname`, `username`, `password`, `email`) VALUES
(1, 'Carsten', 'Engelhardt', 'Kodomax', 'PolizeiAuto', 'engelhardtcarsten00@gmail.com'),
(11, 'Alex', 'Leder', 'Leadz', 'Alex', 'Alexleder@gmail.com');

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes fÃ¼r die Tabelle `fragen`
--
ALTER TABLE `fragen`
  ADD PRIMARY KEY (`ID`);

--
-- Indizes fÃ¼r die Tabelle `highscore`
--
ALTER TABLE `highscore`
  ADD PRIMARY KEY (`ID`);

--
-- Indizes fÃ¼r die Tabelle `spieler`
--
ALTER TABLE `spieler`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT fÃ¼r exportierte Tabellen
--

--
-- AUTO_INCREMENT fÃ¼r Tabelle `fragen`
--
ALTER TABLE `fragen`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT fÃ¼r Tabelle `highscore`
--
ALTER TABLE `highscore`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT fÃ¼r Tabelle `spieler`
--
ALTER TABLE `spieler`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
GO

--Syntaxfehler: Falsche Syntax in der Nähe von '`'.
---- phpMyAdmin SQL Dump
---- version 5.2.0
---- https://www.phpmyadmin.net/
----
---- Host: 127.0.0.1
---- Erstellungszeit: 01. Nov 2023 um 11:53
---- Server-Version: 10.4.27-MariaDB
---- PHP-Version: 8.2.0
--
--SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
--START TRANSACTION;
--SET time_zone = "+00:00";
--
--
--/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
--/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
--/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
--/*!40101 SET NAMES utf8mb4 */;
--
----
---- Datenbank: `wwm`
----
--
---- --------------------------------------------------------
--
----
---- Tabellenstruktur fÃ¼r Tabelle `fragen`
----
--
--CREATE TABLE `fragen` (
--  `ID` int(11) NOT NULL,
--  `Frage` varchar(60) NOT NULL,
--  `Antowrt 1` varchar(60) NOT NULL,
--  `Antwort 2` varchar(60) NOT NULL,
--  `Antwort 3` varchar(60) NOT NULL,
--  `Antwort 4` varchar(60) NOT NULL,
--  `Richtige Antwort` int(1) NOT NULL
--) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
--
---- --------------------------------------------------------
--
----
---- Tabellenstruktur fÃ¼r Tabelle `highscore`
----
--
--CREATE TABLE `highscore` (
--  `ID` int(11) NOT NULL,
--  `Zeit` varchar(10) NOT NULL,
--  `Stufe` int(2) NOT NULL
--) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
--
---- --------------------------------------------------------
--
----
---- Tabellenstruktur fÃ¼r Tabelle `spieler`
----
--
--CREATE TABLE `spieler` (
--  `ID` int(11) NOT NULL,
--  `name` varchar(30) NOT NULL,
--  `nachname` varchar(30) NOT NULL,
--  `username` varchar(30) NOT NULL,
--  `password` varchar(30) NOT NULL,
--  `email` varchar(40) NOT NULL
--) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
--
----
---- Daten fÃ¼r Tabelle `spieler`
----
--
--INSERT INTO `spieler` (`ID`, `name`, `nachname`, `username`, `password`, `email`) VALUES
--(1, 'Carsten', 'Engelhardt', 'Kodomax', 'PolizeiAuto', 'engelhardtcarsten00@gmail.com'),
--(11, 'Alex', 'Leder', 'Leadz', 'Alex', 'Alexleder@gmail.com');
--
----
---- Indizes der exportierten Tabellen
----
--
----
---- Indizes fÃ¼r die Tabelle `fragen`
----
--ALTER TABLE `fragen`
--  ADD PRIMARY KEY (`ID`);
--
----
---- Indizes fÃ¼r die Tabelle `highscore`
----
--ALTER TABLE `highscore`
--  ADD PRIMARY KEY (`ID`);
--
----
---- Indizes fÃ¼r die Tabelle `spieler`
----
--ALTER TABLE `spieler`
--  ADD PRIMARY KEY (`ID`);
--
----
---- AUTO_INCREMENT fÃ¼r exportierte Tabellen
----
--
----
---- AUTO_INCREMENT fÃ¼r Tabelle `fragen`
----
--ALTER TABLE `fragen`
--  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;
--
----
---- AUTO_INCREMENT fÃ¼r Tabelle `highscore`
----
--ALTER TABLE `highscore`
--  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;
--
----
---- AUTO_INCREMENT fÃ¼r Tabelle `spieler`
----
--ALTER TABLE `spieler`
--  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
--COMMIT;
--
--/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
--/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
--/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;



GO
