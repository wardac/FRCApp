CREATE TABLE [dbo].[GoalTypes] (
	[GoalTypeID] INT IDENTITY (1,1) PRIMARY KEY,
	[GoalType] NVARCHAR(100) NOT NULL
)
GO
CREATE TABLE [dbo].[GoalSubtypes] (
	[GoalSubtypeID] INT IDENTITY(1,1) PRIMARY KEY,
	[GoalTypeID] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[GoalTypes]([GoalTypeID]),
	[GoalSubtype] NVARCHAR(100) NOT NULL
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

CREATE TABLE [dbo].[MaritalStatus] (
	[MaritalStatusID] INT IDENTITY(1,1) PRIMARY KEY,
	[MaritalStatus] NVARCHAR(50) NOT NULL
)

CREATE TABLE [dbo].[Race] (
	[RaceID] INT IDENTITY (1,1) PRIMARY KEY,
	[Race] NVARCHAR(50) NOT NULL
)

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
	[GenderID] INT FOREIGN KEY REFERENCES [dbo].[Gender]([GenderID]),
	[RaceID] INT FOREIGN KEY REFERENCES [dbo].[Race]([RaceID]),
	[MaritalStatusID] INT FOREIGN KEY REFERENCES [dbo].[MaritalStatus]([MaritalStatusID]),
	[Hispanic] BIT NOT NULL,
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

CREATE TABLE [dbo].[HouseHolds] (
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

CREATE TABLE [dbo].[IncomeTypes] (
	[IncomeTypeID] INT IDENTITY(1,1) PRIMARY KEY,
	[IncomeCode] NVARCHAR(20) NOT NULL
)
GO

CREATE TABLE [dbo].[IncomeSubtypes] (
	[IncomeSubTypeID] INT IDENTITY(1,1) PRIMARY KEY,
	[IncomeSubtype] NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE [dbo].[IncomeIntervals] (
	[IncomeIntervalID] INT IDENTITY(1,1) PRIMARY KEY,
	[Interval] NVARCHAR(50) NOT NULl
)
GO

CREATE TABLE [dbo].[IncomeData] (
	[IncomeDataID] ID IDENTITY(1,1) PRIMARY KEY,
	[ClientID] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[Clients]([ClientID]),
	[IncomeTypeID] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[IncomeTypes]([IncomeTypeID]),
	[IncomeSubtypeID] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[IncomeSubtypes]([IncomeSubtypeID]),
	[EmployerName] NVARCHAR(100),
	[IncomeAmount] DECIMAL(10,2),
	[IncomeIntervalID] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[IncomeIntervals]([IncomeIntervalID]),
	[EmploymentStart] DATE NOT NULL,
	[EmploymentEnd] DATE
	[DateRecorded] DATE
)
GO

CREATE TABLE [dbo].[MonthlyExpenseTypes] (
	[MonthlyExpenseTypeID] INT IDENTITY(1,1) PRIMARY KEY,
	[MonthlyExpenseType] NVARCHAR(50)
)
GO

CREATE TABLE [dbo].[MonthlyExpenses] (
	[MonthlyExpenseID] INT IDENTITY(1,1) PRIMARY KEY
	[HouseHoldID] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[HouseHold]([HouseHoldID]),
	[MonthlyExpenseTypeID] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[MonthlyExpenseTypes]([MonthlyExpenseTypeID]),
	[Amount] DECIMAL(10,2) NOT NULL
)
GO

CREATE TABLE [dbo].[TSVoucherTypes] (
	[TSVoucherTypeID] INT IDENTITY(1,1) PRIMARY KEY,
	[VoucherType] NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE [dbo].[TSVouchers] (
	[TSVoucherID] INT IDENTITY(1,1) PRIMARY KEY,
	[ClientID] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[Client]([ClientID]),
	[TSVoucherTypeID] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[TSVoucherTypes]([TSVoucherTypeID])
	[VoucherAmount] DECIMAL(10,2),
	[VoucherIssueDate] DATE NOT NULL,
	[VoucherExpirationDate] DATE,
	[VoucherRedeemedDate] DATE
)
GO

CREATE TABLE [dbo].[RelationshipTypes] (
	[RelationshipTypeID] INT IDENTITY(1,1) PRIMARY KEY,
	[RelationshipName] NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE [dbo].[Relationships] (
	[RelationshipTypeID] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[RelationshipTypes]([RelationshipTypeID]),
	[ClientIDFrom] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[Client]([ClientID]),
	[ClientIDTo] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[Client]([ClientID])
)
GO

CREATE TABLE [dbo].[OWActionCategories] (
	[OWActionCategoryID] INT IDENTITY(1,1) PRIMARY KEY,
	[OWActionCategory] NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE [dbo].[OWBarrierTypes] (
	[OWBarrierTypeID] INT IDENTITY(1,1) PRIMARY KEY,
	[OWBarrierType] NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE [dbo].[OWBarrierSubtypes] (
	[OWBarrierSubtypeID] INT IDENTITY(1,1) PRIMARY KEY,
	[OWBarrierTypeID] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[OWBarrierTypes]([OWBarrierTypeID]),
	[OWBarrierSubtype] NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE [dbo].[OWGoalTypes] (
	[OWGoalTypeID] INT IDENTITY(1,1) PRIMARY KEY,
	[OWGoalType] NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE [dbo].[OWGoalSubtypes] (
	[OWGoalSubtypeID] INT IDENTITY(1,1) PRIMARY KEY,
	[OWGoalTypeID] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[OWGoalTypes]([OWGoalTypeID]),
	[OWGoalType] NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE [dbo].[OWStatuses] (
	[OWStatusID] INT IDENTITY(1,1) PRIMARY KEY,
	[OWStatus] NVARCHAR(100) NOT NULL
)
GO

CREATE TABLE [dbo].[OWClients] (
	[OWID] INT IDENTITY(1,1) PRIMARY KEY,
	[ClientID] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[Clients]([ClientID]),
	[OWStatusID] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[OWStatuses]([OWStatusID])
)
GO

CREATE TABLE [dbo].[OWBarrierTracking] (
	[OWBarrierTrackingID] INT IDENTITY(1,1) PRIMARY KEY,
	[OWID] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[OWClients]([OWID]),
	[DateIdentified] DATE NOT NULL,
	[OWBarrierTypeID] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[OWBarrierTypes]([OWBarrierTypeID]),
	[OWBarrierSubtypeID] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[OWBarrierSubtypes]([OWBarrierSubtypesID]),
	[Comments] NVARCHAR(MAX),
	[BarrierRemoved] BIT NOT NULL,
	[DateBarrierRemoved] DATE
)
GO

CREATE TABLE [dbo].[OWGoalTracking] (
	[OWGoalTrackingID] INT IDENTITY(1,1) PRIMARY KEY,
	[OWID] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[OWClients]([OWID]),
	[DateSet] DATE NOT NULL,
	[OWGoalTypeID] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[OWGoalTypes]([OWGoalTypeID]),
	[OWGoalSubtypeID] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[OWGoalSubtypes]([OWGoalSubtypeID]),
	[Comments] NVARCHAR(MAX),
	[GoalAchieved] BIT NOT NULL,
	[DateGoalAchieved] DATE
)
GO

CREATE TABLE [OWIntake] (
	[OWIntakeID] INT IDENTITY(1,1) PRIMARY KEY,
	[OWID] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[OWClients]([OWID]),
	[DateLastWorked] DATE,
	[DateStartedJobSearch] DATE,
	[MonthsUnemployed] INT,
	[JobsInLast15Years] INT,
	[LongestForOneEmployer] NVARCHAR(100),
	[EverDoubledFPG] BIT NOT NULL,
	[EverReceivedEmpHealthIns] BIT NOT NULL,
	[EverReceivedVacTime] BIT NOT NULL,
	[EverReceivedRetirment] BIT NOT NULL
)
GO