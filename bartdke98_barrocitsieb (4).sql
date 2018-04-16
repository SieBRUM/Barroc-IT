-- phpMyAdmin SQL Dump
-- version 4.5.0.2
-- http://www.phpmyadmin.net
--
-- Host: 10.3.0.185
-- Gegenereerd op: 09 nov 2016 om 19:02
-- Serverversie: 5.6.29
-- PHP-versie: 5.5.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bartdke98_barrocitsieb`
--

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `tbl_appointments`
--

CREATE TABLE `tbl_appointments` (
  `appointment_id` int(11) NOT NULL,
  `customer_id` int(11) NOT NULL,
  `appointment_datetime` varchar(255) NOT NULL,
  `appointment_residence` varchar(20) NOT NULL,
  `appointment_streetname` varchar(20) NOT NULL,
  `appointment_housenumber` int(11) NOT NULL,
  `appointment_zipcode` varchar(6) NOT NULL,
  `appointment_made` date NOT NULL,
  `appointment_summary` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Gegevens worden geëxporteerd voor tabel `tbl_appointments`
--

INSERT INTO `tbl_appointments` (`appointment_id`, `customer_id`, `appointment_datetime`, `appointment_residence`, `appointment_streetname`, `appointment_housenumber`, `appointment_zipcode`, `appointment_made`, `appointment_summary`) VALUES
(9, 4, '13-1-2017 11:33:47', 'Sint Heerhugowaard', 'Wegenweg', 13, '4652GB', '2016-11-02', ''),
(10, 4, '11-2-2017 11:33:47', 'Oosterhout', 'Joopiestraat', 12, '4892CA', '2016-11-03', 'Gutentag!'),
(11, 4, '16-2-2017 14:16:19', 'Klaasdorpjes', 'straatnaam', 19, '3901cj', '2016-11-05', 'postcode klopt niet'),
(12, 4, '14-4-2017 09:43:56', 'Sint Heerhugowaard', 'Wegenweg', 13, '4652GB', '2016-11-07', 'Ik ga wat thee drinken'),
(13, 20, '7-12-2016 12:00:47', 'Zevenbergen', 'Watermolen', 11, '4761GR', '2016-11-07', 'Ik ga ook wat thee drinken'),
(14, 20, '3-12-2016 12:36:01', 'Zevenbergen', 'Watermolen', 11, '4761GR', '2016-11-07', '24 hoi martijn :P'),
(15, 8, '25-11-2016 20:36:12', 'Oosterhout', 'Cringestreet', 53, '3256AB', '2016-11-08', 'Kenlehhh'),
(16, 10, '30-11-2016 09:34:46', 'aaaaa', 'aaaa', 0, 'aaaa', '2016-11-09', 'testing');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `tbl_customers`
--

CREATE TABLE `tbl_customers` (
  `customer_id` int(11) NOT NULL,
  `first_name` varchar(20) NOT NULL,
  `last_name` varchar(30) NOT NULL,
  `company_name` varchar(30) DEFAULT NULL,
  `street_name` varchar(30) NOT NULL,
  `street_name_2` varchar(30) DEFAULT NULL,
  `house_number` varchar(11) NOT NULL,
  `house_number_2` varchar(11) DEFAULT NULL,
  `residence` varchar(30) NOT NULL,
  `residence_2` varchar(30) DEFAULT NULL,
  `zip_code` varchar(6) NOT NULL,
  `zip_code_2` varchar(6) DEFAULT NULL,
  `phone_number` varchar(11) NOT NULL,
  `phone_number_2` varchar(11) DEFAULT NULL,
  `email` varchar(255) NOT NULL,
  `fax` varchar(11) DEFAULT NULL,
  `iban` varchar(18) NOT NULL,
  `credit_balance` int(11) NOT NULL,
  `creditworthy` tinyint(2) NOT NULL,
  `gross_revenue` int(11) NOT NULL,
  `prospect` tinyint(2) NOT NULL,
  `discount` int(99) NOT NULL,
  `last_contact` date NOT NULL,
  `last_action` varchar(255) NOT NULL,
  `next_contact` date NOT NULL,
  `next_action` varchar(255) NOT NULL,
  `limit` int(11) NOT NULL,
  `bankAccount` varchar(18) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Gegevens worden geëxporteerd voor tabel `tbl_customers`
--

INSERT INTO `tbl_customers` (`customer_id`, `first_name`, `last_name`, `company_name`, `street_name`, `street_name_2`, `house_number`, `house_number_2`, `residence`, `residence_2`, `zip_code`, `zip_code_2`, `phone_number`, `phone_number_2`, `email`, `fax`, `iban`, `credit_balance`, `creditworthy`, `gross_revenue`, `prospect`, `discount`, `last_contact`, `last_action`, `next_contact`, `next_action`, `limit`, `bankAccount`) VALUES
(4, 'Berend', 'Jan', 'CompanyBV', 'Wegenweg', 'Street', '13', '15', 'Sint Heerhugowaard', NULL, '4652GB', NULL, '0653216498', NULL, 'berend@jan.nl', NULL, 'NL94RABO01294857', 500, 1, 5000000, 1, 50, '2016-10-01', 'geslagen', '2016-10-18', 'neerknuppelen', 50, ''),
(5, 'Abdelrani', 'Elbuazati', 'WizardCompany', 'machinistenstraat', NULL, '12', NULL, 'Breda', NULL, '4902cj', NULL, '0662916481', NULL, 'siebrenkraak@hotmail.com', NULL, 'NL39RABO0300065264', 200, 1, 2000000, 1, 0, '2016-10-20', 'koffie', '2017-01-20', 'melk', 2000000, ''),
(6, 'Diederik', 'Berend', 'DBBV', 'Fietsenmakersstraat', 'Machinistenweg', '690', '3', 'Fietsenmakershoek', 'Machinistendorp', '6666GG', '1234AB', '0632154628', '0631206489', 'info@dbbv.nl', '168320615', '', 0, 0, 0, 0, 0, '2016-01-01', 'Gebeld', '2016-10-19', 'Nog maar eens bellen', 0, ''),
(7, 'Kenley', 'Strik', '', 'Cringestreet', '', '53', '', 'Oosterhout', '', '3256AB', '', '0163201350', '', 'ItsyaboyKenley@hotmail.com', '0', '', 0, 0, 0, 0, 0, '2016-10-18', 'Met hem gepraat', '2016-10-19', 'Praten met Kenlehhhh', 0, ''),
(8, 'Kenley', 'Strik', 'KenleyFixIt inc.', 'Cringestreet', '', '53', '', 'Oosterhout', '', '3256AB', '', '0163201350', '', 'ItsyaboyKenley@hotmail.com', '0', '', 0, 1, 0, 0, 0, '2016-10-18', 'Met hem gepraat', '2016-10-19', 'Praten met Kenlehhhh', 0, ''),
(10, 'aaaaa', 'aaaaaa', 'aaaaaqa', 'aaaa', '', '0', '', 'aaaaa', 'aaaaaaa', 'aaaa', 'aaaaaa', '0632012568', '', 'aa', '0', '', 0, 1, 0, 0, 0, '2016-10-18', 'aaaaa', '2016-10-18', 'aaaaa', 0, ''),
(11, 'b', 'bb', 'b', 'b', 'Willemstraat', '103', '0', 'b', 'b', 'b', 'bb', '0134621549', '0634216295', 'b', '0', '', 0, 1, 0, 0, 0, '2016-10-18', 'b', '2016-10-18', 'b', 0, ''),
(12, 'ik ', 'ben', 'heel', 'erg', 'VissenStraat', '12', '0', 'eressant', 'nog', 'omdat', 'niet', '0632164597', '0632514978', 'is', '0', '', 0, 0, 0, 0, 0, '2016-10-18', 'dat', '2016-10-18', 'iszo', 0, ''),
(13, 'Jan', 'Metdelangeachternaam', '', 'doormanstraat', '', '18', '', 'Bavel', '', '5102XM', '', '0612345678', '', 'janmetdelangeachternaam@homtail.com', '0', '', 0, 0, 0, 0, 0, '2016-10-19', 'gebeld', '2016-10-19', 'mailen', 0, ''),
(14, 'Vis', 'Vis', 'Vis', 'Vis', '', '0', '', 'Vis', '', 'Vis', 'Vis', '0632989657', '0613264857', 'Vis', '0', '', 0, 0, 0, 0, 0, '2017-02-16', 'Vis', '2017-01-14', 'Vis', 0, ''),
(15, 'Ben', 'Strik', 'MAND BV', 'Mandstraat', '', '12', '', 'Makkum', '', '5555AB', '', '0168320618', '', 'MAND@makkum.com', '0', '', 0, 0, 0, 0, 0, '2016-10-18', 'Gebeld', '2016-11-06', 'Interview', 0, ''),
(16, 'd', 'd', 'd', 'd', 'JoostLaan', '8321', '0', 'd', 'd', 'd', 'd', '0763216405', '', 'd', '0', '', 0, 0, 0, 0, 0, '2016-10-12', 'd', '2016-11-27', 'd', 0, ''),
(17, 'de', 'de', 'de', 'de', 'Straatnaam', '12', '0', 'de', 'de', 'de', 'de', '0105326057', '', 'de', '0', '', 0, 0, 0, 0, 0, '2016-11-29', 'de', '2016-11-27', 'de', 0, ''),
(18, 'Jeremy', 'Smits', 'Smits Incorporated', 'De wallen', 'DankStreet', '69', '0', 'Oosterhout', '', '6969XD', '', '0654320125', '', 'ItsyaboyJeremy@hotmail.com', '0', '12', 12, 1, 12, 1, 12, '2016-11-03', 'Niks', '2016-11-18', 'Niks', 12, ''),
(19, 'Levi', 'Vlasblom', 'Lemaly', 'Krommebeemd', 'Krommebeemd', '52', '33', 'Oosterhout', 'Oosterhout', '1234AB', '1234AB', '0632012312', '0632154678', 'levi_vlasblom@hotmail.be', '163250164', '', 0, 0, 0, 0, 0, '2016-11-07', 'Gebeld', '2016-11-10', 'Mailen', 0, ''),
(20, 'Martijn', 'van der Linden', 'Sasima BV', 'Watermolen', '', '11', '', 'Zevenbergen', '', '4761GR', '', '0654686218', '', 'm-vd-linden@hotmail.com', '0', 'NL39 RABO 0300 065', 239012, 1, 731287, 1, 69, '2016-11-07', 'Gesproken', '2016-11-23', 'Afspraak inplannen', 731287, ''),
(21, 'Antonio', 'Hart', 'O''Keefe, Beer and Mraz', 'Westend', 'Forest', '443', '11545', 'Eydhafushi', '2', '9472', NULL, '960-(572)79', '63-(410)488', 'ahart0@mail.ru', '62-(828)575', 'FR26 6369 4916 41J', 291720678, 1, 220988434, 1, 40, '2016-02-14', 'vitae quam', '2016-03-23', 'praesent blandit lacinia', 39201146, ''),
(22, 'Frank', 'Washington', 'Schroeder and Sons', 'Superior', 'Northfield', '8', '65949', 'Dayou', '52548', '5293', NULL, '86-(566)149', '351-(257)47', 'fwashington1@wufoo.com', '86-(249)565', 'ES19 9346 1178 596', 697244133, 1, 53941367, 1, 49, '2015-09-03', 'sem', '2016-04-23', 'in blandit ultrices', 56762997, ''),
(23, 'Patrick', 'Ramos', 'Dietrich-Hayes', 'Westerfield', 'Bobwhite', '3', '05', 'Glencoe', '8', '9211', NULL, '27-(861)994', '372-(752)61', 'pramos2@fda.gov', '850-(910)38', 'CH72 0344 1CVE 1SW', 796675088, 1, 719157443, 0, 11, '2016-02-01', 'orci', '2016-05-08', 'in quam fringilla', 68203355, ''),
(24, 'Edward', 'Gutierrez', 'Hansen, Greenholt and Vandervo', 'Kennedy', 'Hanson', '404', '48', 'Suwalan', '094', '1620', NULL, '62-(242)395', '86-(388)520', 'egutierrez3@boston.com', '7-(744)455-', 'RS22 9668 8833 291', 909749833, 1, 8094462, 0, 43, '2016-02-26', 'magna', '2016-03-29', 'pede', 55845395, ''),
(25, 'Sean', 'Henderson', 'Pagac-Kris', 'Dahle', 'Buell', '3151', '53', 'Samann?d', '2', '7382', NULL, '20-(453)491', '86-(733)575', 'shenderson4@constantcontact.com', '996-(556)50', 'FR84 7683 2299 786', 694618352, 1, 149240813, 0, 26, '2015-12-24', 'rhoncus mauris', '2016-01-05', 'id justo', 52118942, ''),
(26, 'Karen', 'Hart', 'Friesen, Grant and Wehner', 'Eagan', 'Veith', '9546', '70', 'Arroio Grande', '2', '9205', NULL, '55-(685)211', '81-(762)924', 'khart5@miitbeian.gov.cn', '62-(378)389', 'KW83 QBBB 8WYY SG6', 832675103, 0, 879464343, 1, 37, '2016-09-25', 'felis sed', '2016-05-27', 'velit id pretium', 87224864, ''),
(27, 'Ralph', 'Stephens', 'Kiehn Inc', 'Logan', 'Burrows', '16', '1', 'Sembungan Kidul', '40553', '8050', NULL, '62-(536)616', '86-(802)854', 'rstephens6@amazon.co.uk', '86-(568)503', 'PT92 0785 1836 588', 148430981, 0, 877777400, 0, 36, '2016-08-20', 'nulla suspendisse potenti', '2016-07-02', 'tortor', 89339014, ''),
(28, 'Jane', 'Ellis', 'Lockman-Crist', 'Scott', 'Darwin', '9579', '07', 'Baranusa', '4', '6935', NULL, '62-(966)115', '7-(804)403-', 'jellis7@artisteer.com', '62-(814)612', 'BG09 CGHU 7180 57F', 387992072, 1, 465919789, 1, 58, '2015-11-20', 'vitae ipsum aliquam', '2015-09-22', 'consequat', 3063498, ''),
(29, 'Julie', 'Thompson', 'Koch-Sanford', 'Butternut', 'Macpherson', '6', '77', 'Rosebank', '69', '6864', NULL, '27-(585)721', '86-(661)830', 'jthompson8@globo.com', '502-(801)44', 'AL76 1673 0485 WYE', 482126451, 0, 597540217, 0, 17, '2016-05-18', 'cras in', '2016-06-05', 'ridiculus mus', 12548708, ''),
(30, 'Roger', 'Taylor', 'Brakus-Langworth', 'American', NULL, '2', '300', 'Tuguan', '0', '1284', NULL, '86-(533)711', '86-(656)152', 'rtaylor9@cam.ac.uk', '381-(232)20', 'LV09 CBFD O0YZ KEW', 62076574, 1, 123161459, 0, 94, '2015-08-11', 'dui vel', '2016-10-17', 'orci', 72851230, '');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `tbl_invoices`
--

CREATE TABLE `tbl_invoices` (
  `invoice_id` int(11) NOT NULL,
  `project_id` int(11) NOT NULL,
  `ledger_account_number` int(11) NOT NULL,
  `VAT` int(99) NOT NULL,
  `status` tinyint(1) NOT NULL,
  `count` int(11) DEFAULT NULL,
  `total_price` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Gegevens worden geëxporteerd voor tabel `tbl_invoices`
--

INSERT INTO `tbl_invoices` (`invoice_id`, `project_id`, `ledger_account_number`, `VAT`, `status`, `count`, `total_price`) VALUES
(1, 9, 0, 99, 1, 0, 500),
(3, 9, 0, 21, 1, NULL, 500),
(4, 40, 0, 21, 0, NULL, 999);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `tbl_notification`
--

CREATE TABLE `tbl_notification` (
  `notification_id` int(11) NOT NULL,
  `notification_type` varchar(255) NOT NULL,
  `notification_date` date NOT NULL,
  `notification_info` varchar(255) NOT NULL,
  `notification_resolved` tinyint(2) NOT NULL,
  `notification_department` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Gegevens worden geëxporteerd voor tabel `tbl_notification`
--

INSERT INTO `tbl_notification` (`notification_id`, `notification_type`, `notification_date`, `notification_info`, `notification_resolved`, `notification_department`) VALUES
(1, 'Creditworthy check', '2016-10-31', 'Customer Ben needs to be checked on creditworthyness', 1, 'Finance'),
(2, 'Creditworthy check', '2016-11-02', 'Customer d needs to be checked on creditworthyness', 0, 'Finance'),
(3, 'Creditworthy check', '2016-11-02', 'Customer de needs to be checked on creditworthyness', 0, 'Finance'),
(4, 'Creditworthy check', '2016-11-03', 'Customer Jeremy needs to be checked on creditworthyness', 0, 'Finance'),
(5, 'Creditworthy check', '2016-11-07', 'Customer Levi needs to be checked on creditworthyness.', 0, 'Finance'),
(6, 'Add financial details', '2016-11-07', 'Customer Levi needs his financial details to be added', 0, 'Finance'),
(7, 'Creditworthy check', '2016-11-07', 'Customer Martijn needs to be checked on creditworthyness.', 0, 'Finance'),
(8, 'Add financial details', '2016-11-07', 'Customer Martijn needs his financial details to be added', 0, 'Finance');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `tbl_projects`
--

CREATE TABLE `tbl_projects` (
  `project_id` int(11) NOT NULL,
  `customer_id` int(11) NOT NULL,
  `project_name` varchar(255) NOT NULL,
  `project_status` tinyint(5) NOT NULL,
  `operating_system` varchar(255) NOT NULL,
  `software` varchar(255) NOT NULL,
  `hardware` varchar(255) NOT NULL,
  `amount_invoice` int(11) NOT NULL,
  `contact_person` varchar(20) NOT NULL,
  `maintenance_contract` tinyint(5) NOT NULL,
  `deadline_date` date NOT NULL,
  `profit` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Gegevens worden geëxporteerd voor tabel `tbl_projects`
--

INSERT INTO `tbl_projects` (`project_id`, `customer_id`, `project_name`, `project_status`, `operating_system`, `software`, `hardware`, `amount_invoice`, `contact_person`, `maintenance_contract`, `deadline_date`, `profit`) VALUES
(9, 4, 'Destiny IT', 1, 'Linux', 'Skype,TextEditor', '', 12, 'J. R. van Laars', 1, '2016-10-17', 0),
(12, 4, 'Recreate Google.com', 1, 'ALL', 'Google Chrome', 'Laptop i7 swoogedy', 3, 'J. R. van Laars', 1, '2017-01-25', 0),
(13, 4, 'Text Editor v2.1', 1, 'Linux', 'Skype For Buinsness', '', 13, 'B.R.A. Moonen', 1, '2017-06-30', 0),
(14, 4, 'Magic Mike WebGame', 1, 'Windows 7+', 'Magical Editor', '', 31, 'M.M. Kleermakers', 1, '2024-07-12', 0),
(15, 4, 'Fietsenmaker website', 1, 'Windows XP', 'Fietsbanden Zoeker', '', 19, 'B. Andenmaker', 1, '2016-11-25', 0),
(16, 4, 'NS App', 1, 'Windows XP', 'NS Voice Actor', '', 12, 'R. Maas', 1, '2017-01-04', 0),
(17, 4, 'Geo Calculator', 1, 'Dorit-OS', 'NaN', '', 21, 'Z. Klaassen', 1, '2017-05-19', 0),
(18, 4, 'Kappa IT', 0, 'Windows 10', 'Skype\r\nChrome\r\nMachinist', '', 12, 'J. R. van Laars', 0, '2017-01-26', 0),
(20, 5, 'Testerino', 0, 'Windows 10', 'Skype', '', 12, 'J. R. van Laars', 1, '2016-12-10', 0),
(21, 4, 'Forbidden Market', 3, 'Windows 10', 'Skype, Chrome', '', 12, 'J. R. van Laars', 1, '2016-10-18', 0),
(22, 4, 'Deep Web', 0, 'Windows 10', 'Skype, Chrome', '', 21, 'Johannes P.', 0, '2016-12-08', 0),
(23, 8, 'Twitch Meme Generator', 0, 'Windows 10', 'Skype, Chrome', '', 9, 'J. R. van Laars', 0, '2017-03-18', 0),
(24, 6, 'Philips Intern App', 0, 'Windows 10', 'Skype, Chrome', 'Laptop i7 swoogedy', 9, 'J. R. van Laars', 0, '2017-01-07', 0),
(26, 11, 'Apple Destructor', 0, 'Windows 10', 'Skype, Chrome', 'Laptop i5', 9, 'J. R. van Laars', 1, '2017-01-14', 0),
(27, 11, 'Windows Promoter', 0, 'Windows 10', 'Skype, Chrome', 'Laptop i7', 2147483647, 'J. R. van Laars', 0, '2017-01-14', 0),
(28, 11, 'Rectangle Creator', 0, 'Windows 10', 'Skype, Chrome', '" SELECT * FROM tbl_customers', 9, 'J. R. van Laars', 0, '2017-01-14', 0),
(29, 4, 'Keyboard fixer', 0, 'Windows 10', 'Skype, Chrome', 'Laptop i7', 9, 'J. R. van Laars', 0, '2019-07-10', 0),
(30, 8, 'Russian transla-Thor v1.3, now with Spiderman :D', 1, 'Windows 7', 'Skype, Chrome,Word', 'Apple', 14, 'Joopie Jan R.', 0, '7690-02-09', 0),
(31, 4, 'Noice', 0, 'Windows 10', 'Skype, Chrome,kaas,tosti,machinist', 'Laptop i7', 9, 'J. R. van Laars', 0, '2017-08-18', 0),
(32, 4, 'AUTO GENERATED TEST DATA', 0, 'Windows 10', 'Skype, Chrome, Edge', 'Laptop i7', 0, 'J. R. van Laars', 0, '2016-11-17', 0),
(33, 4, 'AUTO GENERATED TEST DATA', 0, 'Windows 10', 'Skype, Chrome', 'Laptop i7', 0, 'J. R. van Laars', 0, '2016-11-12', 0),
(34, 4, 'AUTO GENERATED TEST DATA', 0, 'Windows 10', 'Skype, Chrome', 'Laptop i7', 0, 'J. R. van Laars', 0, '2016-11-12', 0),
(35, 4, '''', 0, 'Windows64', 'Niks', 'Laptop i7', 83, 'Diederik', 1, '2016-11-25', 0),
(36, 30, 'Roger''s Project', 0, 'Windows 10', 'Cookie Clicker', 'I5 Laptop', 55, 'J.R. Laars', 1, '2016-11-25', 0),
(37, 21, 'Antonio''s Projectje', 0, 'Windows danks', 'Soepkip simulator', 'Beast pc', 53, 'J.R. Laars', 1, '2016-11-27', 0),
(38, 4, 'Samsung', 0, 'Windows 10', 'Adobe reader', 'Desktop', 8, 'J. Berger', 1, '2016-11-19', 0),
(39, 4, 'Samsung', 0, 'Windows 10', 'A', 'B', 8, 'j. Berger', 1, '2016-11-13', 0),
(40, 4, 'samson en gert simulator', 1, 'windows 10', 'adobe reader', 'desktop', 8, 'J. Berger', 0, '2016-11-30', 0);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `tbl_users`
--

CREATE TABLE `tbl_users` (
  `user_id` int(11) NOT NULL,
  `username` varchar(15) NOT NULL,
  `password` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Gegevens worden geëxporteerd voor tabel `tbl_users`
--

INSERT INTO `tbl_users` (`user_id`, `username`, `password`) VALUES
(1, 'Sales', 'Sales'),
(2, 'Development', 'Development'),
(3, 'Finance', 'Finance'),
(4, 'Admin', 'Admin');

--
-- Indexen voor geëxporteerde tabellen
--

--
-- Indexen voor tabel `tbl_appointments`
--
ALTER TABLE `tbl_appointments`
  ADD PRIMARY KEY (`appointment_id`),
  ADD KEY `tbl_appointment_customer_id` (`customer_id`);

--
-- Indexen voor tabel `tbl_customers`
--
ALTER TABLE `tbl_customers`
  ADD PRIMARY KEY (`customer_id`);

--
-- Indexen voor tabel `tbl_invoices`
--
ALTER TABLE `tbl_invoices`
  ADD PRIMARY KEY (`invoice_id`),
  ADD KEY `project_id` (`project_id`);

--
-- Indexen voor tabel `tbl_notification`
--
ALTER TABLE `tbl_notification`
  ADD PRIMARY KEY (`notification_id`);

--
-- Indexen voor tabel `tbl_projects`
--
ALTER TABLE `tbl_projects`
  ADD PRIMARY KEY (`project_id`),
  ADD KEY `customer_id` (`customer_id`);

--
-- Indexen voor tabel `tbl_users`
--
ALTER TABLE `tbl_users`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT voor geëxporteerde tabellen
--

--
-- AUTO_INCREMENT voor een tabel `tbl_appointments`
--
ALTER TABLE `tbl_appointments`
  MODIFY `appointment_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
