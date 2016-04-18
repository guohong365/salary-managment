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
INSERT INTO `t_evaluation_item` VALUES ('0001','出勤记录','按照公司考勤制度要求，无迟到、早退、旷工、中途脱岗，病事假能按公司要求办理请假手续。（迟到、早退每次扣0.5分；旷工每次口3分）','008',10.00,1,'20160401','0204030100'),('0002','工作纪律','工作时间无睡觉、上网、聊QQ、吃零食、聚众闲聊、大声喧哗；（上班时间做工作无关的事，每次口0.5分）','008',10.00,1,'20160401','0204030100'),('0003','仪容仪表','按公司要求统一着装，工作服保持干净、整洁','008',5.00,1,'20160401','0204030100'),('0004','仪容仪表','保持良好的个人卫生、无异味、无怪异发型；仪表端庄、大方，语言得体','008',5.00,1,'20160401','0204030100'),('0005','交车合格率','按车间内外返制度执行（內返每次扣0.5分，外返每次扣2分；3DC回访派单每次扣1分','007',10.00,1,'20160401','0204030100'),('0006','培训合格率','未按要求参加技术内训，每次扣1.5分','007',6.00,1,'20160401','0204030100'),('0007','培训合格率','培训考核不合格，每次扣2分','007',4.00,1,'20160401','0204030100'),('0008','管理与执行能力','管控并协调组员之间的工作进度；按时、保质的完成车间分配的工作。（出现消极怠工、出状况而不作为，每次扣1分）','007',10.00,1,'20160401','0204030100'),('0009','工具设备','定期检查，不合格每次扣1分','009',5.00,1,'20160401','0204030100'),('0010','卫生区域','所属卫生区域检查不合格每次扣0.5分','009',5.00,1,'20160401','0204030100'),('0011','操作规范','未按规定流程操作，每次扣1分','009',10.00,1,'20160401','0204030100'),('0012','安全生产','禁烟区内吸烟，每次扣1分；发现他人在禁烟区内吸烟未劝阻，每次扣0.5分','009',5.00,1,'20160401','0204030100'),('0013','安全生产','因野蛮操作造成车辆、工具设备受损，人员受伤，每次扣1分','009',5.00,1,'20160401','0204030100'),('0014','CSI得分',NULL,'002',10.00,1,'20160401','0204030100'),('0015','特别业绩','积极参与疑难问题的解决；提出合理化建议，并有效实施；提高工作效率；（可酌情加分）','010',10.00,1,'20160401','0204030100'),('0016','及时接待','','011',1.00,1,'20160401','9999999999'),('0017','售后服务六件套',NULL,'011',1.00,1,'20160401','9999999999'),('0018','环车检查',NULL,'011',1.00,1,'20160401','9999999999'),('0019','贵重物品提醒',NULL,'011',1.00,1,'20160401','9999999999'),('0020','估时估价',NULL,'011',1.00,1,'20160401','9999999999'),('0021','服务响应',NULL,'011',1.00,1,'20160401','9999999999'),('0022','主动问候',NULL,'011',1.00,1,'20160401','9999999999'),('0023','引导休息',NULL,'011',1.00,1,'20160401','9999999999'),('0024','无线网络覆盖',NULL,'011',1.00,1,'20160401','9999999999'),('0025','洗手间环境',NULL,'011',1.00,1,'20160401','9999999999'),('0026','顾客休息区舒适程度',NULL,'011',1.00,1,'20160401','9999999999'),('0027','饮品提供及续杯',NULL,'011',1.00,1,'20160401','9999999999'),('0028','维修进度汇报',NULL,'011',1.00,1,'20160401','9999999999'),('0029','服务人员专业知识',NULL,'011',1.00,1,'20160401','9999999999'),('0030','预估时间内交车',NULL,'011',1.00,1,'20160401','9999999999'),('0031','车辆状态保持',NULL,'011',1.00,1,'20160401','9999999999'),('0032','洗车服务',NULL,'011',1.00,1,'20160401','9999999999'),('0033','旧件展示',NULL,'011',1.00,1,'20160401','9999999999'),('0034','轮胎杂物清理',NULL,'011',1.00,1,'20160401','9999999999'),('0035','维修成果展示',NULL,'011',1.00,1,'20160401','9999999999'),('0036','解释服务项目及收费',NULL,'011',1.00,1,'20160401','9999999999'),('0037','下次保养提醒',NULL,'011',1.00,1,'20160401','9999999999'),('0038','协助提车',NULL,'011',1.00,1,'20160401','9999999999'),('0039','礼貌送行',NULL,'011',1.00,1,'20160401','9999999999'),('0040','服务追踪',NULL,'011',1.00,1,'20160401','9999999999'),('0041','车辆故障一次性修复',NULL,'011',1.00,1,'20160401','9999999999'),('0042','维修时间满意情况',NULL,'011',1.00,1,'20160401','9999999999'),('0043','未接受顾客礼物或财物',NULL,'011',1.00,1,'20160401','9999999999'),('0044','100%车辆全生命周期关怀回访',NULL,'011',1.00,1,'20160401','9999999999'),('0045','推荐购买/再次购买',NULL,'011',1.00,1,'20160401','9999999999'),('1844a508-0994-48ff-a1a6-bc0c6b2f9f9d','培训合格率','按要求参加厂方培训，不合格每次扣2分','007',4.00,1,'20160401','0204000000'),('20cd6b33-dafa-42b1-9584-58f166791013','安全生产','因野蛮操作造成车辆、工具设备受损，人员受伤，每次扣1分','009',5.00,1,'20160401','0204030000'),('2506ecec-5b1f-48a8-8421-96ff5dd2821b','特别业绩','积极参与疑难问题的解决；提出合理化建议，并有效实施；提高工作效率；（可酌情加分）','010',10.00,1,'20160401','0204000000'),('28a2644e-530d-4957-b0d4-d3395e98dd96','安全生产','禁烟区内吸烟，每次扣1分；发现他人在禁烟区内吸烟未劝阻，每次扣0.5分','009',5.00,1,'20160401','0204000000'),('320f6437-b41d-42e7-919a-22c2043a4dfb','培训合格率','未按要求参加技术内训，每次扣1.5分','007',6.00,1,'20160401','0204030000'),('35445f8f-f506-4150-8773-4ce7628aa2eb','交车合格率','按车间内外返制度执行（內返每次扣0.5分，外返每次扣2分；3DC回访派单每次扣1分','007',10.00,1,'20160401','0204030000'),('477f707d-7d0b-468a-931d-a56d779a8edb','安全生产','禁烟区内吸烟，每次扣1分；发现他人在禁烟区内吸烟未劝阻，每次扣0.5分','009',5.00,1,'20160401','0204030000'),('570b0e58-a67c-440f-a208-40876796d940','工作纪律','工作时间无睡觉、上网、聊QQ、吃零食、聚众闲聊、大声喧哗；（上班时间做工作无关的事，每次口0.5分）','008',10.00,1,'20160401','0204030000'),('6075bfcb-190d-4c02-84a9-213644e82b17','安全生产','因野蛮操作造成车辆、工具设备受损，人员受伤，每次扣1分','009',5.00,1,'20160401','0204000000'),('6d52ca58-c2cf-49fd-9611-acbae94f1d47','交车合格率','按车间内外返制度执行（內返每次扣0.5分，外返每次扣2分；3DC回访派单每次扣1分','007',10.00,1,'20160401','0204000000'),('71b3fb4e-0c4c-4108-9b13-a54b8583d47d','培训合格率','按要求开展技术内训，不合格每次扣1.5分','007',6.00,1,'20160401','0204000000'),('73fb6053-02b6-4fc8-9043-7aa5a40d770c','管理与执行能力','完成技术顾问岗位轮值工作；协助技术顾问派工、交车；及时跟进各维修班组的进度，作适时指导及引导（因不作为造成工作延误、客户抱怨，每次扣1分）','007',10.00,1,'20160401','0204030000'),('75acde4d-c039-4c32-b3b0-187c180056fe','现场管理','严把质量关，对竣工车辆仔细检查，开据內返单（因漏检造成外返及客户投诉，每次扣2分）','009',10.00,1,'20160401','0204000000'),('7c00d67d-979d-4dba-8d7c-633ee90f429f','培训合格率','培训考核不合格，每次扣2分','007',4.00,1,'20160401','0204030000'),('81e458b9-4772-4ad3-b9fc-a81f39f4c024','仪容仪表','按公司要求统一着装，工作服保持干净、整洁','008',5.00,1,'20160401','0204030000'),('85f59807-deb2-4f4b-af25-7466d661ab91','现场管理','严把质量关，对竣工车辆仔细检查，开据內返单（因漏检造成外返及客户投诉，每次扣2分）','009',10.00,1,'20160401','0204030000'),('8af9827f-1763-41a1-a5fe-fa7ece060342','出勤记录','按照公司考勤制度要求，无迟到、早退、旷工、中途脱岗，病事假能按公司要求办理请假手续。（迟到、早退每次扣0.5分；旷工每次口3分）','008',10.00,1,'20160401','0204000000'),('9d85c808-84bc-4c3a-bc41-02f7fba1e394','出勤记录','按照公司考勤制度要求，无迟到、早退、旷工、中途脱岗，病事假能按公司要求办理请假手续。（迟到、早退每次扣0.5分；旷工每次口3分）','008',10.00,1,'20160401','0204030000'),('a7343604-2fc5-4ff0-8e94-e68cd7519d33','管理与执行能力','完成技术顾问岗位轮值工作；协助技术顾问派工、交车；及时跟进各维修班组的进度，对疑难故障作及时指导及引导（因不作为造成工作延误、客户抱怨，每次扣1分）','007',10.00,1,'20160401','0204000000'),('ae541886-33f1-4708-a512-92c847f1c613','CSI得分',NULL,'002',10.00,1,'20160401','0204030000'),('b09c49eb-0360-4607-ad08-8fabb2e471e4','仪容仪表','保持良好的个人卫生、无异味、无怪异发型；仪表端庄、大方，语言得体','008',5.00,1,'20160401','0204030000'),('b09f1fce-8ad5-46b9-9cc3-33613fc64e83','现场管理','及时纠正维修过程中的各种不规范行为','009',10.00,1,'20160401','0204000000'),('b2a83c28-d3c9-4bb4-b05f-4d9a59d30893','特别业绩','积极参与疑难问题的解决；提出合理化建议，并有效实施；提高工作效率；（可酌情加分）','010',10.00,1,'20160401','0204030000'),('cfb596ab-c190-4ef8-b6ca-ccd11b5e09b5','现场管理','及时纠正维修过程中的各种不规范行为','009',10.00,1,'20160401','0204030000'),('e2094954-3564-46e9-bcb2-4c6a8bdd5733','仪容仪表','按公司要求统一着装，工作服保持干净、整洁','008',5.00,1,'20160401','0204000000'),('e2d17de7-19ff-4bd2-83da-39709a5dbadc','工作纪律','工作时间无睡觉、上网、聊QQ、吃零食、聚众闲聊、大声喧哗；（上班时间做工作无关的事，每次口0.5分）','008',10.00,1,'20160401','0204000000'),('e86e7d35-d819-44f9-9417-02233eeff86d','CSI得分','','002',10.00,1,'20160401','0204000000'),('eda1dfd7-d570-4c37-8389-0986c1565443','仪容仪表','保持良好的个人卫生、无异味、无怪异发型；仪表端庄、大方，语言得体','008',5.00,1,'20160401','0204000000');
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
INSERT INTO `t_salary_item_type` VALUES ('001','固定值','每次取固数值',1),('002','公式','使用公式计算',1);
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

-- Dump completed on 2016-04-19  3:53:46
