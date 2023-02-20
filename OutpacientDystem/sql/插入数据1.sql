Use OpsDemo;
INSERT tb_Patient(PatientNo,PatientCode)
VALUES
('3210707024',HASHBYTES('MD5','7024')),
('3210707001',HASHBYTES('MD5','7001'));
SELECT * FROM tb_Patient