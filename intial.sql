/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     2016/4/10 20:31:15                           */
/*==============================================================*/


DROP INDEX INDEX_2 ON T_ANNUAL_ASSIGNMENT;

DROP INDEX INDEX_1 ON T_ANNUAL_ASSIGNMENT;

DROP TABLE IF EXISTS T_ANNUAL_ASSIGNMENT;

DROP INDEX INDEX_5 ON T_ASSIGNMENT_DEFINE;

DROP INDEX INDEX_4 ON T_ASSIGNMENT_DEFINE;

DROP INDEX INDEX_3 ON T_ASSIGNMENT_DEFINE;

DROP INDEX INDEX_2 ON T_ASSIGNMENT_DEFINE;

DROP INDEX INDEX_1 ON T_ASSIGNMENT_DEFINE;

DROP TABLE IF EXISTS T_ASSIGNMENT_DEFINE;

DROP INDEX INDEX_1 ON T_ASSIGNMENT_ITEM_TYPE;

DROP TABLE IF EXISTS T_ASSIGNMENT_ITEM_TYPE;

DROP INDEX INDEX_4 ON T_ASSIGNMENT_PERFORMANCE;

DROP INDEX INDEX_2 ON T_ASSIGNMENT_PERFORMANCE;

DROP INDEX INDEX_1 ON T_ASSIGNMENT_PERFORMANCE;

DROP TABLE IF EXISTS T_ASSIGNMENT_PERFORMANCE;

DROP INDEX INDEX_1 ON T_CODE_TABLE;

DROP TABLE IF EXISTS T_CODE_TABLE;

DROP INDEX INDEX_4 ON T_EMPLOYEE;

DROP INDEX INDEX_2 ON T_EMPLOYEE;

DROP INDEX INDEX_3 ON T_EMPLOYEE;

DROP TABLE IF EXISTS T_EMPLOYEE;

DROP INDEX INDEX_4 ON T_EMPLOYEE_SALARY_DETAIL;

DROP INDEX INDEX_3 ON T_EMPLOYEE_SALARY_DETAIL;

DROP INDEX INDEX_2 ON T_EMPLOYEE_SALARY_DETAIL;

DROP INDEX INDEX_1 ON T_EMPLOYEE_SALARY_DETAIL;

DROP TABLE IF EXISTS T_EMPLOYEE_SALARY_DETAIL;

DROP INDEX INDEX_4 ON T_EVALUATION_FORM;

DROP INDEX INDEX_3 ON T_EVALUATION_FORM;

DROP INDEX INDEX_2 ON T_EVALUATION_FORM;

DROP TABLE IF EXISTS T_EVALUATION_FORM;

DROP INDEX INDEX_3 ON T_EVALUATION_FORM_ITEMS;

DROP INDEX INDEX_1 ON T_EVALUATION_FORM_ITEMS;

DROP TABLE IF EXISTS T_EVALUATION_FORM_ITEMS;

DROP INDEX INDEX_4 ON T_EVALUATION_ITEM;

DROP INDEX INDEX_3 ON T_EVALUATION_ITEM;

DROP INDEX INDEX_2 ON T_EVALUATION_ITEM;

DROP INDEX INDEX_1 ON T_EVALUATION_ITEM;

DROP TABLE IF EXISTS T_EVALUATION_ITEM;

DROP INDEX INDEX_1 ON T_EVALUATION_ITEM_TYPE;

DROP TABLE IF EXISTS T_EVALUATION_ITEM_TYPE;

DROP INDEX INDEX_6 ON T_EVALUATION_RESULTS;

DROP INDEX INDEX_5 ON T_EVALUATION_RESULTS;

DROP INDEX INDEX_4 ON T_EVALUATION_RESULTS;

DROP INDEX INDEX_3 ON T_EVALUATION_RESULTS;

DROP INDEX INDEX_2 ON T_EVALUATION_RESULTS;

DROP INDEX INDEX_1 ON T_EVALUATION_RESULTS;

DROP TABLE IF EXISTS T_EVALUATION_RESULTS;

