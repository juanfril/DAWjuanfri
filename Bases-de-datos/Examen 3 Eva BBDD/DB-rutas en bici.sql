CREATE TABLE RUTAS (
    ruta varchar2(100),
    provincia varchar2(100),
    km decimal(6,2) default 0,
    CONSTRAINT PK_rutas PRIMARY KEY(ruta)
);

CREATE TABLE TSEGMENTO (
    ruta varchar2(100),
    nombre varchar2(100),
    unidad varchar2(10),
    distancia decimal(6,2),
    CONSTRAINT PK_segment PRIMARY KEY(ruta, nombre),
    CONSTRAINT FK_segment_rutas FOREIGN KEY(ruta) REFERENCES RUTAS(ruta)
);
    
CREATE TABLE ciclista (
    cod integer,
    nombre varchar2(100),
    codigoPostal varchar2(10),
    CONSTRAINT PK_ciclista PRIMARY KEY(cod)
);

CREATE TABLE tiempo (
    ruta varchar2(100),
    tsegmento varchar2(100),
    ciclista integer,
    tfecha date,
    tsegundos decimal(10,0),
    CONSTRAINT PK_tiempo PRIMARY KEY(ruta, tsegmento, ciclista, tfecha),
    CONSTRAINT FK_tiempo_rutas FOREIGN KEY(ruta) REFERENCES RUTAS(ruta),
    CONSTRAINT FK_tiempo_segment FOREIGN KEY(ruta, tsegmento) REFERENCES tsegmento(ruta, nombre),
    CONSTRAINT FK_tiempo_ciclista FOREIGN KEY(ciclista) REFERENCES ciclista(cod)
);


CREATE SEQUENCE seq_ciclista
    MINVALUE 0
    START WITH 0
    INCREMENT BY 1
    CACHE 20;
    

INSERT INTO RUTAS (ruta, provincia) VALUES ('BTT San Vicente', 'Alicante');
INSERT INTO RUTAS (ruta, provincia) VALUES ('BTT Finestrat', 'Alicante');
INSERT INTO RUTAS (ruta, provincia) VALUES ('BTT Onil', 'Alicante');
INSERT INTO RUTAS (ruta, provincia) VALUES ('BTT Yecla', 'Murcia');
INSERT INTO RUTAS (ruta, provincia) VALUES ('BTT Pinos', 'Alicante');
INSERT INTO RUTAS (ruta, provincia) VALUES ('Vuelta a Murcia', 'Murcia');
INSERT INTO RUTAS (ruta, provincia) VALUES ('Tour Madrileño', 'Madrid');
INSERT INTO RUTAS (ruta, provincia) VALUES ('BTT Gandia', 'Valencia');

INSERT INTO ciclista (cod, nombre, codigoPostal) VALUES (seq_ciclista.NEXTVAL, 'Txus', '03003');
INSERT INTO ciclista (cod, nombre, codigoPostal) VALUES (seq_ciclista.NEXTVAL, 'Jman', '03004');
INSERT INTO ciclista (cod, nombre, codigoPostal) VALUES (seq_ciclista.NEXTVAL, 'Manolo', '03005');
INSERT INTO ciclista (cod, nombre, codigoPostal) VALUES (seq_ciclista.NEXTVAL, '�?lvaro', '03004');


