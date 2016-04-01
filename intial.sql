/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     2016/4/2 4:01:10                             */
/*==============================================================*/


DROP TABLE IF EXISTS T_ASSIGNMENT_ITEM;

DROP TABLE IF EXISTS T_ASSIGNMENT_ITEM_TYPE;

DROP TABLE IF EXISTS T_ASSIGNMENT_PERFORMANCE;

DROP TABLE IF EXISTS T_EMPLOYEE;

DROP TABLE IF EXISTS T_EMPLOYEE_SALARY_DETAIL;

DROP TABLE IF EXISTS T_EVALUATION_FORM;

DROP TABLE IF EXISTS T_EVALUATION_FORM_ITEMS;

DROP TABLE IF EXISTS T_EVALUATION_ITEM;

DROP TABLE IF EXISTS T_EVALUATION_ITEM_TYPE;

DROP TABLE IF EXISTS T_EVALUATION_RESULTS;

DROP TABLE IF EXISTS T_EVALUATION_STANDARD;

DROP TABLE IF EXISTS T_POSITION;

DROP TABLE IF EXISTS T_POSITION_ASSIGNMENTS;

DROP TABLE IF EXISTS T_POSITION_EVALUATION_FORMS;

DROP TABLE IF EXISTS T_POSITION_SALARY_ITEMS;

DROP TABLE IF EXISTS T_REPOSITORY_ASSIGNMENT;

DROP TABLE IF EXISTS T_REPOSITORY_EVALUATION;

DROP TABLE IF EXISTS T_REPOSITORY_SALARY_STRUCT;

DROP TABLE IF EXISTS T_SALARY_ITEM;

DROP TABLE IF EXISTS T_SALARY_ITEM_TYPE;

DROP TABLE IF EXISTS T_SETTINGS;

/*==============================================================*/
/* Table: T_ASSIGNMENT_ITEM                                     */
/*==============================================================*/
CREATE TABLE T_ASSIGNMENT_ITEM
(
   ID                   VARCHAR(40) NOT NULL,
   NAME                 VARCHAR(100) NOT NULL,
   DESCRIPTION          VARCHAR(2000),
   TYPE                 VARCHAR(40) NOT NULL,
   TARGET               DECIMAL(20,6) NOT NULL,
   UNIT                 VARCHAR(40) NOT NULL,
   ENABLED              BOOL NOT NULL,
   VERSION_ID           VARCHAR(40) NOT NULL,
   PRIMARY KEY (ID)
);

/*==============================================================*/
/* Table: T_ASSIGNMENT_ITEM_TYPE                                */
/*==============================================================*/
CREATE TABLE T_ASSIGNMENT_ITEM_TYPE
(
   ID                   VARCHAR(40) NOT NULL,
   NAME                 VARCHAR(100) NOT NULL,
   DESCRIPTION          VARCHAR(2000),
   ENABLED              BOOL NOT NULL,
   PRIMARY KEY (ID)
);

/*==============================================================*/
/* Table: T_ASSIGNMENT_PERFORMANCE                              */
/*==============================================================*/
CREATE TABLE T_ASSIGNMENT_PERFORMANCE
(
   ID                   VARCHAR(40) NOT NULL,
   EMPLOYEE_ID          VARCHAR(40) NOT NULL,
   ASSIGNMENT_ID        VARCHAR(40) NOT NULL,
   COMPLETED            DECIMAL(20,6) NOT NULL,
   ASSIGNMENT_YEAR      INT NOT NULL,
   ASSIGNMENT_MONTH     INT NOT NULL,
   DESCRIPTION          VARCHAR(2000),
   VERSION_ID           VARCHAR(40) NOT NULL,
   PRIMARY KEY (ID)
);

/*==============================================================*/
/* Table: T_EMPLOYEE                                            */
/*==============================================================*/
CREATE TABLE T_EMPLOYEE
(
   ID                   VARCHAR(40) NOT NULL,
   LEADER_ID            VARCHAR(40),
   POSITION_ID          VARCHAR(40),
   NAME                 VARCHAR(100) NOT NULL,
   DESCRIPTION          VARCHAR(2000),
   ENTRY_TIME           DATE NOT NULL,
   DISMISSION_TIME      DATE,
   ENABLED              BOOL NOT NULL,
   PRIMARY KEY (ID)
);

