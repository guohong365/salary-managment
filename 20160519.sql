CREATE DATABASE  IF NOT EXISTS `salary` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `salary`;
-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: salary
-- ------------------------------------------------------
-- Server version	5.7.12-log

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
  PRIMARY KEY (`ID`),
  UNIQUE KEY `INDEX_1` (`ID`),
  KEY `INDEX_2` (`ASSIGNMENT_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_annual_assignment`
--

LOCK TABLES `t_annual_assignment` WRITE;
/*!40000 ALTER TABLE `t_annual_assignment` DISABLE KEYS */;
INSERT INTO `t_annual_assignment` VALUES ('05cf705a-5505-4c30-b564-a0f18f4aaf7e','a529ecb7-c772-44ad-84af-0d9f50c16a20','2016年度2月任务计划','2016年度2月任务计划',2016,2,150.000000,'2016-04-28','nobody','20140404',0),('16c06b19-18a7-4340-8df9-37cb0c5cac0f','a529ecb7-c772-44ad-84af-0d9f50c16a20','2016年度12月任务计划','2016年度12月任务计划',2016,12,150.000000,'2016-04-20','nobody','20140404',0),('1def3060-459c-43b2-81dc-bea3a8a36cf3','a529ecb7-c772-44ad-84af-0d9f50c16a20','2016年度4月任务计划','2016年度4月任务计划',2016,4,75.000000,'2016-04-20','nobody','20140404',1),('22f221b5-bfa1-4df4-99eb-316b49e0580d','a529ecb7-c772-44ad-84af-0d9f50c16a20','2016年度6月任务计划','2016年度6月任务计划',2016,6,75.000000,'2016-04-20','nobody','20140404',0),('3569d6b5-4dee-4dfb-9b6c-b6be137ca219','a529ecb7-c772-44ad-84af-0d9f50c16a20','2016年度3月任务计划','2016年度3月任务计划',2016,3,150.000000,'2016-04-28','nobody','20140404',1),('3c0586ab-bad4-44e7-b0c7-1d132f4b7041','a529ecb7-c772-44ad-84af-0d9f50c16a20','2016年度10月任务计划','2016年度10月任务计划',2016,10,150.000000,'2016-04-20','nobody','20140404',0),('4ae2ed3f-370f-4500-9cdf-459081e4a671','a529ecb7-c772-44ad-84af-0d9f50c16a20','2016年度8月任务计划','2016年度8月任务计划',2016,8,150.000000,'2016-04-20','nobody','20140404',0),('5aaf12c0-be9a-4889-8608-83229ae69c43','a529ecb7-c772-44ad-84af-0d9f50c16a20','2016年度5月任务计划','2016年度5月任务计划',2016,5,75.000000,'2016-04-20','nobody','20140404',1),('6e76e403-55f2-4c98-8dde-17f054d44ae9','a529ecb7-c772-44ad-84af-0d9f50c16a20','2016年度11月任务计划','2016年度11月任务计划',2016,11,150.000000,'2016-04-20','nobody','20140404',0),('b0aa00aa-0414-45cf-bbee-409cbe8a1073','a529ecb7-c772-44ad-84af-0d9f50c16a20','2016年度1月任务计划','2016年度1月任务计划',2016,1,150.000000,'2016-04-28','nobody','20140404',0),('d8ea2fac-dec6-4700-b5aa-53ce333d2e87','a529ecb7-c772-44ad-84af-0d9f50c16a20','2016年度9月任务计划','2016年度9月任务计划',2016,9,150.000000,'2016-04-20','nobody','20140404',0),('db07cac8-eb9e-44e7-877e-434c1679f29f','a529ecb7-c772-44ad-84af-0d9f50c16a20','2016年度7月任务计划','2016年度7月任务计划',2016,7,75.000000,'2016-04-20','nobody','20140404',0);
/*!40000 ALTER TABLE `t_annual_assignment` ENABLE KEYS */;
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
  PRIMARY KEY (`ID`),
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
INSERT INTO `t_assignment_define` VALUES ('01758245-4965-4a64-910b-7664651cbe8a','xxoo',NULL,0,'2',1000.000000,'20140404','3','0000000000'),('9739087d-dc2e-450e-9104-252235cf89de','精品销售',NULL,1,'1',0.000000,'20140404','1','9999999999'),('a529ecb7-c772-44ad-84af-0d9f50c16a20','产值任务',NULL,1,'1',0.000000,'20140404','2','9999999999'),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','xxoo','每月xxoo30次',1,'2',30.000000,'20140404','3','9999999999'),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','工时任务',NULL,1,'3',0.000000,'20140404','5','9999999999');
/*!40000 ALTER TABLE `t_assignment_define` ENABLE KEYS */;
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
  PRIMARY KEY (`ID`),
  UNIQUE KEY `INDEX_1` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_assignment_item_type`
--

LOCK TABLES `t_assignment_item_type` WRITE;
/*!40000 ALTER TABLE `t_assignment_item_type` DISABLE KEYS */;
INSERT INTO `t_assignment_item_type` VALUES ('1','逐级自动分配','任务下达到指定岗位后，再按岗位预设比例逐级分解到下属岗位，如无预设比例则该下属岗位不分配',1),('2','定额任务','任务下达到指定岗位，具有固定任务指标',1),('3','无定额任务','任务下达到指定岗位，没有任务指标。',1);
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
  `DEFINE_NAME` varchar(100) DEFAULT NULL,
  `DEFINE_DESC` varchar(2000) DEFAULT NULL,
  `COMISSION_BASE` decimal(20,6) DEFAULT NULL,
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
  PRIMARY KEY (`ID`),
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
  `ENABLED` tinyint(1) NOT NULL DEFAULT '0',
  `GENDER` varchar(10) NOT NULL DEFAULT '男',
  PRIMARY KEY (`ID`),
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
INSERT INTO `t_employee` VALUES ('1001',NULL,'0000000000','邹伟',NULL,'2004-04-01',NULL,1,'男'),('1002','1001','0200000000','王辉',NULL,'2006-10-17',NULL,1,'男'),('1003','1002','0205000000','费毅军',NULL,'2008-04-07',NULL,1,'男'),('1004','1002','0202000000','庞伟刚',NULL,'2011-06-20',NULL,1,'男'),('1005','1002','0202000000','马庆',NULL,'2008-05-03',NULL,1,'男'),('1006','1002','0206000000','徐浩杰',NULL,'2008-05-23',NULL,1,'男'),('1007','1003','0204030000','陈利鹏',NULL,'2005-04-01',NULL,1,'男'),('1008','1003','0204030000','杨忠林',NULL,'2007-12-01',NULL,1,'男'),('1009','1003','0204000000','余显明',NULL,'2008-08-01',NULL,1,'男'),('1010','1003','0204000000','段树荣',NULL,'2004-04-01',NULL,1,'男'),('1011','1077','0203000000','杨春明',NULL,'2008-05-19',NULL,1,'男'),('1012','1002','0203000000','吴建松',NULL,'2005-01-01',NULL,1,'男'),('1013','1001','0101000000','周艳',NULL,'2014-05-05',NULL,1,'女'),('1014','1002','0207000000','王乾龙',NULL,'2013-12-09',NULL,1,'男'),('1020','1077','0203010000','黄技',NULL,'2010-04-07',NULL,1,'男'),('1021','1011','0203010000','郑红玉',NULL,'2013-10-18',NULL,1,'女'),('1022','1002','0207000000','钟兴龙',NULL,'2005-12-10',NULL,1,'男'),('1025','1003','0204030100','黄生杰',NULL,'2012-07-23',NULL,1,'男'),('1026','1006','0204030100','黄立华',NULL,'2006-02-09',NULL,1,'男'),('1027','1003','0204030100','张云升',NULL,'2005-01-01',NULL,1,'男'),('1028','1003','0204030100','张泽华',NULL,'2014-02-18',NULL,1,'男'),('1029','1003','0204030100','李吉学',NULL,'2012-07-23',NULL,1,'男'),('1030','1036','0204030101','昂跃金',NULL,'2009-02-23',NULL,1,'男'),('1033','1003','0300000000','王云春',NULL,'2016-10-01',NULL,1,'男'),('1034','1003','0204030300','黄兴学',NULL,'2005-07-01',NULL,1,'男'),('1036','1003','0204030100','高翔',NULL,'2014-02-09',NULL,1,'男'),('1037','1025','0204030101','汪杰',NULL,'2013-08-13',NULL,1,'男'),('1038','1027','0204030101','李石锁',NULL,'2013-09-06',NULL,1,'男'),('1040','1002','0204040000','崔顺鹏',NULL,'2014-02-16',NULL,1,'男'),('1042','1003','0204030101','余晋',NULL,'2013-09-30',NULL,1,'男'),('1043','1062','0201010000','梅文良',NULL,'2014-04-15',NULL,1,'男'),('1044','1028','0204030101','陈永超',NULL,'2013-09-26',NULL,1,'男'),('1045','1029','0204030101','余万恒',NULL,'2014-09-02',NULL,1,'男'),('1046','1027','0204030101','时从林',NULL,'2016-04-01',NULL,1,'男'),('1047','1028','0204030101','吴宏文',NULL,'2014-12-03',NULL,1,'男'),('1048','1076','0204030101','毕云红',NULL,'2013-12-09',NULL,1,'男'),('1052','1042','0204030101','莫文祥',NULL,'2012-08-01',NULL,1,'男'),('1055','1026','0204030101','黄国靖',NULL,'2015-07-01',NULL,1,'男'),('1056','1076','0204030101','李朝圣',NULL,'2016-04-12',NULL,1,'男'),('1057','1006','0202030100','余兵军',NULL,'2014-04-17',NULL,1,'男'),('1058','1004','0202030100','王林茳',NULL,'2011-09-08',NULL,1,'男'),('1059','1004','0202030100','娄翛然',NULL,'2011-11-14',NULL,1,'男'),('1060','1004','0202030100','孙鹏涛',NULL,'2014-02-21',NULL,1,'男'),('1061','1004','0202030100','李孟琴',NULL,'2013-09-11',NULL,1,'女'),('1062','1002','0201000000','白守跃',NULL,'2007-04-20',NULL,1,'男'),('1063','1005','0000000000','魏志坤',NULL,'2005-12-10',NULL,1,'男'),('1065','1005','0202030100','徐在强',NULL,'2015-04-07',NULL,1,'男'),('1066','1036','0204030101','胡锦山',NULL,'2016-03-01',NULL,1,'男'),('1067','1025','0204030101','金伟',NULL,'2016-04-01',NULL,1,'男'),('1068','1028','0204030101','李宏伟',NULL,'2015-09-14',NULL,1,'男'),('1069','1042','0204030101','李文广',NULL,'2015-09-16',NULL,1,'男'),('1070','1036','0204030101','潘生敏',NULL,'2015-08-05',NULL,1,'男'),('1071','1025','0204030101','钱泽辉',NULL,'2015-12-01',NULL,1,'男'),('1072','1029','0204030101','王斌',NULL,'2016-03-01',NULL,1,'男'),('1073','1029','0204030101','文天源',NULL,'2015-08-24',NULL,1,'男'),('1074','1042','0204030101','徐强',NULL,'2016-04-01',NULL,1,'男'),('1075','1028','0204030101','张官令',NULL,'2016-03-01',NULL,1,'男'),('1076','1006','0204030100','余金平',NULL,'2016-02-26',NULL,1,'男'),('1077','1002','0208000000','濮勇',NULL,'2016-02-17',NULL,1,'男'),('1078','1062','0201010000','何晓梨',NULL,'2016-03-21',NULL,1,'男'),('1079','1002','0207000000','和杰',NULL,'2015-10-08',NULL,1,'男');
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
  PRIMARY KEY (`ID`),
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
  PRIMARY KEY (`ID`),
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
  PRIMARY KEY (`EVALUATION_FORM_ID`,`EVALUATION_FORM_ITEM_ID`),
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
  PRIMARY KEY (`ID`),
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
INSERT INTO `t_evaluation_item` VALUES ('0001','出勤记录','按照公司考勤制度要求，无迟到、早退、旷工、中途脱岗，病事假能按公司要求办理请假手续。（迟到、早退每次扣0.5分；旷工每次口3分）','008',10.00,1,'20160401','0204030100'),('0002','工作纪律','工作时间无睡觉、上网、聊QQ、吃零食、聚众闲聊、大声喧哗；（上班时间做工作无关的事，每次口0.5分）','008',10.00,1,'20160401','0204030100'),('0003','仪容仪表','按公司要求统一着装，工作服保持干净、整洁','008',5.00,1,'20160401','0204030100'),('0004','仪容仪表','保持良好的个人卫生、无异味、无怪异发型；仪表端庄、大方，语言得体','008',5.00,1,'20160401','0204030100'),('0005','交车合格率','按车间内外返制度执行（內返每次扣0.5分，外返每次扣2分；3DC回访派单每次扣1分','007',10.00,1,'20160401','0204030100'),('0006','培训合格率','未按要求参加技术内训，每次扣1.5分','007',6.00,1,'20160401','0204030100'),('0007','培训合格率','培训考核不合格，每次扣2分','007',4.00,1,'20160401','0204030100'),('0008','管理与执行能力','管控并协调组员之间的工作进度；按时、保质的完成车间分配的工作。（出现消极怠工、出状况而不作为，每次扣1分）','007',10.00,1,'20160401','0204030100'),('0009','工具设备','定期检查，不合格每次扣1分','009',5.00,1,'20160401','0204030100'),('0010','卫生区域','所属卫生区域检查不合格每次扣0.5分','009',5.00,1,'20160401','0204030100'),('0011','操作规范','未按规定流程操作，每次扣1分','009',10.00,1,'20160401','0204030100'),('0012','安全生产','禁烟区内吸烟，每次扣1分；发现他人在禁烟区内吸烟未劝阻，每次扣0.5分','009',5.00,1,'20160401','0204030100'),('0013','安全生产','因野蛮操作造成车辆、工具设备受损，人员受伤，每次扣1分','009',5.00,1,'20160401','0204030100'),('0014','CSI得分',NULL,'002',10.00,1,'20160401','0204030100'),('0015','特别业绩','积极参与疑难问题的解决；提出合理化建议，并有效实施；提高工作效率；（可酌情加分）','010',10.00,1,'20160401','0204030100'),('0016','及时接待','','011',1.00,1,'20160401','9999999999'),('0017','售后服务六件套',NULL,'011',1.00,1,'20160401','9999999999'),('0018','环车检查',NULL,'011',1.00,1,'20160401','9999999999'),('0019','贵重物品提醒',NULL,'011',1.00,1,'20160401','9999999999'),('0020','估时估价',NULL,'011',1.00,1,'20160401','9999999999'),('0021','服务响应',NULL,'011',1.00,1,'20160401','9999999999'),('0022','主动问候',NULL,'011',1.00,1,'20160401','9999999999'),('0023','引导休息',NULL,'011',1.00,1,'20160401','9999999999'),('0024','无线网络覆盖',NULL,'011',1.00,1,'20160401','9999999999'),('0025','洗手间环境',NULL,'011',1.00,1,'20160401','9999999999'),('0026','顾客休息区舒适程度',NULL,'011',1.00,1,'20160401','9999999999'),('0027','饮品提供及续杯',NULL,'011',1.00,1,'20160401','9999999999'),('0028','维修进度汇报',NULL,'011',1.00,1,'20160401','9999999999'),('0029','服务人员专业知识',NULL,'011',1.00,1,'20160401','9999999999'),('0030','预估时间内交车',NULL,'011',1.00,1,'20160401','9999999999'),('0031','车辆状态保持',NULL,'011',1.00,1,'20160401','9999999999'),('0032','洗车服务',NULL,'011',1.00,1,'20160401','9999999999'),('0033','旧件展示',NULL,'011',1.00,1,'20160401','9999999999'),('0034','轮胎杂物清理',NULL,'011',1.00,1,'20160401','9999999999'),('0035','维修成果展示',NULL,'011',1.00,1,'20160401','9999999999'),('0036','解释服务项目及收费',NULL,'011',1.00,1,'20160401','9999999999'),('0037','下次保养提醒',NULL,'011',1.00,1,'20160401','9999999999'),('0038','协助提车',NULL,'011',1.00,1,'20160401','9999999999'),('0039','礼貌送行',NULL,'011',1.00,1,'20160401','9999999999'),('0040','服务追踪',NULL,'011',1.00,1,'20160401','9999999999'),('0041','车辆故障一次性修复',NULL,'011',1.00,1,'20160401','9999999999'),('0042','维修时间满意情况',NULL,'011',1.00,1,'20160401','9999999999'),('0043','未接受顾客礼物或财物',NULL,'011',1.00,1,'20160401','9999999999'),('0044','100%车辆全生命周期关怀回访',NULL,'011',1.00,1,'20160401','9999999999'),('0045','推荐购买/再次购买',NULL,'011',1.00,1,'20160401','9999999999'),('1844a508-0994-48ff-a1a6-bc0c6b2f9f9d','培训合格率','按要求参加厂方培训，不合格每次扣2分','007',4.00,1,'20160401','0204000000'),('1fd59609-f5a0-4f15-bcc8-daa98fc3d806','出勤记录','按照公司考勤制度要求，无迟到、早退、旷工、中途脱岗，病事假能按公司要求办理请假手续。（迟到、早退每次扣0.5分；旷工每次口3分）','008',10.00,1,'20160401','0204030300'),('20cd6b33-dafa-42b1-9584-58f166791013','安全生产','因野蛮操作造成车辆、工具设备受损，人员受伤，每次扣1分','009',5.00,1,'20160401','0204030000'),('2506ecec-5b1f-48a8-8421-96ff5dd2821b','特别业绩','积极参与疑难问题的解决；提出合理化建议，并有效实施；提高工作效率；（可酌情加分）','010',10.00,1,'20160401','0204000000'),('28a2644e-530d-4957-b0d4-d3395e98dd96','安全生产','禁烟区内吸烟，每次扣1分；发现他人在禁烟区内吸烟未劝阻，每次扣0.5分','009',5.00,1,'20160401','0204000000'),('320f6437-b41d-42e7-919a-22c2043a4dfb','培训合格率','未按要求参加技术内训，每次扣1.5分','007',6.00,1,'20160401','0204030000'),('35445f8f-f506-4150-8773-4ce7628aa2eb','交车合格率','按车间内外返制度执行（內返每次扣0.5分，外返每次扣2分；3DC回访派单每次扣1分','007',10.00,1,'20160401','0204030000'),('477f707d-7d0b-468a-931d-a56d779a8edb','安全生产','禁烟区内吸烟，每次扣1分；发现他人在禁烟区内吸烟未劝阻，每次扣0.5分','009',5.00,1,'20160401','0204030000'),('570b0e58-a67c-440f-a208-40876796d940','工作纪律','工作时间无睡觉、上网、聊QQ、吃零食、聚众闲聊、大声喧哗；（上班时间做工作无关的事，每次口0.5分）','008',10.00,1,'20160401','0204030000'),('6075bfcb-190d-4c02-84a9-213644e82b17','安全生产','因野蛮操作造成车辆、工具设备受损，人员受伤，每次扣1分','009',5.00,1,'20160401','0204000000'),('6d52ca58-c2cf-49fd-9611-acbae94f1d47','交车合格率','按车间内外返制度执行（內返每次扣0.5分，外返每次扣2分；3DC回访派单每次扣1分','007',10.00,1,'20160401','0204000000'),('71b3fb4e-0c4c-4108-9b13-a54b8583d47d','培训合格率','按要求开展技术内训，不合格每次扣1.5分','007',6.00,1,'20160401','0204000000'),('73fb6053-02b6-4fc8-9043-7aa5a40d770c','管理与执行能力','完成技术顾问岗位轮值工作；协助技术顾问派工、交车；及时跟进各维修班组的进度，作适时指导及引导（因不作为造成工作延误、客户抱怨，每次扣1分）','007',10.00,1,'20160401','0204030000'),('75acde4d-c039-4c32-b3b0-187c180056fe','现场管理','严把质量关，对竣工车辆仔细检查，开据內返单（因漏检造成外返及客户投诉，每次扣2分）','009',10.00,1,'20160401','0204000000'),('7c00d67d-979d-4dba-8d7c-633ee90f429f','培训合格率','培训考核不合格，每次扣2分','007',4.00,1,'20160401','0204030000'),('81e458b9-4772-4ad3-b9fc-a81f39f4c024','仪容仪表','按公司要求统一着装，工作服保持干净、整洁','008',5.00,1,'20160401','0204030000'),('85f59807-deb2-4f4b-af25-7466d661ab91','现场管理','严把质量关，对竣工车辆仔细检查，开据內返单（因漏检造成外返及客户投诉，每次扣2分）.','009',10.00,1,'20160401','0204030000'),('8af9827f-1763-41a1-a5fe-fa7ece060342','出勤记录','按照公司考勤制度要求，无迟到、早退、旷工、中途脱岗，病事假能按公司要求办理请假手续。（迟到、早退每次扣0.5分；旷工每次口3分）','008',10.00,1,'20160401','0204000000'),('9d85c808-84bc-4c3a-bc41-02f7fba1e394','出勤记录','按照公司考勤制度要求，无迟到、早退、旷工、中途脱岗，病事假能按公司要求办理请假手续。（迟到、早退每次扣0.5分；旷工每次口3分）','008',10.00,1,'20160401','0204030000'),('a7343604-2fc5-4ff0-8e94-e68cd7519d33','管理与执行能力','完成技术顾问岗位轮值工作；协助技术顾问派工、交车；及时跟进各维修班组的进度，对疑难故障作及时指导及引导（因不作为造成工作延误、客户抱怨，每次扣1分）','007',10.00,1,'20160401','0204000000'),('ae541886-33f1-4708-a512-92c847f1c613','CSI得分',NULL,'002',10.00,1,'20160401','0204030000'),('b09c49eb-0360-4607-ad08-8fabb2e471e4','仪容仪表','保持良好的个人卫生、无异味、无怪异发型；仪表端庄、大方，语言得体','008',5.00,1,'20160401','0204030000'),('b09f1fce-8ad5-46b9-9cc3-33613fc64e83','现场管理','及时纠正维修过程中的各种不规范行为','009',10.00,1,'20160401','0204000000'),('b2a83c28-d3c9-4bb4-b05f-4d9a59d30893','特别业绩','积极参与疑难问题的解决；提出合理化建议，并有效实施；提高工作效率；（可酌情加分）','010',10.00,1,'20160401','0204030000'),('cfb596ab-c190-4ef8-b6ca-ccd11b5e09b5','现场管理','及时纠正维修过程中的各种不规范行为','009',10.00,1,'20160401','0204030000'),('e2094954-3564-46e9-bcb2-4c6a8bdd5733','仪容仪表','按公司要求统一着装，工作服保持干净、整洁','008',5.00,1,'20160401','0204000000'),('e2d17de7-19ff-4bd2-83da-39709a5dbadc','工作纪律','工作时间无睡觉、上网、聊QQ、吃零食、聚众闲聊、大声喧哗；（上班时间做工作无关的事，每次口0.5分）','008',10.00,1,'20160401','0204000000'),('e86e7d35-d819-44f9-9417-02233eeff86d','CSI得分','','002',10.00,1,'20160401','0204000000'),('eda1dfd7-d570-4c37-8389-0986c1565443','仪容仪表','保持良好的个人卫生、无异味、无怪异发型；仪表端庄、大方，语言得体','008',5.00,1,'20160401','0204000000');
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
  PRIMARY KEY (`ID`),
  UNIQUE KEY `INDEX_1` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_evaluation_item_type`
