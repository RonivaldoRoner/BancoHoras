CREATE TABLE DBHoras
(
	id_DBHoras INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	fk_Funionario INT NOT NULL,
	data DATE NOT NULL,
	inicio TIME NOT NULL,
	termino TIME NOT NULL,
	qt_Horas TIME,
	total_Horas TIME
);