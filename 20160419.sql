CREATE DATABASE  IF NOT EXISTS `salary` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `salary`;
-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: salary
-- ------------------------------------------------------
-- Server version	5.7.9-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `t_annual_assignment`
--

DROP TABLE IF EXISTS `t_annual_assignment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_annual_assignment` (
  `ID` varchar(40) NOT NULL,
  `ASSIGNMENT_ID` varchar(40) NOT NULL,
  `NAME` varchar(100) NOT NULL,
  `DESCRIPTION` varchar(2000) DEFAULT NULL,
  `ASSIGNMENT_YEAR` int(11) NOT NULL,
  `ASSIGNMENT_MONTH` int(11) NOT NULL,
  `TARGET` decimal(20,6) NOT NULL,
  `CREATE_TIME` date NOT NULL,
  `CREATOR_ID` varchar(40) DEFAULT NULL,
  `VERSION_ID` varchar(40) NOT NULL,
  `EXEC_STATE` int(11) NOT NULL COMMENT '0 - 未分配\n            1 - 已分配\n            2 - 已执行\n            3 - 执行完成',
  UNIQUE KEY `INDEX_1` (`ID`),
  KEY `INDEX_2` (`ASSIGNMENT_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_annual_assignment`
--

LOCK TABLES `t_annual_assignment` WRITE;
/*!40000 ALTER TABLE `t_annual_assignment` DISABLE KEYS */;
INSERT INTO `t_annual_assignment` VALUES ('0754db2b-381b-4ae9-9310-919a45d817d6','91e17323-e3eb-42b3-b662-04fd3043b1d8','2016年度7月任务计划','2016年度7月任务计划',2016,7,337.094956,'2016-04-18','nobody','20140404',0),('0c65c8d8-3867-4d18-8113-6b8b32c27f68','91e17323-e3eb-42b3-b662-04fd3043b1d8','2016年度8月任务计划','2016年度8月任务计划',2016,8,674.189911,'2016-04-18','nobody','20140404',0),('492b923a-d4e2-4944-8976-f694c4a945d2','91e17323-e3eb-42b3-b662-04fd3043b1d8','2016年度4月任务计划','2016年度4月任务计划',2016,4,337.094956,'2016-04-18','nobody','20140404',1),('6dea9111-44e2-46cf-8313-a1afd064ebef','91e17323-e3eb-42b3-b662-04fd3043b1d8','2016年度10月任务计划','2016年度10月任务计划',2016,10,674.189911,'2016-04-18','nobody','20140404',0),('74a090e9-0a60-4a6c-910b-a66a749f7454','91e17323-e3eb-42b3-b662-04fd3043b1d8','2016年度12月任务计划','2016年度12月任务计划',2016,12,674.189911,'2016-04-18','nobody','20140404',0),('79bfeb33-7c2a-47aa-b9c7-99a9a5b9c4a0','91e17323-e3eb-42b3-b662-04fd3043b1d8','2016年度5月任务计划','2016年度5月任务计划',2016,5,337.094956,'2016-04-18','nobody','20140404',1),('87530c4b-34a1-4b7e-a6e5-abf45922aed6','91e17323-e3eb-42b3-b662-04fd3043b1d8','2016年度6月任务计划','2016年度6月任务计划',2016,6,337.094956,'2016-04-18','nobody','20140404',0),('955ac4c0-a791-4942-927b-4eb8a5b93c22','91e17323-e3eb-42b3-b662-04fd3043b1d8','2016年度9月任务计划','2016年度9月任务计划',2016,9,674.189911,'2016-04-18','nobody','20140404',0),('a46af49e-617a-4c5c-8fb7-55c64beaf00a','91e17323-e3eb-42b3-b662-04fd3043b1d8','2016年度11月任务计划','2016年度11月任务计划',2016,11,674.189911,'2016-04-18','nobody','20140404',0);
/*!40000 ALTER TABLE `t_annual_assignment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_assignment`
--

DROP TABLE IF EXISTS `t_assignment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_assignment` (
  `ID` varchar(40) NOT NULL,
  `NAME` varchar(100) NOT NULL,
  `DESCRIPTION` varchar(2000) DEFAULT NULL,
  `TYPE` varchar(40) NOT NULL,
  `TARGET` decimal(20,6) NOT NULL,
  `UNIT` varchar(40) NOT NULL,
  `ENABLED` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_assignment`
--

LOCK TABLES `t_assignment` WRITE;
/*!40000 ALTER TABLE `t_assignment` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_assignment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_assignment_define`
--

DROP TABLE IF EXISTS `t_assignment_define`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_assignment_define` (
  `ID` varchar(40) NOT NULL,
  `NAME` varchar(100) NOT NULL,
  `DESCRIPTION` varchar(2000) DEFAULT NULL,
  `ENABLED` tinyint(1) NOT NULL,
  `TYPE` varchar(40) NOT NULL,
  `DEFAULT_VALUE` decimal(20,6) NOT NULL,
  `VERSION_ID` varchar(40) NOT NULL,
  `UNIT_ID` varchar(40) NOT NULL,
  `POSITION_ID` varchar(40) NOT NULL,
  UNIQUE KEY `INDEX_1` (`ID`),
  KEY `INDEX_2` (`TYPE`),
  KEY `INDEX_3` (`UNIT_ID`),
  KEY `INDEX_4` (`VERSION_ID`),
  KEY `INDEX_5` (`POSITION_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_assignment_define`
--

LOCK TABLES `t_assignment_define` WRITE;
/*!40000 ALTER TABLE `t_assignment_define` DISABLE KEYS */;
INSERT INTO `t_assignment_define` VALUES ('12cea176-2040-4116-832b-eb4a8b6032fd','吃饭次数',NULL,1,'2',10000.000000,'20140404','3','0000000000'),('4de125fc-020c-4aaa-9d9b-12b913f40d82','工时任务',NULL,1,'3',0.000000,'20140404','5','9999999999'),('91e17323-e3eb-42b3-b662-04fd3043b1d8','产值任务',NULL,1,'1',0.000000,'20140404','2','9999999999'),('c304c340-abb0-49be-a646-46cc1a0a51d0','检验数量',NULL,1,'2',1000.000000,'20140404','3','0204020000'),('cac57f41-d92b-4894-b7b6-befd85c71aea','精品辅料',NULL,0,'1',0.000000,'20140404','2','9999999999');
/*!40000 ALTER TABLE `t_assignment_define` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_assignment_item`
--

DROP TABLE IF EXISTS `t_assignment_item`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_assignment_item` (
  `ID` varchar(40) NOT NULL,
  `NAME` varchar(100) NOT NULL,
  `DESCRIPTION` varchar(2000) DEFAULT NULL,
  `TYPE` varchar(40) NOT NULL,
  `TARGET` decimal(20,6) NOT NULL,
  `UNIT` varchar(40) NOT NULL,
  `ENABLED` tinyint(1) NOT NULL,
  `VERSION_ID` varchar(40) NOT NULL,
  `POSITION_ID` varchar(40) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_assignment_item`
--

LOCK TABLES `t_assignment_item` WRITE;
/*!40000 ALTER TABLE `t_assignment_item` DISABLE KEYS */;
INSERT INTO `t_assignment_item` VALUES ('750590f0-8349-4cea-8494-80bf664b60fd','task 1',NULL,'1',10.000000,'2',1,'20140404','9999999999');
/*!40000 ALTER TABLE `t_assignment_item` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_assignment_item_type`
--

DROP TABLE IF EXISTS `t_assignment_item_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_assignment_item_type` (
  `ID` varchar(40) NOT NULL,
  `NAME` varchar(100) NOT NULL,
  `DESCRIPTION` varchar(2000) DEFAULT NULL,
  `ENABLED` tinyint(1) NOT NULL,
  UNIQUE KEY `INDEX_1` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_assignment_item_type`
--

LOCK TABLES `t_assignment_item_type` WRITE;
/*!40000 ALTER TABLE `t_assignment_item_type` DISABLE KEYS */;
INSERT INTO `t_assignment_item_type` VALUES ('1','自动分配任务','任务下达到指定岗位后，再按岗位预设比例逐级分解到下属岗位，如无预设比例则该下属岗位不分配',1),('2','定额任务','任务下达到指定岗位，具有固定任务指标',1),('3','无定额任务','任务下达到指定岗位，没有任务指标。',1);
/*!40000 ALTER TABLE `t_assignment_item_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_assignment_performance`
--

DROP TABLE IF EXISTS `t_assignment_performance`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_assignment_performance` (
  `ID` varchar(40) NOT NULL,
  `EMPLOYEE_ID` varchar(40) NOT NULL,
  `COMPLETED` decimal(20,6) NOT NULL,
  `TARGET` decimal(20,6) DEFAULT NULL,
  `ASSIGNMENT_YEAR` int(11) NOT NULL,
  `ASSIGNMENT_MONTH` int(11) NOT NULL,
  `DESCRIPTION` varchar(2000) DEFAULT NULL,
  `VERSION_ID` varchar(40) NOT NULL,
  `DEFINE_ID` varchar(40) NOT NULL,
  UNIQUE KEY `INDEX_1` (`ID`),
  KEY `INDEX_2` (`EMPLOYEE_ID`),
  KEY `INDEX_4` (`VERSION_ID`),
  KEY `INDEX_5` (`DEFINE_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_assignment_performance`
--

LOCK TABLES `t_assignment_performance` WRITE;
/*!40000 ALTER TABLE `t_assignment_performance` DISABLE KEYS */;
INSERT INTO `t_assignment_performance` VALUES ('00eb68a7-c479-4413-bd80-a100d6a8d2cc','006',0.000000,34.184300,2016,5,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('0907c535-a58e-4694-a01a-314b738c3cb1','004',0.000000,1.424200,2016,5,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('09a01a4d-7c16-489e-98e9-c073e7d940d8','016',0.000000,3.428567,2016,4,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('0ae94d1d-926e-48a2-b8f9-d1a4cb758a69','009',0.000000,34.184300,2016,5,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('0ecc7ba2-bb50-41ec-ba72-bc0d12aa91f1','031',0.000000,2.856900,2016,4,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('1ce63c87-2d6d-4cee-8fb4-6bf47d078766','020',0.000000,17.142900,2016,4,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('2387b597-3675-40d3-9e9f-a311fd12b36f','025',0.000000,3.418400,2016,5,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('24059b3e-9e88-44f7-9de5-3bd91c7dd7f6','0001',0.000000,170.921400,2016,5,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('335583ae-cfc4-4509-8bd1-61b5071501c2','028',0.000000,1.424200,2016,5,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('3964e287-546b-4eef-9372-9db6e5375328','028',0.000000,0.714200,2016,4,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('3d04b691-a60f-4b80-a193-70cbea8ed898','005',0.000000,0.714225,2016,4,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('3d684ccd-98f9-45cc-bdd9-afb6bcae9880','009',0.000000,17.142900,2016,4,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('3f78083a-fa48-497e-b024-45dc7292cbdf','031',0.000000,5.696800,2016,5,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('421bdab6-d521-49d5-a662-d541d40491a7','036',0.000000,6.836900,2016,5,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('48787c3c-4575-4b62-814e-83a1c38d12bc','012',0.000000,17.142900,2016,4,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('50cfc6b9-c647-47e7-91c5-b052ef65e0aa','033',0.000000,2.857700,2016,4,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('5297c5a8-454f-419c-a62c-eec0b27a85bb','004',0.000000,0.714225,2016,4,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('52b7d2ab-89a7-4667-a91c-ef62ee915a11','027',0.000000,0.714225,2016,4,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('56bc1d5d-6993-42a3-a56c-7fcb41c56cb5','0002',0.000000,68.571400,2016,4,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('5f504a0f-a1ce-46ec-85b3-391819d6a141','022',0.000000,8.571500,2016,4,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('6039d2c4-5e15-4916-b75b-a209f5f7302d','003',0.000000,1.424200,2016,5,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('650b26cf-37c5-4799-a135-6cdf7042d048','011',0.000000,17.092200,2016,5,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('67f61838-1bcf-4dde-a89d-73fbc7151af1','026',0.000000,17.092200,2016,5,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('6806c840-de0d-41a0-b323-e2989ff3f741','015',0.000000,20.510600,2016,5,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('6c749f3e-31d7-4555-80ad-4d7fbc84528a','030',0.000000,5.696800,2016,5,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('6dfdccf5-7a2a-418c-ad3b-ed59adfe164f','030',0.000000,2.856900,2016,4,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('78a15019-65b4-4ba2-89ed-4f3941032d62','007',0.000000,34.184300,2016,5,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('87f5d1c9-27e2-4947-b116-b4626234dbfb','033',0.000000,5.698500,2016,5,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('88b3c5cd-81b6-4712-b0ad-2594ac4159c7','014',0.000000,13.673700,2016,5,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('8c7f10e8-58bc-440d-a816-33e8592e3bda','012',0.000000,34.184300,2016,5,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('8fc999c6-bd97-49d9-8f49-621c20939d81','040',0.000000,3.428567,2016,4,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('929a93f7-1ce4-4d3a-9a4e-7e3b665cfc0c','034',0.000000,2.857700,2016,4,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('97abf586-0a5e-464b-9b64-060d31ca7cc9','0001',0.000000,85.714300,2016,4,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('98f8d67a-52e8-4eb3-91f3-949cb97a1314','037',0.000000,3.428600,2016,4,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('9a814b0e-8529-4100-9792-9ccfd1af9431','023',0.000000,17.142900,2016,4,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('a0fd9125-036d-4975-acc0-0fefbbee1912','014',0.000000,6.857200,2016,4,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('a26c1834-9afd-4ae2-9d41-e61d728a4447','036',0.000000,3.428600,2016,4,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('a8ffdaad-6a25-46db-8524-33433295254e','016',0.000000,6.836867,2016,5,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('ad6a238f-6b8a-4733-9ed8-2c1a97349839','010',0.000000,17.092200,2016,5,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('aed86498-9e2d-41e9-80d4-f92992f43076','021',0.000000,8.571500,2016,4,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('b4932d18-8177-46f1-ad6f-bf47ca804dbf','021',0.000000,17.092200,2016,5,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('ba3d6181-ce11-4670-95aa-1d8027a6deeb','011',0.000000,8.571500,2016,4,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('be8140b8-4495-4222-b00f-3d32c93d6d12','027',0.000000,1.424200,2016,5,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('cbf4e507-7f5d-42eb-8d14-749ada3f4ac4','034',0.000000,5.698500,2016,5,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('d0c34105-0bab-4d87-bca4-bcde8555ccce','026',0.000000,8.571500,2016,4,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('d5a7d29c-0042-4148-b351-f962be30bb3d','007',0.000000,17.142900,2016,4,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('d88da990-0755-4f3f-9d5e-978e2e4e25bb','006',0.000000,17.142900,2016,4,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('dd2add05-2239-42f3-b48e-c7991024ce3a','023',0.000000,34.184300,2016,5,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('dda82a72-5bae-40d5-a606-3fdf54b1af72','039',0.000000,3.428567,2016,4,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('de2c8a32-c52f-4a2e-8c81-9dd0ac8a6c1a','039',0.000000,6.836867,2016,5,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('e04be9f7-1859-42fe-b197-dcf7ae8e2185','003',0.000000,0.714225,2016,4,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('e2e1f678-adc9-422d-87e1-3951d9a9e74d','005',0.000000,1.424200,2016,5,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('e4255e78-7f23-46c5-aa59-6cd0c618a8f5','037',0.000000,6.836900,2016,5,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('e445bf51-72d4-4167-b689-3359d65e0c26','025',0.000000,1.714300,2016,4,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('eeb2ed97-276a-4b84-8e03-988d1bef031d','0002',0.000000,136.737100,2016,5,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('f2f0b634-fbf8-432e-9e80-78f00ebf8eeb','022',0.000000,17.092200,2016,5,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('f73dcb74-36f8-42c1-a377-1fd4a7bc2be8','015',0.000000,10.285700,2016,4,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('faf5ecb0-335f-410c-900a-877cbf66e170','010',0.000000,8.571500,2016,4,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('fc59189c-4b88-4357-a166-71a50293e487','020',0.000000,34.184300,2016,5,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8'),('fdb5ab11-835a-455c-b7ef-aea6f1b7da5c','040',0.000000,6.836867,2016,5,'','20140404','91e17323-e3eb-42b3-b662-04fd3043b1d8');
/*!40000 ALTER TABLE `t_assignment_performance` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_code_table`
--

DROP TABLE IF EXISTS `t_code_table`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_code_table` (
  `ID` varchar(40) NOT NULL,
  `NAME` varchar(100) NOT NULL,
  `DESCRIPTION` varchar(2000) DEFAULT NULL,
  `ENABLED` tinyint(1) NOT NULL,
  UNIQUE KEY `INDEX_1` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_code_table`
--

LOCK TABLES `t_code_table` WRITE;
/*!40000 ALTER TABLE `t_code_table` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_code_table` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_employee`
--

DROP TABLE IF EXISTS `t_employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_employee` (
  `ID` varchar(40) NOT NULL,
  `LEADER_ID` varchar(40) DEFAULT NULL,
  `POSITION_ID` varchar(40) DEFAULT NULL,
  `NAME` varchar(100) NOT NULL,
  `DESCRIPTION` varchar(2000) DEFAULT NULL,
  `ENTRY_TIME` date NOT NULL,
  `DISMISSION_TIME` date DEFAULT NULL,
  `ENABLED` tinyint(1) NOT NULL,
  UNIQUE KEY `INDEX_3` (`ID`),
  KEY `INDEX_2` (`POSITION_ID`),
  KEY `INDEX_4` (`LEADER_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_employee`
--

LOCK TABLES `t_employee` WRITE;
/*!40000 ALTER TABLE `t_employee` DISABLE KEYS */;
INSERT INTO `t_employee` VALUES ('0001',NULL,'0000000000','邹伟','总经理','2000-01-01',NULL,1),('0002','0001','0200000000','王辉',NULL,'2006-01-01',NULL,1),('003','026','0204030100','机电李四','机电组长','2006-01-01',NULL,1),('004','026','0204030100','机电王二',NULL,'2006-01-01',NULL,1),('005','026','0204030100','机电张三 ',NULL,'2006-01-01',NULL,1),('006','0001','0100000000','客服经理1',NULL,'2006-01-01',NULL,1),('007','006','0101000000','顾客管理员1',NULL,'2006-01-01',NULL,1),('008','006','0102000000','信息员1',NULL,'2006-01-01',NULL,1),('009','0002','0201000000','保险部经理1',NULL,'2006-01-01',NULL,1),('010','009','0201010000','事故专员1',NULL,'2006-01-01',NULL,1),('011','009','0201020000','电话车险销售1',NULL,'2006-01-01',NULL,1),('012','0002','0202000000','服务经理',NULL,'2006-01-01',NULL,1),('013','012','0202010000','非技术内训师1',NULL,'2006-01-01',NULL,1),('014','012','0202020000','索赔员1',NULL,'2006-01-01',NULL,1),('015','012','0202030000','前台主管1',NULL,'2006-01-01',NULL,1),('016','015','0202030100','服务顾问1',NULL,'2006-01-01',NULL,1),('017','016','0202030201','实习服务顾问1',NULL,'2006-01-01',NULL,1),('018','015','0202030200','休息区服务专员1',NULL,'2006-01-01',NULL,1),('019','012','0202040000','网络管理员1',NULL,'2006-01-01',NULL,1),('020','0002','0203000000','配件经理1',NULL,'2006-01-01',NULL,1),('021','020','0203010000','库管员1',NULL,'2006-01-01',NULL,1),('022','020','0203020000','配件计划员1',NULL,'2006-01-01',NULL,1),('023','0002','0204000000','技术经理1',NULL,'2006-01-01',NULL,1),('024','023','0204010000','技术内训师1',NULL,'2006-01-01',NULL,1),('025','023','0204020000','质检员1',NULL,'2006-01-01',NULL,1),('026','023','0204030000','车间主管1',NULL,'2006-01-01',NULL,1),('027','026','0204030100','机电组长1',NULL,'2006-01-01',NULL,1),('028','027','0204030101','机电技师1',NULL,'2006-01-01',NULL,1),('029','027','0204030102','机电学徒1',NULL,'2006-01-01',NULL,1),('030','026','0204030200','钣金组长1',NULL,'2006-01-01',NULL,1),('031','030','0204030201','钣金技师',NULL,'2006-01-01',NULL,1),('032','030','0204030202','钣金学徒',NULL,'2006-01-01',NULL,1),('033','026','0204030300','漆工组长',NULL,'2006-01-01',NULL,1),('034','033','0204030301','漆工技师',NULL,'2006-01-01',NULL,1),('035','033','0204030302','漆工学徒',NULL,'2006-01-01',NULL,1),('036','023','0204040000','PDI专员',NULL,'2006-01-01',NULL,1),('037','023','0204050000','救急专员',NULL,'2006-01-01',NULL,1),('038','023','0204060000','废料收集员',NULL,'2006-01-01',NULL,1),('039','015','0202030100','服务顾问2',NULL,'2006-01-01',NULL,1),('040','015','0202030100','服务顾问3',NULL,'2006-01-01',NULL,1);
/*!40000 ALTER TABLE `t_employee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_employee_salary_detail`
--

DROP TABLE IF EXISTS `t_employee_salary_detail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_employee_salary_detail` (
  `ID` varchar(40) NOT NULL,
  `EMPLOYEE_ID` varchar(40) NOT NULL,
  `SALARY_ITEM_ID` varchar(40) NOT NULL,
  `SALARY_YEAR` int(11) NOT NULL,
  `SALARY_MONTH` int(11) NOT NULL,
  `AMOUNT` decimal(10,2) NOT NULL,
  `VERSION_ID` varchar(40) NOT NULL,
  UNIQUE KEY `INDEX_1` (`ID`),
  KEY `INDEX_2` (`EMPLOYEE_ID`),
  KEY `INDEX_3` (`SALARY_ITEM_ID`),
  KEY `INDEX_4` (`VERSION_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_employee_salary_detail`
--

LOCK TABLES `t_employee_salary_detail` WRITE;
/*!40000 ALTER TABLE `t_employee_salary_detail` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_employee_salary_detail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_evaluation_form`
--

DROP TABLE IF EXISTS `t_evaluation_form`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_evaluation_form` (
  `ID` varchar(40) NOT NULL,
  `NAME` varchar(100) NOT NULL,
  `DESCRIPTION` varchar(2000) NOT NULL,
  `ENABLED` tinyint(1) NOT NULL,
  `VERSION_ID` varchar(40) NOT NULL,
  `POSITION_ID` varchar(40) NOT NULL,
  UNIQUE KEY `INDEX_2` (`ID`),
  KEY `INDEX_3` (`VERSION_ID`),
  KEY `INDEX_4` (`POSITION_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_evaluation_form`
--

LOCK TABLES `t_evaluation_form` WRITE;
/*!40000 ALTER TABLE `t_evaluation_form` DISABLE KEYS */;
INSERT INTO `t_evaluation_form` VALUES ('0001','KPI','KPI',1,'20160401','0204030100'),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','CSI','CSI',1,'20160401','9999999999');
/*!40000 ALTER TABLE `t_evaluation_form` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_evaluation_form_items`
--

DROP TABLE IF EXISTS `t_evaluation_form_items`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_evaluation_form_items` (
  `EVALUATION_FORM_ID` varchar(40) NOT NULL,
  `EVALUATION_FORM_ITEM_ID` varchar(40) NOT NULL,
  `VERSION_ID` varchar(40) NOT NULL,
  `ENABLED` tinyint(1) NOT NULL,
  `SHOW_ORDER` int(11) NOT NULL,
  UNIQUE KEY `INDEX_1` (`EVALUATION_FORM_ID`,`EVALUATION_FORM_ITEM_ID`),
  KEY `INDEX_3` (`VERSION_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_evaluation_form_items`
--

LOCK TABLES `t_evaluation_form_items` WRITE;
/*!40000 ALTER TABLE `t_evaluation_form_items` DISABLE KEYS */;
INSERT INTO `t_evaluation_form_items` VALUES ('0001','0001','20160401',1,0),('0001','0002','20160401',1,1),('0001','0003','20160401',1,2),('0001','0004','20160401',1,3),('0001','0005','20160401',1,4),('0001','0006','20160401',1,5),('0001','0007','20160401',1,6),('0001','0008','20160401',1,7),('0001','0009','20160401',1,8),('0001','0010','20160401',1,9),('0001','0011','20160401',1,10),('0001','0012','20160401',1,11),('0001','0013','20160401',1,12),('0001','0014','20160401',1,13),('0001','0015','20160401',1,14),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0016','20160401',1,0),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0017','20160401',1,1),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0018','20160401',1,2),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0019','20160401',1,3),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0020','20160401',1,4),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0021','20160401',1,5),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0022','20160401',1,6),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0023','20160401',1,7),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0024','20160401',1,8),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0025','20160401',1,9),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0026','20160401',1,10),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0027','20160401',1,11),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0028','20160401',1,12),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0029','20160401',1,13),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0030','20160401',1,14),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0031','20160401',1,15),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0032','20160401',1,16),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0033','20160401',1,17),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0034','20160401',1,18),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0035','20160401',1,19),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0036','20160401',1,20),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0037','20160401',1,21),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0038','20160401',1,22),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0039','20160401',1,23),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0040','20160401',1,24),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0041','20160401',1,25),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0042','20160401',1,26),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0043','20160401',1,27),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0044','20160401',1,28),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0045','20160401',1,29);
/*!40000 ALTER TABLE `t_evaluation_form_items` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_evaluation_item`
--

DROP TABLE IF EXISTS `t_evaluation_item`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_evaluation_item` (
  `ID` varchar(40) NOT NULL,
  `NAME` varchar(100) NOT NULL,
  `DESCRIPTION` varchar(2000) DEFAULT NULL,
  `TYPE` varchar(40) NOT NULL,
  `FULL_MARK` decimal(10,2) NOT NULL,
  `ENABLED` tinyint(1) NOT NULL,
  `VERSION_ID` varchar(40) NOT NULL,
  `POSITION_ID` varchar(40) NOT NULL,
  UNIQUE KEY `INDEX_1` (`ID`),
  KEY `INDEX_2` (`VERSION_ID`),
  KEY `INDEX_3` (`TYPE`),
  KEY `INDEX_4` (`POSITION_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_evaluation_item`
--

LOCK TABLES `t_evaluation_item` WRITE;
/*!40000 ALTER TABLE `t_evaluation_item` DISABLE KEYS */;
INSERT INTO `t_evaluation_item` VALUES ('0001','出勤记录','按照公司考勤制度要求，无迟到、早退、旷工、中途脱岗，病事假能按公司要求办理请假手续。（迟到、早退每次扣0.5分；旷工每次口3分）','008',10.00,1,'20160401','0204030100'),('0002','工作纪律','工作时间无睡觉、上网、聊QQ、吃零食、聚众闲聊、大声喧哗；（上班时间做工作无关的事，每次口0.5分）','008',10.00,1,'20160401','0204030100'),('0003','仪容仪表','按公司要求统一着装，工作服保持干净、整洁','008',5.00,1,'20160401','0204030100'),('0004','仪容仪表','保持良好的个人卫生、无异味、无怪异发型；仪表端庄、大方，语言得体','008',5.00,1,'20160401','0204030100'),('0005','交车合格率','按车间内外返制度执行（內返每次扣0.5分，外返每次扣2分；3DC回访派单每次扣1分','007',10.00,1,'20160401','0204030100'),('0006','培训合格率','未按要求参加技术内训，每次扣1.5分','007',6.00,1,'20160401','0204030100'),('0007','培训合格率','培训考核不合格，每次扣2分','007',4.00,1,'20160401','0204030100'),('0008','管理与执行能力','管控并协调组员之间的工作进度；按时、保质的完成车间分配的工作。（出现消极怠工、出状况而不作为，每次扣1分）','007',10.00,1,'20160401','0204030100'),('0009','工具设备','定期检查，不合格每次扣1分','009',5.00,1,'20160401','0204030100'),('0010','卫生区域','所属卫生区域检查不合格每次扣0.5分','009',5.00,1,'20160401','0204030100'),('0011','操作规范','未按规定流程操作，每次扣1分','009',10.00,1,'20160401','0204030100'),('0012','安全生产','禁烟区内吸烟，每次扣1分；发现他人在禁烟区内吸烟未劝阻，每次扣0.5分','009',5.00,1,'20160401','0204030100'),('0013','安全生产','因野蛮操作造成车辆、工具设备受损，人员受伤，每次扣1分','009',5.00,1,'20160401','0204030100'),('0014','CSI得分',NULL,'002',10.00,1,'20160401','0204030100'),('0015','特别业绩','积极参与疑难问题的解决；提出合理化建议，并有效实施；提高工作效率；（可酌情加分）','010',10.00,1,'20160401','0204030100'),('0016','及时接待','','011',1.00,1,'20160401','9999999999'),('0017','售后服务六件套',NULL,'011',1.00,1,'20160401','9999999999'),('0018','环车检查',NULL,'011',1.00,1,'20160401','9999999999'),('0019','贵重物品提醒',NULL,'011',1.00,1,'20160401','9999999999'),('0020','估时估价',NULL,'011',1.00,1,'20160401','9999999999'),('0021','服务响应',NULL,'011',1.00,1,'20160401','9999999999'),('0022','主动问候',NULL,'011',1.00,1,'20160401','9999999999'),('0023','引导休息',NULL,'011',1.00,1,'20160401','9999999999'),('0024','无线网络覆盖',NULL,'011',1.00,1,'20160401','9999999999'),('0025','洗手间环境',NULL,'011',1.00,1,'20160401','9999999999'),('0026','顾客休息区舒适程度',NULL,'011',1.00,1,'20160401','9999999999'),('0027','饮品提供及续杯',NULL,'011',1.00,1,'20160401','9999999999'),('0028','维修进度汇报',NULL,'011',1.00,1,'20160401','9999999999'),('0029','服务人员专业知识',NULL,'011',1.00,1,'20160401','9999999999'),('0030','预估时间内交车',NULL,'011',1.00,1,'20160401','9999999999'),('0031','车辆状态保持',NULL,'011',1.00,1,'20160401','9999999999'),('0032','洗车服务',NULL,'011',1.00,1,'20160401','9999999999'),('0033','旧件展示',NULL,'011',1.00,1,'20160401','9999999999'),('0034','轮胎杂物清理',NULL,'011',1.00,1,'20160401','9999999999'),('0035','维修成果展示',NULL,'011',1.00,1,'20160401','9999999999'),('0036','解释服务项目及收费',NULL,'011',1.00,1,'20160401','9999999999'),('0037','下次保养提醒',NULL,'011',1.00,1,'20160401','9999999999'),('0038','协助提车',NULL,'011',1.00,1,'20160401','9999999999'),('0039','礼貌送行',NULL,'011',1.00,1,'20160401','9999999999'),('0040','服务追踪',NULL,'011',1.00,1,'20160401','9999999999'),('0041','车辆故障一次性修复',NULL,'011',1.00,1,'20160401','9999999999'),('0042','维修时间满意情况',NULL,'011',1.00,1,'20160401','9999999999'),('0043','未接受顾客礼物或财物',NULL,'011',1.00,1,'20160401','9999999999'),('0044','100%车辆全生命周期关怀回访',NULL,'011',1.00,1,'20160401','9999999999'),('0045','推荐购买/再次购买',NULL,'011',1.00,1,'20160401','9999999999');
/*!40000 ALTER TABLE `t_evaluation_item` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_evaluation_item_type`
--

DROP TABLE IF EXISTS `t_evaluation_item_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_evaluation_item_type` (
  `ID` varchar(40) NOT NULL,
  `NAME` varchar(100) NOT NULL,
  `DESCRIPTION` varchar(2000) DEFAULT NULL,
  `ENABLED` tinyint(1) NOT NULL,
  UNIQUE KEY `INDEX_1` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_evaluation_item_type`
--

LOCK TABLES `t_evaluation_item_type` WRITE;
/*!40000 ALTER TABLE `t_evaluation_item_type` DISABLE KEYS */;
INSERT INTO `t_evaluation_item_type` VALUES ('001','业绩',NULL,1),('002','满意度',NULL,1),('003','服务流程',NULL,1),('004','基础工作',NULL,1),('005','工作态度',NULL,1),('006','关键事件',NULL,1),('007','岗位职责',NULL,1),('008','基础管理',NULL,1),('009','6S管理',NULL,1),('010','加分项',NULL,1),('011','CSI',NULL,1),('143acac5-ae06-4c13-85bb-eaf9b6068f17','ff',NULL,1),('21fc4961-cb04-4cab-a099-4f94acf9e815','aaa',NULL,1);
/*!40000 ALTER TABLE `t_evaluation_item_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_evaluation_results`
--

DROP TABLE IF EXISTS `t_evaluation_results`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_evaluation_results` (
  `ID` varchar(40) NOT NULL,
  `DESCRIPTION` varchar(2000) DEFAULT NULL,
  `EMPLOYEE_ID` varchar(40) NOT NULL COMMENT '被考核人',
  `EVALUATION_YEAR` int(11) NOT NULL,
  `EVALUATION_MONTH` int(11) NOT NULL,
  `EVALUATOR` varchar(40) NOT NULL,
  `EVALUATION_FORM_ID` varchar(40) NOT NULL,
  `EVALUATION_ITEM_ID` varchar(40) NOT NULL,
  `EVALUATION_TIME` date NOT NULL,
  `MARK` decimal(10,2) NOT NULL,
  `VERSION_ID` varchar(40) NOT NULL,
  UNIQUE KEY `INDEX_1` (`ID`),
  KEY `INDEX_2` (`EMPLOYEE_ID`),
  KEY `INDEX_3` (`EVALUATOR`),
  KEY `INDEX_4` (`EVALUATION_FORM_ID`),
  KEY `INDEX_5` (`EVALUATION_ITEM_ID`),
  KEY `INDEX_6` (`VERSION_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_evaluation_results`
--

LOCK TABLES `t_evaluation_results` WRITE;
/*!40000 ALTER TABLE `t_evaluation_results` DISABLE KEYS */;
INSERT INTO `t_evaluation_results` VALUES ('0d9bdcb3-7cdf-4c9c-a340-1dbed20d99f0','','003',2016,3,'nobody','0001','0001','2016-04-18',7.00,'20160401'),('0f54add3-afc5-407d-9761-8ae269501c22','','003',2016,3,'nobody','6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0043','2016-04-18',1.00,'20160401'),('149e82de-0853-4ccd-ae07-6eda98bd5672','','003',2016,3,'nobody','6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0038','2016-04-18',1.00,'20160401'),('15ac7d34-bcd4-4d7c-836b-863f8e6baa7a','','003',2016,3,'nobody','6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0022','2016-04-18',1.00,'20160401'),('16fd16bf-0667-4bf1-afb4-9b997503e5a9','','003',2016,3,'nobody','6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0019','2016-04-18',1.00,'20160401'),('1d7780ca-9072-45cc-b10d-7ab3bd331868','','003',2016,3,'nobody','6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0030','2016-04-18',1.00,'20160401'),('1eb99864-ee10-4bdf-82a0-6c21689c4e4d','','003',2016,3,'nobody','6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0041','2016-04-18',1.00,'20160401'),('1fb8829a-5a50-4bb5-a8e1-f96530b1392f','','003',2016,3,'nobody','6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0036','2016-04-18',1.00,'20160401'),('368d9428-fc62-4dd5-9721-d840f5146169','','003',2016,3,'nobody','0001','0004','2016-04-18',4.00,'20160401'),('36abf599-c98d-4974-965d-f8d8a1170d73','','003',2016,3,'nobody','0001','0005','2016-04-18',7.00,'20160401'),('3892d19a-f973-46c3-b9bc-c6a3bb123540','','003',2016,3,'nobody','6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0037','2016-04-18',1.00,'20160401'),('3e86e362-43a4-4fe2-a19b-2d4fd1cd8246','','003',2016,3,'nobody','6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0039','2016-04-18',1.00,'20160401'),('3f46e09c-1696-4ede-8dee-fd44f81b7b93','','003',2016,3,'nobody','6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0020','2016-04-18',1.00,'20160401'),('417d9ca4-b79b-4b82-b141-ec4e1c684bed','','003',2016,3,'nobody','6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0017','2016-04-18',1.00,'20160401'),('43a63e79-0a0c-475d-9c2a-0e4e389f48f1','','003',2016,3,'nobody','6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0044','2016-04-18',1.00,'20160401'),('4fda744c-9b4c-486d-b4d8-c530e08ed469','','003',2016,3,'nobody','6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0034','2016-04-18',1.00,'20160401'),('57ad5035-651b-4524-a51c-9bd98ef97162','','003',2016,3,'nobody','6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0025','2016-04-18',1.00,'20160401'),('61c77e78-2bfe-4bc7-a0bf-c56c76dbda4b','','003',2016,3,'nobody','0001','0007','2016-04-18',4.00,'20160401'),('69a1134b-3975-4d27-b59e-b728333625f4','','003',2016,3,'nobody','0001','0009','2016-04-18',3.00,'20160401'),('6a47e047-1d33-4621-a3da-5e01505fe036','','003',2016,3,'nobody','6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0028','2016-04-18',1.00,'20160401'),('7820d6a2-25a7-46a6-b55b-13b15517a1ee','','003',2016,3,'nobody','6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0016','2016-04-18',1.00,'20160401'),('868d6a0f-09c0-4b06-9c0c-d7465b52f431','','003',2016,3,'nobody','6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0040','2016-04-18',1.00,'20160401'),('8bdd3f67-277d-4f2d-8a80-ad4ec56d8522','','003',2016,3,'nobody','6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0026','2016-04-18',1.00,'20160401'),('8e7b6ac4-a257-4507-9cb7-21f4b4f89d68','','003',2016,3,'nobody','0001','0003','2016-04-18',4.00,'20160401'),('915e830a-f7ab-4da8-b9a6-2b0a5ffb326d','','003',2016,3,'nobody','6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0027','2016-04-18',1.00,'20160401'),('9d769642-3474-4577-8449-19c932920fc7','','003',2016,3,'nobody','6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0042','2016-04-18',1.00,'20160401'),('a674e55f-3fd6-4db3-a8f7-7c3e0e000623','','003',2016,3,'nobody','6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0018','2016-04-18',1.00,'20160401'),('ab7560df-a86b-4c11-a873-f6864419de81','','003',2016,3,'nobody','0001','0011','2016-04-18',7.00,'20160401'),('ac681e0d-94ca-4288-b1cc-401ed51c8cd7','','003',2016,3,'nobody','6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0045','2016-04-18',1.00,'20160401'),('b2210fe5-3328-473d-bdc1-61eb1e292853','','003',2016,3,'nobody','0001','0002','2016-04-18',7.00,'20160401'),('b437ec07-1928-4520-a5bc-27e0eb9c0f8b','','003',2016,3,'nobody','0001','0014','2016-04-18',7.00,'20160401'),('b757d763-f449-443a-8efd-71b1e0695041','','003',2016,3,'nobody','0001','0015','2016-04-18',7.00,'20160401'),('bce10336-c2d0-4312-af68-2515875763ab','','003',2016,3,'nobody','6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0031','2016-04-18',1.00,'20160401'),('c319024c-aacc-4a16-8d97-29b0e7d12b0e','','003',2016,3,'nobody','0001','0010','2016-04-18',3.00,'20160401'),('c3eb5125-5895-49c4-a087-d89a3e54a90b','','003',2016,3,'nobody','0001','0006','2016-04-18',5.00,'20160401'),('c5c8cd6d-4998-4f5b-8081-9f72babdafd9','','003',2016,3,'nobody','0001','0008','2016-04-18',7.00,'20160401'),('ccbd7ed5-db7b-436b-bc54-5cae119f355f','','003',2016,3,'nobody','6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0033','2016-04-18',1.00,'20160401'),('ce445ea2-f817-4f27-a74a-ea902b90e5a4','','003',2016,3,'nobody','6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0023','2016-04-18',1.00,'20160401'),('d19b25d6-9da9-4c69-b275-b062cea46a6c','','003',2016,3,'nobody','0001','0013','2016-04-18',3.00,'20160401'),('d1beb7c7-95ae-41b3-bdfe-5908a045e558','','003',2016,3,'nobody','6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0035','2016-04-18',1.00,'20160401'),('e4eaeb52-f56b-4fe4-b8c4-9dba101aef0e','','003',2016,3,'nobody','6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0029','2016-04-18',1.00,'20160401'),('f3bdffd3-3362-4ac7-9c5a-8c397b8526be','','003',2016,3,'nobody','0001','0012','2016-04-18',3.00,'20160401'),('f4652947-7bc9-45ce-8d41-aaec5076dfa2','','003',2016,3,'nobody','6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0021','2016-04-18',1.00,'20160401'),('f89c5ab0-7c7e-4f68-b929-ba0ccb772c21','','003',2016,3,'nobody','6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0032','2016-04-18',1.00,'20160401'),('fb304d78-0d68-4bff-8eeb-e0037dddc58c','','003',2016,3,'nobody','6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0024','2016-04-18',1.00,'20160401');
/*!40000 ALTER TABLE `t_evaluation_results` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_evaluation_standard`
--

DROP TABLE IF EXISTS `t_evaluation_standard`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_evaluation_standard` (
  `ID` varchar(40) NOT NULL,
  `NAME` varchar(100) NOT NULL,
  `DESCRIPTION` varchar(2000) DEFAULT NULL,
  `ENABLED` tinyint(1) NOT NULL DEFAULT '1',
  `ITEM_ID` varchar(40) NOT NULL,
  `SHOW_ORDER` int(11) NOT NULL DEFAULT '0',
  `VERSION_ID` varchar(40) NOT NULL,
  UNIQUE KEY `INDEX_1` (`ID`),
  KEY `INDEX_2` (`ITEM_ID`),
  KEY `INDEX_3` (`VERSION_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_evaluation_standard`
--

LOCK TABLES `t_evaluation_standard` WRITE;
/*!40000 ALTER TABLE `t_evaluation_standard` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_evaluation_standard` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_position`
--

DROP TABLE IF EXISTS `t_position`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_position` (
  `ID` varchar(40) NOT NULL,
  `LEADER_ID` varchar(40) DEFAULT NULL,
  `NAME` varchar(100) NOT NULL,
  `DESCRIPTION` varchar(2000) DEFAULT NULL,
  `ENABLED` tinyint(1) NOT NULL,
  UNIQUE KEY `岗位表_PK` (`ID`),
  KEY `上级岗位编号_FK` (`LEADER_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_position`
--

LOCK TABLES `t_position` WRITE;
/*!40000 ALTER TABLE `t_position` DISABLE KEYS */;
INSERT INTO `t_position` VALUES ('0000000000',NULL,'总经理','',1),('0100000000','0000000000','客服经理','',1),('0101000000','0100000000','顾客管理员','',1),('0102000000','0100000000','信息员','',1),('0200000000','0000000000','服务总监','',1),('0201000000','0200000000','保险部经理','',1),('0201010000','0201000000','事故专员','',1),('0201020000','0201000000','电话车险销售员','',1),('0202000000','0200000000','服务经理','',1),('0202010000','0202000000','非技术内训师','',1),('0202020000','0202000000','索赔员','',1),('0202030000','0202000000','前台主管','',1),('0202030100','0202030000','服务顾问','',1),('0202030200','0202030000','休息区服务专员','',1),('0202040000','0202000000','网络管理员','',1),('0203000000','0200000000','配件经理','',1),('0203010000','0203000000','库管员','',1),('0203020000','0203000000','配件计划员','',1),('0203030101','0202030100','实习服务顾问','',1),('0204000000','0200000000','技术经理','',1),('0204010000','0204000000','技术内训师','',1),('0204020000','0204000000','质检员','',1),('0204030000','0204000000','车间主管','',1),('0204030100','0204030000','机电组长','',1),('0204030101','0204030100','机电技师','',1),('0204030102','0204030100','机电学徒','',1),('0204030200','0204030000','钣金组长','',1),('0204030201','0204030200','钣金技师','',1),('0204030202','0204030200','钣金学徒','',1),('0204030300','0204030000','漆工组长','',1),('0204030301','0204030300','漆工技师','',1),('0204030302','0204030300','漆工学徒','',1),('0204040000','0204000000','PDI专员','',1),('0204050000','0204000000','救急专员','',1),('0204060000','0204000000','废料收集员','',1),('9999999999',NULL,'通用岗位','通用岗位',1);
/*!40000 ALTER TABLE `t_position` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_position_assignments`
--

DROP TABLE IF EXISTS `t_position_assignments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_position_assignments` (
  `ASSIGNMENT_ID` varchar(40) NOT NULL,
  `POSITION_ID` varchar(40) NOT NULL,
  `ENABLED` tinyint(1) NOT NULL,
  `VERSION_ID` varchar(40) NOT NULL,
  `WEIGHT` decimal(10,2) NOT NULL,
  `VALUE` decimal(20,6) NOT NULL,
  UNIQUE KEY `INDEX_1` (`ASSIGNMENT_ID`,`POSITION_ID`),
  KEY `INDEX_2` (`VERSION_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_position_assignments`
--

LOCK TABLES `t_position_assignments` WRITE;
/*!40000 ALTER TABLE `t_position_assignments` DISABLE KEYS */;
INSERT INTO `t_position_assignments` VALUES ('4de125fc-020c-4aaa-9d9b-12b913f40d82','0000000000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0100000000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0101000000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0102000000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0200000000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0201000000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0201010000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0201020000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0202000000',1,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0202010000',1,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0202020000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0202030000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0202030100',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0202030200',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0202040000',1,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0203000000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0203010000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0203020000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0203030101',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0204000000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0204010000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0204020000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0204030000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0204030100',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0204030101',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0204030102',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0204030200',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0204030201',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0204030202',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0204030300',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0204030301',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0204030302',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0204040000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0204050000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0204060000',0,'20140404',100.00,0.000000),('91e17323-e3eb-42b3-b662-04fd3043b1d8','0000000000',1,'20140404',100.00,100.000000),('91e17323-e3eb-42b3-b662-04fd3043b1d8','0100000000',1,'20140404',100.00,20.000000),('91e17323-e3eb-42b3-b662-04fd3043b1d8','0101000000',1,'20140404',100.00,100.000000),('91e17323-e3eb-42b3-b662-04fd3043b1d8','0102000000',0,'20140404',100.00,0.000000),('91e17323-e3eb-42b3-b662-04fd3043b1d8','0200000000',1,'20140404',100.00,80.000000),('91e17323-e3eb-42b3-b662-04fd3043b1d8','0201000000',1,'20140404',100.00,25.000000),('91e17323-e3eb-42b3-b662-04fd3043b1d8','0201010000',1,'20140404',100.00,50.000000),('91e17323-e3eb-42b3-b662-04fd3043b1d8','0201020000',1,'20140404',100.00,50.000000),('91e17323-e3eb-42b3-b662-04fd3043b1d8','0202000000',1,'20140404',100.00,25.000000),('91e17323-e3eb-42b3-b662-04fd3043b1d8','0202010000',0,'20140404',100.00,0.000000),('91e17323-e3eb-42b3-b662-04fd3043b1d8','0202020000',1,'20140404',100.00,40.000000),('91e17323-e3eb-42b3-b662-04fd3043b1d8','0202030000',1,'20140404',100.00,60.000000),('91e17323-e3eb-42b3-b662-04fd3043b1d8','0202030100',1,'20140404',100.00,100.000000),('91e17323-e3eb-42b3-b662-04fd3043b1d8','0202030200',0,'20140404',100.00,0.000000),('91e17323-e3eb-42b3-b662-04fd3043b1d8','0202040000',0,'20140404',100.00,0.000000),('91e17323-e3eb-42b3-b662-04fd3043b1d8','0203000000',1,'20140404',100.00,25.000000),('91e17323-e3eb-42b3-b662-04fd3043b1d8','0203010000',1,'20140404',100.00,50.000000),('91e17323-e3eb-42b3-b662-04fd3043b1d8','0203020000',1,'20140404',100.00,50.000000),('91e17323-e3eb-42b3-b662-04fd3043b1d8','0203030101',0,'20140404',100.00,0.000000),('91e17323-e3eb-42b3-b662-04fd3043b1d8','0204000000',1,'20140404',100.00,25.000000),('91e17323-e3eb-42b3-b662-04fd3043b1d8','0204010000',0,'20140404',100.00,0.000000),('91e17323-e3eb-42b3-b662-04fd3043b1d8','0204020000',1,'20140404',100.00,10.000000),('91e17323-e3eb-42b3-b662-04fd3043b1d8','0204030000',1,'20140404',100.00,50.000000),('91e17323-e3eb-42b3-b662-04fd3043b1d8','0204030100',1,'20140404',100.00,33.330000),('91e17323-e3eb-42b3-b662-04fd3043b1d8','0204030101',1,'20140404',100.00,100.000000),('91e17323-e3eb-42b3-b662-04fd3043b1d8','0204030102',0,'20140404',100.00,0.000000),('91e17323-e3eb-42b3-b662-04fd3043b1d8','0204030200',1,'20140404',100.00,33.330000),('91e17323-e3eb-42b3-b662-04fd3043b1d8','0204030201',1,'20140404',100.00,100.000000),('91e17323-e3eb-42b3-b662-04fd3043b1d8','0204030202',0,'20140404',100.00,0.000000),('91e17323-e3eb-42b3-b662-04fd3043b1d8','0204030300',1,'20140404',100.00,33.340000),('91e17323-e3eb-42b3-b662-04fd3043b1d8','0204030301',1,'20140404',100.00,100.000000),('91e17323-e3eb-42b3-b662-04fd3043b1d8','0204030302',0,'20140404',100.00,0.000000),('91e17323-e3eb-42b3-b662-04fd3043b1d8','0204040000',1,'20140404',100.00,20.000000),('91e17323-e3eb-42b3-b662-04fd3043b1d8','0204050000',1,'20140404',100.00,20.000000),('91e17323-e3eb-42b3-b662-04fd3043b1d8','0204060000',0,'20140404',100.00,0.000000),('cac57f41-d92b-4894-b7b6-befd85c71aea','0000000000',1,'20140404',100.00,100.000000),('cac57f41-d92b-4894-b7b6-befd85c71aea','0100000000',1,'20140404',100.00,50.000000),('cac57f41-d92b-4894-b7b6-befd85c71aea','0101000000',1,'20140404',100.00,50.000000),('cac57f41-d92b-4894-b7b6-befd85c71aea','0102000000',1,'20140404',100.00,50.000000),('cac57f41-d92b-4894-b7b6-befd85c71aea','0200000000',1,'20140404',100.00,50.000000),('cac57f41-d92b-4894-b7b6-befd85c71aea','0201000000',1,'20140404',100.00,25.000000),('cac57f41-d92b-4894-b7b6-befd85c71aea','0201010000',1,'20140404',100.00,50.000000),('cac57f41-d92b-4894-b7b6-befd85c71aea','0201020000',1,'20140404',100.00,50.000000),('cac57f41-d92b-4894-b7b6-befd85c71aea','0202000000',1,'20140404',100.00,25.000000),('cac57f41-d92b-4894-b7b6-befd85c71aea','0202010000',1,'20140404',100.00,25.000000),('cac57f41-d92b-4894-b7b6-befd85c71aea','0202020000',1,'20140404',100.00,25.000000),('cac57f41-d92b-4894-b7b6-befd85c71aea','0202030000',1,'20140404',100.00,25.000000),('cac57f41-d92b-4894-b7b6-befd85c71aea','0202030100',1,'20140404',100.00,50.000000),('cac57f41-d92b-4894-b7b6-befd85c71aea','0202030200',1,'20140404',100.00,50.000000),('cac57f41-d92b-4894-b7b6-befd85c71aea','0202040000',1,'20140404',100.00,25.000000),('cac57f41-d92b-4894-b7b6-befd85c71aea','0203000000',1,'20140404',100.00,25.000000),('cac57f41-d92b-4894-b7b6-befd85c71aea','0203010000',1,'20140404',100.00,50.000000),('cac57f41-d92b-4894-b7b6-befd85c71aea','0203020000',1,'20140404',100.00,50.000000),('cac57f41-d92b-4894-b7b6-befd85c71aea','0203030101',1,'20140404',100.00,100.000000),('cac57f41-d92b-4894-b7b6-befd85c71aea','0204000000',1,'20140404',100.00,25.000000),('cac57f41-d92b-4894-b7b6-befd85c71aea','0204010000',1,'20140404',100.00,16.660000),('cac57f41-d92b-4894-b7b6-befd85c71aea','0204020000',1,'20140404',100.00,16.660000),('cac57f41-d92b-4894-b7b6-befd85c71aea','0204030000',1,'20140404',100.00,16.660000),('cac57f41-d92b-4894-b7b6-befd85c71aea','0204030100',1,'20140404',100.00,33.330000),('cac57f41-d92b-4894-b7b6-befd85c71aea','0204030101',1,'20140404',100.00,50.000000),('cac57f41-d92b-4894-b7b6-befd85c71aea','0204030102',1,'20140404',100.00,50.000000),('cac57f41-d92b-4894-b7b6-befd85c71aea','0204030200',1,'20140404',100.00,33.330000),('cac57f41-d92b-4894-b7b6-befd85c71aea','0204030201',1,'20140404',100.00,50.000000),('cac57f41-d92b-4894-b7b6-befd85c71aea','0204030202',1,'20140404',100.00,50.000000),('cac57f41-d92b-4894-b7b6-befd85c71aea','0204030300',1,'20140404',100.00,33.340000),('cac57f41-d92b-4894-b7b6-befd85c71aea','0204030301',1,'20140404',100.00,50.000000),('cac57f41-d92b-4894-b7b6-befd85c71aea','0204030302',1,'20140404',100.00,50.000000),('cac57f41-d92b-4894-b7b6-befd85c71aea','0204040000',1,'20140404',100.00,16.660000),('cac57f41-d92b-4894-b7b6-befd85c71aea','0204050000',1,'20140404',100.00,16.660000),('cac57f41-d92b-4894-b7b6-befd85c71aea','0204060000',1,'20140404',100.00,16.700000);
/*!40000 ALTER TABLE `t_position_assignments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_position_evaluation_forms`
--

DROP TABLE IF EXISTS `t_position_evaluation_forms`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_position_evaluation_forms` (
  `POSITION_ID` varchar(40) NOT NULL,
  `EVALUATION_FORM_ID` varchar(40) NOT NULL,
  `WEIGHT` decimal(10,2) NOT NULL,
  `ENABLED` tinyint(1) NOT NULL,
  `VERSION_ID` varchar(40) NOT NULL,
  UNIQUE KEY `INDEX_1` (`POSITION_ID`,`EVALUATION_FORM_ID`),
  KEY `INDEX_2` (`VERSION_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_position_evaluation_forms`
--

LOCK TABLES `t_position_evaluation_forms` WRITE;
/*!40000 ALTER TABLE `t_position_evaluation_forms` DISABLE KEYS */;
INSERT INTO `t_position_evaluation_forms` VALUES ('0204030100','0001',80.00,1,'20160401'),('0204030100','6dc3c933-1863-43b7-9d91-9b76ab8c69ec',20.00,1,'20160401'),('0204030301','6dc3c933-1863-43b7-9d91-9b76ab8c69ec',100.00,1,'20160401');
/*!40000 ALTER TABLE `t_position_evaluation_forms` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_position_salary_items`
--

DROP TABLE IF EXISTS `t_position_salary_items`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_position_salary_items` (
  `POSITION_ID` varchar(40) NOT NULL,
  `SALARY_ITEM_ID` varchar(40) NOT NULL,
  `VERSION_ID` varchar(40) NOT NULL,
  `ENABLED` tinyint(1) NOT NULL,
  UNIQUE KEY `INDEX_1` (`POSITION_ID`,`SALARY_ITEM_ID`),
  KEY `INDEX_2` (`VERSION_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_position_salary_items`
--

LOCK TABLES `t_position_salary_items` WRITE;
/*!40000 ALTER TABLE `t_position_salary_items` DISABLE KEYS */;
INSERT INTO `t_position_salary_items` VALUES ('0000000000','f51b21fb-9fad-41d8-9b93-a46040ed4b25','20160401',1),('0204030100','b01668d5-ec6b-45ea-a9c2-d07ee4ea8c37','20160401',1),('0204030100','f51b21fb-9fad-41d8-9b93-a46040ed4b25','20160401',1);
/*!40000 ALTER TABLE `t_position_salary_items` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_repository_assignment`
--

DROP TABLE IF EXISTS `t_repository_assignment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_repository_assignment` (
  `ID` varchar(40) NOT NULL,
  `NAME` varchar(100) NOT NULL,
  `DESCRIPTION` varchar(2000) DEFAULT NULL,
  `ENABLED` tinyint(1) NOT NULL,
  `CREATE_TIME` date NOT NULL,
  `CREATOR` varchar(40) NOT NULL,
  UNIQUE KEY `INDEX_1` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_repository_assignment`
--

LOCK TABLES `t_repository_assignment` WRITE;
/*!40000 ALTER TABLE `t_repository_assignment` DISABLE KEYS */;
INSERT INTO `t_repository_assignment` VALUES ('20140404','任务指标初始版本','任务指标初始版本',1,'2016-04-04','nobody');
/*!40000 ALTER TABLE `t_repository_assignment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_repository_evaluation`
--

DROP TABLE IF EXISTS `t_repository_evaluation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_repository_evaluation` (
  `ID` varchar(40) NOT NULL,
  `NAME` varchar(100) NOT NULL,
  `DESCRIPTION` varchar(2000) DEFAULT NULL,
  `ENABLED` tinyint(1) NOT NULL,
  `CREATE_TIME` date NOT NULL,
  `CREATOR` varchar(40) NOT NULL,
  UNIQUE KEY `INDEX_1` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_repository_evaluation`
--

LOCK TABLES `t_repository_evaluation` WRITE;
/*!40000 ALTER TABLE `t_repository_evaluation` DISABLE KEYS */;
INSERT INTO `t_repository_evaluation` VALUES ('20160401','初始考核版本','',1,'2016-04-02','nobody');
/*!40000 ALTER TABLE `t_repository_evaluation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_repository_salary_struct`
--

DROP TABLE IF EXISTS `t_repository_salary_struct`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_repository_salary_struct` (
  `ID` varchar(40) NOT NULL,
  `NAME` varchar(100) NOT NULL,
  `DESCRIPTION` varchar(2000) DEFAULT NULL,
  `ENABLED` tinyint(1) NOT NULL,
  `CREATE_TIME` date NOT NULL,
  `CREATOR` varchar(40) NOT NULL,
  UNIQUE KEY `INDEX_1` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_repository_salary_struct`
--

LOCK TABLES `t_repository_salary_struct` WRITE;
/*!40000 ALTER TABLE `t_repository_salary_struct` DISABLE KEYS */;
INSERT INTO `t_repository_salary_struct` VALUES ('20160401','初始薪资版本','',1,'2016-04-02','nobody');
/*!40000 ALTER TABLE `t_repository_salary_struct` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_salary_function`
--

DROP TABLE IF EXISTS `t_salary_function`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_salary_function` (
  `ID` varchar(40) NOT NULL,
  `NAME` varchar(100) NOT NULL,
  `DESCRIPTION` varchar(2000) DEFAULT NULL,
  `SQL_STMT` varchar(4000) NOT NULL,
  `ENABLED` tinyint(1) NOT NULL,
  UNIQUE KEY `INDEX_1` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_salary_function`
--

LOCK TABLES `t_salary_function` WRITE;
/*!40000 ALTER TABLE `t_salary_function` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_salary_function` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_salary_function_parameter`
--

DROP TABLE IF EXISTS `t_salary_function_parameter`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_salary_function_parameter` (
  `ID` varchar(40) NOT NULL,
  `NAME` varchar(100) NOT NULL,
  `DESCRIPTION` varchar(2000) DEFAULT NULL,
  `TYPE` varchar(100) NOT NULL,
  `MIN_VALUE` varchar(100) DEFAULT NULL,
  `MAX_VALUE` varchar(100) DEFAULT NULL,
  `FUNC_ID` varchar(40) NOT NULL,
  UNIQUE KEY `INDEX_1` (`ID`),
  KEY `INDEX_2` (`FUNC_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_salary_function_parameter`
--

LOCK TABLES `t_salary_function_parameter` WRITE;
/*!40000 ALTER TABLE `t_salary_function_parameter` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_salary_function_parameter` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_salary_item`
--

DROP TABLE IF EXISTS `t_salary_item`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_salary_item` (
  `ID` varchar(40) NOT NULL,
  `NAME` varchar(100) NOT NULL,
  `DESCRIPTION` varchar(2000) DEFAULT NULL,
  `TYPE` varchar(40) NOT NULL,
  `VALUE` decimal(10,2) DEFAULT NULL,
  `ENABLED` tinyint(1) NOT NULL,
  `VERSION_ID` varchar(40) NOT NULL,
  `POSITION_ID` varchar(40) NOT NULL,
  `FUNC_ID` varchar(40) DEFAULT NULL,
  UNIQUE KEY `INDEX_1` (`ID`),
  UNIQUE KEY `INDEX_2` (`TYPE`),
  KEY `INDEX_3` (`VERSION_ID`),
  KEY `INDEX_4` (`POSITION_ID`),
  KEY `INDEX_6` (`FUNC_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_salary_item`
--

LOCK TABLES `t_salary_item` WRITE;
/*!40000 ALTER TABLE `t_salary_item` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_salary_item` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_salary_item_type`
--

DROP TABLE IF EXISTS `t_salary_item_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_salary_item_type` (
  `ID` varchar(40) NOT NULL,
  `NAME` varchar(100) NOT NULL,
  `DESCRIPTION` varchar(2000) DEFAULT NULL,
  `ENABLED` tinyint(1) NOT NULL,
  UNIQUE KEY `INDEX_1` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_salary_item_type`
--

LOCK TABLES `t_salary_item_type` WRITE;
/*!40000 ALTER TABLE `t_salary_item_type` DISABLE KEYS */;
INSERT INTO `t_salary_item_type` VALUES ('001','固定值','每次取固数值',1),('002','固定比例','取固定比例',1),('003','公式','使用公式计算',1);
/*!40000 ALTER TABLE `t_salary_item_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_settings`
--

DROP TABLE IF EXISTS `t_settings`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_settings` (
  `NAME` varchar(100) NOT NULL,
  `VALUE` varchar(2000) NOT NULL,
  `DESCRIPTION` varchar(2000) DEFAULT NULL,
  `TYPE` int(11) NOT NULL,
  UNIQUE KEY `INDEX_1` (`NAME`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_settings`
--

LOCK TABLES `t_settings` WRITE;
/*!40000 ALTER TABLE `t_settings` DISABLE KEYS */;
INSERT INTO `t_settings` VALUES ('assignment.schedule.01','10','1月任务默认占比',1),('assignment.schedule.02','10','2月任务默认占比',1),('assignment.schedule.03','10','3月任务默认占比',1),('assignment.schedule.04','5','4月任务默认占比',1),('assignment.schedule.05','5','5月任务默认占比',1),('assignment.schedule.06','5','6月任务默认占比',1),('assignment.schedule.07','5','7月任务默认占比',1),('assignment.schedule.08','10','8月任务默认占比',1),('assignment.schedule.09','10','9月任务默认占比',1),('assignment.schedule.10','10','10月任务默认占比',1),('assignment.schedule.11','10','11月任务默认占比',1),('assignment.schedule.12','10','12月任务默认占比',1),('default.creator','0000000000','默认创建人',1),('input.evaluation.detail','1','是否录入考核表明细结果',1),('repository.assignment','20140404','当前任务指标版本',0),('repository.evaluation','20160401','当前绩效考核版本',0),('repository.salary','20160401','当前薪资构成版本',0);
/*!40000 ALTER TABLE `t_settings` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_unit`
--

DROP TABLE IF EXISTS `t_unit`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_unit` (
  `ID` varchar(40) NOT NULL,
  `NAME` varchar(100) NOT NULL,
  `ENABLED` tinyint(1) NOT NULL,
  UNIQUE KEY `INDEX_1` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_unit`
--

LOCK TABLES `t_unit` WRITE;
/*!40000 ALTER TABLE `t_unit` DISABLE KEYS */;
INSERT INTO `t_unit` VALUES ('1','元',1),('2','万元',1),('3','次',1),('4','台次',1),('5','工时',1);
/*!40000 ALTER TABLE `t_unit` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `v_assignment_detail`
--

DROP TABLE IF EXISTS `v_assignment_detail`;
/*!50001 DROP VIEW IF EXISTS `v_assignment_detail`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `v_assignment_detail` AS SELECT 
 1 AS `ASSIGNMENT_ID`,
 1 AS `POSITION_ID`,
 1 AS `ENABLED`,
 1 AS `VERSION_ID`,
 1 AS `WEIGHT`,
 1 AS `NAME`,
 1 AS `DESCRIPTION`,
 1 AS `TYPE`,
 1 AS `DEFAULT_VALUE`,
 1 AS `UNIT_ID`,
 1 AS `FIT_POSITION_ID`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_auto_assignment_list`
--

DROP TABLE IF EXISTS `v_auto_assignment_list`;
/*!50001 DROP VIEW IF EXISTS `v_auto_assignment_list`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `v_auto_assignment_list` AS SELECT 
 1 AS `ASSIGNMENT_ID`,
 1 AS `NAME`,
 1 AS `VERSION_ID`,
 1 AS `UNIT_ID`,
 1 AS `UNIT_NAME`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_employee_evaluation_total_mark`
--

DROP TABLE IF EXISTS `v_employee_evaluation_total_mark`;
/*!50001 DROP VIEW IF EXISTS `v_employee_evaluation_total_mark`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `v_employee_evaluation_total_mark` AS SELECT 
 1 AS `EMPLOYEE_ID`,
 1 AS `EVALUATION_YEAR`,
 1 AS `EVALUATION_MONTH`,
 1 AS `VERSION_ID`,
 1 AS `TOTAL_MARK`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_employee_salary_detail`
--

DROP TABLE IF EXISTS `v_employee_salary_detail`;
/*!50001 DROP VIEW IF EXISTS `v_employee_salary_detail`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `v_employee_salary_detail` AS SELECT 
 1 AS `ID`,
 1 AS `NAME`,
 1 AS `POSITION_ID`,
 1 AS `SALARY_ITEM_ID`,
 1 AS `VERSION_ID`,
 1 AS `SALARY_ITEM_NAME`,
 1 AS `SALARY_ITEM_TYPE`,
 1 AS `SALARY_ITEM_DESC`,
 1 AS `VALUE`,
 1 AS `FUNC_ID`,
 1 AS `SALARY_DETAIL_ID`,
 1 AS `SALARY_YEAR`,
 1 AS `SALARY_MONTH`,
 1 AS `AMOUNT`,
 1 AS `POSITION_NAME`,
 1 AS `SALARY_ITEM_TYPE_NAME`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_employee_tree_assignment`
--

DROP TABLE IF EXISTS `v_employee_tree_assignment`;
/*!50001 DROP VIEW IF EXISTS `v_employee_tree_assignment`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `v_employee_tree_assignment` AS SELECT 
 1 AS `EMPLOYEE_ID`,
 1 AS `EMPLOYEE_LEADER`,
 1 AS `EMPLOYEE_NAME`,
 1 AS `POSITION_ID`,
 1 AS `POSITION_NAME`,
 1 AS `ASSIGNMENT_ID`,
 1 AS `VERSION_ID`,
 1 AS `POSITION_WEIGHT`,
 1 AS `DEF_NAME`,
 1 AS `UNIT_ID`,
 1 AS `UNIT_NAME`,
 1 AS `PERF_ID`,
 1 AS `TARGET`,
 1 AS `COMPLETED`,
 1 AS `ASSIGNMENT_MONTH`,
 1 AS `ASSIGNMENT_YEAR`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_evaluation_form_detail`
--

DROP TABLE IF EXISTS `v_evaluation_form_detail`;
/*!50001 DROP VIEW IF EXISTS `v_evaluation_form_detail`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `v_evaluation_form_detail` AS SELECT 
 1 AS `FORM_ID`,
 1 AS `ITEM_ID`,
 1 AS `NAME`,
 1 AS `DESCRIPTION`,
 1 AS `TYPE`,
 1 AS `FULL_MARK`,
 1 AS `ENABLED`,
 1 AS `VERSION_ID`,
 1 AS `POSITION_ID`,
 1 AS `USED`,
 1 AS `SHOW_ORDER`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_evaluation_form_full_mark`
--

DROP TABLE IF EXISTS `v_evaluation_form_full_mark`;
/*!50001 DROP VIEW IF EXISTS `v_evaluation_form_full_mark`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `v_evaluation_form_full_mark` AS SELECT 
 1 AS `NAME`,
 1 AS `EVALUATION_FORM_ID`,
 1 AS `FULL_MARK`,
 1 AS `VERSION_ID`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_evaluation_result_detail`
--

DROP TABLE IF EXISTS `v_evaluation_result_detail`;
/*!50001 DROP VIEW IF EXISTS `v_evaluation_result_detail`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `v_evaluation_result_detail` AS SELECT 
 1 AS `POSITION_ID`,
 1 AS `FORM_ID`,
 1 AS `WEIGHT`,
 1 AS `VERSION_ID`,
 1 AS `FORM_NAME`,
 1 AS `ITEM_ID`,
 1 AS `SHOW_ORDER`,
 1 AS `ITEM_NAME`,
 1 AS `ITEM_DESC`,
 1 AS `ITEM_TYPE`,
 1 AS `FULL_MARK`,
 1 AS `EMPLOYEE_ID`,
 1 AS `EMPLOYEE_NAME`,
 1 AS `RESULT_ID`,
 1 AS `RESULT_DESC`,
 1 AS `EVALUATION_YEAR`,
 1 AS `EVALUATION_MONTH`,
 1 AS `EVALUATOR`,
 1 AS `EVALUATION_TIME`,
 1 AS `MARK`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_personal_assignment_detail`
--

DROP TABLE IF EXISTS `v_personal_assignment_detail`;
/*!50001 DROP VIEW IF EXISTS `v_personal_assignment_detail`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `v_personal_assignment_detail` AS SELECT 
 1 AS `ID`,
 1 AS `LEADER_ID`,
 1 AS `NAME`,
 1 AS `DEFINE_ID`,
 1 AS `DEFINE_NAME`,
 1 AS `DEFINE_DESC`,
 1 AS `DEFINE_TYPE`,
 1 AS `VERSION_ID`,
 1 AS `UNIT_ID`,
 1 AS `DEFAULT_VALUE`,
 1 AS `FIT_POSITION_ID`,
 1 AS `USED`,
 1 AS `WEIGHT`,
 1 AS `VALUE`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_position_tree_auto_assignment`
--

DROP TABLE IF EXISTS `v_position_tree_auto_assignment`;
/*!50001 DROP VIEW IF EXISTS `v_position_tree_auto_assignment`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `v_position_tree_auto_assignment` AS SELECT 
 1 AS `ID`,
 1 AS `LEADER_ID`,
 1 AS `NAME`,
 1 AS `DEFINE_ID`,
 1 AS `DEFINE_NAME`,
 1 AS `VERSION_ID`,
 1 AS `WEIGHT`,
 1 AS `EMPLOYEE_ID`,
 1 AS `EMPLOYEE_NAME`,
 1 AS `POSITION_ID`,
 1 AS `PERF_ID`,
 1 AS `TARGET`,
 1 AS `COMPLETED`,
 1 AS `ASSIGNMENT_YEAR`,
 1 AS `ASSIGNMENT_MONTH`,
 1 AS `UNIT_NAME`,
 1 AS `ICON`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_salary_struct_detail`
--

DROP TABLE IF EXISTS `v_salary_struct_detail`;
/*!50001 DROP VIEW IF EXISTS `v_salary_struct_detail`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `v_salary_struct_detail` AS SELECT 
 1 AS `POSITION_ID`,
 1 AS `ENABLED`,
 1 AS `VERSION_ID`,
 1 AS `SALARY_ITEM_ID`,
 1 AS `NAME`,
 1 AS `DESCRIPTION`,
 1 AS `TYPE`,
 1 AS `VALUE`,
 1 AS `FIT_POSITION_ID`,
 1 AS `FUNC_ID`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_team_assignment_detail`
--

DROP TABLE IF EXISTS `v_team_assignment_detail`;
/*!50001 DROP VIEW IF EXISTS `v_team_assignment_detail`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `v_team_assignment_detail` AS SELECT 
 1 AS `ID`,
 1 AS `LEADER_ID`,
 1 AS `NAME`,
 1 AS `DEFINE_ID`,
 1 AS `DEFINE_NAME`,
 1 AS `DEFINE_DESC`,
 1 AS `DEFINE_TYPE`,
 1 AS `VERSION_ID`,
 1 AS `UNIT_ID`,
 1 AS `FIT_POSITION_ID`,
 1 AS `IS_NEW`,
 1 AS `USED`,
 1 AS `WEIGHT`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_template_auto_employee_assignment`
--

DROP TABLE IF EXISTS `v_template_auto_employee_assignment`;
/*!50001 DROP VIEW IF EXISTS `v_template_auto_employee_assignment`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `v_template_auto_employee_assignment` AS SELECT 
 1 AS `EMPLOYEE_ID`,
 1 AS `EMPLOYEE_NAME`,
 1 AS `LEADER_ID`,
 1 AS `ASSIGNMENT_ID`,
 1 AS `POSITION_ID`,
 1 AS `POSITION_NAME`,
 1 AS `NAME`,
 1 AS `VERSION_ID`,
 1 AS `UNIT_NAME`,
 1 AS `PERF_ID`,
 1 AS `TARGET`,
 1 AS `ASSIGNMENT_YEAR`,
 1 AS `ASSIGNMENT_MONTH`,
 1 AS `PERF_DESC`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_template_position_tree_auto_assignment`
--

DROP TABLE IF EXISTS `v_template_position_tree_auto_assignment`;
/*!50001 DROP VIEW IF EXISTS `v_template_position_tree_auto_assignment`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `v_template_position_tree_auto_assignment` AS SELECT 
 1 AS `ID`,
 1 AS `LEADER_ID`,
 1 AS `NAME`,
 1 AS `DEFINE_ID`,
 1 AS `DEFINE_NAME`,
 1 AS `VERSION_ID`,
 1 AS `WEIGHT`,
 1 AS `EMPLOYEE_ID`,
 1 AS `EMPLOYEE_NAME`,
 1 AS `PERF_ID`,
 1 AS `TARGET`,
 1 AS `COMPLETED`,
 1 AS `ASSIGNMENT_YEAR`,
 1 AS `ASSIGNMENT_MONTH`,
 1 AS `UNIT_NAME`*/;
SET character_set_client = @saved_cs_client;

--
-- Dumping routines for database 'salary'
--

--
-- Final view structure for view `v_assignment_detail`
--

/*!50001 DROP VIEW IF EXISTS `v_assignment_detail`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `v_assignment_detail` AS select `t1`.`ASSIGNMENT_ID` AS `ASSIGNMENT_ID`,`t1`.`POSITION_ID` AS `POSITION_ID`,`t1`.`ENABLED` AS `ENABLED`,`t1`.`VERSION_ID` AS `VERSION_ID`,`t1`.`WEIGHT` AS `WEIGHT`,`t2`.`NAME` AS `NAME`,`t2`.`DESCRIPTION` AS `DESCRIPTION`,`t2`.`TYPE` AS `TYPE`,`t2`.`DEFAULT_VALUE` AS `DEFAULT_VALUE`,`t2`.`UNIT_ID` AS `UNIT_ID`,`t2`.`POSITION_ID` AS `FIT_POSITION_ID` from (`t_position_assignments` `t1` join `t_assignment_define` `t2`) where ((`t1`.`ASSIGNMENT_ID` = `t2`.`ID`) and `t2`.`ENABLED`) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_auto_assignment_list`
--

/*!50001 DROP VIEW IF EXISTS `v_auto_assignment_list`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `v_auto_assignment_list` AS select distinct `t`.`ASSIGNMENT_ID` AS `ASSIGNMENT_ID`,`t1`.`NAME` AS `NAME`,`t1`.`VERSION_ID` AS `VERSION_ID`,`t1`.`UNIT_ID` AS `UNIT_ID`,`t2`.`NAME` AS `UNIT_NAME` from ((`t_position_assignments` `t` join `t_assignment_define` `t1` on(((`t1`.`ID` = `t`.`ASSIGNMENT_ID`) and (`t1`.`VERSION_ID` = `t`.`VERSION_ID`)))) join `t_unit` `t2` on((`t2`.`ID` = `t1`.`UNIT_ID`))) where ((`t`.`ENABLED` = TRUE) and (`t1`.`TYPE` = '1') and (`t1`.`ENABLED` = TRUE)) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_employee_evaluation_total_mark`
--

/*!50001 DROP VIEW IF EXISTS `v_employee_evaluation_total_mark`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `v_employee_evaluation_total_mark` AS select `a`.`EMPLOYEE_ID` AS `EMPLOYEE_ID`,`a`.`EVALUATION_YEAR` AS `EVALUATION_YEAR`,`a`.`EVALUATION_MONTH` AS `EVALUATION_MONTH`,`a`.`VERSION_ID` AS `VERSION_ID`,sum((`a`.`TOTAL_MARK` * `b`.`WEIGHT`)) AS `TOTAL_MARK` from (((select `t`.`EMPLOYEE_ID` AS `EMPLOYEE_ID`,`t1`.`POSITION_ID` AS `POSITION_ID`,`t`.`EVALUATION_FORM_ID` AS `EVALUATION_FORM_ID`,`t`.`EVALUATION_YEAR` AS `EVALUATION_YEAR`,`t`.`EVALUATION_MONTH` AS `EVALUATION_MONTH`,`t`.`VERSION_ID` AS `VERSION_ID`,(sum(`t`.`MARK`) / `t2`.`FULL_MARK`) AS `TOTAL_MARK` from ((`salary`.`t_evaluation_results` `t` join `salary`.`t_employee` `t1` on((`t1`.`ID` = `t`.`EMPLOYEE_ID`))) join `salary`.`v_evaluation_form_full_mark` `t2` on((`t2`.`EVALUATION_FORM_ID` = `t`.`EVALUATION_FORM_ID`))) group by `t`.`EMPLOYEE_ID`,`t`.`EVALUATION_FORM_ID`,`t`.`EVALUATION_YEAR`,`t`.`EVALUATION_MONTH`,`t`.`VERSION_ID`)) `a` join (select `t`.`WEIGHT` AS `WEIGHT`,`t`.`POSITION_ID` AS `POSITION_ID`,`t`.`VERSION_ID` AS `VERSION_ID`,`t`.`EVALUATION_FORM_ID` AS `EVALUATION_FORM_ID` from `salary`.`t_position_evaluation_forms` `t`) `b` on(((`a`.`POSITION_ID` = `b`.`POSITION_ID`) and (`a`.`VERSION_ID` = `b`.`VERSION_ID`) and (`a`.`EVALUATION_FORM_ID` = `b`.`EVALUATION_FORM_ID`)))) group by `a`.`EVALUATION_YEAR`,`a`.`EVALUATION_MONTH`,`a`.`VERSION_ID` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_employee_salary_detail`
--

/*!50001 DROP VIEW IF EXISTS `v_employee_salary_detail`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `v_employee_salary_detail` AS select `t`.`ID` AS `ID`,`t`.`NAME` AS `NAME`,`t`.`POSITION_ID` AS `POSITION_ID`,`t1`.`SALARY_ITEM_ID` AS `SALARY_ITEM_ID`,`t1`.`VERSION_ID` AS `VERSION_ID`,`t2`.`NAME` AS `SALARY_ITEM_NAME`,`t2`.`TYPE` AS `SALARY_ITEM_TYPE`,`t2`.`DESCRIPTION` AS `SALARY_ITEM_DESC`,`t2`.`VALUE` AS `VALUE`,`t2`.`FUNC_ID` AS `FUNC_ID`,`t3`.`ID` AS `SALARY_DETAIL_ID`,`t3`.`SALARY_YEAR` AS `SALARY_YEAR`,`t3`.`SALARY_MONTH` AS `SALARY_MONTH`,`t3`.`AMOUNT` AS `AMOUNT`,`c1`.`NAME` AS `POSITION_NAME`,`c2`.`NAME` AS `SALARY_ITEM_TYPE_NAME` from (((((`t_employee` `t` left join `t_position_salary_items` `t1` on(((`t`.`POSITION_ID` = `t1`.`POSITION_ID`) and (`t`.`ENABLED` = TRUE)))) left join `t_salary_item` `t2` on(((`t2`.`ID` = `t1`.`SALARY_ITEM_ID`) and (`t2`.`ENABLED` = TRUE) and (`t1`.`VERSION_ID` = `t2`.`VERSION_ID`)))) left join `t_employee_salary_detail` `t3` on(((`t3`.`EMPLOYEE_ID` = `t`.`ID`) and (`t3`.`VERSION_ID` = `t1`.`VERSION_ID`) and (`t3`.`SALARY_ITEM_ID` = `t1`.`SALARY_ITEM_ID`)))) left join `t_position` `c1` on((`t`.`POSITION_ID` = `c1`.`ID`))) left join `t_salary_item_type` `c2` on((`t2`.`TYPE` = `c2`.`ID`))) where ((`t`.`ENABLED` = TRUE) and (`t1`.`ENABLED` = TRUE) and (`t2`.`ENABLED` = TRUE)) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_employee_tree_assignment`
--

/*!50001 DROP VIEW IF EXISTS `v_employee_tree_assignment`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `v_employee_tree_assignment` AS select `t`.`ID` AS `EMPLOYEE_ID`,`t`.`LEADER_ID` AS `EMPLOYEE_LEADER`,`t`.`NAME` AS `EMPLOYEE_NAME`,`t`.`POSITION_ID` AS `POSITION_ID`,`c2`.`NAME` AS `POSITION_NAME`,`t1`.`ASSIGNMENT_ID` AS `ASSIGNMENT_ID`,`t1`.`VERSION_ID` AS `VERSION_ID`,`t1`.`VALUE` AS `POSITION_WEIGHT`,`t2`.`NAME` AS `DEF_NAME`,`t2`.`UNIT_ID` AS `UNIT_ID`,`c1`.`NAME` AS `UNIT_NAME`,`t3`.`ID` AS `PERF_ID`,ifnull(`t3`.`TARGET`,0) AS `TARGET`,ifnull(`t3`.`COMPLETED`,0) AS `COMPLETED`,`t3`.`ASSIGNMENT_MONTH` AS `ASSIGNMENT_MONTH`,`t3`.`ASSIGNMENT_YEAR` AS `ASSIGNMENT_YEAR` from (((((`t_employee` `t` left join `t_position_assignments` `t1` on(((`t1`.`POSITION_ID` = `t`.`POSITION_ID`) and (`t1`.`ENABLED` = TRUE)))) left join `t_assignment_define` `t2` on(((`t2`.`ID` = `t1`.`ASSIGNMENT_ID`) and (`t2`.`TYPE` = '1') and (`t2`.`ENABLED` = TRUE) and (`t2`.`VERSION_ID` = `t1`.`VERSION_ID`)))) left join `t_assignment_performance` `t3` on(((`t3`.`EMPLOYEE_ID` = `t`.`ID`) and (`t3`.`DEFINE_ID` = `t1`.`ASSIGNMENT_ID`) and (`t3`.`VERSION_ID` = `t1`.`VERSION_ID`)))) left join `t_unit` `c1` on((`c1`.`ID` = `t2`.`UNIT_ID`))) left join `t_position` `c2` on((`c2`.`ID` = `t`.`POSITION_ID`))) where ((`t`.`ENABLED` = TRUE) and (`t`.`ID` <> '9999999999') and (`t1`.`ENABLED` = TRUE) and (`t2`.`TYPE` = '1')) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_evaluation_form_detail`
--

/*!50001 DROP VIEW IF EXISTS `v_evaluation_form_detail`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `v_evaluation_form_detail` AS select `t1`.`ID` AS `FORM_ID`,`t2`.`ID` AS `ITEM_ID`,`t2`.`NAME` AS `NAME`,`t2`.`DESCRIPTION` AS `DESCRIPTION`,`t2`.`TYPE` AS `TYPE`,`t2`.`FULL_MARK` AS `FULL_MARK`,`t2`.`ENABLED` AS `ENABLED`,`t2`.`VERSION_ID` AS `VERSION_ID`,`t2`.`POSITION_ID` AS `POSITION_ID`,`t3`.`ENABLED` AS `USED`,`t3`.`SHOW_ORDER` AS `SHOW_ORDER` from ((`t_evaluation_form` `t1` left join `t_evaluation_form_items` `t3` on((`t3`.`EVALUATION_FORM_ID` = `t1`.`ID`))) left join `t_evaluation_item` `t2` on((`t2`.`ID` = `t3`.`EVALUATION_FORM_ITEM_ID`))) where (`t2`.`ENABLED` = TRUE) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_evaluation_form_full_mark`
--

/*!50001 DROP VIEW IF EXISTS `v_evaluation_form_full_mark`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `v_evaluation_form_full_mark` AS select `c1`.`NAME` AS `NAME`,`t1`.`EVALUATION_FORM_ID` AS `EVALUATION_FORM_ID`,sum(`t2`.`FULL_MARK`) AS `FULL_MARK`,`t1`.`VERSION_ID` AS `VERSION_ID` from ((`t_evaluation_form_items` `t1` join `t_evaluation_item` `t2` on(((`t1`.`EVALUATION_FORM_ITEM_ID` = `t2`.`ID`) and (`t2`.`ENABLED` = TRUE)))) join `t_evaluation_form` `c1` on((`c1`.`ID` = `t1`.`EVALUATION_FORM_ID`))) where ((`t1`.`ENABLED` = TRUE) and (`t2`.`ENABLED` = TRUE)) group by `t1`.`EVALUATION_FORM_ID`,`t1`.`VERSION_ID` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_evaluation_result_detail`
--

/*!50001 DROP VIEW IF EXISTS `v_evaluation_result_detail`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `v_evaluation_result_detail` AS select `t1`.`POSITION_ID` AS `POSITION_ID`,`t1`.`EVALUATION_FORM_ID` AS `FORM_ID`,`t1`.`WEIGHT` AS `WEIGHT`,`t1`.`VERSION_ID` AS `VERSION_ID`,`t2`.`NAME` AS `FORM_NAME`,`t3`.`EVALUATION_FORM_ITEM_ID` AS `ITEM_ID`,`t3`.`SHOW_ORDER` AS `SHOW_ORDER`,`t4`.`NAME` AS `ITEM_NAME`,`t4`.`DESCRIPTION` AS `ITEM_DESC`,`t4`.`TYPE` AS `ITEM_TYPE`,`t4`.`FULL_MARK` AS `FULL_MARK`,`t5`.`ID` AS `EMPLOYEE_ID`,`t5`.`NAME` AS `EMPLOYEE_NAME`,`t6`.`ID` AS `RESULT_ID`,`t6`.`DESCRIPTION` AS `RESULT_DESC`,`t6`.`EVALUATION_YEAR` AS `EVALUATION_YEAR`,`t6`.`EVALUATION_MONTH` AS `EVALUATION_MONTH`,`t6`.`EVALUATOR` AS `EVALUATOR`,`t6`.`EVALUATION_TIME` AS `EVALUATION_TIME`,`t6`.`MARK` AS `MARK` from (((((`t_position_evaluation_forms` `t1` join `t_evaluation_form` `t2` on((`t2`.`ID` = `t1`.`EVALUATION_FORM_ID`))) join `t_evaluation_form_items` `t3` on((`t3`.`EVALUATION_FORM_ID` = `t2`.`ID`))) join `t_evaluation_item` `t4` on((`t4`.`ID` = `t3`.`EVALUATION_FORM_ITEM_ID`))) join `t_employee` `t5` on((`t1`.`POSITION_ID` = `t5`.`POSITION_ID`))) left join `t_evaluation_results` `t6` on(((`t5`.`ID` = `t6`.`EMPLOYEE_ID`) and (`t6`.`VERSION_ID` = `t1`.`VERSION_ID`) and (`t6`.`EVALUATION_FORM_ID` = `t1`.`EVALUATION_FORM_ID`) and (`t6`.`EVALUATION_ITEM_ID` = `t4`.`ID`)))) where ((`t1`.`ENABLED` = TRUE) and (`t2`.`ENABLED` = TRUE) and (`t3`.`ENABLED` = TRUE) and (`t4`.`ENABLED` = TRUE) and (`t5`.`ENABLED` = TRUE)) order by `t2`.`NAME`,`t3`.`SHOW_ORDER` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_personal_assignment_detail`
--

/*!50001 DROP VIEW IF EXISTS `v_personal_assignment_detail`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `v_personal_assignment_detail` AS select `t1`.`ID` AS `ID`,`t1`.`LEADER_ID` AS `LEADER_ID`,`t1`.`NAME` AS `NAME`,`t2`.`ID` AS `DEFINE_ID`,`t2`.`NAME` AS `DEFINE_NAME`,`t2`.`DESCRIPTION` AS `DEFINE_DESC`,`t2`.`TYPE` AS `DEFINE_TYPE`,`t2`.`VERSION_ID` AS `VERSION_ID`,`t2`.`UNIT_ID` AS `UNIT_ID`,`t2`.`DEFAULT_VALUE` AS `DEFAULT_VALUE`,`t2`.`POSITION_ID` AS `FIT_POSITION_ID`,ifnull(`t3`.`ENABLED`,false) AS `USED`,ifnull(`t3`.`WEIGHT`,100) AS `WEIGHT`,ifnull(`t3`.`VALUE`,`t2`.`DEFAULT_VALUE`) AS `VALUE` from ((`t_position` `t1` join `t_assignment_define` `t2` on(((`t1`.`ID` = `t2`.`POSITION_ID`) or (`t2`.`POSITION_ID` = '9999999999')))) left join `t_position_assignments` `t3` on(((`t1`.`ID` = `t3`.`POSITION_ID`) and (`t2`.`ID` = `t3`.`ASSIGNMENT_ID`)))) where ((`t1`.`ENABLED` = TRUE) and (`t1`.`ID` <> '9999999999') and (`t2`.`ENABLED` = TRUE) and (`t2`.`TYPE` <> '1')) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_position_tree_auto_assignment`
--

/*!50001 DROP VIEW IF EXISTS `v_position_tree_auto_assignment`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `v_position_tree_auto_assignment` AS select `t1`.`ID` AS `ID`,`t1`.`LEADER_ID` AS `LEADER_ID`,`t1`.`NAME` AS `NAME`,`t2`.`ID` AS `DEFINE_ID`,`t2`.`NAME` AS `DEFINE_NAME`,`t2`.`VERSION_ID` AS `VERSION_ID`,`t3`.`VALUE` AS `WEIGHT`,`t4`.`ID` AS `EMPLOYEE_ID`,`t4`.`NAME` AS `EMPLOYEE_NAME`,`t4`.`POSITION_ID` AS `POSITION_ID`,`t5`.`ID` AS `PERF_ID`,`t5`.`TARGET` AS `TARGET`,`t5`.`COMPLETED` AS `COMPLETED`,`t5`.`ASSIGNMENT_YEAR` AS `ASSIGNMENT_YEAR`,`t5`.`ASSIGNMENT_MONTH` AS `ASSIGNMENT_MONTH`,`t6`.`NAME` AS `UNIT_NAME`,0 AS `ICON` from (((((`t_position` `t1` left join `t_assignment_define` `t2` on(((`t1`.`ID` = `t2`.`POSITION_ID`) or (`t2`.`POSITION_ID` = '9999999999')))) left join `t_position_assignments` `t3` on(((`t1`.`ID` = `t3`.`POSITION_ID`) and (`t3`.`ASSIGNMENT_ID` = `t2`.`ID`) and (`t2`.`VERSION_ID` = `t3`.`VERSION_ID`)))) left join `t_employee` `t4` on(((`t4`.`POSITION_ID` = `t1`.`ID`) and (`t4`.`ENABLED` = TRUE)))) left join `t_assignment_performance` `t5` on(((`t5`.`EMPLOYEE_ID` = `t4`.`ID`) and (`t5`.`VERSION_ID` = `t2`.`VERSION_ID`) and (`t5`.`DEFINE_ID` = `t2`.`ID`)))) left join `t_unit` `t6` on((`t6`.`ID` = `t2`.`UNIT_ID`))) where ((`t1`.`ENABLED` = TRUE) and (`t1`.`ID` <> '9999999999') and (`t2`.`ENABLED` = TRUE) and (`t2`.`TYPE` = '1') and (`t3`.`ENABLED` = TRUE)) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_salary_struct_detail`
--

/*!50001 DROP VIEW IF EXISTS `v_salary_struct_detail`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `v_salary_struct_detail` AS select `t1`.`POSITION_ID` AS `POSITION_ID`,`t1`.`ENABLED` AS `ENABLED`,`t1`.`VERSION_ID` AS `VERSION_ID`,`t1`.`SALARY_ITEM_ID` AS `SALARY_ITEM_ID`,`t2`.`NAME` AS `NAME`,`t2`.`DESCRIPTION` AS `DESCRIPTION`,`t2`.`TYPE` AS `TYPE`,`t2`.`VALUE` AS `VALUE`,`t2`.`POSITION_ID` AS `FIT_POSITION_ID`,`t2`.`FUNC_ID` AS `FUNC_ID` from (`t_position_salary_items` `t1` left join `t_salary_item` `t2` on((`t2`.`ID` = `t1`.`SALARY_ITEM_ID`))) where `t2`.`ENABLED` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_team_assignment_detail`
--

/*!50001 DROP VIEW IF EXISTS `v_team_assignment_detail`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `v_team_assignment_detail` AS select `t1`.`ID` AS `ID`,`t1`.`LEADER_ID` AS `LEADER_ID`,`t1`.`NAME` AS `NAME`,`t2`.`ID` AS `DEFINE_ID`,`t2`.`NAME` AS `DEFINE_NAME`,`t2`.`DESCRIPTION` AS `DEFINE_DESC`,`t2`.`TYPE` AS `DEFINE_TYPE`,`t2`.`VERSION_ID` AS `VERSION_ID`,`t2`.`UNIT_ID` AS `UNIT_ID`,`t2`.`POSITION_ID` AS `FIT_POSITION_ID`,(ifnull(`t3`.`ASSIGNMENT_ID`,'0') = '0') AS `IS_NEW`,ifnull(`t3`.`ENABLED`,FALSE) AS `USED`,ifnull(`t3`.`VALUE`,0) AS `WEIGHT` from ((`t_position` `t1` join `t_assignment_define` `t2` on(((`t1`.`ID` = `t2`.`POSITION_ID`) or (`t2`.`POSITION_ID` = '9999999999')))) left join `t_position_assignments` `t3` on(((`t1`.`ID` = `t3`.`POSITION_ID`) and (`t3`.`ASSIGNMENT_ID` = `t2`.`ID`)))) where ((`t1`.`ENABLED` = TRUE) and (`t1`.`ID` <> '9999999999') and (`t2`.`ENABLED` = TRUE) and (`t2`.`TYPE` = '1')) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_template_auto_employee_assignment`
--

/*!50001 DROP VIEW IF EXISTS `v_template_auto_employee_assignment`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `v_template_auto_employee_assignment` AS select `t0`.`ID` AS `EMPLOYEE_ID`,`t0`.`NAME` AS `EMPLOYEE_NAME`,`t0`.`LEADER_ID` AS `LEADER_ID`,`t1`.`ASSIGNMENT_ID` AS `ASSIGNMENT_ID`,`t1`.`POSITION_ID` AS `POSITION_ID`,`t5`.`NAME` AS `POSITION_NAME`,`t2`.`NAME` AS `NAME`,`t2`.`VERSION_ID` AS `VERSION_ID`,`t4`.`NAME` AS `UNIT_NAME`,ifnull(`t3`.`ID`,'') AS `PERF_ID`,ifnull(`t3`.`TARGET`,0) AS `TARGET`,ifnull(`t3`.`ASSIGNMENT_YEAR`,2016) AS `ASSIGNMENT_YEAR`,ifnull(`t3`.`ASSIGNMENT_MONTH`,1) AS `ASSIGNMENT_MONTH`,ifnull(`t3`.`DESCRIPTION`,'') AS `PERF_DESC` from (((((`t_employee` `t0` left join `t_position_assignments` `t1` on((`t0`.`POSITION_ID` = `t1`.`POSITION_ID`))) join `t_assignment_define` `t2` on(((`t2`.`ID` = `t1`.`ASSIGNMENT_ID`) and (`t2`.`TYPE` = '1')))) left join `t_assignment_performance` `t3` on((`t3`.`EMPLOYEE_ID` = `t0`.`ID`))) join `t_unit` `t4` on((`t4`.`ID` = `t2`.`UNIT_ID`))) join `t_position` `t5` on((`t5`.`ID` = `t0`.`POSITION_ID`))) where (((`t0`.`ENABLED` = TRUE) and (`t2`.`TYPE` = '1') and (`t1`.`ENABLED` = TRUE) and ((`t3`.`VERSION_ID` = `t1`.`VERSION_ID`) or isnull(`t3`.`VERSION_ID`)) and (`t3`.`ASSIGNMENT_YEAR` = 2016)) or (isnull(`t3`.`ASSIGNMENT_YEAR`) and (`t3`.`ASSIGNMENT_MONTH` = 1)) or isnull(`t3`.`ASSIGNMENT_MONTH`)) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_template_position_tree_auto_assignment`
--

/*!50001 DROP VIEW IF EXISTS `v_template_position_tree_auto_assignment`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `v_template_position_tree_auto_assignment` AS select `t1`.`ID` AS `ID`,`t1`.`LEADER_ID` AS `LEADER_ID`,`t1`.`NAME` AS `NAME`,`t2`.`ID` AS `DEFINE_ID`,`t2`.`NAME` AS `DEFINE_NAME`,`t2`.`VERSION_ID` AS `VERSION_ID`,`t3`.`VALUE` AS `WEIGHT`,`t4`.`ID` AS `EMPLOYEE_ID`,`t4`.`NAME` AS `EMPLOYEE_NAME`,`t5`.`ID` AS `PERF_ID`,`t5`.`TARGET` AS `TARGET`,`t5`.`COMPLETED` AS `COMPLETED`,`t5`.`ASSIGNMENT_YEAR` AS `ASSIGNMENT_YEAR`,`t5`.`ASSIGNMENT_MONTH` AS `ASSIGNMENT_MONTH`,`t6`.`ID` AS `UNIT_NAME` from (((((`t_position` `t1` join `t_assignment_define` `t2` on(((`t1`.`ID` = `t2`.`POSITION_ID`) or (`t2`.`POSITION_ID` = '9999999999')))) join `t_position_assignments` `t3` on(((`t1`.`ID` = `t3`.`POSITION_ID`) and (`t3`.`ASSIGNMENT_ID` = `t2`.`ID`) and (`t2`.`VERSION_ID` = `t3`.`VERSION_ID`)))) left join `t_employee` `t4` on(((`t4`.`POSITION_ID` = `t1`.`ID`) and (`t4`.`ENABLED` = TRUE)))) left join `t_assignment_performance` `t5` on(((`t5`.`EMPLOYEE_ID` = `t4`.`ID`) and (`t5`.`VERSION_ID` = `t2`.`VERSION_ID`) and (`t5`.`DEFINE_ID` = `t2`.`ID`)))) join `t_unit` `t6` on((`t6`.`ID` = `t2`.`UNIT_ID`))) where ((`t1`.`ENABLED` = TRUE) and (`t1`.`ID` <> '9999999999') and (`t2`.`ENABLED` = TRUE) and (`t2`.`TYPE` = '1') and (`t3`.`ENABLED` = TRUE)) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-04-19  0:57:33
