IF DB_ID('OpsDemo') IS NOT NULL
   DROP DATABASE OpsDemo;
    CREATE DATABASE OpsDemo
      ON
        (NAME='DataFile_1'
          ,FILENAME='D:\医学数据库\DataFile_1.mdf')
      LOG ON
     (NAME='LogFile_1'
     ,FILENAME='D:\医学数据库\LogFile_1.ldf');
USE OpsDemo;
IF OBJECT_ID('tb_Patient')IS NOT NULL
DROP TABLE tb_Patient;

GO 
CREATE TABLE tb_Patient
(PatientNo
	CHAR(10)
	NOT NULL
	CONSTRAINT pk_Patient_UserNo
		PRIMARY KEY(PatientNo)
	CONSTRAINT PatientNo
		CHECK(PatientNo LIKE'[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
,PatientCode
	VARBINARY(128)
	NOT NULL);
