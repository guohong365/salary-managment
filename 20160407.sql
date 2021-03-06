-- MySQL dump 10.13  Distrib 5.7.9, for Win32 (AMD64)
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
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_assignment_item_type`
--

LOCK TABLES `t_assignment_item_type` WRITE;
/*!40000 ALTER TABLE `t_assignment_item_type` DISABLE KEYS */;
INSERT INTO `t_assignment_item_type` VALUES ('1','团队任务','按岗位分配比例逐级自动分配',1),('2','个人任务','按岗位手工分配，仅该岗位上员工具有',1);
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
  `ASSIGNMENT_ID` varchar(40) NOT NULL,
  `COMPLETED` decimal(20,6) NOT NULL,
  `ASSIGNMENT_YEAR` int(11) NOT NULL,
  `ASSIGNMENT_MONTH` int(11) NOT NULL,
  `DESCRIPTION` varchar(2000) DEFAULT NULL,
  `VERSION_ID` varchar(40) NOT NULL,
  PRIMARY KEY (`ID`)
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
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_employee`
--

LOCK TABLES `t_employee` WRITE;
/*!40000 ALTER TABLE `t_employee` DISABLE KEYS */;
INSERT INTO `t_employee` VALUES ('0001',NULL,'0000000000','邹伟','总经理','2000-01-01',NULL,1),('0002','0001','0200000000','王辉',NULL,'2006-01-01',NULL,1);
/*!40000 ALTER TABLE `t_employee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_employee_salary`
--

DROP TABLE IF EXISTS `t_employee_salary`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_employee_salary` (
  `ID` varchar(40) NOT NULL,
  `EMPLOYEE_ID` varchar(40) NOT NULL,
  `SALARY_ITEM_ID` varchar(40) NOT NULL,
  `SALARY_YEAR` int(11) NOT NULL,
  `SALARY_MONTH` int(11) NOT NULL,
  `AMOUNT` decimal(10,2) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_employee_salary`
--

LOCK TABLES `t_employee_salary` WRITE;
/*!40000 ALTER TABLE `t_employee_salary` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_employee_salary` ENABLE KEYS */;
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
  PRIMARY KEY (`ID`)
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
  PRIMARY KEY (`ID`)
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
  PRIMARY KEY (`EVALUATION_FORM_ID`,`EVALUATION_FORM_ITEM_ID`)
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
  PRIMARY KEY (`ID`)
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
  PRIMARY KEY (`ID`)
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
  `EVALUATION_YEAY` int(11) NOT NULL,
  `EVALUATION_MONTH` int(11) NOT NULL,
  `EVALUATOR` varchar(40) NOT NULL,
  `EVALUATION_FORM_ID` varchar(40) NOT NULL,
  `EVALUATION_ITEM_ID` varchar(40) NOT NULL,
  `EVALUATION_TIME` date NOT NULL,
  `MARK` decimal(10,2) NOT NULL,
  `VERSION_ID` varchar(40) NOT NULL,
  PRIMARY KEY (`ID`)
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
  PRIMARY KEY (`ID`)
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
-- Table structure for table `t_evalueation_results`
--

DROP TABLE IF EXISTS `t_evalueation_results`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_evalueation_results` (
  `ID` varchar(40) NOT NULL,
  `DESCRIPTION` varchar(2000) DEFAULT NULL,
  `EMPLOYEE_ID` varchar(40) NOT NULL COMMENT '被考核人',
  `EVALUATION_YEAY` int(11) DEFAULT NULL,
  `EVALUATION_MONTH` int(11) DEFAULT NULL,
  `EVALUATOR` varchar(40) NOT NULL,
  `EVALUATION_FORM_ID` varchar(40) NOT NULL,
  `EVALUATION_ITEM_ID` varchar(40) NOT NULL,
  `EVALUATION_TIME` date NOT NULL,
  `MARK` decimal(10,2) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_evalueation_results`
--