INSERT INTO TSEGMENTO (ruta, nombre, unidad,distancia) VALUES ('BTT San Vicente', 'Cocons','m',1500);
INSERT INTO TSEGMENTO (ruta, nombre, unidad,distancia) VALUES ('BTT San Vicente', 'Coche quemado','m', 865);
INSERT INTO TSEGMENTO (ruta, nombre, unidad,distancia) VALUES ('BTT San Vicente', 'Piter Pan','km', 1);
INSERT INTO TSEGMENTO (ruta, nombre, unidad,distancia) VALUES ('BTT San Vicente', 'Sabineta', 'm',1550);
INSERT INTO TSEGMENTO (ruta, nombre, unidad,distancia) VALUES ('BTT Finestrat', 'Senda Fox','km', 8);
INSERT INTO TSEGMENTO (ruta, nombre, unidad,distancia) VALUES ('BTT Finestrat', 'Super Enduro','m', 1500);
INSERT INTO TSEGMENTO (ruta, nombre, unidad,distancia) VALUES ('BTT Gandia', 'Senda Churrasca', 'm',3022);
INSERT INTO TSEGMENTO (ruta, nombre, unidad,distancia) VALUES ('BTT Gandia', 'Rompe frenos','km', 2);
-- INSERT INTO TSEGMENTO (ruta, nombre, unidad,distancia) VALUES ('BTT Gandia', 'Niños volando','m', -600);
INSERT INTO TSEGMENTO (ruta, nombre, unidad,distancia) VALUES ('BTT Gandia', 'Amigos de ET','km', 2);
INSERT INTO TSEGMENTO (ruta, nombre, unidad,distancia) VALUES ('BTT Onil', 'Biscoy', 'm',3022);
INSERT INTO tsegmento (ruta, nombre, unidad,distancia) VALUES ('BTT Onil', 'Barranc Molins','km', 6);
INSERT INTO tsegmento (ruta, nombre, unidad,distancia) VALUES ('BTT Onil', 'Pedragosa','km', 2);
INSERT INTO tsegmento (ruta, nombre, unidad,distancia) VALUES ('BTT Onil', 'Canalis','km', 4);
INSERT INTO tsegmento (ruta, nombre, unidad,distancia) VALUES ('BTT Onil', 'Barranco del Lobo','m', 1400);



INSERT INTO tiempo (ruta, tsegmento, ciclista, tfecha, tsegundos) 
VALUES ('BTT San Vicente', 'Cocons', 1, TO_DATE('13/01/2017', 'dd/mm/yyyy'), 8000);
INSERT INTO tiempo (ruta, tsegmento, ciclista, tfecha, tsegundos) 
VALUES ('BTT San Vicente', 'Coche quemado', 1, TO_DATE('12/01/2017', 'dd/mm/yyyy'), 7500);
INSERT INTO tiempo (ruta, tsegmento, ciclista, tfecha, tsegundos) 
VALUES ('BTT Finestrat', 'Senda Fox', 1, TO_DATE('18/01/2017', 'dd/mm/yyyy'), 3000);
INSERT INTO tiempo (ruta, tsegmento, ciclista, tfecha, tsegundos) 
VALUES ('BTT Finestrat', 'Senda Fox', 2, TO_DATE('08/02/2017', 'dd/mm/yyyy'), 6000);
INSERT INTO tiempo (ruta, tsegmento, ciclista, tfecha, tsegundos) 
VALUES ('BTT San Vicente', 'Piter Pan', 2, TO_DATE('08/01/2017', 'dd/mm/yyyy'), 4000);
INSERT INTO tiempo (ruta, tsegmento, ciclista, tfecha, tsegundos) 
VALUES ('BTT San Vicente', 'Cocons', 3, TO_DATE('08/03/2017', 'dd/mm/yyyy'), 10000);
INSERT INTO tiempo (ruta, tsegmento, ciclista, tfecha, tsegundos) 
VALUES ('BTT San Vicente', 'Coche quemado', 3, TO_DATE('08/01/2017', 'dd/mm/yyyy'), 1500);
INSERT INTO tiempo (ruta, tsegmento, ciclista, tfecha, tsegundos) 
VALUES ('BTT San Vicente', 'Piter Pan', 3, TO_DATE('18/01/2017', 'dd/mm/yyyy'), 1000);
INSERT INTO tiempo (ruta, tsegmento, ciclista, tfecha, tsegundos) 
VALUES ('BTT Onil', 'Biscoy', 1, TO_DATE('08/03/2017', 'dd/mm/yyyy'), 10890);
INSERT INTO tiempo (ruta, tsegmento, ciclista, tfecha, tsegundos) 
VALUES ('BTT Onil', 'Biscoy', 1, TO_DATE('08/01/2017', 'dd/mm/yyyy'), 15423);