/*==============================================================*/
/* Table: T_EMPLOYEE_SALARY_DETAIL                              */
/*==============================================================*/
CREATE TABLE T_EMPLOYEE_SALARY_DETAIL
(
   ID                   VARCHAR(40) NOT NULL,
   EMPLOYEE_ID          VARCHAR(40) NOT NULL,
   SALARY_ITEM_ID       VARCHAR(40) NOT NULL,
   SALARY_YEAR          INT NOT NULL,
   SALARY_MONTH         INT NOT NULL,
   AMOUNT               DECIMAL(10,2) NOT NULL,
   VERSION_ID           VARCHAR(40) NOT NULL,
   PRIMARY KEY (ID)
);

/*==============================================================*/
/* Table: T_EVALUATION_FORM                                     */
/*==============================================================*/
CREATE TABLE T_EVALUATION_FORM
(
   ID                   VARCHAR(40) NOT NULL,
   NAME                 VARCHAR(100) NOT NULL,
   DESCRIPTION          VARCHAR(2000) NOT NULL,
   ENABLED              BOOL NOT NULL,
   VERSION_ID           VARCHAR(40) NOT NULL,
   PRIMARY KEY (ID)
);

/*==============================================================*/
/* Table: T_EVALUATION_FORM_ITEMS                               */
/*==============================================================*/
CREATE TABLE T_EVALUATION_FORM_ITEMS
(
   EVALUATION_FORM_ID   VARCHAR(40) NOT NULL,
   EVALUATION_FORM_ITEM_ID VARCHAR(40) NOT NULL,
   VERSION_ID           VARCHAR(40) NOT NULL,
   ENABLED              BOOL NOT NULL,
   PRIMARY KEY (EVALUATION_FORM_ID, EVALUATION_FORM_ITEM_ID)
);

/*==============================================================*/
/* Table: T_EVALUATION_ITEM                                     */
/*==============================================================*/
CREATE TABLE T_EVALUATION_ITEM
(
   ID                   VARCHAR(40) NOT NULL,
   NAME                 VARCHAR(100) NOT NULL,
   DESCRIPTION          VARCHAR(2000),
   TYPE                 VARCHAR(40) NOT NULL,
   FULL_MARK            DECIMAL(10,2) NOT NULL,
   ENABLED              BOOL NOT NULL,
   VERSION_ID           VARCHAR(40) NOT NULL,
   PRIMARY KEY (ID)
);

/*==============================================================*/
/* Table: T_EVALUATION_ITEM_TYPE                                */
/*==============================================================*/
CREATE TABLE T_EVALUATION_ITEM_TYPE
(
   ID                   VARCHAR(40) NOT NULL,
   NAME                 VARCHAR(100) NOT NULL,
   DESCRIPTION          VARCHAR(2000),
   ENABLED              BOOL NOT NULL,
   PRIMARY KEY (ID)
);

/*==============================================================*/
/* Table: T_EVALUATION_RESULTS                                  */
/*==============================================================*/
CREATE TABLE T_EVALUATION_RESULTS
(
   ID                   VARCHAR(40) NOT NULL,
   DESCRIPTION          VARCHAR(2000),
   EMPLOYEE_ID          VARCHAR(40) NOT NULL COMMENT '被考核人',
   EVALUATION_YEAY      INT NOT NULL,
   EVALUATION_MONTH     INT NOT NULL,
   EVALUATOR            VARCHAR(40) NOT NULL,
   EVALUATION_FORM_ID   VARCHAR(40) NOT NULL,
   EVALUATION_ITEM_ID   VARCHAR(40) NOT NULL,
   EVALUATION_TIME      DATE NOT NULL,
   MARK                 DECIMAL(10,2) NOT NULL,
   VERSION_ID           VARCHAR(40) NOT NULL,
   PRIMARY KEY (ID)
);

/*==============================================================*/
/* Table: T_EVALUATION_STANDARD                                 */
/*==============================================================*/
CREATE TABLE T_EVALUATION_STANDARD
(
   ID                   VARCHAR(40) NOT NULL,
   NAME                 VARCHAR(100) NOT NULL,
   DESCRIPTION          VARCHAR(2000),
   ENABLED              BOOL NOT NULL DEFAULT TRUE,
   ITEM_ID              VARCHAR(40) NOT NULL,
   SHOW_ORDER           INT NOT NULL DEFAULT 0,
   VERSION_ID           VARCHAR(40) NOT NULL,
   PRIMARY KEY (ID)
);

/*==============================================================*/
/* Table: T_POSITION                                            */
/*==============================================================*/
CREATE TABLE T_POSITION
(
   ID                   VARCHAR(40) NOT NULL,
   LEADER_ID            VARCHAR(40),
   NAME                 VARCHAR(100) NOT NULL,
   DESCRIPTION          VARCHAR(2000),
   ENABLED              BOOL NOT NULL,
   PRIMARY KEY (ID)
);