--

LOCK TABLES `t_evaluation_item_type` WRITE;
/*!40000 ALTER TABLE `t_evaluation_item_type` DISABLE KEYS */;
INSERT INTO `t_evaluation_item_type` VALUES ('001','业绩',NULL,1),('002','满意度',NULL,1),('003','服务流程',NULL,1),('004','基础工作',NULL,1),('005','工作态度',NULL,1),('006','关键事件',NULL,1),('007','岗位职责',NULL,1),('008','基础管理',NULL,1),('009','6S管理',NULL,1),('010','加分项',NULL,1),('011','CSI',NULL,1);
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
  PRIMARY KEY (`ID`),
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
INSERT INTO `t_evaluation_results` VALUES ('2bcd76b3-96ce-4243-989e-8ff19d80cc73','','003',2016,3,'nobody','0001','0008','2016-04-20',10.00,'20160401'),('37ad565a-4dcc-4e27-bb78-06bc70686c72','','003',2016,3,'nobody','0001','0004','2016-04-20',5.00,'20160401'),('3ee6d1c6-9f09-49dc-b310-7a7419a5adf3','','003',2016,3,'nobody','0001','0012','2016-04-20',5.00,'20160401'),('4ea17de5-debf-47cd-b43d-b69cb9577957','','005',2016,3,'nobody','0001','0001','2016-04-20',1.00,'20160401'),('4fd30c81-d869-4b3e-9ac9-2fc6af1b08a0','','003',2016,3,'nobody','0001','0005','2016-04-20',10.00,'20160401'),('614923b2-2f45-4bbd-8e8c-521d2ced5596','','003',2016,3,'nobody','0001','0009','2016-04-20',5.00,'20160401'),('61e34baa-6f7e-4b29-ac16-2042406da569','','003',2016,3,'nobody','0001','0013','2016-04-20',5.00,'20160401'),('7b767203-7869-48ba-845a-18765137ff76','','003',2016,3,'nobody','0001','0002','2016-04-20',10.00,'20160401'),('8d1137ab-5876-4bb9-aa2f-a6568ec383b8','','003',2016,3,'nobody','0001','0011','2016-04-20',10.00,'20160401'),('8da07ae9-d4eb-4133-87ee-5a90ab6f0e2b','','003',2016,3,'nobody','0001','0014','2016-04-20',10.00,'20160401'),('ace15604-36b9-4b1f-ae6c-98d17bccf57d','','003',2016,3,'nobody','0001','0003','2016-04-20',5.00,'20160401'),('b8c1499b-b8e8-4009-a6bc-735a85277fa0','','003',2016,3,'nobody','0001','0010','2016-04-20',5.00,'20160401'),('d49af781-a3e0-4529-a5c7-457c69e3571f','','003',2016,3,'nobody','0001','0007','2016-04-20',4.00,'20160401'),('d9484d74-6698-4140-a87e-da6623c9b28e','','003',2016,3,'nobody','0001','0015','2016-04-20',10.00,'20160401'),('de3b003e-8656-4966-be1d-b40d618c56d9','','003',2016,3,'nobody','0001','0001','2016-04-20',10.00,'20160401'),('e524bdfe-9f84-4e0f-8ccf-9ac50e2c19db','','003',2016,3,'nobody','0001','0006','2016-04-20',6.00,'20160401');
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
  PRIMARY KEY (`ID`),
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
-- Table structure for table `t_parameter_type`
--

