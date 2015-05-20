CREATE TABLE [dbo].[VEHICULO] (
    [codigo]      VARCHAR (10)   NOT NULL,
    [nombre]      VARCHAR (10)   NULL,
    [descripcion] TEXT           NULL,
    [pvp]         DECIMAL (3, 2) NULL,
    [url_imagen]  VARCHAR (500)  NULL,
    [disponible]  BIT            NULL,
    [puertas] INT NULL, 
    [combustible] BINARY(50) NOT NULL, 
    [ruedas] INT NULL, 
    CONSTRAINT [cp_art_codigo] PRIMARY KEY CLUSTERED ([codigo] ASC),
	CONSTRAINT combustible_vehiculos CHECK (combustible IN('diesel', 'gasolina')) 
);

