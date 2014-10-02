CREATE TABLE [dbo].[Barriers] (
	[BarrierID] INT IDENTITY (1,1) PRIMARY KEY,
	[BarrierType] NVARCHAR(100) NOT NULL
)
GO
CREATE TABLE [dbo].[BarrierSubtypes] (
	[BarrierSubtypeID] INT IDENTITY(1,1) PRIMARY KEY,
	[BarrierSubtype] NVARCHAR(100) NOT NULL
)
GO

CREATE TABLE [dbo].[BarriersToSubtypes] (
	[BarrierID] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[Barriers]([BarrierID]),
	[BarrierSubtypeID] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[BarrierSubtypes]([BarrierSubtypeID]),
	PRIMARY KEY ([BarrierID],[BarrierSubtypeID])
)
GO

CREATE TABLE [dbo].[Genders] (
	[GenderID] INT IDENTITY (1,1) PRIMARY KEY,
	[Gender] NVARCHAR(50)
)
GO

CREATE TABLE [dbo].[NameSuffixes] (
	[NameSuffixID] INT IDENTITY(1,1) PRIMARY KEY,
	[Suffix] NVARCHAR(10) NOT NULL
)
GO

CREATE TABLE [dbo].[Salutations] (
	[SalutationID] INT IDENTITY(1,1) PRIMARY KEY,
	[Salutation] NVARCHAR(20) NOT NULL
)
GO

CREATE TABLE [dbo].[Clients] (
	[ClientID] INT IDENTITY(1,1) PRIMARY KEY,
	[SalutationID] INT FOREIGN KEY REFERENCES [dbo].[Salutations]([SalutationID]),
	[SuffixID] INT FOREIGN KEY REFERENCES [dbo].[NameSuffixes]([NameSuffixID]),
	[FirstName] NVARCHAR(20) NOT NULL,
	[LastName] NVARCHAR(20) NOT NULL,
	[MiddleName] NVARCHAR(100),
	[PreferredName] NVARCHAR(20),
	[DOB] DATE,
	[SSN] NVARCHAR(10),
	[Disability] BIT,
	[Veteran] BIT,
	[InitialServiceDate] DATE NOT NULL
)
GO

CREATE TABLE [dbo].[EmailAddresses] (
	[ClientID] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[Clients]([ClientID]),
	[EmailAddress] NVARCHAR(100) NOT NULL,
	[Preferred] BIT NOT NULL,
	PRIMARY KEY ([ClientID],[EmailAddress])
)
GO

CREATE TABLE [dbo].[PhoneTypes] (
	[PhoneTypeID] INT IDENTITY(1,1) PRIMARY KEY,
	[PhoneType] NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE [dbo].[PhoneNumbers] (
	[ClientID] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[Clients]([ClientID]),
	[PhoneNumber] NVARCHAR(15) NOT NULL,
	[PhoneTypeID] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[PhoneTypes](PhoneTypeID)
	PRIMARY KEY ([ClientID],[PhoneNumber])
)
GO

CREATE TABLE [dbo].[SelfSufficiencyScores] (
	[SelfSufficiencyScoreID] INT IDENTITY(1,1) PRIMARY KEY,
	[ClientID] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[Clients]([ClientID]),
	[DateReported] DATE NOT NULL,
	[Housing] DECIMAL(10,2) NOT NULL,
	[Utilities] DECIMAL(10,2) NOT NULL,
	[Food] DECIMAL(10,2) NOT NULL,
	[Income] DECIMAL(10,2) NOT NULL,
	[Employment] DECIMAL(10,2) NOT NULL,
	[Education] DECIMAL(10,2) NOT NULL,
	[HealthCare] DECIMAL(10,2) NOT NULL,
	[Transportation] DECIMAL(10,2) NOT NULL,
	[Total] DECIMAL(10,2) NOT NULL,
	[Average] DECIMAL(10,2) NOT NULL
)
GO

CREATE TABLE [dbo].[BenefitBankServicesAppointments] (
	[AppointmentID] INT IDENTITY(1,1) PRIMARY KEY,
	[ClientID] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[Clients]([ClientID]),
	[Category] NVARCHAR(100) NOT NULL,
	[AppointmentDate] DATETIME NOT NULL
)
GO

CREATE TABLE [dbo].[Benefits] (
	[BenefitID] INT IDENTITY(1,1) PRIMARY KEY,
	[BenefitType] NVARCHAR(100) NOT NULL
)
GO

CREATE TABLE [dbo].[ClientBenefits] (
	[ClientBenefitID] INT IDENTITY(1,1) PRIMARY KEY,
	[ClientID] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[Clients]([ClientID]),
	[DateReported] DATE NOT NULL,
	[BenefitID] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[Benefits]([BenefitID]),
	[BenefitTerminated] BIT NOT NULL,
	[DateTerminated] DATE
)
GO

CREATE TABLE [dbo].[CaseNotes] (
	[CaseNoteID] INT IDENTITY(1,1) PRIMARY KEY,
	[ClientID] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[Clients]([ClientID]),
	[TimeStamp] DATETIME NOT NULL,
	[Notes] NVARCHAR(MAX) NOT NULL
)
GO

CREATE TABLE [dbo].[Cities] (
	[CityID] INT IDENTITY(1,1) PRIMARY KEY,
	[CityName] NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE [dbo].[States] (
	[StateID] INT IDENTITY(1,1) PRIMARY KEY,
	[StateName] NVARCHAR(20) NOT NULL,
	[Abbreviation] NVARCHAR(5) NOT NULL
)
GO

CREATE TABLE [dbo].[ZipCodes] (
	[ZipCodeID] INT IDENTITY(1,1) PRIMARY KEY,
	[ZipCode] NVARCHAR(10) NOT NULL
)
GO

CREATE TABLE [dbo].[ResidencyCodes] (
	[ResidencyCodeID] INT IDENTITY(1,1) PRIMARY KEY,
	[ResidencyCode] NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE [dbo].[HouseHold] (
	[HouseHoldID] INT IDENTITY(1,1) PRIMARY KEY,
	[StreetName] NVARCHAR(50) NOT NULL,
	[StreetNumber] NVARCHAR(10) NOT NULL,
	[Apt Lot Unit] NVARCHAR(10),
	[CityID] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[Cities]([CityID]),
	[StateID] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[States]([StateID]),
	[ZipCodeID] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[ZipCodes]([ZipCodeID]),
	[ResidencyCodeID] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[ResidencyCodes]([ResidencyCodeID])
)
GO
