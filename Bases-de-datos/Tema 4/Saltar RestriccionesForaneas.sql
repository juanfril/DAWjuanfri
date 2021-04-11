INSERT INTO hospital (Hospital_Cod, Nombre, Direccion) 
VALUE (50, 'La Paz', 'Catalana 2000');
INSERT INTO sala VALUE
(50, 1, 'Recuperacion', 10);
SET foreign_key_checks = 0; 
DELETE FROM sala WHERE hospital_cod = 22 and cdad_camas = 10;
SET foreign_key_checks = 1;