-- MySQL dump 10.13  Distrib 8.0.18, for Win64 (x86_64)
--
-- Host: localhost    Database: spotify
-- ------------------------------------------------------
-- Server version	8.0.18

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `premium_pp`
--

DROP TABLE IF EXISTS `premium_pp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `premium_pp` (
  `ID_usuario` int(10) unsigned NOT NULL,
  `fecha_renovacion` date NOT NULL,
  `Username_pp` varchar(50) NOT NULL,
  PRIMARY KEY (`ID_usuario`),
  UNIQUE KEY `Username_pp` (`Username_pp`),
  CONSTRAINT `premium_pp_ibfk_1` FOREIGN KEY (`ID_usuario`) REFERENCES `usuario` (`ID_usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `premium_pp`
--

LOCK TABLES `premium_pp` WRITE;
/*!40000 ALTER TABLE `premium_pp` DISABLE KEYS */;
INSERT INTO `premium_pp` VALUES (20,'2019-03-26','PP20'),(22,'2019-01-03','PP22'),(24,'2019-01-05','PP24'),(40,'2019-01-07','PP40'),(42,'2019-01-09','PP42'),(44,'2019-01-11','PP44'),(46,'2019-01-13','PP46'),(48,'2019-01-15','PP48');
/*!40000 ALTER TABLE `premium_pp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `premium_tc`
--

DROP TABLE IF EXISTS `premium_tc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `premium_tc` (
  `ID_usuario` int(10) unsigned NOT NULL,
  `fecha_renovacion` date NOT NULL,
  `numero_tarjeta` varchar(10) NOT NULL,
  `mes_caducidad` tinyint(2) unsigned zerofill DEFAULT NULL,
  `anio_caducidad` year(4) DEFAULT NULL,
  `codigo_seguridad` smallint(3) unsigned zerofill DEFAULT NULL,
  PRIMARY KEY (`ID_usuario`),
  UNIQUE KEY `numero_tarjeta` (`numero_tarjeta`),
  CONSTRAINT `premium_tc_ibfk_1` FOREIGN KEY (`ID_usuario`) REFERENCES `usuario` (`ID_usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `premium_tc`
--

LOCK TABLES `premium_tc` WRITE;
/*!40000 ALTER TABLE `premium_tc` DISABLE KEYS */;
INSERT INTO `premium_tc` VALUES (2,'2019-02-01','4569856635',01,2020,157),(4,'2019-02-25','4569856636',02,2020,159),(6,'2019-03-21','4569856637',03,2021,161),(8,'2019-01-01','4569856638',04,2022,163),(10,'2019-01-15','4569856639',05,2020,165),(12,'2019-01-29','4569856640',06,2020,167),(14,'2019-02-12','4569856641',07,2021,169),(16,'2019-02-26','4569856642',08,2022,171),(18,'2019-03-12','4569856643',09,2020,173),(50,'2019-01-17','4569856652',12,2020,191),(52,'2019-01-19','4569856653',01,2021,193),(54,'2019-01-21','4569856654',01,2022,195),(56,'2019-01-23','4569856655',02,2020,197),(58,'2019-01-25','4569856656',02,2020,199),(60,'2019-01-27','4569856657',03,2021,201),(80,'2019-01-29','4569856658',01,2022,203),(82,'2019-01-31','4569856659',07,2020,205),(84,'2019-02-02','4569856660',07,2020,207),(86,'2019-02-04','4569856661',08,2021,209),(88,'2019-02-06','4569856662',08,2022,211);
/*!40000 ALTER TABLE `premium_tc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `ID_usuario` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `password` varchar(30) DEFAULT NULL,
  `email` varchar(50) NOT NULL,
  `fecha_nacimiento` date NOT NULL,
  `pais` varchar(50) NOT NULL,
  `sexo` enum('H','M') NOT NULL,
  `tipo_usuario` enum('Free','Premium') NOT NULL DEFAULT 'Free',
  PRIMARY KEY (`ID_usuario`),
  UNIQUE KEY `username` (`username`),
  UNIQUE KEY `email` (`email`)
) ENGINE=InnoDB AUTO_INCREMENT=101 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'A_GARCIA','GARCIA30761','A_GARCIA@gmail.com','1984-03-20','ARGENTINA','H','Free'),(2,'B_GONZALEZ','GONZALEZ24089','B_GONZALEZ@hotmail.com','2065-12-13','AUSTRALIA','M','Premium'),(3,'C_RODRIGUEZ','RODRIGUEZ25404','C_RODRIGUEZ@hotmail.com','2069-07-20','AMSTERDAN','H','Free'),(4,'D_FERNANDEZ','FERNANDEZ23946','D_FERNANDEZ@hotmail.com','2065-07-23','BAHAMAS','M','Premium'),(5,'E_LOPEZ','LOPEZ30971','E_LOPEZ@hotmail.com','1984-10-16','BELGICA','H','Free'),(6,'F_MARTINEZ','MARTINEZ28810','F_MARTINEZ@hotmail.com','1978-11-16','BOLIVIA ','M','Premium'),(7,'G_SANCHEZ','SANCHEZ24551','G_SANCHEZ@gmail.com','2067-03-20','BRASIL','H','Free'),(8,'H_PEREZ','PEREZ24367','H_PEREZ@gmail.com','2066-09-17','CANADA','M','Premium'),(9,'I_GOMEZ','GOMEZ24755','I_GOMEZ@gmail.com','2067-10-10','CAMERUN','H','Free'),(10,'J_MARTIN','MARTIN36309','J_MARTIN@gmail.com','1999-05-29','CHILE','M','Premium'),(11,'K_JIMENEZ','JIMENEZ24908','K_JIMENEZ@gmail.com','2068-03-11','CHINA','H','Free'),(12,'L_RUIZ','RUIZ30948','L_RUIZ@gmail.com','1984-09-23','COLOMBIA','M','Premium'),(13,'M_HERNANDEZ','HERNANDEZ24120','M_HERNANDEZ@gmail.com','2066-01-13','DINAMARCA','H','Free'),(14,'N_DIAZ','DIAZ32022','N_DIAZ@gmail.com','1987-09-02','ESPAÑA','M','Premium'),(15,'O_MORENO','MORENO25402','O_MORENO@yahoo.com','2069-07-18','ESTADOS UNIDOS','H','Free'),(16,'P_MUÑOZ','MUÑOZ25233','P_MUÑOZ@yahoo.com','2069-01-30','FRANCIA','M','Premium'),(17,'Q_ALVAREZ','ALVAREZ24564','Q_ALVAREZ@yahoo.com','2067-04-02','GUATEMALA','H','Free'),(18,'R_ROMERO','ROMERO28736','R_ROMERO@hotmail.com','1978-09-03','LIBANO','H','Premium'),(19,'S_ALONSO','ALONSO24258','S_ALONSO@hotmail.com','2066-05-31','MEXICO','H','Free'),(20,'T_GUTIERREZ','GUTIERREZ24736','T_GUTIERREZ@hotmail.com','2067-09-21','NIGERIA','H','Premium'),(21,'U_NAVARRO','NAVARRO23065','U_NAVARRO@hotmail.com','2063-02-23','PANAMA','H','Free'),(22,'V_TORRES','TORRES28516','V_TORRES@gmail.com','1978-01-26','ARGENTINA','H','Premium'),(23,'A_DOMINGUEZ','DOMINGUEZ36426','A_DOMINGUEZ@gmail.com','1999-09-23','AUSTRALIA','H','Free'),(24,'B_VAZQUEZ','VAZQUEZ30952','B_VAZQUEZ@gmail.com','1984-09-27','AMSTERDAN','H','Premium'),(25,'C_RAMOS','RAMOS22727','C_RAMOS@gmail.com','2062-03-22','BAHAMAS','H','Free'),(26,'D_GIL','GIL23946','D_GIL@gmail.com','2065-07-23','FRANCIA','H','Free'),(27,'E_RAMIREZ','RAMIREZ25336','E_RAMIREZ@gmail.com','2069-05-13','FRANCIA','H','Free'),(28,'F_SERRANO','SERRANO24244','F_SERRANO@gmail.com','2066-05-17','FRANCIA','H','Free'),(29,'G_BLANCO','BLANCO32722','G_BLANCO@gmail.com','1989-08-02','FRANCIA','H','Free'),(30,'H_MOLINA','MOLINA32512','H_MOLINA@gmail.com','1989-01-04','FRANCIA','M','Free'),(31,'I_MORALES','MORALES25171','I_MORALES@gmail.com','2068-11-29','FRANCIA','H','Free'),(32,'J_SUAREZ','SUAREZ30847','J_SUAREZ@gmail.com','1984-06-14','FRANCIA','M','Free'),(33,'K_ORTEGA','ORTEGA25374','K_ORTEGA@gmail.com','2069-06-20','FRANCIA','H','Free'),(34,'L_DELGADO','DELGADO24432','L_DELGADO@gmail.com','2066-11-21','DINAMARCA','M','Free'),(35,'M_CASTRO','CASTRO32645','M_CASTRO@gmail.com','1989-05-17','ESPAÑA','H','Free'),(36,'N_ORTIZ','ORTIZ23934','N_ORTIZ@gmail.com','2065-07-11','ESTADOS UNIDOS','M','Free'),(37,'O_RUBIO','RUBIO22989','O_RUBIO@gmail.com','2062-12-09','FRANCIA','H','Free'),(38,'P_MARIN','MARIN24188','P_MARIN@gmail.com','2066-03-22','GUATEMALA','M','Free'),(39,'Q_SANZ','SANZ24525','Q_SANZ@gmail.com','2067-02-22','LIBANO','H','Free'),(40,'R_NUÑEZ','NUÑEZ25408','R_NUÑEZ@gmail.com','2069-07-24','MEXICO','M','Premium'),(41,'S_IGLESIAS','IGLESIAS28725','S_IGLESIAS@gmail.com','1978-08-23','NIGERIA','H','Free'),(42,'T_MEDINA','MEDINA32127','T_MEDINA@gmail.com','1987-12-16','PANAMA','M','Premium'),(43,'U_GARRIDO','GARRIDO24551','U_GARRIDO@gmail.com','2067-03-20','ARGENTINA','H','Free'),(44,'V_CORTES','CORTES32611','V_CORTES@hotmail.com','1989-04-13','ESTADOS UNIDOS','M','Premium'),(45,'A_CASTILLO','CASTILLO36183','A_CASTILLO@hotmail.com','1999-01-23','ESTADOS UNIDOS','H','Free'),(46,'B_SANTOS','SANTOS24304','B_SANTOS@hotmail.com','2066-07-16','ESTADOS UNIDOS','H','Premium'),(47,'C_LOZANO','LOZANO24893','C_LOZANO@hotmail.com','2068-02-25','ESTADOS UNIDOS','H','Free'),(48,'D_GUERRERO','GUERRERO22875','D_GUERRERO@hotmail.com','2062-08-17','ESTADOS UNIDOS','H','Premium'),(49,'E_CANO','CANO22478','E_CANO@hotmail.com','2061-07-16','ESTADOS UNIDOS','H','Free'),(50,'F_PRIETO','PRIETO30704','F_PRIETO@hotmail.com','1984-01-23','ESTADOS UNIDOS','H','Premium'),(51,'G_MENDEZ','MENDEZ23252','G_MENDEZ@hotmail.com','2063-08-29','ESTADOS UNIDOS','H','Free'),(52,'H_CRUZ','CRUZ22331','H_CRUZ@hotmail.com','2061-02-19','ESTADOS UNIDOS','H','Premium'),(53,'I_CALVO','CALVO32618','I_CALVO@hotmail.com','1989-04-20','ESTADOS UNIDOS','H','Free'),(54,'J_GALLEGO','GALLEGO30975','J_GALLEGO@hotmail.com','1984-10-20','ESTADOS UNIDOS','H','Premium'),(55,'K_HERRERA','HERRERA36246','K_HERRERA@hotmail.com','1999-03-27','ESTADOS UNIDOS','H','Free'),(56,'L_MARQUEZ','MARQUEZ36412','L_MARQUEZ@hotmail.com','1999-09-09','ESTADOS UNIDOS','M','Premium'),(57,'M_LEON','LEON24414','M_LEON@hotmail.com','2066-11-03','ESTADOS UNIDOS','H','Free'),(58,'N_VIDAL','VIDAL36214','N_VIDAL@hotmail.com','1999-02-23','ESTADOS UNIDOS','M','Premium'),(59,'O_PEÑA','PEÑA22939','O_PEÑA@yahoo.com','2062-10-20','ESTADOS UNIDOS','H','Free'),(60,'P_FLORES','FLORES25349','P_FLORES@yahoo.com','2069-05-26','LIBANO','M','Premium'),(61,'Q_CABRERA','CABRERA24239','Q_CABRERA@yahoo.com','2066-05-12','COLOMBIA','H','Free'),(62,'R_CAMPOS','CAMPOS36402','R_CAMPOS@yahoo.com','1999-08-30','COLOMBIA','M','Free'),(63,'S_VEGA','VEGA22799','S_VEGA@yahoo.com','2062-06-02','COLOMBIA','H','Free'),(64,'T_FUENTES','FUENTES32722','T_FUENTES@gmail.com','1989-08-02','COLOMBIA','M','Free'),(65,'U_CARRASCO','CARRASCO24356','U_CARRASCO@gmail.com','2066-09-06','COLOMBIA','H','Free'),(66,'V_DIEZ','DIEZ23062','V_DIEZ@gmail.com','2063-02-20','COLOMBIA','M','Free'),(67,'A_REYES','REYES22847','A_REYES@gmail.com','2062-07-20','COLOMBIA','H','Free'),(68,'B_CABALLERO','CABALLERO36491','B_CABALLERO@gmail.com','1999-11-27','COLOMBIA','M','Free'),(69,'C_NIETO','NIETO32830','C_NIETO@gmail.com','1989-11-18','COLOMBIA','H','Free'),(70,'D_AGUILAR','AGUILAR25136','D_AGUILAR@gmail.com','2068-10-25','BRASIL','M','Free'),(71,'E_PASCUAL','PASCUAL23052','E_PASCUAL@gmail.com','2063-02-10','CANADA','H','Free'),(72,'F_SANTANA','SANTANA25236','F_SANTANA@gmail.com','2069-02-02','CAMERUN','M','Free'),(73,'G_HERRERO','HERRERO30757','G_HERRERO@gmail.com','1984-03-16','CHILE','H','Free'),(74,'H_MONTERO','MONTERO30854','H_MONTERO@gmail.com','1984-06-21','CHINA','M','Free'),(75,'I_LORENZO','LORENZO32100','I_LORENZO@gmail.com','1987-11-19','COLOMBIA','H','Free'),(76,'J_HIDALGO','HIDALGO24441','J_HIDALGO@gmail.com','2066-11-30','DINAMARCA','H','Free'),(77,'K_GIMENEZ','GIMENEZ36406','K_GIMENEZ@gmail.com','1999-09-03','MEXICO','H','Free'),(78,'L_IBAÑEZ','IBAÑEZ30983','L_IBAÑEZ@gmail.com','1984-10-28','MEXICO','H','Free'),(79,'M_FERRER','FERRER32612','M_FERRER@gmail.com','1989-04-14','MEXICO','H','Free'),(80,'N_DURAN','DURAN24735','N_DURAN@gmail.com','2067-09-20','MEXICO','H','Premium'),(81,'O_SANTIAGO','SANTIAGO24251','O_SANTIAGO@gmail.com','2066-05-24','MEXICO','H','Free'),(82,'P_BENITEZ','BENITEZ24623','P_BENITEZ@gmail.com','2067-05-31','MEXICO','M','Premium'),(83,'Q_VARGAS','VARGAS28784','Q_VARGAS@gmail.com','1978-10-21','MEXICO','H','Free'),(84,'R_MORA','MORA32784','R_MORA@gmail.com','1989-10-03','MEXICO','H','Premium'),(85,'S_VICENTE','VICENTE22424','S_VICENTE@gmail.com','2061-05-23','ARGENTINA','H','Free'),(86,'T_ARIAS','ARIAS22297','T_ARIAS@hotmail.com','2061-01-16','AUSTRALIA','H','Premium'),(87,'U_CARMONA','CARMONA32079','U_CARMONA@hotmail.com','1987-10-29','AMSTERDAN','H','Free'),(88,'V_CRESPO','CRESPO24811','V_CRESPO@hotmail.com','2067-12-05','CHILE','M','Premium'),(89,'A_ROMAN','ROMAN24045','A_ROMAN@hotmail.com','2065-10-30','CHILE','H','Free'),(90,'B_PASTOR','PASTOR25342','B_PASTOR@hotmail.com','2069-05-19','CHILE','M','Free'),(91,'C_SOTO','SOTO30877','C_SOTO@hotmail.com','1984-07-14','CHILE','H','Free'),(92,'D_SAEZ','SAEZ30710','D_SAEZ@hotmail.com','1984-01-29','CHILE','M','Free'),(93,'E_VELASCO','VELASCO28572','E_VELASCO@hotmail.com','1978-03-23','CHILE','H','Free'),(94,'F_MOYA','MOYA24415','F_MOYA@hotmail.com','2066-11-04','CHILE','M','Free'),(95,'G_SOLER','SOLER24670','G_SOLER@hotmail.com','2067-07-17','CHINA','H','Free'),(96,'H_PARRA','PARRA24154','H_PARRA@gmail.com','2066-02-16','COLOMBIA','M','Free'),(97,'I_ESTEBAN','ESTEBAN24175','I_ESTEBAN@gmail.com','2066-03-09','DINAMARCA','H','Free'),(98,'J_BRAVO','BRAVO25285','J_BRAVO@gmail.com','2069-03-23','BOLIVIA ','M','Free'),(99,'K_GALLARDO','GALLARDO32042','K_GALLARDO@gmail.com','1987-09-22','BOLIVIA ','H','Free'),(100,'L_ROJAS','ROJAS22600','L_ROJAS@gmail.com','2061-11-15','BOLIVIA ','M','Free');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-12-13 16:31:49
