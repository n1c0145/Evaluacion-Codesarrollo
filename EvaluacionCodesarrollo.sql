--Creacíon de la base

CREATE DATABASE EvaluacionCodesarrollo;

USE EvaluacionCodesarrollo;

-- Tabla de garantías
CREATE TABLE TipoGarantias
(
    TipoGarantia INT PRIMARY KEY,
    NombreGarantia VARCHAR(50) NOT NULL
);

-- Tabla crédito
CREATE TABLE Credito
(
    NumeroCredito INT NOT NULL,
    EstatusCredito VARCHAR(20) NOT NULL,
    GarantiaCredito INT NOT NULL,
    Sucursal INT NOT NULL,

    CONSTRAINT PK_Credito 
    PRIMARY KEY (NumeroCredito, Sucursal),

    CONSTRAINT FK_Credito_Garantia
    FOREIGN KEY (GarantiaCredito)
    REFERENCES TipoGarantias(TipoGarantia)
);


-- Tabla Cuota crédito
CREATE TABLE CuotaCredito
(
    NumeroCredito INT NOT NULL,
    NumeroCuota INT NOT NULL,
    FechaVencimiento DATE NOT NULL,
    Capital DECIMAL(10,2) NOT NULL,
    Interes DECIMAL(10,2) NOT NULL,
    Mora DECIMAL(10,2) NOT NULL,
    Pagada BIT NOT NULL,
    Sucursal INT NOT NULL,

    CONSTRAINT PK_CuotaCredito
    PRIMARY KEY (NumeroCredito, NumeroCuota, Sucursal),

    CONSTRAINT FK_Cuota_Credito
    FOREIGN KEY (NumeroCredito, Sucursal)
    REFERENCES Credito(NumeroCredito, Sucursal)
);
-- Insertar datos

INSERT INTO TipoGarantias
(TipoGarantia, NombreGarantia)
VALUES
(1, 'Prendaria'),
(2, 'Quirografaria');


INSERT INTO Credito
(
 NumeroCredito,
 EstatusCredito,
 GarantiaCredito,
 Sucursal
)
VALUES
(1001,'Vigente',1,1),
(1002,'Vigente',1,1),
(1003,'Vigente',2,1),
(1004,'Cancelado',1,2),
(1005,'Vigente',1,2),
(1006,'Vigente',2,2),
(1007,'Vigente',1,3),
(1008,'Cancelado',2,3),
(1009,'Vigente',1,3),
(1010,'Vigente',1,4);

INSERT INTO CuotaCredito
(
 NumeroCredito,
 NumeroCuota,
 FechaVencimiento,
 Capital,
 Interes,
 Mora,
 Pagada,
 Sucursal
)
VALUES

(1001,1,'2026-07-10',500,50,0,0,1),
(1002,1,'2026-05-20',800,80,20,0,1),
(1005,1,'2026-03-15',1200,100,50,0,2),
(1007,1,'2025-12-01',2000,200,100,0,3),
(1009,1,'2025-01-01',3500,300,150,0,3),
(1010,1,'2026-06-01',900,90,0,1,4),
(1003,1,'2026-06-15',700,70,0,0,1),
(1004,1,'2025-10-01',1500,150,50,0,2),
(1001,2,'2026-04-01',600,60,20,0,1),
(1005,2,'2024-10-01',2500,250,100,0,2);

--Consulta

SELECT
    CASE
        WHEN DATEDIFF(DAY, CC.FechaVencimiento, GETDATE()) BETWEEN 1 AND 30 THEN '1 a 30 días'
        WHEN DATEDIFF(DAY, CC.FechaVencimiento, GETDATE()) BETWEEN 31 AND 90 THEN '31 a 90 días'
        WHEN DATEDIFF(DAY, CC.FechaVencimiento, GETDATE()) BETWEEN 91 AND 180 THEN '91 a 180 días'
        WHEN DATEDIFF(DAY, CC.FechaVencimiento, GETDATE()) BETWEEN 181 AND 360 THEN '181 a 360 días'
        ELSE 'Mayor a 360 días'
    END AS BandaVencimiento,

    SUM(CC.Capital) AS CapitalTotal

FROM CuotaCredito CC

INNER JOIN Credito C
    ON CC.NumeroCredito = C.NumeroCredito
    AND CC.Sucursal = C.Sucursal

INNER JOIN TipoGarantias TG
    ON C.GarantiaCredito = TG.TipoGarantia

WHERE 
    CC.Pagada = 0
    AND C.EstatusCredito = 'Vigente'
    AND TG.NombreGarantia = 'Prendaria'

GROUP BY
    CASE
        WHEN DATEDIFF(DAY, CC.FechaVencimiento, GETDATE()) BETWEEN 1 AND 30 THEN '1 a 30 días'
        WHEN DATEDIFF(DAY, CC.FechaVencimiento, GETDATE()) BETWEEN 31 AND 90 THEN '31 a 90 días'
        WHEN DATEDIFF(DAY, CC.FechaVencimiento, GETDATE()) BETWEEN 91 AND 180 THEN '91 a 180 días'
        WHEN DATEDIFF(DAY, CC.FechaVencimiento, GETDATE()) BETWEEN 181 AND 360 THEN '181 a 360 días'
        ELSE 'Mayor a 360 días'
    END;