--
-- AUTO_INCREMENT voor een tabel `tbl_customers`
--
ALTER TABLE `tbl_customers`
  MODIFY `customer_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;
--
-- AUTO_INCREMENT voor een tabel `tbl_invoices`
--
ALTER TABLE `tbl_invoices`
  MODIFY `invoice_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT voor een tabel `tbl_notification`
--
ALTER TABLE `tbl_notification`
  MODIFY `notification_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT voor een tabel `tbl_projects`
--
ALTER TABLE `tbl_projects`
  MODIFY `project_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=41;
--
-- AUTO_INCREMENT voor een tabel `tbl_users`
--
ALTER TABLE `tbl_users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- Beperkingen voor geëxporteerde tabellen
--

--
-- Beperkingen voor tabel `tbl_appointments`
--
ALTER TABLE `tbl_appointments`
  ADD CONSTRAINT `tbl_appointments_ibfk_1` FOREIGN KEY (`customer_id`) REFERENCES `tbl_customers` (`customer_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Beperkingen voor tabel `tbl_invoices`
--
ALTER TABLE `tbl_invoices`
  ADD CONSTRAINT `tbl_invoices_ibfk_1` FOREIGN KEY (`project_id`) REFERENCES `tbl_projects` (`project_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Beperkingen voor tabel `tbl_projects`
--
ALTER TABLE `tbl_projects`
  ADD CONSTRAINT `tbl_projects_ibfk_1` FOREIGN KEY (`customer_id`) REFERENCES `tbl_customers` (`customer_id`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