LOCK TABLES `t_evalueation_results` WRITE;
/*!40000 ALTER TABLE `t_evalueation_results` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_evalueation_results` ENABLE KEYS */;
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
  PRIMARY KEY (`ID`)
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
  PRIMARY KEY (`ASSIGNMENT_ID`,`POSITION_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_position_assignments`
--

LOCK TABLES `t_position_assignments` WRITE;
/*!40000 ALTER TABLE `t_position_assignments` DISABLE KEYS */;
INSERT INTO `t_position_assignments` VALUES ('750590f0-8349-4cea-8494-80bf664b60fd','0201000000',1,'20140404'),('750590f0-8349-4cea-8494-80bf664b60fd','0204030100',1,'20140404');
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
  PRIMARY KEY (`POSITION_ID`,`EVALUATION_FORM_ID`)
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
  PRIMARY KEY (`POSITION_ID`,`SALARY_ITEM_ID`)
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
  PRIMARY KEY (`ID`)
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
  `CREATOR` varchar(40) DEFAULT NULL,
  PRIMARY KEY (`ID`)
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
  PRIMARY KEY (`ID`)
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
-- Table structure for table `t_salary_data_source_type`
--

DROP TABLE IF EXISTS `t_salary_data_source_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_salary_data_source_type` (
  `ID` varchar(40) NOT NULL,
  `NAME` varchar(100) NOT NULL,
  `DESCRIPTION` varchar(2000) DEFAULT NULL,
  `ENABLED` tinyint(1) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='1 行间，取VALUE字段值\n2 字段，取某字段\n3 公式，使用VALUE字段值作为公式计算';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_salary_data_source_type`
--

LOCK TABLES `t_salary_data_source_type` WRITE;
/*!40000 ALTER TABLE `t_salary_data_source_type` DISABLE KEYS */;
INSERT INTO `t_salary_data_source_type` VALUES ('1','行间','直接取项目记录“取值”字段',1),('2','公式','取项目记录“取值”字段作为公式，计算',0),('3','录入','录入工资表时录入',1);
/*!40000 ALTER TABLE `t_salary_data_source_type` ENABLE KEYS */;
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
  `VALUE` varchar(2000) NOT NULL,
  `ENABLED` tinyint(1) NOT NULL,
  `VERSION_ID` varchar(40) NOT NULL,
  `POSITION_ID` varchar(40) NOT NULL,
  `DATA_SOURCE_TYPE` char(40) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_salary_item`
--

LOCK TABLES `t_salary_item` WRITE;
/*!40000 ALTER TABLE `t_salary_item` DISABLE KEYS */;
INSERT INTO `t_salary_item` VALUES ('b01668d5-ec6b-45ea-a9c2-d07ee4ea8c37','提成',NULL,'002','0.5',1,'20160401','0204030100','3'),('f51b21fb-9fad-41d8-9b93-a46040ed4b25','基本工资',NULL,'001','800',1,'20160401','9999999999','1');
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
  PRIMARY KEY (`ID`)
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
  PRIMARY KEY (`NAME`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_settings`
--

LOCK TABLES `t_settings` WRITE;
/*!40000 ALTER TABLE `t_settings` DISABLE KEYS */;
INSERT INTO `t_settings` VALUES ('repository.assignment','20140404','当前任务指标版本',0),('repository.evaluation','20160401','当前绩效考核版本',0),('repository.salary','20160401','当前薪资构成版本',0);
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
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_unit`
--

LOCK TABLES `t_unit` WRITE;
/*!40000 ALTER TABLE `t_unit` DISABLE KEYS */;
INSERT INTO `t_unit` VALUES ('1','元',1),('2','万元',1),('3','次',1),('4','台次',1);
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
 1 AS `NAME`,
 1 AS `DESCRIPTION`,
 1 AS `TYPE`,
 1 AS `TARGET`,
 1 AS `UNIT`,
 1 AS `FIT_POSITION_ID`*/;
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
 1 AS `DATA_SOURCE_TYPE`*/;
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
/*!50001 VIEW `v_assignment_detail` AS select `t1`.`ASSIGNMENT_ID` AS `ASSIGNMENT_ID`,`t1`.`POSITION_ID` AS `POSITION_ID`,`t1`.`ENABLED` AS `ENABLED`,`t1`.`VERSION_ID` AS `VERSION_ID`,`t2`.`NAME` AS `NAME`,`t2`.`DESCRIPTION` AS `DESCRIPTION`,`t2`.`TYPE` AS `TYPE`,`t2`.`TARGET` AS `TARGET`,`t2`.`UNIT` AS `UNIT`,`t2`.`POSITION_ID` AS `FIT_POSITION_ID` from (`t_position_assignments` `t1` join `t_assignment_item` `t2`) where ((`t1`.`ASSIGNMENT_ID` = `t2`.`ID`) and `t2`.`ENABLED`) */;
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
/*!50001 VIEW `v_salary_struct_detail` AS select `t1`.`POSITION_ID` AS `POSITION_ID`,`t1`.`ENABLED` AS `ENABLED`,`t1`.`VERSION_ID` AS `VERSION_ID`,`t1`.`SALARY_ITEM_ID` AS `SALARY_ITEM_ID`,`t2`.`NAME` AS `NAME`,`t2`.`DESCRIPTION` AS `DESCRIPTION`,`t2`.`TYPE` AS `TYPE`,`t2`.`VALUE` AS `VALUE`,`t2`.`POSITION_ID` AS `FIT_POSITION_ID`,`t2`.`DATA_SOURCE_TYPE` AS `DATA_SOURCE_TYPE` from (`t_position_salary_items` `t1` left join `t_salary_item` `t2` on((`t2`.`ID` = `t1`.`SALARY_ITEM_ID`))) where `t2`.`ENABLED` */;
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

-- Dump completed on 2016-04-07 18:14:16