DROP INDEX INDEX_3 ON T_EVALUATION_STANDARD;

DROP INDEX INDEX_2 ON T_EVALUATION_STANDARD;

DROP INDEX INDEX_1 ON T_EVALUATION_STANDARD;

DROP TABLE IF EXISTS T_EVALUATION_STANDARD;

DROP INDEX 上级岗位编号_FK ON T_POSITION;

DROP INDEX 岗位表_PK ON T_POSITION;

DROP TABLE IF EXISTS T_POSITION;

DROP INDEX INDEX_2 ON T_POSITION_ASSIGNMENTS;

DROP INDEX INDEX_1 ON T_POSITION_ASSIGNMENTS;

DROP TABLE IF EXISTS T_POSITION_ASSIGNMENTS;

DROP INDEX INDEX_2 ON T_POSITION_EVALUATION_FORMS;

DROP INDEX INDEX_1 ON T_POSITION_EVALUATION_FORMS;

DROP TABLE IF EXISTS T_POSITION_EVALUATION_FORMS;

DROP INDEX INDEX_2 ON T_POSITION_SALARY_ITEMS;

DROP INDEX INDEX_1 ON T_POSITION_SALARY_ITEMS;

DROP TABLE IF EXISTS T_POSITION_SALARY_ITEMS;

DROP INDEX INDEX_1 ON T_REPOSITORY_ASSIGNMENT;

DROP TABLE IF EXISTS T_REPOSITORY_ASSIGNMENT;

DROP INDEX INDEX_1 ON T_REPOSITORY_EVALUATION;

DROP TABLE IF EXISTS T_REPOSITORY_EVALUATION;

DROP INDEX INDEX_1 ON T_REPOSITORY_SALARY_STRUCT;

DROP TABLE IF EXISTS T_REPOSITORY_SALARY_STRUCT;

DROP INDEX INDEX_1 ON T_SALARY_DATA_SOURCE_TYPE;

DROP TABLE IF EXISTS T_SALARY_DATA_SOURCE_TYPE;

DROP INDEX INDEX_5 ON T_SALARY_ITEM;

DROP INDEX INDEX_4 ON T_SALARY_ITEM;

DROP INDEX INDEX_3 ON T_SALARY_ITEM;

DROP INDEX INDEX_2 ON T_SALARY_ITEM;

DROP INDEX INDEX_1 ON T_SALARY_ITEM;

DROP TABLE IF EXISTS T_SALARY_ITEM;

DROP INDEX INDEX_1 ON T_SALARY_ITEM_TYPE;

DROP TABLE IF EXISTS T_SALARY_ITEM_TYPE;

DROP INDEX INDEX_1 ON T_SETTINGS;

DROP TABLE IF EXISTS T_SETTINGS;

DROP INDEX INDEX_1 ON T_UNIT;

DROP TABLE IF EXISTS T_UNIT;

/*==============================================================*/
/* Table: T_ANNUAL_ASSIGNMENT                                   */
/*==============================================================*/
CREATE TABLE T_ANNUAL_ASSIGNMENT
(
   ID                   VARCHAR(40) NOT NULL,
   ASSIGNMENT_ID        VARCHAR(40) NOT NULL,
   NAME                 VARCHAR(100) NOT NULL,
   DESCRIPTION          VARCHAR(2000),
   ASSIGNMENT_YEAR      INT NOT NULL,
   ASSIGNMENT_MONTH     INT NOT NULL,
   TARGET               DECIMAL(20,6) NOT NULL,
   CREATE_TIME          DATE NOT NULL,
   CREATOR_ID           VARCHAR(40),
   VERSION_ID           VARCHAR(40) NOT NULL,
   EXEC_STATE           INT NOT NULL COMMENT '0 - 未分配
            1 - 已分配
            2 - 已执行
            3 - 执行完成'
);

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
CREATE UNIQUE INDEX INDEX_1 ON T_ANNUAL_ASSIGNMENT
(
   ID
);

