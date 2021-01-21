INSERT INTO hospital VALUE
(13, 'Provincial', 'O Donell 50', '964-4264', 0),
(18, 'General', 'Atocha s/n', '595-3111', 0),
(22, 'La Paz', 'Castellana 1000', '923-5411', 0),
(45, 'San Carlos', 'Ciudad Universitaria', '597-1500', 0);

INSERT INTO sala VALUE
(13, 3, 'Curas Intensivas', 21),
(13, 6, 'Psiquiatrico', 67),
(18, 3, 'Curas Intensivas', 10),
(18, 4, 'Cardiologia', 53),
(22, 1, 'Recuperación', 10),
(22, 6, 'Psiquiatrico', 118),
(22, 2, 'Maternidad', 34),
(45, 4, 'Cardiologia', 55),
(45, 1, 'Recuperación', 13),
(45, 2, 'Maternidad', 24);

INSERT INTO plantilla VALUE
(13, 6, 3754, 'Díaz B.', 'Enfermera', 'T', 2262000),
(13, 6, 3106, 'Hernández J.', 'Enfermero', 'T', 2755000),
(18, 4, 6357, 'Karplus W.', 'Interno', 'T', 3379000),
(22, 6, 1009, 'Higueras D.', 'Enfermera', 'T', 2005000),
(22, 6, 8422, 'Bocina G.', 'Enfermero', 'M', 1638000),
(22, 2, 9901, 'Adams C.', 'Interno', 'M', 2210000),
(22, 1, 6065, 'Rivera G.', 'Enfermera', 'N', 1626000),
(22, 1, 7379, 'Carlos R.', 'Enfermera', 'T', 2119000),
(45, 4, 1280, 'Amigó R.', 'Interno', 'N', 2210000),
(45, 1, 8526, 'Frank H.', 'Enfermera', 'T', 2522000);

INSERT INTO enfermo VALUE
(10995, 'Laguía M.', 'Goya 20', '1956-05-16', 'H', 280862482),
(18004, 'Serrano V.', 'Alcala 12', '1960-05-21', 'M', 284991452),
(14024, 'Fernández M.', 'Recoletos 50', '1967-06-23', 'M', 321790059),
(36658, 'Domin S.', 'Mayor 71', '1942-01-01', 'H', 160657471),
(38702, 'Neal R.', 'Orense 11', '1940-06-18', 'M', 380010217),
(39217, 'Cervantes M.', 'Peron 38', '1952-02-29', 'H', 440294390),
(59076, 'Miller G.', 'Lopez de Hoyos 2', '1945-09-16', 'M', 311969044),
(63827, 'Ruíz P.', 'Esquerdo 103', '1980-12-26', 'H', 100973253),
(64823, 'Fraser A.', 'Soto 3', '1980-07-10', 'M', 285201776),
(74835, 'Benítez E.', 'Argentina 5', '1957-10-05', 'H', 154811767);

INSERT INTO ingresos VALUE
(10995, 13, 3, 1),
(18004, 13, 3, 2),
(14024, 13 ,3, 3),
(36658, 18, 4, 1),
(38702, 18, 4, 2),
(39217, 22, 6, 1),
(59076, 22, 6, 2),
(63827, 22, 6, 3),
(64823, 22, 2, 1);

INSERT INTO doctor VALUE
(13, 435, 'López A.', 'Cardiologia'),
(18, 585, 'Miller G.', 'Ginecologia'),
(18, 982, 'Cajal R.', 'Cardiologia'),
(22, 453, 'Galo D.', 'Pediatria'),
(22, 398, 'Best K.', 'Urologia'),
(22, 386, 'Cabeza D.', 'Psiquiatria'),
(45, 607, 'Nico P.', 'Pediatria'),
(45, 522, 'Adams C.', 'Neurologia');