/*==============================================================*/
/* Table: T_POSITION_ASSIGNMENTS                                */
/*==============================================================*/
CREATE TABLE T_POSITION_ASSIGNMENTS
(
   ASSIGNMENT_ID        VARCHAR(40) NOT NULL,
   POSITION_ID          VARCHAR(40) NOT NULL,
   ENABLED              BOOL NOT NULL,
   VERSION_ID           VARCHAR(40) NOT NULL,
   PRIMARY KEY (ASSIGNMENT_ID, POSITION_ID)
);

/*==============================================================*/
/* Table: T_POSITION_EVALUATION_FORMS                           */
/*==============================================================*/
CREATE TABLE T_POSITION_EVALUATION_FORMS
(
   POSITION_ID          VARCHAR(40) NOT NULL,
   EVALUATION_FORM_ID   VARCHAR(40) NOT NULL,
   WEIGHT               DECIMAL(10,2) NOT NULL,
   ENABLED              BOOL NOT NULL,
   VERSION_ID           VARCHAR(40) NOT NULL,
   PRIMARY KEY (POSITION_ID, EVALUATION_FORM_ID)
);

/*==============================================================*/
/* Table: T_POSITION_SALARY_ITEMS                               */
/*==============================================================*/
CREATE TABLE T_POSITION_SALARY_ITEMS
(
   POSITION_ID          VARCHAR(40) NOT NULL,
   SALARY_ITEM_ID       VARCHAR(40) NOT NULL,
   VERSION_ID           VARCHAR(40) NOT NULL,
   ENABLED              BOOL NOT NULL,
   PRIMARY KEY (POSITION_ID, SALARY_ITEM_ID)
);

/*==============================================================*/
/* Table: T_REPOSITORY_ASSIGNMENT                               */
/*==============================================================*/
CREATE TABLE T_REPOSITORY_ASSIGNMENT
(
   ID                   VARCHAR(40) NOT NULL,
   NAME                 VARCHAR(100) NOT NULL,
   DESCRIPTION          VARCHAR(2000),
   ENABLED              BOOL NOT NULL,
   CREATE_TIME          DATE NOT NULL,
   CREATOR              VARCHAR(40) NOT NULL,
   PRIMARY KEY (ID)
);

/*==============================================================*/
/* Table: T_REPOSITORY_EVALUATION                               */
/*==============================================================*/
CREATE TABLE T_REPOSITORY_EVALUATION
(
   ID                   VARCHAR(40) NOT NULL,
   NAME                 VARCHAR(100) NOT NULL,
   DESCRIPTION          VARCHAR(2000),
   ENABLED              BOOL NOT NULL,
   CREATE_TIME          DATE NOT NULL,
   CREATOR              VARCHAR(40),
   PRIMARY KEY (ID)
);

/*==============================================================*/
/* Table: T_REPOSITORY_SALARY_STRUCT                            */
/*==============================================================*/
CREATE TABLE T_REPOSITORY_SALARY_STRUCT
(
   ID                   VARCHAR(40) NOT NULL,
   NAME                 VARCHAR(100) NOT NULL,
   DESCRIPTION          VARCHAR(2000),
   ENABLED              BOOL NOT NULL,
   PRIMARY KEY (ID)
);

/*==============================================================*/
/* Table: T_SALARY_ITEM                                         */
/*==============================================================*/
CREATE TABLE T_SALARY_ITEM
(
   ID                   VARCHAR(40) NOT NULL,
   NAME                 VARCHAR(100) NOT NULL,
   DESCRIPTION          VARCHAR(2000),
   TYPE                 VARCHAR(40) NOT NULL,
   VALUE                VARCHAR(2000) NOT NULL,
   ENABLED              BOOL NOT NULL,
   VESION_ID            VARCHAR(40) NOT NULL,
   PRIMARY KEY (ID)
);

/*==============================================================*/
/* Table: T_SALARY_ITEM_TYPE                                    */
/*==============================================================*/
CREATE TABLE T_SALARY_ITEM_TYPE
(
   ID                   VARCHAR(40) NOT NULL,
   NAME                 VARCHAR(100) NOT NULL,
   DESCRIPTION          VARCHAR(2000),
   ENABLED              BOOL NOT NULL,
   PRIMARY KEY (ID)
);

/*==============================================================*/
/* Table: T_SETTINGS                                            */
/*==============================================================*/
CREATE TABLE T_SETTINGS
(
   NAME                 VARCHAR(100) NOT NULL,
   VALUE                VARCHAR(2000) NOT NULL,
   DESCRIPTION          VARCHAR(2000),
   TYPE                 INT NOT NULL,
   PRIMARY KEY (NAME)
);