/*==============================================================*/
/* Index: INDEX_2                                               */
/*==============================================================*/
CREATE INDEX INDEX_2 ON T_ANNUAL_ASSIGNMENT
(
   ASSIGNMENT_ID
);

/*==============================================================*/
/* Table: T_ASSIGNMENT_DEFINE                                   */
/*==============================================================*/
CREATE TABLE T_ASSIGNMENT_DEFINE
(
   ID                   VARCHAR(40) NOT NULL,
   NAME                 VARCHAR(100) NOT NULL,
   DESCRIPTION          VARCHAR(2000),
   ENABLED              BOOL NOT NULL,
   TYPE                 VARCHAR(40) NOT NULL,
   DEFAULT_VALUE        DECIMAL(20,6) NOT NULL,
   VERSION_ID           VARCHAR(40) NOT NULL,
   UNIT_ID              VARCHAR(40) NOT NULL,
   POSITION_ID          VARCHAR(40) NOT NULL
);

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
CREATE UNIQUE INDEX INDEX_1 ON T_ASSIGNMENT_DEFINE
(
   ID
);

/*==============================================================*/
/* Index: INDEX_2                                               */
/*==============================================================*/
CREATE INDEX INDEX_2 ON T_ASSIGNMENT_DEFINE
(
   TYPE
);

/*==============================================================*/
/* Index: INDEX_3                                               */
/*==============================================================*/
CREATE INDEX INDEX_3 ON T_ASSIGNMENT_DEFINE
(
   UNIT_ID
);

/*==============================================================*/
/* Index: INDEX_4                                               */
/*==============================================================*/
CREATE INDEX INDEX_4 ON T_ASSIGNMENT_DEFINE
(
   VERSION_ID
);

/*==============================================================*/
/* Index: INDEX_5                                               */
/*==============================================================*/
CREATE INDEX INDEX_5 ON T_ASSIGNMENT_DEFINE
(
   POSITION_ID
);

/*==============================================================*/
/* Table: T_ASSIGNMENT_ITEM_TYPE                                */
/*==============================================================*/
CREATE TABLE T_ASSIGNMENT_ITEM_TYPE
(
   ID                   VARCHAR(40) NOT NULL,
   NAME                 VARCHAR(100) NOT NULL,
   DESCRIPTION          VARCHAR(2000),
   ENABLED              BOOL NOT NULL
);

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
CREATE UNIQUE INDEX INDEX_1 ON T_ASSIGNMENT_ITEM_TYPE
(
   ID
);

/*==============================================================*/
/* Table: T_ASSIGNMENT_PERFORMANCE                              */
/*==============================================================*/
CREATE TABLE T_ASSIGNMENT_PERFORMANCE
(
   ID                   VARCHAR(40) NOT NULL,
   EMPLOYEE_ID          VARCHAR(40) NOT NULL,
   COMPLETED            DECIMAL(20,6) NOT NULL,
   TARGET               DECIMAL(20,6),
   ASSIGNMENT_YEAR      INT NOT NULL,
   ASSIGNMENT_MONTH     INT NOT NULL,
   DESCRIPTION          VARCHAR(2000),
   VERSION_ID           VARCHAR(40) NOT NULL
);

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
CREATE UNIQUE INDEX INDEX_1 ON T_ASSIGNMENT_PERFORMANCE
(
   ID
);

/*==============================================================*/
/* Index: INDEX_2                                               */
/*==============================================================*/
CREATE INDEX INDEX_2 ON T_ASSIGNMENT_PERFORMANCE
(
   EMPLOYEE_ID
);

/*==============================================================*/
/* Index: INDEX_4                                               */
/*==============================================================*/
CREATE INDEX INDEX_4 ON T_ASSIGNMENT_PERFORMANCE
(
   VERSION_ID
);

/*==============================================================*/
/* Table: T_CODE_TABLE                                          */
/*==============================================================*/
CREATE TABLE T_CODE_TABLE
(
   ID                   VARCHAR(40) NOT NULL,
   NAME                 VARCHAR(100) NOT NULL,
   DESCRIPTION          VARCHAR(2000),
   ENABLED              BOOL NOT NULL
);

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
CREATE UNIQUE INDEX INDEX_1 ON T_CODE_TABLE
(
   ID
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
   ENABLED              BOOL NOT NULL
);

