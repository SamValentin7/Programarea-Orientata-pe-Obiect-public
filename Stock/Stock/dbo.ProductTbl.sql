CREATE TABLE [dbo].[ProductTbl] (
    [Code]     INT          IDENTITY (1, 1) NOT NULL,
    [Name]     VARCHAR (50) NOT NULL,
    [Category] INT          NOT NULL,
    [Quantity]   INT          NOT NULL,
    [BPrice]   INT          NOT NULL,
    [SPrice]   INT          NOT NULL,
    [PrData]   DATE         NOT NULL,
    [ExpData]  DATE         NOT NULL,
    [Supp]     INT          NOT NULL,
    [Gain]     INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Code] ASC)
);

