-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: proyecto2
-- ------------------------------------------------------
-- Server version	8.3.0

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `mesas`
--

DROP TABLE IF EXISTS `mesas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mesas` (
  `id_mesa` int NOT NULL AUTO_INCREMENT,
  `id_pedido` int DEFAULT NULL,
  `capacidad` int DEFAULT NULL,
  `estado` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id_mesa`),
  KEY `id_pedido` (`id_pedido`),
  CONSTRAINT `mesas_ibfk_1` FOREIGN KEY (`id_pedido`) REFERENCES `pedidos` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mesas`
--

LOCK TABLES `mesas` WRITE;
/*!40000 ALTER TABLE `mesas` DISABLE KEYS */;
/*!40000 ALTER TABLE `mesas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pedidos`
--

DROP TABLE IF EXISTS `pedidos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pedidos` (
  `id` int NOT NULL AUTO_INCREMENT,
  `usuario` varchar(255) NOT NULL,
  `comentario` varchar(255) DEFAULT NULL,
  `nombre_plato` varchar(255) NOT NULL,
  `cantidad` int NOT NULL,
  `precio` decimal(10,2) NOT NULL,
  `total` decimal(10,2) NOT NULL,
  `cliente` varchar(255) DEFAULT NULL,
  `generado` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedidos`
--

LOCK TABLES `pedidos` WRITE;
/*!40000 ALTER TABLE `pedidos` DISABLE KEYS */;
INSERT INTO `pedidos` VALUES (1,'Wil','Sin camote','Olla de Carne',1,4500.00,4500.00,'Wil',0),(2,'Wil','Con mucho caldo la carne en salsa','Carne en Salsa',1,15000.00,19500.00,'Wil',0),(3,'Wil','Con mucho caldo la carne en salsa','Olla de Carne',1,4500.00,19500.00,'Wil',0),(4,'Wil','daswdadaw','Carne en Salsa',1,15000.00,19500.00,'sdfasd',0),(5,'Wil','daswdadaw','Olla de Carne',1,4500.00,19500.00,'sdfasd',0),(6,'Wil','wadsasdas','Carne en Salsa',1,15000.00,19500.00,'sdawdas',0),(7,'Wil','wadsasdas','Olla de Carne',1,4500.00,19500.00,'sdawdas',0),(8,'Wil','dewadaw','Carne en Salsa',1,15000.00,19500.00,'Wil',0),(9,'Wil','dewadaw','Olla de Carne',1,4500.00,19500.00,'Wil',0),(10,'Wil','cdscdsccs','Carne en Salsa',1,15000.00,19500.00,'csvssdf',0),(11,'Wil','cdscdsccs','Olla de Carne',1,4500.00,19500.00,'csvssdf',0),(12,'Wil','dawda','Carne en Salsa',1,15000.00,19500.00,'dsa',0),(13,'Wil','dawda','Olla de Carne',1,4500.00,19500.00,'dsa',0),(14,'Wil','dawdadwa','Carne en Salsa',1,15000.00,19500.00,'dawdwd',0),(15,'Wil','dawdadwa','Olla de Carne',1,4500.00,19500.00,'dawdwd',0),(16,'Wil','awdsdadas','Carne en Salsa',1,15000.00,19500.00,'dawda',0),(17,'Wil','awdsdadas','Olla de Carne',1,4500.00,19500.00,'dawda',0),(18,'asda','ds','Carne en Salsa',1,15000.00,19500.00,'dada',0),(19,'asda','ds','Olla de Carne',1,4500.00,19500.00,'dada',0),(20,'Wil','gfgf','Carne en Salsa',1,15000.00,19500.00,'gff',0),(21,'Wil','gfgf','Olla de Carne',1,4500.00,19500.00,'gff',0),(22,'Wil','dasdasda','Carne en Salsa',1,15000.00,19500.00,'scad',0),(23,'Wil','dasdasda','Olla de Carne',1,4500.00,19500.00,'scad',0),(24,'Wil','dadwadwasd','Carne en Salsa',1,15000.00,19500.00,'Wil',0),(25,'Wil','dadwadwasd','Olla de Carne',1,4500.00,19500.00,'Wil',0),(26,'Wil','dads','Carne en Salsa',1,15000.00,19500.00,'dwasda',0),(27,'Wil','dads','Olla de Carne',1,4500.00,19500.00,'dwasda',0),(28,'Wil','3werw','Carne en Salsa',1,15000.00,19500.00,'erw',0),(29,'Wil','3werw','Olla de Carne',1,4500.00,19500.00,'erw',0),(30,'Wil','Con mucho Caldo','Carne en Salsa',1,15000.00,15000.00,'Carlos',1),(31,'Wil','saasa','Carne en Salsa',1,15000.00,19500.00,'asas',1),(32,'Wil','saasa','Olla de Carne',1,4500.00,19500.00,'asas',1);
/*!40000 ALTER TABLE `pedidos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `platos`
--

DROP TABLE IF EXISTS `platos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `platos` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `description` text,
  `price` decimal(10,2) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `platos`
--

LOCK TABLES `platos` WRITE;
/*!40000 ALTER TABLE `platos` DISABLE KEYS */;
INSERT INTO `platos` VALUES (1,'Carne en Salsa','Es Carne en Salsa',15000.00),(2,'Olla de Carne','Platillo tipicos, Caldo a base de carne y verduras',4500.00),(3,'Gallo Pinto','Gallo Pinto Tradiciona',2500.00);
/*!40000 ALTER TABLE `platos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `salas`
--

DROP TABLE IF EXISTS `salas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `salas` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `capacity` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `salas`
--

LOCK TABLES `salas` WRITE;
/*!40000 ALTER TABLE `salas` DISABLE KEYS */;
INSERT INTO `salas` VALUES (1,'WetBar',8),(2,'Salon',25),(3,'Room Service',5),(4,'Chef Room',2);
/*!40000 ALTER TABLE `salas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `role` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'Wil','sdjlad','admin'),(5,'Admin','12qw90op','admin');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-04-04 20:08:54