/*==============================================================*/
/* Index: INDEX_3                                               */
/*==============================================================*/
CREATE UNIQUE INDEX INDEX_3 ON T_EMPLOYEE
(
   ID
);

/*==============================================================*/
/* Index: INDEX_2                                               */
/*==============================================================*/
CREATE INDEX INDEX_2 ON T_EMPLOYEE
(
   POSITION_ID
);

/*==============================================================*/
/* Index: INDEX_4                                               */
/*==============================================================*/
CREATE INDEX INDEX_4 ON T_EMPLOYEE
(
   LEADER_ID
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
   VERSION_ID           VARCHAR(40) NOT NULL
);

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
CREATE UNIQUE INDEX INDEX_1 ON T_EMPLOYEE_SALARY_DETAIL
(
   ID
);

/*==============================================================*/
/* Index: INDEX_2                                               */
/*==============================================================*/
CREATE INDEX INDEX_2 ON T_EMPLOYEE_SALARY_DETAIL
(
   EMPLOYEE_ID
);

/*==============================================================*/
/* Index: INDEX_3                                               */
/*==============================================================*/
CREATE INDEX INDEX_3 ON T_EMPLOYEE_SALARY_DETAIL
(
   SALARY_ITEM_ID
);

/*==============================================================*/
/* Index: INDEX_4                                               */
/*==============================================================*/
CREATE INDEX INDEX_4 ON T_EMPLOYEE_SALARY_DETAIL
(
   VERSION_ID
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
   POSITION_ID          VARCHAR(40) NOT NULL
);

/*==============================================================*/
/* Index: INDEX_2                                               */
/*==============================================================*/
CREATE UNIQUE INDEX INDEX_2 ON T_EVALUATION_FORM
(
   ID
);

/*==============================================================*/
/* Index: INDEX_3                                               */
/*==============================================================*/
CREATE INDEX INDEX_3 ON T_EVALUATION_FORM
(
   VERSION_ID
);

/*==============================================================*/
/* Index: INDEX_4                                               */
/*==============================================================*/
CREATE INDEX INDEX_4 ON T_EVALUATION_FORM
(
   POSITION_ID
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
   SHOW_ORDER           INT NOT NULL
);

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
CREATE UNIQUE INDEX INDEX_1 ON T_EVALUATION_FORM_ITEMS
(
   EVALUATION_FORM_ID,
   EVALUATION_FORM_ITEM_ID
);

/*==============================================================*/
/* Index: INDEX_3                                               */
/*==============================================================*/
CREATE INDEX INDEX_3 ON T_EVALUATION_FORM_ITEMS
(
   VERSION_ID
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
   POSITION_ID          VARCHAR(40) NOT NULL
);

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
CREATE UNIQUE INDEX INDEX_1 ON T_EVALUATION_ITEM
(
   ID
);

/*==============================================================*/
/* Index: INDEX_2                                               */
/*==============================================================*/
CREATE INDEX INDEX_2 ON T_EVALUATION_ITEM
(
   VERSION_ID
);

/*==============================================================*/
/* Index: INDEX_3                                               */
/*==============================================================*/
CREATE INDEX INDEX_3 ON T_EVALUATION_ITEM
(
   TYPE
);

/*==============================================================*/
/* Index: INDEX_4                                               */
/*==============================================================*/
CREATE INDEX INDEX_4 ON T_EVALUATION_ITEM
(
   POSITION_ID
);

/*==============================================================*/
/* Table: T_EVALUATION_ITEM_TYPE                                */
/*==============================================================*/
CREATE TABLE T_EVALUATION_ITEM_TYPE
(
   ID                   VARCHAR(40) NOT NULL,
   NAME                 VARCHAR(100) NOT NULL,
   DESCRIPTION          VARCHAR(2000),
   ENABLED              BOOL NOT NULL
);

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
CREATE UNIQUE INDEX INDEX_1 ON T_EVALUATION_ITEM_TYPE
(
   ID
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
   VERSION_ID           VARCHAR(40) NOT NULL
);

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
CREATE UNIQUE INDEX INDEX_1 ON T_EVALUATION_RESULTS
(
   ID
);

