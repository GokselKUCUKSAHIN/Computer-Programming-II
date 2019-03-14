CREATE TABLE [dbo].[Kisiler] (
    [KisiID]  INT           IDENTITY (1, 1) NOT NULL,
    [Adi]     VARCHAR (20)  NOT NULL,
    [Soyadi]  VARCHAR (15)  NOT NULL,
	[Telefon] VARCHAR(20) NULL,
    [SehirID] INT           NOT NULL,
    [Adres]   VARCHAR (250) NULL,
    PRIMARY KEY CLUSTERED ([KisiID] ASC)
);

