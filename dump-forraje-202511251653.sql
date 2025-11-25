-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: localhost    Database: forraje
-- ------------------------------------------------------
-- Server version	8.4.3

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
-- Table structure for table `alimento`
--

DROP TABLE IF EXISTS `alimento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `alimento` (
  `Id_alimento` int NOT NULL AUTO_INCREMENT,
  `Stock` int NOT NULL,
  `Precio_kilo` int NOT NULL,
  `Precio_bolsa` int NOT NULL,
  `Nombre` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `tipo_alimento` varchar(100) DEFAULT NULL,
  `idmarca` int NOT NULL,
  `peso` decimal(10,2) NOT NULL,
  `Sabor` varchar(100) DEFAULT NULL,
  `Stock_minimo` varchar(100) NOT NULL,
  `Stock_maximo` varchar(100) NOT NULL,
  `Idfabricante` int NOT NULL,
  PRIMARY KEY (`Id_alimento`),
  KEY `alimento_marca_FK` (`idmarca`),
  KEY `alimento_fabricante_FK` (`Idfabricante`),
  CONSTRAINT `alimento_fabricante_FK` FOREIGN KEY (`Idfabricante`) REFERENCES `fabricante` (`Idfabricante`),
  CONSTRAINT `alimento_marca_FK` FOREIGN KEY (`idmarca`) REFERENCES `marca` (`idmarca`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `alimento`
--

LOCK TABLES `alimento` WRITE;
/*!40000 ALTER TABLE `alimento` DISABLE KEYS */;
INSERT INTO `alimento` VALUES (18,5,533,8000,'Croquetas VitalMix Adulto','Gato',14,15.00,'Pollo y arroz','10','25',3),(19,202,475,9500,'DogPro Energy Plus','Perro Mordida Grande',13,20.00,'Carne vacuna','5','50',4),(20,15,600,10800,'CanBalance Premium','Gato',14,18.00,'Cordero ','5','50',5),(21,20,600,120005,'K9Max Performance','Gato',15,20.00,'Pollo y vegetales','5','40',6),(22,20,550,5500,'NutriPaws Senior Care','Gato',16,10.00,'Leche y cereales','5','4000',8),(23,20,600,7200,'SabrosDog Classic','Perro Alérgico',17,12.00,'Carne y pollo','6','50',9),(24,60,500,20000,'comidita','Gato',13,22.00,'carne','5','100',4);
/*!40000 ALTER TABLE `alimento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `camas`
--

DROP TABLE IF EXISTS `camas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `camas` (
  `Id_cama` int NOT NULL AUTO_INCREMENT,
  `Precio` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Stock` int NOT NULL,
  `Color` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Tamaño` int NOT NULL,
  `Tipo_cama` varchar(100) DEFAULT NULL,
  `Id_provedor` int DEFAULT NULL,
  PRIMARY KEY (`Id_cama`),
  KEY `camas_provedor_FK` (`Id_provedor`),
  CONSTRAINT `camas_provedor_FK` FOREIGN KEY (`Id_provedor`) REFERENCES `provedor` (`Id_provedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `camas`
--

