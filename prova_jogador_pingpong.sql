-- MySQL dump 10.13  Distrib 8.0.16, for Win64 (x86_64)
--
-- Host: localhost    Database: prova
-- ------------------------------------------------------
-- Server version	8.0.16

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `jogador_pingpong`
--

DROP TABLE IF EXISTS `jogador_pingpong`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `jogador_pingpong` (
  `id_jogo` int(11) NOT NULL AUTO_INCREMENT,
  `nome_jogador1` varchar(45) NOT NULL,
  `score_jogador1` int(11) NOT NULL,
  `nome_jogador2` varchar(45) NOT NULL,
  `score_jogador2` int(11) NOT NULL,
  PRIMARY KEY (`id_jogo`)
) ENGINE=InnoDB AUTO_INCREMENT=18921 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jogador_pingpong`
--

LOCK TABLES `jogador_pingpong` WRITE;
/*!40000 ALTER TABLE `jogador_pingpong` DISABLE KEYS */;
INSERT INTO `jogador_pingpong` VALUES (18913,'Leo',4,'Pedro',5),(18914,'Leo',4,'PEdro',5),(18915,'Pedro',5,'Faria',2),(18916,'Pedro',1,'Faria2',5),(18917,'Pedor',2,'LEd',5),(18918,'Leo',2,'PEdro',5),(18919,'Leozao',5,'Leozinho',0),(18920,'LeoHenrique',1,'Faria',5);
/*!40000 ALTER TABLE `jogador_pingpong` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-09-19 20:21:09