DROP TABLE IF EXISTS `t_parameter_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_parameter_type` (
  `SYSTEM_TYPE` varchar(1000) NOT NULL,
  `NAME` varchar(100) NOT NULL,
  `SIZE` int(11) NOT NULL,
  `FIXED` tinyint(1) NOT NULL,
  PRIMARY KEY (`SYSTEM_TYPE`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_parameter_type`
--

LOCK TABLES `t_parameter_type` WRITE;
/*!40000 ALTER TABLE `t_parameter_type` DISABLE KEYS */;
INSERT INTO `t_parameter_type` VALUES ('System.Boolean','布尔',0,1),('System.Char','字符',0,1),('System.DateTime','日期时间',0,1),('System.Decimal','小数',0,1),('System.Int32','整数',0,1),('System.String','字符串',100,1);
/*!40000 ALTER TABLE `t_parameter_type` ENABLE KEYS */;
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
  PRIMARY KEY (`ID`),
  UNIQUE KEY `岗位表_PK` (`ID`),
  KEY `上级岗位编号_FK` (`LEADER_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_position`
--

LOCK TABLES `t_position` WRITE;
/*!40000 ALTER TABLE `t_position` DISABLE KEYS */;
INSERT INTO `t_position` VALUES ('0000000000',NULL,'总经理','',1),('0100000000','0000000000','客服经理','',1),('0101000000','0000000000','顾客关系经理','',1),('0102000000','0000000000','信息员','',1),('0200000000','0000000000','服务总监','',1),('0201000000','0200000000','保险部经理','',1),('0201010000','0201000000','事故专员','',1),('0201020000','0201000000','电话车险销售员','',1),('0202000000','0200000000','服务经理','',1),('0202010000','0202000000','非技术内训师','',1),('0202030000','0200000000','前台主管','',1),('0202030100','0202000000','服务顾问','',1),('0202030200','0202030000','休息区服务专员','',1),('0202040000','0202000000','网络管理员','',1),('0203000000','0208000000','备件经理','',1),('0203010000','0208000000','库管员','',1),('0203020000','0208000000','配件计划员','',1),('0203030101','0202000000','实习服务顾问','',1),('0204000000','0205000000','技术经理','',1),('0204010000','0000000000','技术内训师','',1),('0204020000','0000000000','质检员','',1),('0204030000','0205000000','车间主管','',1),('0204030100','0205000000','机电组长','',1),('0204030101','0204030100','机电技师','',1),('0204030102','0204030100','机电学徒','',1),('0204030200','0205000000','钣金组长','',1),('0204030201','0204030200','钣金技师','',1),('0204030202','0205000000','钣金学徒','',1),('0204030300','0205000000','漆工组长','',1),('0204030301','0204030300','漆工技师','',1),('0204030302','0204030300','漆工学徒','',1),('0204040000','0200000000','PDI专员','',1),('0204050000','0200000000','救急专员','',1),('0204060000','0000000000','废料收集员','',1),('0205000000','0200000000','服务副总监',NULL,1),('0206000000','0000000000','站长助理',NULL,1),('0207000000','0200000000','索赔员','',1),('0208000000','0200000000','配件经理',NULL,1),('0300000000','0205000000','钣喷组长',NULL,1),('9999999999',NULL,'通用岗位','通用岗位',1);
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
  PRIMARY KEY (`ASSIGNMENT_ID`,`POSITION_ID`),
  UNIQUE KEY `INDEX_1` (`ASSIGNMENT_ID`,`POSITION_ID`),
  KEY `INDEX_2` (`VERSION_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_position_assignments`
--

LOCK TABLES `t_position_assignments` WRITE;
/*!40000 ALTER TABLE `t_position_assignments` DISABLE KEYS */;
INSERT INTO `t_position_assignments` VALUES ('01758245-4965-4a64-910b-7664651cbe8a','0000000000',1,'20140404',100.00,1000.000000),('9739087d-dc2e-450e-9104-252235cf89de','0000000000',1,'20140404',100.00,100.000000),('9739087d-dc2e-450e-9104-252235cf89de','0100000000',1,'20140404',100.00,12.500000),('9739087d-dc2e-450e-9104-252235cf89de','0101000000',1,'20140404',100.00,12.500000),('9739087d-dc2e-450e-9104-252235cf89de','0102000000',1,'20140404',100.00,12.500000),('9739087d-dc2e-450e-9104-252235cf89de','0200000000',1,'20140404',100.00,12.500000),('9739087d-dc2e-450e-9104-252235cf89de','0201000000',1,'20140404',100.00,12.500000),('9739087d-dc2e-450e-9104-252235cf89de','0201010000',1,'20140404',100.00,50.000000),('9739087d-dc2e-450e-9104-252235cf89de','0201020000',1,'20140404',100.00,50.000000),('9739087d-dc2e-450e-9104-252235cf89de','0202000000',1,'20140404',100.00,12.500000),('9739087d-dc2e-450e-9104-252235cf89de','0202010000',1,'20140404',100.00,25.000000),('9739087d-dc2e-450e-9104-252235cf89de','0202030000',1,'20140404',100.00,12.500000),('9739087d-dc2e-450e-9104-252235cf89de','0202030100',1,'20140404',100.00,25.000000),('9739087d-dc2e-450e-9104-252235cf89de','0202030200',1,'20140404',100.00,100.000000),('9739087d-dc2e-450e-9104-252235cf89de','0202040000',1,'20140404',100.00,25.000000),('9739087d-dc2e-450e-9104-252235cf89de','0203000000',1,'20140404',100.00,33.330000),('9739087d-dc2e-450e-9104-252235cf89de','0203010000',1,'20140404',100.00,33.330000),('9739087d-dc2e-450e-9104-252235cf89de','0203020000',1,'20140404',100.00,33.340000),('9739087d-dc2e-450e-9104-252235cf89de','0203030101',1,'20140404',100.00,25.000000),('9739087d-dc2e-450e-9104-252235cf89de','0204000000',1,'20140404',100.00,14.280000),('9739087d-dc2e-450e-9104-252235cf89de','0204010000',1,'20140404',100.00,12.500000),('9739087d-dc2e-450e-9104-252235cf89de','0204020000',1,'20140404',100.00,12.500000),('9739087d-dc2e-450e-9104-252235cf89de','0204030000',1,'20140404',100.00,14.280000),('9739087d-dc2e-450e-9104-252235cf89de','0204030100',1,'20140404',100.00,14.280000),('9739087d-dc2e-450e-9104-252235cf89de','0204030101',1,'20140404',100.00,50.000000),('9739087d-dc2e-450e-9104-252235cf89de','0204030102',1,'20140404',100.00,50.000000),('9739087d-dc2e-450e-9104-252235cf89de','0204030200',1,'20140404',100.00,14.280000),('9739087d-dc2e-450e-9104-252235cf89de','0204030201',1,'20140404',100.00,100.000000),('9739087d-dc2e-450e-9104-252235cf89de','0204030202',1,'20140404',100.00,14.280000),('9739087d-dc2e-450e-9104-252235cf89de','0204030300',1,'20140404',100.00,14.280000),('9739087d-dc2e-450e-9104-252235cf89de','0204030301',1,'20140404',100.00,50.000000),('9739087d-dc2e-450e-9104-252235cf89de','0204030302',1,'20140404',100.00,50.000000),('9739087d-dc2e-450e-9104-252235cf89de','0204040000',1,'20140404',100.00,12.500000),('9739087d-dc2e-450e-9104-252235cf89de','0204050000',1,'20140404',100.00,12.500000),('9739087d-dc2e-450e-9104-252235cf89de','0204060000',1,'20140404',100.00,12.500000),('9739087d-dc2e-450e-9104-252235cf89de','0205000000',1,'20140404',100.00,12.500000),('9739087d-dc2e-450e-9104-252235cf89de','0206000000',1,'20140404',100.00,12.500000),('9739087d-dc2e-450e-9104-252235cf89de','0207000000',1,'20140404',100.00,12.500000),('9739087d-dc2e-450e-9104-252235cf89de','0208000000',1,'20140404',100.00,12.500000),('9739087d-dc2e-450e-9104-252235cf89de','0300000000',1,'20140404',100.00,14.320000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0000000000',1,'20140404',100.00,0.000000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0100000000',1,'20140404',100.00,12.500000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0101000000',1,'20140404',100.00,12.500000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0102000000',1,'20140404',100.00,12.500000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0200000000',1,'20140404',100.00,12.500000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0201000000',1,'20140404',100.00,12.500000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0201010000',1,'20140404',100.00,50.000000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0201020000',1,'20140404',100.00,50.000000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0202000000',1,'20140404',100.00,12.500000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0202010000',1,'20140404',100.00,25.000000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0202020000',1,'20140404',100.00,25.000000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0202030000',1,'20140404',100.00,12.500000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0202030100',1,'20140404',100.00,25.000000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0202030200',1,'20140404',100.00,100.000000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0202040000',1,'20140404',100.00,25.000000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0203000000',1,'20140404',100.00,33.330000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0203010000',1,'20140404',100.00,33.330000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0203020000',1,'20140404',100.00,33.340000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0203030101',1,'20140404',100.00,25.000000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0204000000',1,'20140404',100.00,14.280000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0204010000',1,'20140404',100.00,12.500000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0204020000',1,'20140404',100.00,12.500000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0204030000',1,'20140404',100.00,14.280000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0204030100',1,'20140404',100.00,14.280000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0204030101',1,'20140404',100.00,50.000000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0204030102',1,'20140404',100.00,50.000000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0204030200',1,'20140404',100.00,14.280000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0204030201',1,'20140404',100.00,100.000000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0204030202',1,'20140404',100.00,14.280000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0204030300',1,'20140404',100.00,14.280000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0204030301',1,'20140404',100.00,50.000000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0204030302',1,'20140404',100.00,50.000000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0204040000',1,'20140404',100.00,12.500000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0204050000',1,'20140404',100.00,12.500000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0204060000',1,'20140404',100.00,12.500000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0205000000',1,'20140404',100.00,12.500000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0206000000',1,'20140404',100.00,12.500000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0207000000',1,'20140404',100.00,12.500000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0208000000',1,'20140404',100.00,12.500000),('a529ecb7-c772-44ad-84af-0d9f50c16a20','0300000000',1,'20140404',100.00,14.320000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0000000000',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0100000000',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0101000000',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0102000000',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0200000000',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0201000000',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0201010000',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0201020000',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0202000000',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0202010000',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0202020000',0,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0202030000',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0202030100',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0202030200',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0202040000',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0203000000',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0203010000',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0203020000',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0203030101',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0204000000',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0204010000',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0204020000',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0204030000',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0204030100',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0204030101',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0204030102',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0204030200',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0204030201',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0204030202',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0204030300',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0204030301',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0204030302',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0204040000',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0204050000',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0204060000',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0205000000',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0206000000',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0207000000',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0208000000',1,'20140404',100.00,30.000000),('c4b73c07-4e95-4f99-86cc-fe4748497e9e','0300000000',1,'20140404',100.00,30.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0000000000',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0100000000',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0101000000',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0102000000',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0200000000',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0201000000',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0201010000',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0201020000',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0202000000',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0202010000',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0202020000',0,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0202030000',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0202030100',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0202030200',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0202040000',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0203000000',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0203010000',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0203020000',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0203030101',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0204000000',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0204010000',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0204020000',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0204030000',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0204030100',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0204030101',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0204030102',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0204030200',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0204030201',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0204030202',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0204030300',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0204030301',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0204030302',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0204040000',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0204050000',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0204060000',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0205000000',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0206000000',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0207000000',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0208000000',1,'20140404',100.00,0.000000),('dc6f0e59-571f-48bf-b49b-a78c3dd9d1be','0300000000',1,'20140404',100.00,0.000000);
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
  PRIMARY KEY (`POSITION_ID`,`EVALUATION_FORM_ID`),
  UNIQUE KEY `INDEX_1` (`POSITION_ID`,`EVALUATION_FORM_ID`),
  KEY `INDEX_2` (`VERSION_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_position_evaluation_forms`
--

LOCK TABLES `t_position_evaluation_forms` WRITE;
/*!40000 ALTER TABLE `t_position_evaluation_forms` DISABLE KEYS */;
INSERT INTO `t_position_evaluation_forms` VALUES ('0204030100','0001',50.00,1,'20160401'),('0204030100','6dc3c933-1863-43b7-9d91-9b76ab8c69ec',50.00,1,'20160401');
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
  PRIMARY KEY (`POSITION_ID`,`SALARY_ITEM_ID`),
  UNIQUE KEY `INDEX_1` (`POSITION_ID`,`SALARY_ITEM_ID`),
  KEY `INDEX_2` (`VERSION_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_position_salary_items`
--

LOCK TABLES `t_position_salary_items` WRITE;
/*!40000 ALTER TABLE `t_position_salary_items` DISABLE KEYS */;
INSERT INTO `t_position_salary_items` VALUES ('0000000000','1739afd3-0703-4efa-8eb8-73986042aefb','20160401',1),('0000000000','3d0d1b65-6b0d-4331-98cb-e2338adaac42','20160401',1),('0000000000','51bcd4dc-d2c6-4765-b897-32f55da7d8cf','20160401',1),('0000000000','f4876dbc-b404-4f70-82ba-c898b2e35cfb','20160401',1),('0000000000','fc0166dc-0ccb-438e-8e21-d4a7d69a7f60','20160401',1),('0100000000','1739afd3-0703-4efa-8eb8-73986042aefb','20160401',1),('0100000000','3d0d1b65-6b0d-4331-98cb-e2338adaac42','20160401',1),('0100000000','51bcd4dc-d2c6-4765-b897-32f55da7d8cf','20160401',1),('0100000000','f4876dbc-b404-4f70-82ba-c898b2e35cfb','20160401',1),('0100000000','fc0166dc-0ccb-438e-8e21-d4a7d69a7f60','20160401',1),('0101000000','1739afd3-0703-4efa-8eb8-73986042aefb','20160401',1),('0101000000','3d0d1b65-6b0d-4331-98cb-e2338adaac42','20160401',1),('0101000000','51bcd4dc-d2c6-4765-b897-32f55da7d8cf','20160401',1),('0101000000','f4876dbc-b404-4f70-82ba-c898b2e35cfb','20160401',1),('0101000000','fc0166dc-0ccb-438e-8e21-d4a7d69a7f60','20160401',1),('0102000000','3d0d1b65-6b0d-4331-98cb-e2338adaac42','20160401',1),('0102000000','51bcd4dc-d2c6-4765-b897-32f55da7d8cf','20160401',1),('0102000000','f4876dbc-b404-4f70-82ba-c898b2e35cfb','20160401',1),('0200000000','1739afd3-0703-4efa-8eb8-73986042aefb','20160401',1),('0200000000','3d0d1b65-6b0d-4331-98cb-e2338adaac42','20160401',1),('0200000000','51bcd4dc-d2c6-4765-b897-32f55da7d8cf','20160401',1),('0200000000','f4876dbc-b404-4f70-82ba-c898b2e35cfb','20160401',1),('0200000000','fc0166dc-0ccb-438e-8e21-d4a7d69a7f60','20160401',1),('0201000000','1739afd3-0703-4efa-8eb8-73986042aefb','20160401',1),('0201000000','3d0d1b65-6b0d-4331-98cb-e2338adaac42','20160401',1),('0201000000','51bcd4dc-d2c6-4765-b897-32f55da7d8cf','20160401',1),('0201000000','f4876dbc-b404-4f70-82ba-c898b2e35cfb','20160401',1),('0201000000','fc0166dc-0ccb-438e-8e21-d4a7d69a7f60','20160401',1),('0201010000','1739afd3-0703-4efa-8eb8-73986042aefb','20160401',1),('0201010000','3d0d1b65-6b0d-4331-98cb-e2338adaac42','20160401',1),('0201010000','51bcd4dc-d2c6-4765-b897-32f55da7d8cf','20160401',1),('0201010000','f4876dbc-b404-4f70-82ba-c898b2e35cfb','20160401',1),('0201010000','fc0166dc-0ccb-438e-8e21-d4a7d69a7f60','20160401',1),('0201020000','1739afd3-0703-4efa-8eb8-73986042aefb','20160401',1),('0201020000','3d0d1b65-6b0d-4331-98cb-e2338adaac42','20160401',1),('0201020000','51bcd4dc-d2c6-4765-b897-32f55da7d8cf','20160401',1),('0201020000','f4876dbc-b404-4f70-82ba-c898b2e35cfb','20160401',1),('0201020000','fc0166dc-0ccb-438e-8e21-d4a7d69a7f60','20160401',1),('0202000000','1739afd3-0703-4efa-8eb8-73986042aefb','20160401',1),('0202000000','3d0d1b65-6b0d-4331-98cb-e2338adaac42','20160401',1),('0202000000','51bcd4dc-d2c6-4765-b897-32f55da7d8cf','20160401',1),('0202000000','f4876dbc-b404-4f70-82ba-c898b2e35cfb','20160401',1),('0202000000','fc0166dc-0ccb-438e-8e21-d4a7d69a7f60','20160401',1),('0202010000','3d0d1b65-6b0d-4331-98cb-e2338adaac42','20160401',1),('0202010000','51bcd4dc-d2c6-4765-b897-32f55da7d8cf','20160401',1),('0202010000','f4876dbc-b404-4f70-82ba-c898b2e35cfb','20160401',1),('0202020000','1739afd3-0703-4efa-8eb8-73986042aefb','20160401',1),('0202020000','3d0d1b65-6b0d-4331-98cb-e2338adaac42','20160401',1),('0202020000','51bcd4dc-d2c6-4765-b897-32f55da7d8cf','20160401',1),('0202020000','f4876dbc-b404-4f70-82ba-c898b2e35cfb','20160401',1),('0202020000','fc0166dc-0ccb-438e-8e21-d4a7d69a7f60','20160401',1),('0202030000','1739afd3-0703-4efa-8eb8-73986042aefb','20160401',1),('0202030000','3d0d1b65-6b0d-4331-98cb-e2338adaac42','20160401',1),('0202030000','51bcd4dc-d2c6-4765-b897-32f55da7d8cf','20160401',1),('0202030000','f4876dbc-b404-4f70-82ba-c898b2e35cfb','20160401',1),('0202030000','fc0166dc-0ccb-438e-8e21-d4a7d69a7f60','20160401',1),('0202030100','1739afd3-0703-4efa-8eb8-73986042aefb','20160401',1),('0202030100','3d0d1b65-6b0d-4331-98cb-e2338adaac42','20160401',1),('0202030100','51bcd4dc-d2c6-4765-b897-32f55da7d8cf','20160401',1),('0202030100','f4876dbc-b404-4f70-82ba-c898b2e35cfb','20160401',1),('0202030100','fc0166dc-0ccb-438e-8e21-d4a7d69a7f60','20160401',1),('0202030200','3d0d1b65-6b0d-4331-98cb-e2338adaac42','20160401',1),('0202030200','51bcd4dc-d2c6-4765-b897-32f55da7d8cf','20160401',1),('0202030200','f4876dbc-b404-4f70-82ba-c898b2e35cfb','20160401',1),('0202040000','3d0d1b65-6b0d-4331-98cb-e2338adaac42','20160401',1),('0202040000','51bcd4dc-d2c6-4765-b897-32f55da7d8cf','20160401',1),('0202040000','f4876dbc-b404-4f70-82ba-c898b2e35cfb','20160401',1),('0203000000','1739afd3-0703-4efa-8eb8-73986042aefb','20160401',1),('0203000000','3d0d1b65-6b0d-4331-98cb-e2338adaac42','20160401',1),('0203000000','51bcd4dc-d2c6-4765-b897-32f55da7d8cf','20160401',1),('0203000000','f4876dbc-b404-4f70-82ba-c898b2e35cfb','20160401',1),('0203000000','fc0166dc-0ccb-438e-8e21-d4a7d69a7f60','20160401',1),('0203010000','1739afd3-0703-4efa-8eb8-73986042aefb','20160401',1),('0203010000','3d0d1b65-6b0d-4331-98cb-e2338adaac42','20160401',1),('0203010000','51bcd4dc-d2c6-4765-b897-32f55da7d8cf','20160401',1),('0203010000','f4876dbc-b404-4f70-82ba-c898b2e35cfb','20160401',1),('0203010000','fc0166dc-0ccb-438e-8e21-d4a7d69a7f60','20160401',1),('0203020000','1739afd3-0703-4efa-8eb8-73986042aefb','20160401',1),('0203020000','3d0d1b65-6b0d-4331-98cb-e2338adaac42','20160401',1),('0203020000','51bcd4dc-d2c6-4765-b897-32f55da7d8cf','20160401',1),('0203020000','f4876dbc-b404-4f70-82ba-c898b2e35cfb','20160401',1),('0203020000','fc0166dc-0ccb-438e-8e21-d4a7d69a7f60','20160401',1),('0203030101','1739afd3-0703-4efa-8eb8-73986042aefb','20160401',1),('0203030101','3d0d1b65-6b0d-4331-98cb-e2338adaac42','20160401',1),('0203030101','51bcd4dc-d2c6-4765-b897-32f55da7d8cf','20160401',1),('0203030101','f4876dbc-b404-4f70-82ba-c898b2e35cfb','20160401',1),('0203030101','fc0166dc-0ccb-438e-8e21-d4a7d69a7f60','20160401',1),('0204010000','3d0d1b65-6b0d-4331-98cb-e2338adaac42','20160401',1),('0204010000','51bcd4dc-d2c6-4765-b897-32f55da7d8cf','20160401',1),('0204010000','f4876dbc-b404-4f70-82ba-c898b2e35cfb','20160401',1),('0204020000','1739afd3-0703-4efa-8eb8-73986042aefb','20160401',1),('0204020000','3d0d1b65-6b0d-4331-98cb-e2338adaac42','20160401',1),('0204020000','51bcd4dc-d2c6-4765-b897-32f55da7d8cf','20160401',1),('0204020000','f4876dbc-b404-4f70-82ba-c898b2e35cfb','20160401',1),('0204020000','fc0166dc-0ccb-438e-8e21-d4a7d69a7f60','20160401',1),('0204030000','1739afd3-0703-4efa-8eb8-73986042aefb','20160401',1),('0204030000','3d0d1b65-6b0d-4331-98cb-e2338adaac42','20160401',1),('0204030000','51bcd4dc-d2c6-4765-b897-32f55da7d8cf','20160401',1),('0204030000','f4876dbc-b404-4f70-82ba-c898b2e35cfb','20160401',1),('0204030000','fc0166dc-0ccb-438e-8e21-d4a7d69a7f60','20160401',1),('0204030100','1739afd3-0703-4efa-8eb8-73986042aefb','20160401',1),('0204030100','3d0d1b65-6b0d-4331-98cb-e2338adaac42','20160401',1),('0204030100','51bcd4dc-d2c6-4765-b897-32f55da7d8cf','20160401',1),('0204030100','f4876dbc-b404-4f70-82ba-c898b2e35cfb','20160401',1),('0204030100','fc0166dc-0ccb-438e-8e21-d4a7d69a7f60','20160401',1),('0204030101','1739afd3-0703-4efa-8eb8-73986042aefb','20160401',1),('0204030101','3d0d1b65-6b0d-4331-98cb-e2338adaac42','20160401',1),('0204030101','51bcd4dc-d2c6-4765-b897-32f55da7d8cf','20160401',1),('0204030101','f4876dbc-b404-4f70-82ba-c898b2e35cfb','20160401',1),('0204030101','fc0166dc-0ccb-438e-8e21-d4a7d69a7f60','20160401',1),('0204030102','1739afd3-0703-4efa-8eb8-73986042aefb','20160401',1),('0204030102','3d0d1b65-6b0d-4331-98cb-e2338adaac42','20160401',1),('0204030102','51bcd4dc-d2c6-4765-b897-32f55da7d8cf','20160401',1),('0204030102','f4876dbc-b404-4f70-82ba-c898b2e35cfb','20160401',1),('0204030102','fc0166dc-0ccb-438e-8e21-d4a7d69a7f60','20160401',1),('0204030200','1739afd3-0703-4efa-8eb8-73986042aefb','20160401',1),('0204030200','3d0d1b65-6b0d-4331-98cb-e2338adaac42','20160401',1),('0204030200','51bcd4dc-d2c6-4765-b897-32f55da7d8cf','20160401',1),('0204030200','f4876dbc-b404-4f70-82ba-c898b2e35cfb','20160401',1),('0204030200','fc0166dc-0ccb-438e-8e21-d4a7d69a7f60','20160401',1),('0204030201','1739afd3-0703-4efa-8eb8-73986042aefb','20160401',1),('0204030201','3d0d1b65-6b0d-4331-98cb-e2338adaac42','20160401',1),('0204030201','51bcd4dc-d2c6-4765-b897-32f55da7d8cf','20160401',1),('0204030201','f4876dbc-b404-4f70-82ba-c898b2e35cfb','20160401',1),('0204030201','fc0166dc-0ccb-438e-8e21-d4a7d69a7f60','20160401',1),('0204030202','1739afd3-0703-4efa-8eb8-73986042aefb','20160401',1),('0204030202','3d0d1b65-6b0d-4331-98cb-e2338adaac42','20160401',1),('0204030202','51bcd4dc-d2c6-4765-b897-32f55da7d8cf','20160401',1),('0204030202','f4876dbc-b404-4f70-82ba-c898b2e35cfb','20160401',1),('0204030202','fc0166dc-0ccb-438e-8e21-d4a7d69a7f60','20160401',1),('0204030300','1739afd3-0703-4efa-8eb8-73986042aefb','20160401',1),('0204030300','3d0d1b65-6b0d-4331-98cb-e2338adaac42','20160401',1),('0204030300','51bcd4dc-d2c6-4765-b897-32f55da7d8cf','20160401',1),('0204030300','f4876dbc-b404-4f70-82ba-c898b2e35cfb','20160401',1),('0204030300','fc0166dc-0ccb-438e-8e21-d4a7d69a7f60','20160401',1),('0204030301','1739afd3-0703-4efa-8eb8-73986042aefb','20160401',1),('0204030301','3d0d1b65-6b0d-4331-98cb-e2338adaac42','20160401',1),('0204030301','51bcd4dc-d2c6-4765-b897-32f55da7d8cf','20160401',1),('0204030301','f4876dbc-b404-4f70-82ba-c898b2e35cfb','20160401',1),('0204030301','fc0166dc-0ccb-438e-8e21-d4a7d69a7f60','20160401',1),('0204030302','1739afd3-0703-4efa-8eb8-73986042aefb','20160401',1),('0204030302','3d0d1b65-6b0d-4331-98cb-e2338adaac42','20160401',1),('0204030302','51bcd4dc-d2c6-4765-b897-32f55da7d8cf','20160401',1),('0204030302','f4876dbc-b404-4f70-82ba-c898b2e35cfb','20160401',1),('0204030302','fc0166dc-0ccb-438e-8e21-d4a7d69a7f60','20160401',1),('0204040000','1739afd3-0703-4efa-8eb8-73986042aefb','20160401',1),('0204040000','3d0d1b65-6b0d-4331-98cb-e2338adaac42','20160401',1),('0204040000','51bcd4dc-d2c6-4765-b897-32f55da7d8cf','20160401',1),('0204040000','f4876dbc-b404-4f70-82ba-c898b2e35cfb','20160401',1),('0204040000','fc0166dc-0ccb-438e-8e21-d4a7d69a7f60','20160401',1),('0204050000','1739afd3-0703-4efa-8eb8-73986042aefb','20160401',1),('0204050000','3d0d1b65-6b0d-4331-98cb-e2338adaac42','20160401',1),('0204050000','51bcd4dc-d2c6-4765-b897-32f55da7d8cf','20160401',1),('0204050000','f4876dbc-b404-4f70-82ba-c898b2e35cfb','20160401',1),('0204050000','fc0166dc-0ccb-438e-8e21-d4a7d69a7f60','20160401',1),('0204060000','3d0d1b65-6b0d-4331-98cb-e2338adaac42','20160401',1),('0204060000','51bcd4dc-d2c6-4765-b897-32f55da7d8cf','20160401',1),('0204060000','f4876dbc-b404-4f70-82ba-c898b2e35cfb','20160401',1);
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
  PRIMARY KEY (`ID`),
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
  PRIMARY KEY (`ID`),
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
  PRIMARY KEY (`ID`),
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
  `DISPLAY_FORMULA` varchar(2000) DEFAULT NULL,
  `DESCRIPTION` varchar(2000) DEFAULT NULL,
  `SQL_STMT` varchar(4000) NOT NULL,
  `ENABLED` tinyint(1) NOT NULL,
  `PREDEFINED` tinyint(1) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `INDEX_1` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_salary_function`
--

LOCK TABLES `t_salary_function` WRITE;
/*!40000 ALTER TABLE `t_salary_function` DISABLE KEYS */;
INSERT INTO `t_salary_function` VALUES ('001','工龄计算','年数([当前时间]-[员工表][入职时间])','计算员工工龄','SELECT (YEAR(curdate())-YEAR(ENTRY_TIME))-(RIGHT(curdate(),5)>RIGHT(ENTRY_TIME, 5)) from t_employee where ID=\'{员工编号}\'',1,1),('002','工龄工资','[员工][工龄]*[取值]','计算员工工龄工资总额','select {工龄}*VALUE from ',1,1);
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
  `TYPE` varchar(1000) NOT NULL,
  `MIN_VALUE` varchar(100) DEFAULT NULL,
  `MAX_VALUE` varchar(100) DEFAULT NULL,
  `FUNC_ID` varchar(40) NOT NULL,
  `LENGTH` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID_UNIQUE` (`ID`),
  KEY `INDEX_2` (`FUNC_ID`),
  KEY `INDEX_3` (`TYPE`)
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
  PRIMARY KEY (`ID`),
  UNIQUE KEY `INDEX_1` (`ID`),
  KEY `INDEX_2` (`TYPE`),
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
INSERT INTO `t_salary_item` VALUES ('1739afd3-0703-4efa-8eb8-73986042aefb','工时提成',NULL,'002',NULL,1,'20160401','9999999999',NULL),('3d0d1b65-6b0d-4331-98cb-e2338adaac42','工龄工资','每满一年工龄，增加50元','002',50.00,1,'20160401','9999999999','002'),('51bcd4dc-d2c6-4765-b897-32f55da7d8cf','考核工资',NULL,'002',NULL,1,'20160401','9999999999',NULL),('f4876dbc-b404-4f70-82ba-c898b2e35cfb','基本工资','基本工资','001',800.00,1,'20160401','9999999999',NULL),('fc0166dc-0ccb-438e-8e21-d4a7d69a7f60','产值提成',NULL,'002',NULL,1,'20160401','9999999999',NULL);
/*!40000 ALTER TABLE `t_salary_item` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_salary_item_group`
--

DROP TABLE IF EXISTS `t_salary_item_group`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_salary_item_group` (
  `ID` varchar(40) NOT NULL,
  `NAME` varchar(100) NOT NULL,
  `DESCRIPTION` varchar(2000) DEFAULT NULL,
  `ITEM_ID` varchar(40) NOT NULL,
  `SHOW_ORDER` int(11) NOT NULL,
  `ENABLED` tinyint(1) NOT NULL,
  `VERSION_ID` varchar(40) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `INDEX_1` (`ID`),
  KEY `INDEX_2` (`ITEM_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_salary_item_group`
--

LOCK TABLES `t_salary_item_group` WRITE;
/*!40000 ALTER TABLE `t_salary_item_group` DISABLE KEYS */;
INSERT INTO `t_salary_item_group` VALUES ('3f43b9e7-9ba8-4d4c-8418-fd386582ecf1','考核工资',NULL,'51bcd4dc-d2c6-4765-b897-32f55da7d8cf',4,1,'20160401'),('58e229b1-4d8e-41cc-9549-4789e4d0791a','基本工资',NULL,'3d0d1b65-6b0d-4331-98cb-e2338adaac42',1,1,'20160401'),('731e5176-6853-46f4-b40f-1343c356a43e','基本工资',NULL,'f4876dbc-b404-4f70-82ba-c898b2e35cfb',0,1,'20160401'),('c8ec5cf7-8378-46cb-aaec-bb3a0765385c','考核工资',NULL,'fc0166dc-0ccb-438e-8e21-d4a7d69a7f60',2,1,'20160401'),('e845df6e-407c-4353-8d4a-762cf3c95d3e','考核工资',NULL,'1739afd3-0703-4efa-8eb8-73986042aefb',3,1,'20160401');
/*!40000 ALTER TABLE `t_salary_item_group` ENABLE KEYS */;
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
  PRIMARY KEY (`ID`),
  UNIQUE KEY `INDEX_1` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_salary_item_type`
--

LOCK TABLES `t_salary_item_type` WRITE;
/*!40000 ALTER TABLE `t_salary_item_type` DISABLE KEYS */;
INSERT INTO `t_salary_item_type` VALUES ('001','固定值','每次取固数值',1),('002','公式','使用公式计算',1),('003','直接录入','直接录入',1);
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
  PRIMARY KEY (`NAME`),
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
  PRIMARY KEY (`ID`),
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
-- Temporary view structure for view `v_personal_assignment_schedule`
--

DROP TABLE IF EXISTS `v_personal_assignment_schedule`;
/*!50001 DROP VIEW IF EXISTS `v_personal_assignment_schedule`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `v_personal_assignment_schedule` AS SELECT 
 1 AS `EMPLOYEE_ID`,
 1 AS `EMPLOYEE_NAME`,
 1 AS `DEF_ID`,
 1 AS `VERSION_ID`,
 1 AS `VALUE`,
 1 AS `DEF_NAME`,
 1 AS `DEF_TYPE`,
 1 AS `UNIT_ID`,
 1 AS `PERF_ID`,
 1 AS `COMPLETED`,
 1 AS `TARGET`,
 1 AS `ASSIGNMENT_YEAR`,
 1 AS `ASSIGNMENT_MONTH`,
 1 AS `ASSIGNED`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_personal_tree_assignment`
--

DROP TABLE IF EXISTS `v_personal_tree_assignment`;
/*!50001 DROP VIEW IF EXISTS `v_personal_tree_assignment`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `v_personal_tree_assignment` AS SELECT 
 1 AS `ID`,
 1 AS `LEADER_ID`,
 1 AS `NAME`,
 1 AS `DEFINE_ID`,
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
/*!50001 VIEW `v_personal_assignment_detail` AS select `t1`.`ID` AS `ID`,`t1`.`LEADER_ID` AS `LEADER_ID`,`t1`.`NAME` AS `NAME`,`t2`.`ID` AS `DEFINE_ID`,`t2`.`NAME` AS `DEFINE_NAME`,`t2`.`DESCRIPTION` AS `DEFINE_DESC`,`t2`.`TYPE` AS `DEFINE_TYPE`,`t2`.`VERSION_ID` AS `VERSION_ID`,`t2`.`UNIT_ID` AS `UNIT_ID`,`t2`.`DEFAULT_VALUE` AS `DEFAULT_VALUE`,`t2`.`POSITION_ID` AS `FIT_POSITION_ID`,ifnull(`t3`.`ENABLED`,FALSE) AS `USED`,ifnull(`t3`.`WEIGHT`,100) AS `WEIGHT`,ifnull(`t3`.`VALUE`,`t2`.`DEFAULT_VALUE`) AS `VALUE` from ((`t_position` `t1` left join `t_assignment_define` `t2` on(((`t1`.`ID` = `t2`.`POSITION_ID`) or (`t2`.`POSITION_ID` = '9999999999')))) left join `t_position_assignments` `t3` on(((`t1`.`ID` = `t3`.`POSITION_ID`) and (`t2`.`ID` = `t3`.`ASSIGNMENT_ID`)))) where ((`t1`.`ENABLED` = TRUE) and (`t1`.`ID` <> '9999999999') and (`t2`.`ENABLED` = TRUE) and (`t2`.`TYPE` <> '1')) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_personal_assignment_schedule`
--

/*!50001 DROP VIEW IF EXISTS `v_personal_assignment_schedule`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `v_personal_assignment_schedule` AS select `t`.`ID` AS `EMPLOYEE_ID`,`t`.`NAME` AS `EMPLOYEE_NAME`,`t1`.`ASSIGNMENT_ID` AS `DEF_ID`,`t1`.`VERSION_ID` AS `VERSION_ID`,`t1`.`VALUE` AS `VALUE`,`t2`.`NAME` AS `DEF_NAME`,`t2`.`TYPE` AS `DEF_TYPE`,`t2`.`UNIT_ID` AS `UNIT_ID`,`t3`.`ID` AS `PERF_ID`,ifnull(`t3`.`COMPLETED`,0) AS `COMPLETED`,ifnull(`t3`.`TARGET`,`t1`.`VALUE`) AS `TARGET`,`t3`.`ASSIGNMENT_YEAR` AS `ASSIGNMENT_YEAR`,`t3`.`ASSIGNMENT_MONTH` AS `ASSIGNMENT_MONTH`,if(isnull(`t3`.`ID`),FALSE,TRUE) AS `ASSIGNED` from (((`t_employee` `t` left join `t_position_assignments` `t1` on(((`t1`.`POSITION_ID` = `t`.`POSITION_ID`) and (`t1`.`ENABLED` = TRUE)))) left join `t_assignment_define` `t2` on(((`t2`.`ID` = `t1`.`ASSIGNMENT_ID`) and (`t2`.`TYPE` <> '1') and (`t2`.`ENABLED` = TRUE) and (`t2`.`VERSION_ID` = `t1`.`VERSION_ID`)))) left join `t_assignment_performance` `t3` on(((`t`.`ID` = `t3`.`EMPLOYEE_ID`) and (`t3`.`VERSION_ID` = `t1`.`VERSION_ID`) and (`t3`.`DEFINE_ID` = `t1`.`ASSIGNMENT_ID`)))) where ((`t`.`ENABLED` = TRUE) and (`t1`.`ENABLED` = TRUE) and (`t2`.`ENABLED` = TRUE)) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_personal_tree_assignment`
--

/*!50001 DROP VIEW IF EXISTS `v_personal_tree_assignment`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `v_personal_tree_assignment` AS select if((`u`.`DEFINE_ID` <> ''),concat(`u`.`DEFINE_ID`,`u`.`ID`),`u`.`ID`) AS `ID`,if((`u`.`DEFINE_ID` <> ''),`u`.`ID`,`u`.`LEADER_ID`) AS `LEADER_ID`,if((`u`.`DEFINE_ID` <> ''),`u`.`DEFINE_NAME`,`u`.`NAME`) AS `NAME`,`u`.`DEFINE_ID` AS `DEFINE_ID`,`u`.`DEFINE_DESC` AS `DEFINE_DESC`,`u`.`DEFINE_TYPE` AS `DEFINE_TYPE`,`u`.`VERSION_ID` AS `VERSION_ID`,`u`.`UNIT_ID` AS `UNIT_ID`,`u`.`DEFAULT_VALUE` AS `DEFAULT_VALUE`,`u`.`FIT_POSITION_ID` AS `FIT_POSITION_ID`,`u`.`USED` AS `USED`,`u`.`WEIGHT` AS `WEIGHT`,`u`.`VALUE` AS `VALUE` from (select `t`.`ID` AS `ID`,`t`.`LEADER_ID` AS `LEADER_ID`,`t`.`NAME` AS `NAME`,'' AS `DEFINE_ID`,'' AS `DEFINE_NAME`,'' AS `DEFINE_DESC`,'' AS `DEFINE_TYPE`,'' AS `VERSION_ID`,'' AS `UNIT_ID`,0 AS `DEFAULT_VALUE`,'' AS `FIT_POSITION_ID`,0 AS `USED`,0 AS `WEIGHT`,0 AS `VALUE` from `salary`.`t_position` `t` union all select `t1`.`ID` AS `ID`,`t1`.`LEADER_ID` AS `LEADER_ID`,`t1`.`NAME` AS `NAME`,`t1`.`DEFINE_ID` AS `DEFINE_ID`,`t1`.`DEFINE_NAME` AS `DEFINE_NAME`,`t1`.`DEFINE_DESC` AS `DEFINE_DESC`,`t1`.`DEFINE_TYPE` AS `DEFINE_TYPE`,`t1`.`VERSION_ID` AS `VERSION_ID`,`t1`.`UNIT_ID` AS `UNIT_ID`,`t1`.`DEFAULT_VALUE` AS `DEFAULT_VALUE`,`t1`.`FIT_POSITION_ID` AS `FIT_POSITION_ID`,`t1`.`USED` AS `USED`,`t1`.`WEIGHT` AS `WEIGHT`,`t1`.`VALUE` AS `VALUE` from `salary`.`v_personal_assignment_detail` `t1`) `u` */;
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

-- Dump completed on 2016-05-19 10:16:43
