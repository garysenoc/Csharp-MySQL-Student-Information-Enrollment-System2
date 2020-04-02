-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.5.16


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema dbstamonica
--

CREATE DATABASE IF NOT EXISTS dbstamonica;
USE dbstamonica;

--
-- Definition of table `tbadmin`
--

DROP TABLE IF EXISTS `tbadmin`;
CREATE TABLE `tbadmin` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbadmin`
--

/*!40000 ALTER TABLE `tbadmin` DISABLE KEYS */;
INSERT INTO `tbadmin` (`id`,`username`,`password`) VALUES 
 (2,'admin','admin');
/*!40000 ALTER TABLE `tbadmin` ENABLE KEYS */;


--
-- Definition of table `tbstudent`
--

DROP TABLE IF EXISTS `tbstudent`;
CREATE TABLE `tbstudent` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `fname` varchar(200) NOT NULL,
  `mname` varchar(200) NOT NULL,
  `lname` varchar(200) NOT NULL,
  `telno` varchar(200) NOT NULL,
  `age` varchar(200) NOT NULL,
  `sex` varchar(200) NOT NULL,
  `status` varchar(200) NOT NULL,
  `height` varchar(200) NOT NULL,
  `weght` varchar(200) NOT NULL,
  `citizenship` varchar(200) NOT NULL,
  `birthday` varchar(200) NOT NULL,
  `birthplace` varchar(200) NOT NULL,
  `fathername` varchar(200) NOT NULL,
  `fage` varchar(200) NOT NULL,
  `foccupation` varchar(200) NOT NULL,
  `mothername` varchar(200) NOT NULL,
  `mage` varchar(200) NOT NULL,
  `moccupation` varchar(200) NOT NULL,
  `province` varchar(200) NOT NULL,
  `cityadd` varchar(200) NOT NULL,
  `nameguardian` varchar(200) NOT NULL,
  `gaddress` varchar(200) NOT NULL,
  `persontocontact` varchar(200) NOT NULL,
  `persontocontactaddress` varchar(200) NOT NULL,
  `persontocontactadd` varchar(200) NOT NULL,
  `lrnno` varchar(200) NOT NULL,
  `gradelevel` varchar(200) DEFAULT NULL,
  `class` varchar(200) DEFAULT NULL,
  `semester` varchar(200) DEFAULT NULL,
  `schoolyear` varchar(4500) DEFAULT NULL,
  `pic` varchar(4500) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbstudent`
--

/*!40000 ALTER TABLE `tbstudent` DISABLE KEYS */;
INSERT INTO `tbstudent` (`id`,`fname`,`mname`,`lname`,`telno`,`age`,`sex`,`status`,`height`,`weght`,`citizenship`,`birthday`,`birthplace`,`fathername`,`fage`,`foccupation`,`mothername`,`mage`,`moccupation`,`province`,`cityadd`,`nameguardian`,`gaddress`,`persontocontact`,`persontocontactaddress`,`persontocontactadd`,`lrnno`,`gradelevel`,`class`,`semester`,`schoolyear`,`pic`) VALUES 
 (2,'Gary Lloyd','m.','Senoc','123131','12','Male','Married','123','123','Filipino','Saturday, October 27, 2018','Palawan','ronaldo','21','govt employee','ellen','12','housewife','palawan','puerto princesa city','mama','puerto princesa city','ellen','puerto princesa city','1231231','12313213','IV','Old','1st','2018-2019','C:\\Users\\Gary Lloyd Senoc\\Desktop\\library sytem.jpg'),
 (3,'asdfasf','asdfas','asdfa','dfaasdfa','','','','','','','Saturday, October 27, 2018','','','','','','','','','','','','','','','asdfasf','III','Old','1st','2017-2018',''),
 (6,'qwerwty','mmmsdfgdfsg','sefsdf','123','12','Male','Single ','128','12','','Wednesday, February 13, 2019','','','','','','','','','','','','','','','','','','','',''),
 (7,'GGGG','M. ','Senoc','0912309123','16','Male','Single ','123','123','Filipino','Wednesday, February 13, 2019','Palawan','papa','16','leyte','mama','12','palawan','palawan','asdfdsf','ellen','palawan','mama','palawan','123123','21312312','III','New','2nd','2019-2020','C:\\Users\\Gary Lloyd Senoc\\Desktop\\img\\48364436_774543929565811_4461735515984494592_n.jpg');
/*!40000 ALTER TABLE `tbstudent` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
