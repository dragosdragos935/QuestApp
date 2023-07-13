CREATE TABLE [dbo].[EmployeeDb] (
    [EmployeeId]     INT          IDENTITY (1, 1) NOT NULL,
    [ProviderName]   VARCHAR (50) NOT NULL,
    [DocumentNumber] VARCHAR (50) NOT NULL,
    [Data]           VARCHAR (50) NOT NULL,
    [CostType]       VARCHAR (50) NOT NULL,
    [Amount]         VARCHAR (50) NOT NULL,
    [Currency]       TEXT         NOT NULL,
	[CurrencyRon]	VARCHAR(50) NOT NULL DEFAULT 0,
	[DateCurrency]	VARCHAR(50) NOT NULL DEFAULT 0,
    PRIMARY KEY CLUSTERED ([EmployeeId] ASC)
);