/*==============================================================*/
/* Index: INDEX_2                                               */
/*==============================================================*/
CREATE INDEX INDEX_2 ON T_EVALUATION_RESULTS
(
   EMPLOYEE_ID
);

/*==============================================================*/
/* Index: INDEX_3                                               */
/*==============================================================*/
CREATE INDEX INDEX_3 ON T_EVALUATION_RESULTS
(
   EVALUATOR
);

/*==============================================================*/
/* Index: INDEX_4                                               */
/*==============================================================*/
CREATE INDEX INDEX_4 ON T_EVALUATION_RESULTS
(
   EVALUATION_FORM_ID
);

/*==============================================================*/
/* Index: INDEX_5                                               */
/*==============================================================*/
CREATE INDEX INDEX_5 ON T_EVALUATION_RESULTS
(
   EVALUATION_ITEM_ID
);

/*==============================================================*/
/* Index: INDEX_6                                               */
/*==============================================================*/
CREATE INDEX INDEX_6 ON T_EVALUATION_RESULTS
(
   VERSION_ID
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
   VERSION_ID           VARCHAR(40) NOT NULL
);

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
CREATE UNIQUE INDEX INDEX_1 ON T_EVALUATION_STANDARD
(
   ID
);

/*==============================================================*/
/* Index: INDEX_2                                               */
/*==============================================================*/
CREATE INDEX INDEX_2 ON T_EVALUATION_STANDARD
(
   ITEM_ID
);

/*==============================================================*/
/* Index: INDEX_3                                               */
/*==============================================================*/
CREATE INDEX INDEX_3 ON T_EVALUATION_STANDARD
(
   VERSION_ID
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
   ENABLED              BOOL NOT NULL
);

/*==============================================================*/
/* Index: 岗位表_PK                                                */
/*==============================================================*/
CREATE UNIQUE INDEX 岗位表_PK ON T_POSITION
(
   ID
);

/*==============================================================*/
/* Index: 上级岗位编号_FK                                             */
/*==============================================================*/
CREATE INDEX 上级岗位编号_FK ON T_POSITION
(
   LEADER_ID
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
   WEIGHT               DECIMAL(10,2) NOT NULL
);

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
CREATE UNIQUE INDEX INDEX_1 ON T_POSITION_ASSIGNMENTS
(
   ASSIGNMENT_ID,
   POSITION_ID
);

/*==============================================================*/
/* Index: INDEX_2                                               */
/*==============================================================*/
CREATE INDEX INDEX_2 ON T_POSITION_ASSIGNMENTS
(
   VERSION_ID
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
   VERSION_ID           VARCHAR(40) NOT NULL
);

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
CREATE UNIQUE INDEX INDEX_1 ON T_POSITION_EVALUATION_FORMS
(
   POSITION_ID,
   EVALUATION_FORM_ID
);

/*==============================================================*/
/* Index: INDEX_2                                               */
/*==============================================================*/
CREATE UNIQUE INDEX INDEX_2 ON T_POSITION_EVALUATION_FORMS
(
   VERSION_ID
);

/*==============================================================*/
/* Table: T_POSITION_SALARY_ITEMS                               */
/*==============================================================*/
CREATE TABLE T_POSITION_SALARY_ITEMS
(
   POSITION_ID          VARCHAR(40) NOT NULL,
   SALARY_ITEM_ID       VARCHAR(40) NOT NULL,
   VERSION_ID           VARCHAR(40) NOT NULL,
   ENABLED              BOOL NOT NULL
);

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
CREATE UNIQUE INDEX INDEX_1 ON T_POSITION_SALARY_ITEMS
(
   POSITION_ID,
   SALARY_ITEM_ID
);

