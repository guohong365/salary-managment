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
-- Dumping data for table `t_annual_assignment`
--

LOCK TABLES `t_annual_assignment` WRITE;
/*!40000 ALTER TABLE `t_annual_assignment` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_annual_assignment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `t_assignment_define`
--

LOCK TABLES `t_assignment_define` WRITE;
/*!40000 ALTER TABLE `t_assignment_define` DISABLE KEYS */;
INSERT INTO `t_assignment_define` VALUES ('12cea176-2040-4116-832b-eb4a8b6032fd','吃饭次数',NULL,1,'2',10000.000000,'20140404','3','0000000000'),('4de125fc-020c-4aaa-9d9b-12b913f40d82','工时任务',NULL,1,'3',0.000000,'20140404','5','9999999999'),('91e17323-e3eb-42b3-b662-04fd3043b1d8','产值任务',NULL,1,'1',0.000000,'20140404','2','9999999999'),('c304c340-abb0-49be-a646-46cc1a0a51d0','检验数量',NULL,1,'2',1000.000000,'20140404','3','0204020000'),('cac57f41-d92b-4894-b7b6-befd85c71aea','精品辅料',NULL,1,'1',0.000000,'20140404','2','9999999999');
/*!40000 ALTER TABLE `t_assignment_define` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `t_assignment_item_type`
--

LOCK TABLES `t_assignment_item_type` WRITE;
/*!40000 ALTER TABLE `t_assignment_item_type` DISABLE KEYS */;
INSERT INTO `t_assignment_item_type` VALUES ('1','自动分配任务','任务下达到指定岗位后，再按岗位预设比例逐级分解到下属岗位，如无预设比例则该下属岗位不分配',1),('2','定额任务','任务下达到指定岗位，具有固定任务指标',1),('3','无定额任务','任务下达到指定岗位，没有任务指标。',1);
/*!40000 ALTER TABLE `t_assignment_item_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `t_assignment_performance`
--

LOCK TABLES `t_assignment_performance` WRITE;
/*!40000 ALTER TABLE `t_assignment_performance` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_assignment_performance` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `t_code_table`
--

LOCK TABLES `t_code_table` WRITE;
/*!40000 ALTER TABLE `t_code_table` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_code_table` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `t_employee`
--

LOCK TABLES `t_employee` WRITE;
/*!40000 ALTER TABLE `t_employee` DISABLE KEYS */;
INSERT INTO `t_employee` VALUES ('0001',NULL,'0000000000','邹伟','总经理','2000-01-01',NULL,1),('0002','0001','0200000000','王辉',NULL,'2006-01-01',NULL,1),('003',NULL,'0204030100','机电李四','机电组长','2006-01-01',NULL,1);
/*!40000 ALTER TABLE `t_employee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `t_employee_salary_detail`
--

LOCK TABLES `t_employee_salary_detail` WRITE;
/*!40000 ALTER TABLE `t_employee_salary_detail` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_employee_salary_detail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `t_evaluation_form`
--

LOCK TABLES `t_evaluation_form` WRITE;
/*!40000 ALTER TABLE `t_evaluation_form` DISABLE KEYS */;
INSERT INTO `t_evaluation_form` VALUES ('0001','KPI','KPI',1,'20160401','0204030100'),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','CSI','CSI',1,'20160401','9999999999');
/*!40000 ALTER TABLE `t_evaluation_form` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `t_evaluation_form_items`
--

LOCK TABLES `t_evaluation_form_items` WRITE;
/*!40000 ALTER TABLE `t_evaluation_form_items` DISABLE KEYS */;
INSERT INTO `t_evaluation_form_items` VALUES ('0001','0001','20160401',1,0),('0001','0002','20160401',1,1),('0001','0003','20160401',1,2),('0001','0004','20160401',1,3),('0001','0005','20160401',1,4),('0001','0006','20160401',1,5),('0001','0007','20160401',1,6),('0001','0008','20160401',1,7),('0001','0009','20160401',1,8),('0001','0010','20160401',1,9),('0001','0011','20160401',1,10),('0001','0012','20160401',1,11),('0001','0013','20160401',1,12),('0001','0014','20160401',1,13),('0001','0015','20160401',1,14),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0016','20160401',1,0),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0017','20160401',1,1),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0018','20160401',1,2),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0019','20160401',1,3),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0020','20160401',1,4),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0021','20160401',1,5),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0022','20160401',1,6),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0023','20160401',1,7),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0024','20160401',1,8),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0025','20160401',1,9),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0026','20160401',1,10),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0027','20160401',1,11),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0028','20160401',1,12),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0029','20160401',1,13),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0030','20160401',1,14),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0031','20160401',1,15),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0032','20160401',1,16),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0033','20160401',1,17),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0034','20160401',1,18),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0035','20160401',1,19),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0036','20160401',1,20),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0037','20160401',1,21),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0038','20160401',1,22),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0039','20160401',1,23),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0040','20160401',1,24),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0041','20160401',1,25),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0042','20160401',1,26),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0043','20160401',1,27),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0044','20160401',1,28),('6dc3c933-1863-43b7-9d91-9b76ab8c69ec','0045','20160401',1,29);
/*!40000 ALTER TABLE `t_evaluation_form_items` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `t_evaluation_item`
--

LOCK TABLES `t_evaluation_item` WRITE;
/*!40000 ALTER TABLE `t_evaluation_item` DISABLE KEYS */;
INSERT INTO `t_evaluation_item` VALUES ('0001','出勤记录','按照公司考勤制度要求，无迟到、早退、旷工、中途脱岗，病事假能按公司要求办理请假手续。（迟到、早退每次扣0.5分；旷工每次口3分）','008',10.00,1,'20160401','0204030100'),('0002','工作纪律','工作时间无睡觉、上网、聊QQ、吃零食、聚众闲聊、大声喧哗；（上班时间做工作无关的事，每次口0.5分）','008',10.00,1,'20160401','0204030100'),('0003','仪容仪表','按公司要求统一着装，工作服保持干净、整洁','008',5.00,1,'20160401','0204030100'),('0004','仪容仪表','保持良好的个人卫生、无异味、无怪异发型；仪表端庄、大方，语言得体','008',5.00,1,'20160401','0204030100'),('0005','交车合格率','按车间内外返制度执行（內返每次扣0.5分，外返每次扣2分；3DC回访派单每次扣1分','007',10.00,1,'20160401','0204030100'),('0006','培训合格率','未按要求参加技术内训，每次扣1.5分','007',6.00,1,'20160401','0204030100'),('0007','培训合格率','培训考核不合格，每次扣2分','007',4.00,1,'20160401','0204030100'),('0008','管理与执行能力','管控并协调组员之间的工作进度；按时、保质的完成车间分配的工作。（出现消极怠工、出状况而不作为，每次扣1分）','007',10.00,1,'20160401','0204030100'),('0009','工具设备','定期检查，不合格每次扣1分','009',5.00,1,'20160401','0204030100'),('0010','卫生区域','所属卫生区域检查不合格每次扣0.5分','009',5.00,1,'20160401','0204030100'),('0011','操作规范','未按规定流程操作，每次扣1分','009',10.00,1,'20160401','0204030100'),('0012','安全生产','禁烟区内吸烟，每次扣1分；发现他人在禁烟区内吸烟未劝阻，每次扣0.5分','009',5.00,1,'20160401','0204030100'),('0013','安全生产','因野蛮操作造成车辆、工具设备受损，人员受伤，每次扣1分','009',5.00,1,'20160401','0204030100'),('0014','CSI得分',NULL,'002',10.00,1,'20160401','0204030100'),('0015','特别业绩','积极参与疑难问题的解决；提出合理化建议，并有效实施；提高工作效率；（可酌情加分）','010',10.00,1,'20160401','0204030100'),('0016','及时接待','','011',1.00,1,'20160401','9999999999'),('0017','售后服务六件套',NULL,'011',1.00,1,'20160401','9999999999'),('0018','环车检查',NULL,'011',1.00,1,'20160401','9999999999'),('0019','贵重物品提醒',NULL,'011',1.00,1,'20160401','9999999999'),('0020','估时估价',NULL,'011',1.00,1,'20160401','9999999999'),('0021','服务响应',NULL,'011',1.00,1,'20160401','9999999999'),('0022','主动问候',NULL,'011',1.00,1,'20160401','9999999999'),('0023','引导休息',NULL,'011',1.00,1,'20160401','9999999999'),('0024','无线网络覆盖',NULL,'011',1.00,1,'20160401','9999999999'),('0025','洗手间环境',NULL,'011',1.00,1,'20160401','9999999999'),('0026','顾客休息区舒适程度',NULL,'011',1.00,1,'20160401','9999999999'),('0027','饮品提供及续杯',NULL,'011',1.00,1,'20160401','9999999999'),('0028','维修进度汇报',NULL,'011',1.00,1,'20160401','9999999999'),('0029','服务人员专业知识',NULL,'011',1.00,1,'20160401','9999999999'),('0030','预估时间内交车',NULL,'011',1.00,1,'20160401','9999999999'),('0031','车辆状态保持',NULL,'011',1.00,1,'20160401','9999999999'),('0032','洗车服务',NULL,'011',1.00,1,'20160401','9999999999'),('0033','旧件展示',NULL,'011',1.00,1,'20160401','9999999999'),('0034','轮胎杂物清理',NULL,'011',1.00,1,'20160401','9999999999'),('0035','维修成果展示',NULL,'011',1.00,1,'20160401','9999999999'),('0036','解释服务项目及收费',NULL,'011',1.00,1,'20160401','9999999999'),('0037','下次保养提醒',NULL,'011',1.00,1,'20160401','9999999999'),('0038','协助提车',NULL,'011',1.00,1,'20160401','9999999999'),('0039','礼貌送行',NULL,'011',1.00,1,'20160401','9999999999'),('0040','服务追踪',NULL,'011',1.00,1,'20160401','9999999999'),('0041','车辆故障一次性修复',NULL,'011',1.00,1,'20160401','9999999999'),('0042','维修时间满意情况',NULL,'011',1.00,1,'20160401','9999999999'),('0043','未接受顾客礼物或财物',NULL,'011',1.00,1,'20160401','9999999999'),('0044','100%车辆全生命周期关怀回访',NULL,'011',1.00,1,'20160401','9999999999'),('0045','推荐购买/再次购买',NULL,'011',1.00,1,'20160401','9999999999');
/*!40000 ALTER TABLE `t_evaluation_item` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `t_evaluation_item_type`
--

LOCK TABLES `t_evaluation_item_type` WRITE;
/*!40000 ALTER TABLE `t_evaluation_item_type` DISABLE KEYS */;
INSERT INTO `t_evaluation_item_type` VALUES ('001','业绩',NULL,1),('002','满意度',NULL,1),('003','服务流程',NULL,1),('004','基础工作',NULL,1),('005','工作态度',NULL,1),('006','关键事件',NULL,1),('007','岗位职责',NULL,1),('008','基础管理',NULL,1),('009','6S管理',NULL,1),('010','加分项',NULL,1),('011','CSI',NULL,1),('143acac5-ae06-4c13-85bb-eaf9b6068f17','ff',NULL,1),('21fc4961-cb04-4cab-a099-4f94acf9e815','aaa',NULL,1);
/*!40000 ALTER TABLE `t_evaluation_item_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `t_evaluation_results`
--

LOCK TABLES `t_evaluation_results` WRITE;
/*!40000 ALTER TABLE `t_evaluation_results` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_evaluation_results` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `t_evaluation_standard`
--

LOCK TABLES `t_evaluation_standard` WRITE;
/*!40000 ALTER TABLE `t_evaluation_standard` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_evaluation_standard` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `t_position`
--

LOCK TABLES `t_position` WRITE;
/*!40000 ALTER TABLE `t_position` DISABLE KEYS */;
INSERT INTO `t_position` VALUES ('0000000000',NULL,'总经理','',1),('0100000000','0000000000','客服经理','',1),('0101000000','0100000000','顾客管理员','',1),('0102000000','0100000000','信息员','',1),('0200000000','0000000000','服务总监','',1),('0201000000','0200000000','保险部经理','',1),('0201010000','0201000000','事故专员','',1),('0201020000','0201000000','电话车险销售员','',1),('0202000000','0200000000','服务经理','',1),('0202010000','0202000000','非技术内训师','',1),('0202020000','0202000000','索赔员','',1),('0202030000','0202000000','前台主管','',1),('0202030100','0202030000','服务顾问','',1),('0202030200','0202030000','休息区服务专员','',1),('0202040000','0202000000','网络管理员','',1),('0203000000','0200000000','配件经理','',1),('0203010000','0203000000','库管员','',1),('0203020000','0203000000','配件计划员','',1),('0203030101','0202030100','实习服务顾问','',1),('0204000000','0200000000','技术经理','',1),('0204010000','0204000000','技术内训师','',1),('0204020000','0204000000','质检员','',1),('0204030000','0204000000','车间主管','',1),('0204030100','0204030000','机电组长','',1),('0204030101','0204030100','机电技师','',1),('0204030102','0204030100','机电学徒','',1),('0204030200','0204030000','钣金组长','',1),('0204030201','0204030200','钣金技师','',1),('0204030202','0204030200','钣金学徒','',1),('0204030300','0204030000','漆工组长','',1),('0204030301','0204030300','漆工技师','',1),('0204030302','0204030300','漆工学徒','',1),('0204040000','0204000000','PDI专员','',1),('0204050000','0204000000','救急专员','',1),('0204060000','0204000000','废料收集员','',1),('9999999999',NULL,'通用岗位','通用岗位',1);
/*!40000 ALTER TABLE `t_position` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `t_position_assignments`
--

LOCK TABLES `t_position_assignments` WRITE;
/*!40000 ALTER TABLE `t_position_assignments` DISABLE KEYS */;
INSERT INTO `t_position_assignments` VALUES ('4de125fc-020c-4aaa-9d9b-12b913f40d82','0000000000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0100000000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0101000000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0102000000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0200000000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0201000000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0201010000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0201020000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0202000000',1,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0202010000',1,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0202020000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0202030000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0202030100',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0202030200',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0202040000',1,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0203000000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0203010000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0203020000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0203030101',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0204000000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0204010000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0204020000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0204030000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0204030100',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0204030101',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0204030102',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0204030200',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0204030201',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0204030202',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0204030300',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0204030301',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0204030302',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0204040000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0204050000',0,'20140404',100.00,0.000000),('4de125fc-020c-4aaa-9d9b-12b913f40d82','0204060000',0,'20140404',100.00,0.000000);
/*!40000 ALTER TABLE `t_position_assignments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `t_position_evaluation_forms`
--

LOCK TABLES `t_position_evaluation_forms` WRITE;
/*!40000 ALTER TABLE `t_position_evaluation_forms` DISABLE KEYS */;
INSERT INTO `t_position_evaluation_forms` VALUES ('0204030301','6dc3c933-1863-43b7-9d91-9b76ab8c69ec',100.00,1,'20160401');
/*!40000 ALTER TABLE `t_position_evaluation_forms` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `t_position_salary_items`
--

LOCK TABLES `t_position_salary_items` WRITE;
/*!40000 ALTER TABLE `t_position_salary_items` DISABLE KEYS */;
INSERT INTO `t_position_salary_items` VALUES ('0000000000','f51b21fb-9fad-41d8-9b93-a46040ed4b25','20160401',1),('0204030100','b01668d5-ec6b-45ea-a9c2-d07ee4ea8c37','20160401',1),('0204030100','f51b21fb-9fad-41d8-9b93-a46040ed4b25','20160401',1);
/*!40000 ALTER TABLE `t_position_salary_items` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `t_repository_assignment`
--

LOCK TABLES `t_repository_assignment` WRITE;
/*!40000 ALTER TABLE `t_repository_assignment` DISABLE KEYS */;
INSERT INTO `t_repository_assignment` VALUES ('20140404','任务指标初始版本','任务指标初始版本',1,'2016-04-04','nobody');
/*!40000 ALTER TABLE `t_repository_assignment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `t_repository_evaluation`
--

LOCK TABLES `t_repository_evaluation` WRITE;
/*!40000 ALTER TABLE `t_repository_evaluation` DISABLE KEYS */;
INSERT INTO `t_repository_evaluation` VALUES ('20160401','初始考核版本','',1,'2016-04-02','nobody');
/*!40000 ALTER TABLE `t_repository_evaluation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `t_repository_salary_struct`
--

LOCK TABLES `t_repository_salary_struct` WRITE;
/*!40000 ALTER TABLE `t_repository_salary_struct` DISABLE KEYS */;
INSERT INTO `t_repository_salary_struct` VALUES ('20160401','初始薪资版本','',1,'2016-04-02','nobody');
/*!40000 ALTER TABLE `t_repository_salary_struct` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `t_salary_data_source_type`
--

LOCK TABLES `t_salary_data_source_type` WRITE;
/*!40000 ALTER TABLE `t_salary_data_source_type` DISABLE KEYS */;
INSERT INTO `t_salary_data_source_type` VALUES ('1','行间','直接取项目记录“取值”字段',1),('2','公式','取项目记录“取值”字段作为公式，计算',0),('3','录入','录入工资表时录入',1);
/*!40000 ALTER TABLE `t_salary_data_source_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `t_salary_item`
--

LOCK TABLES `t_salary_item` WRITE;
/*!40000 ALTER TABLE `t_salary_item` DISABLE KEYS */;
INSERT INTO `t_salary_item` VALUES ('b01668d5-ec6b-45ea-a9c2-d07ee4ea8c37','提成',NULL,'002','15%',1,'20160401','0204030100','3'),('f51b21fb-9fad-41d8-9b93-a46040ed4b25','基本工资',NULL,'001','800',1,'20160401','9999999999','1');
/*!40000 ALTER TABLE `t_salary_item` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `t_salary_item_type`
--

LOCK TABLES `t_salary_item_type` WRITE;
/*!40000 ALTER TABLE `t_salary_item_type` DISABLE KEYS */;
INSERT INTO `t_salary_item_type` VALUES ('001','固定值','每次取固数值',1),('002','固定比例','取固定比例',1),('003','公式','使用公式计算',1);
/*!40000 ALTER TABLE `t_salary_item_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `t_settings`
--

LOCK TABLES `t_settings` WRITE;
/*!40000 ALTER TABLE `t_settings` DISABLE KEYS */;
INSERT INTO `t_settings` VALUES ('assignment.schedule.01','10','1月任务默认占比',1),('assignment.schedule.02','10','2月任务默认占比',1),('assignment.schedule.03','10','3月任务默认占比',1),('assignment.schedule.04','5','4月任务默认占比',1),('assignment.schedule.05','5','5月任务默认占比',1),('assignment.schedule.06','5','6月任务默认占比',1),('assignment.schedule.07','5','7月任务默认占比',1),('assignment.schedule.08','10','8月任务默认占比',1),('assignment.schedule.09','10','9月任务默认占比',1),('assignment.schedule.10','10','10月任务默认占比',1),('assignment.schedule.11','10','11月任务默认占比',1),('assignment.schedule.12','10','12月任务默认占比',1),('repository.assignment','20140404','当前任务指标版本',0),('repository.evaluation','20160401','当前绩效考核版本',0),('repository.salary','20160401','当前薪资构成版本',0);
/*!40000 ALTER TABLE `t_settings` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `t_unit`
--

LOCK TABLES `t_unit` WRITE;
/*!40000 ALTER TABLE `t_unit` DISABLE KEYS */;
INSERT INTO `t_unit` VALUES ('1','元',1),('2','万元',1),('3','次',1),('4','台次',1),('5','工时',1);
/*!40000 ALTER TABLE `t_unit` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'salary'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-04-13  2:18:12
