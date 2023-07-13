CREATE TABLE [dbo].[EmployeeDb]
(
	[EmployeeId] INT NOT NULL PRIMARY KEY IDENTITY,
	[Username] TEXT,
	[ProviderName] TEXT,
	[DocumentNumber]TEXT,
	[Data] DATE,
	[CostType]TEXT,
	[Amount]FLOAT,
	[Currency]TEXT, 
    CONSTRAINT [FK_EmployeeDb_ToTable] FOREIGN KEY ([Username]) REFERENCES [UserDb]([Username]),
)