/*==============================================================*/
/* Index: INDEX_2                                               */
/*==============================================================*/
CREATE INDEX INDEX_2 ON T_POSITION_SALARY_ITEMS
(
   VERSION_ID
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
   CREATOR              VARCHAR(40) NOT NULL
);

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
CREATE UNIQUE INDEX INDEX_1 ON T_REPOSITORY_ASSIGNMENT
(
   ID
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
   CREATOR              VARCHAR(40) NOT NULL
);

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
CREATE UNIQUE INDEX INDEX_1 ON T_REPOSITORY_EVALUATION
(
   ID
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
   CREATE_TIME          DATE NOT NULL,
   CREATOR              VARCHAR(40) NOT NULL
);

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
CREATE UNIQUE INDEX INDEX_1 ON T_REPOSITORY_SALARY_STRUCT
(
   ID
);

/*==============================================================*/
/* Table: T_SALARY_DATA_SOURCE_TYPE                             */
/*==============================================================*/
CREATE TABLE T_SALARY_DATA_SOURCE_TYPE
(
   ID                   VARCHAR(40) NOT NULL,
   NAME                 VARCHAR(100) NOT NULL,
   DESCRIPTION          VARCHAR(2000),
   ENABLED              BOOL NOT NULL
);

ALTER TABLE T_SALARY_DATA_SOURCE_TYPE COMMENT '1 行间，取VALUE字段值
2 字段，取某字段
3 公式，使用VALUE字段值作为公式计算';

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
CREATE UNIQUE INDEX INDEX_1 ON T_SALARY_DATA_SOURCE_TYPE
(
   ID
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
   VERSION_ID           VARCHAR(40) NOT NULL,
   POSITION_ID          VARCHAR(40) NOT NULL,
   DATA_SOURCE_TYPE     VARCHAR(40) NOT NULL
);

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
CREATE UNIQUE INDEX INDEX_1 ON T_SALARY_ITEM
(
   ID
);

/*==============================================================*/
/* Index: INDEX_2                                               */
/*==============================================================*/
CREATE UNIQUE INDEX INDEX_2 ON T_SALARY_ITEM
(
   TYPE
);

/*==============================================================*/
/* Index: INDEX_3                                               */
/*==============================================================*/
CREATE INDEX INDEX_3 ON T_SALARY_ITEM
(
   VERSION_ID
);

/*==============================================================*/
/* Index: INDEX_4                                               */
/*==============================================================*/
CREATE INDEX INDEX_4 ON T_SALARY_ITEM
(
   POSITION_ID
);

/*==============================================================*/
/* Index: INDEX_5                                               */
/*==============================================================*/
CREATE INDEX INDEX_5 ON T_SALARY_ITEM
(
   DATA_SOURCE_TYPE
);

/*==============================================================*/
/* Table: T_SALARY_ITEM_TYPE                                    */
/*==============================================================*/
CREATE TABLE T_SALARY_ITEM_TYPE
(
   ID                   VARCHAR(40) NOT NULL,
   NAME                 VARCHAR(100) NOT NULL,
   DESCRIPTION          VARCHAR(2000),
   ENABLED              BOOL NOT NULL
);

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
CREATE UNIQUE INDEX INDEX_1 ON T_SALARY_ITEM_TYPE
(
   ID
);

/*==============================================================*/
/* Table: T_SETTINGS                                            */
/*==============================================================*/
CREATE TABLE T_SETTINGS
(
   NAME                 VARCHAR(100) NOT NULL,
   VALUE                VARCHAR(2000) NOT NULL,
   DESCRIPTION          VARCHAR(2000),
   TYPE                 INT NOT NULL
);

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
CREATE UNIQUE INDEX INDEX_1 ON T_SETTINGS
(
   NAME
);

/*==============================================================*/
/* Table: T_UNIT                                                */
/*==============================================================*/
CREATE TABLE T_UNIT
(
   ID                   VARCHAR(40) NOT NULL,
   NAME                 VARCHAR(100) NOT NULL,
   ENABLED              BOOL NOT NULL
);

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
CREATE UNIQUE INDEX INDEX_1 ON T_UNIT
(
   ID
);