LOCK TABLES `camas` WRITE;
/*!40000 ALTER TABLE `camas` DISABLE KEYS */;
/*!40000 ALTER TABLE `camas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fabricante`
--

DROP TABLE IF EXISTS `fabricante`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fabricante` (
  `Idfabricante` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Origen` varchar(100) NOT NULL,
  PRIMARY KEY (`Idfabricante`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fabricante`
--

LOCK TABLES `fabricante` WRITE;
/*!40000 ALTER TABLE `fabricante` DISABLE KEYS */;
INSERT INTO `fabricante` VALUES (1,'Purina','chile'),(3,'PetFoods Argentina S.A.','Argentina'),(4,'NutriCan Ltd','Brasil'),(5,'Alimentos Mascoteros SRL','Uruguay'),(6,'Global Pet Nutrition','EE.UU.'),(7,'Chile','Alimentos del Sur'),(8,'PetLife Corp.','Canadá'),(9,'Mascota Feliz S.A.','México'),(10,'Gold Pacific','Chile'),(12,'hola','rumania'),(13,'as','asd');
/*!40000 ALTER TABLE `fabricante` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `juguetes`
--

DROP TABLE IF EXISTS `juguetes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `juguetes` (
  `Id_juguete` int NOT NULL AUTO_INCREMENT,
  `Stock` int NOT NULL,
  `Precio` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `clase_juguete` varchar(100) NOT NULL,
  `Id_provedor` int DEFAULT NULL,
  PRIMARY KEY (`Id_juguete`),
  KEY `juguetes_provedor_FK` (`Id_provedor`),
  CONSTRAINT `juguetes_provedor_FK` FOREIGN KEY (`Id_provedor`) REFERENCES `provedor` (`Id_provedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `juguetes`
--

LOCK TABLES `juguetes` WRITE;
/*!40000 ALTER TABLE `juguetes` DISABLE KEYS */;
/*!40000 ALTER TABLE `juguetes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `maceta`
--

DROP TABLE IF EXISTS `maceta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `maceta` (
  `Stock` int NOT NULL,
  `color` varchar(100) NOT NULL,
  `Tamaño` int NOT NULL,
  `Tipo_maceta` varchar(100) NOT NULL,
  `Id_maceta` int NOT NULL AUTO_INCREMENT,
  `Id_provedor` int DEFAULT NULL,
  PRIMARY KEY (`Id_maceta`),
  KEY `maceta_provedor_FK` (`Id_provedor`),
  CONSTRAINT `maceta_provedor_FK` FOREIGN KEY (`Id_provedor`) REFERENCES `provedor` (`Id_provedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maceta`
--

LOCK TABLES `maceta` WRITE;
/*!40000 ALTER TABLE `maceta` DISABLE KEYS */;
/*!40000 ALTER TABLE `maceta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `marca`
--

DROP TABLE IF EXISTS `marca`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `marca` (
  `idmarca` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) DEFAULT NULL,
  `Idfabricante` int DEFAULT NULL,
  PRIMARY KEY (`idmarca`),
  KEY `marca_fabricante_FK` (`Idfabricante`),
  CONSTRAINT `marca_fabricante_FK` FOREIGN KEY (`Idfabricante`) REFERENCES `fabricante` (`Idfabricante`),
  CONSTRAINT `marca_ibfk_1` FOREIGN KEY (`Idfabricante`) REFERENCES `fabricante` (`Idfabricante`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `marca`
--

LOCK TABLES `marca` WRITE;
/*!40000 ALTER TABLE `marca` DISABLE KEYS */;
INSERT INTO `marca` VALUES (11,'cura',1),(12,'VitalMix',3),(13,'DogPro',4),(14,'CanBalance',5),(15,'K9Max',6),(16,'NutriPaws',8),(17,'SabrosDog',9),(18,'Gold CAT',10),(19,'hola',1);
/*!40000 ALTER TABLE `marca` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `provedor`
--

DROP TABLE IF EXISTS `provedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `provedor` (
  `Id_provedor` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(100) NOT NULL,
  `Apellido` varchar(100) NOT NULL,
  `Telefo` int NOT NULL,
  `Gmail` varchar(100) NOT NULL,
  `id-usuario` int DEFAULT NULL,
  PRIMARY KEY (`Id_provedor`),
  KEY `provedor_usuario_FK` (`id-usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `provedor`
--

LOCK TABLES `provedor` WRITE;
/*!40000 ALTER TABLE `provedor` DISABLE KEYS */;
/*!40000 ALTER TABLE `provedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ropa`
--

DROP TABLE IF EXISTS `ropa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ropa` (
  `Id_ropa` int NOT NULL AUTO_INCREMENT,
  `Precio` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Stock` int NOT NULL,
  `Color` varchar(100) NOT NULL,
  `Talle` int NOT NULL,
  `Id_provedor` int DEFAULT NULL,
  PRIMARY KEY (`Id_ropa`),
  KEY `ropa_provedor_FK` (`Id_provedor`),
  CONSTRAINT `ropa_provedor_FK` FOREIGN KEY (`Id_provedor`) REFERENCES `provedor` (`Id_provedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ropa`
--

LOCK TABLES `ropa` WRITE;
/*!40000 ALTER TABLE `ropa` DISABLE KEYS */;
/*!40000 ALTER TABLE `ropa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `semillas`
--

DROP TABLE IF EXISTS `semillas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `semillas` (
  `Stock` int NOT NULL,
  `Id_semillas` int NOT NULL AUTO_INCREMENT,
  `Precio_kilo` int NOT NULL,
  `Precio_bolsa` int NOT NULL,
  `tipo_semilla` varchar(100) NOT NULL,
  `Id_provedor` int DEFAULT NULL,
  PRIMARY KEY (`Id_semillas`),
  KEY `semillas_provedor_FK` (`Id_provedor`),
  CONSTRAINT `semillas_provedor_FK` FOREIGN KEY (`Id_provedor`) REFERENCES `provedor` (`Id_provedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `semillas`
--

LOCK TABLES `semillas` WRITE;
/*!40000 ALTER TABLE `semillas` DISABLE KEYS */;
/*!40000 ALTER TABLE `semillas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `id-usuario` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `nombreusuario` varchar(100) NOT NULL,
  `contraseña` varchar(100) NOT NULL,
  PRIMARY KEY (`id-usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'maxi','maxi','123'),(2,'guido','guido1','123'),(3,'maxi','maxi','maxi'),(4,'uriel','uriel','uriel');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ventas`
--

DROP TABLE IF EXISTS `ventas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ventas` (
  `Id_venta` int NOT NULL AUTO_INCREMENT,
  `Dinero_ingresado` int NOT NULL,
  `Fecha` time NOT NULL,
  `Modo_de_pago` varchar(100) NOT NULL,
  `id-usuario` int DEFAULT NULL,
  PRIMARY KEY (`Id_venta`),
  KEY `ventas_usuario_FK` (`id-usuario`),
  CONSTRAINT `ventas_usuario_FK` FOREIGN KEY (`id-usuario`) REFERENCES `usuario` (`id-usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ventas`
--

LOCK TABLES `ventas` WRITE;
/*!40000 ALTER TABLE `ventas` DISABLE KEYS */;
/*!40000 ALTER TABLE `ventas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'forraje'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-11-25 16:53:55
