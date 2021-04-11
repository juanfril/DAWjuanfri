-- MySQL dump 10.13  Distrib 8.0.13, for Win64 (x86_64)
--
-- Host: localhost    Database: cine
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.6-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8mb4 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `empleado`
--

DROP TABLE IF EXISTS `empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `empleado` (
  `Codigo_emp` varchar(10) NOT NULL,
  `Nombre_emp` varchar(100) NOT NULL,
  `Nacionalidad` varchar(70) NOT NULL,
  PRIMARY KEY (`Codigo_emp`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleado`
--

LOCK TABLES `empleado` WRITE;
/*!40000 ALTER TABLE `empleado` DISABLE KEYS */;
INSERT INTO `empleado` VALUES ('EMP0001','John McTiernan','EEUU'),('EMP0002','Bruce Willis','Alemania'),('EMP0003','Alan Rickman','Reino Unido'),('EMP0004','Bonnie Bedelia','EEUU'),('EMP0005','William Atherton','EEUU'),('EMP0006','Vin Diesel','EEUU'),('EMP0007','Dwayne Johnson','EEUU'),('EMP0008','Michelle Rodriguez','EEUU'),('EMP0009','Kurt Russell','EEUU'),('EMP0010','Gary Gray','EEUU'),('EMP0011','Leonardo DiCaprio','EEUU'),('EMP0012','Kate Winslet','Reino Unido'),('EMP0013','Nicole Kidman','EEUU'),('EMP0014','Fionnula Flanagan','Irlanda'),('EMP0015','Patrick Wilson','EEUU'),('EMP0016','Vera Farmiga','EEUU');
/*!40000 ALTER TABLE `empleado` ENABLE KEYS */;
UNLOCK TABLES;
