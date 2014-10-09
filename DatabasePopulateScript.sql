CREATE TABLE [GoalTypes] (
	[GoalTypeID] INT IDENTITY (1,1) PRIMARY KEY,
	[GoalType] NVARCHAR(100) NOT NULL
)
GO
CREATE TABLE [GoalSubtypes] (
	[GoalSubtypeID] INT IDENTITY(1,1) PRIMARY KEY,
	[GoalTypeID] INT NOT NULL FOREIGN KEY REFERENCES [GoalTypes]([GoalTypeID]),
	[GoalSubtype] NVARCHAR(100) NOT NULL
)
GO

CREATE TABLE [Genders] (
	[GenderID] INT IDENTITY (1,1) PRIMARY KEY,
	[Gender] NVARCHAR(50)
)
GO

CREATE TABLE [NameSuffixes] (
	[NameSuffixID] INT IDENTITY(1,1) PRIMARY KEY,
	[Suffix] NVARCHAR(10) NOT NULL
)
GO

CREATE TABLE [Salutations] (
	[SalutationID] INT IDENTITY(1,1) PRIMARY KEY,
	[Salutation] NVARCHAR(20) NOT NULL
)
GO

CREATE TABLE [MaritalStatuses] (
	[MaritalStatusID] INT IDENTITY(1,1) PRIMARY KEY,
	[MaritalStatus] NVARCHAR(50) NOT NULL
)

CREATE TABLE [Races] (
	[RaceID] INT IDENTITY (1,1) PRIMARY KEY,
	[Race] NVARCHAR(50) NOT NULL
)

CREATE TABLE [Clients] (
	[ClientID] INT IDENTITY(1,1) PRIMARY KEY,
	[SalutationID] INT FOREIGN KEY REFERENCES [Salutations]([SalutationID]),
	[SuffixID] INT FOREIGN KEY REFERENCES [NameSuffixes]([NameSuffixID]),
	[FirstName] NVARCHAR(20) NOT NULL,
	[LastName] NVARCHAR(20) NOT NULL,
	[MiddleName] NVARCHAR(100),
	[PreferredName] NVARCHAR(20),
	[DOB] DATE,
	[SSN] NVARCHAR(10),
	[GenderID] INT FOREIGN KEY REFERENCES [Genders]([GenderID]),
	[RaceID] INT FOREIGN KEY REFERENCES [Races]([RaceID]),
	[MaritalStatusID] INT FOREIGN KEY REFERENCES [MaritalStatuses]([MaritalStatusID]),
	[Hispanic] BIT NOT NULL,
	[Disability] BIT,
	[Veteran] BIT,
	[InitialServiceDate] DATE NOT NULL
)
GO

CREATE TABLE [EmailAddresses] (
	[ClientID] INT NOT NULL FOREIGN KEY REFERENCES [Clients]([ClientID]),
	[EmailAddress] NVARCHAR(100) NOT NULL,
	[Preferred] BIT NOT NULL,
	PRIMARY KEY ([ClientID],[EmailAddress])
)
GO

CREATE TABLE [PhoneTypes] (
	[PhoneTypeID] INT IDENTITY(1,1) PRIMARY KEY,
	[PhoneType] NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE [PhoneNumbers] (
	[ClientID] INT NOT NULL FOREIGN KEY REFERENCES [Clients]([ClientID]),
	[PhoneNumber] NVARCHAR(15) NOT NULL,
	[PhoneTypeID] INT NOT NULL FOREIGN KEY REFERENCES [PhoneTypes](PhoneTypeID)
	PRIMARY KEY ([ClientID],[PhoneNumber])
)
GO

CREATE TABLE [SelfSufficiencyScores] (
	[SelfSufficiencyScoreID] INT IDENTITY(1,1) PRIMARY KEY,
	[ClientID] INT NOT NULL FOREIGN KEY REFERENCES [Clients]([ClientID]),
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

CREATE TABLE [BenefitBankServicesAppointments] (
	[AppointmentID] INT IDENTITY(1,1) PRIMARY KEY,
	[ClientID] INT NOT NULL FOREIGN KEY REFERENCES [Clients]([ClientID]),
	[Category] NVARCHAR(100) NOT NULL,
	[AppointmentDate] DATETIME NOT NULL
)
GO

CREATE TABLE [Benefits] (
	[BenefitID] INT IDENTITY(1,1) PRIMARY KEY,
	[BenefitType] NVARCHAR(100) NOT NULL
)
GO

CREATE TABLE [ClientBenefits] (
	[ClientBenefitID] INT IDENTITY(1,1) PRIMARY KEY,
	[ClientID] INT NOT NULL FOREIGN KEY REFERENCES [Clients]([ClientID]),
	[DateReported] DATE NOT NULL,
	[BenefitID] INT NOT NULL FOREIGN KEY REFERENCES [Benefits]([BenefitID]),
	[BenefitTerminated] BIT NOT NULL,
	[DateTerminated] DATE
)
GO

CREATE TABLE [CaseNotes] (
	[CaseNoteID] INT IDENTITY(1,1) PRIMARY KEY,
	[ClientID] INT NOT NULL FOREIGN KEY REFERENCES [Clients]([ClientID]),
	[TimeStamp] DATETIME NOT NULL,
	[Notes] NVARCHAR(MAX) NOT NULL
)
GO

CREATE TABLE [Cities] (
	[CityID] INT IDENTITY(1,1) PRIMARY KEY,
	[CityName] NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE [States] (
	[StateID] INT IDENTITY(1,1) PRIMARY KEY,
	[StateName] NVARCHAR(20) NOT NULL,
	[Abbreviation] NVARCHAR(5) NOT NULL
)
GO

CREATE TABLE [ZipCodes] (
	[ZipCodeID] INT IDENTITY(1,1) PRIMARY KEY,
	[ZipCode] NVARCHAR(10) NOT NULL
)
GO

CREATE TABLE [ResidencyCodes] (
	[ResidencyCodeID] INT IDENTITY(1,1) PRIMARY KEY,
	[ResidencyCode] NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE [HouseHolds] (
	[HouseHoldID] INT IDENTITY(1,1) PRIMARY KEY,
	[StreetName] NVARCHAR(50) NOT NULL,
	[StreetNumber] NVARCHAR(10) NOT NULL,
	[Apt Lot Unit] NVARCHAR(10),
	[CityID] INT NOT NULL FOREIGN KEY REFERENCES [Cities]([CityID]),
	[StateID] INT NOT NULL FOREIGN KEY REFERENCES [States]([StateID]),
	[ZipCodeID] INT NOT NULL FOREIGN KEY REFERENCES [ZipCodes]([ZipCodeID]),
	[ResidencyCodeID] INT NOT NULL FOREIGN KEY REFERENCES [ResidencyCodes]([ResidencyCodeID])
)
GO

CREATE TABLE [IncomeTypes] (
	[IncomeTypeID] INT IDENTITY(1,1) PRIMARY KEY,
	[IncomeCode] NVARCHAR(20) NOT NULL
)
GO

CREATE TABLE [IncomeSubtypes] (
	[IncomeSubTypeID] INT IDENTITY(1,1) PRIMARY KEY,
	[IncomeSubtype] NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE [IncomeIntervals] (
	[IncomeIntervalID] INT IDENTITY(1,1) PRIMARY KEY,
	[Interval] NVARCHAR(50) NOT NULl
)
GO

CREATE TABLE [IncomeData] (
	[IncomeDataID] INT IDENTITY(1,1) PRIMARY KEY,
	[ClientID] INT NOT NULL FOREIGN KEY REFERENCES [Clients]([ClientID]),
	[IncomeTypeID] INT NOT NULL FOREIGN KEY REFERENCES [IncomeTypes]([IncomeTypeID]),
	[IncomeSubtypeID] INT NOT NULL FOREIGN KEY REFERENCES [IncomeSubtypes]([IncomeSubtypeID]),
	[EmployerName] NVARCHAR(100),
	[IncomeAmount] DECIMAL(10,2),
	[IncomeIntervalID] INT NOT NULL FOREIGN KEY REFERENCES [IncomeIntervals]([IncomeIntervalID]),
	[EmploymentStart] DATE NOT NULL,
	[EmploymentEnd] DATE,
	[DateRecorded] DATE
)
GO

CREATE TABLE [MonthlyExpenseTypes] (
	[MonthlyExpenseTypeID] INT IDENTITY(1,1) PRIMARY KEY,
	[MonthlyExpenseType] NVARCHAR(50)
)
GO

CREATE TABLE [MonthlyExpenses] (
	[MonthlyExpenseID] INT IDENTITY(1,1) PRIMARY KEY,
	[HouseHoldID] INT NOT NULL FOREIGN KEY REFERENCES [HouseHolds]([HouseHoldID]),
	[MonthlyExpenseTypeID] INT NOT NULL FOREIGN KEY REFERENCES [MonthlyExpenseTypes]([MonthlyExpenseTypeID]),
	[Amount] DECIMAL(10,2) NOT NULL
)
GO

CREATE TABLE [TSVoucherTypes] (
	[TSVoucherTypeID] INT IDENTITY(1,1) PRIMARY KEY,
	[VoucherType] NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE [TSVouchers] (
	[TSVoucherID] INT IDENTITY(1,1) PRIMARY KEY,
	[ClientID] INT NOT NULL FOREIGN KEY REFERENCES [Clients]([ClientID]),
	[TSVoucherTypeID] INT NOT NULL FOREIGN KEY REFERENCES [TSVoucherTypes]([TSVoucherTypeID]),
	[VoucherAmount] DECIMAL(10,2),
	[VoucherIssueDate] DATE NOT NULL,
	[VoucherExpirationDate] DATE,
	[VoucherRedeemedDate] DATE
)
GO

CREATE TABLE [RelationshipTypes] (
	[RelationshipTypeID] INT IDENTITY(1,1) PRIMARY KEY,
	[RelationshipName] NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE [Relationships] (
	[RelationshipTypeID] INT NOT NULL FOREIGN KEY REFERENCES [RelationshipTypes]([RelationshipTypeID]),
	[ClientIDFrom] INT NOT NULL FOREIGN KEY REFERENCES [Clients]([ClientID]),
	[ClientIDTo] INT NOT NULL FOREIGN KEY REFERENCES [Clients]([ClientID])
)
GO

CREATE TABLE [OWActionCategories] (
	[OWActionCategoryID] INT IDENTITY(1,1) PRIMARY KEY,
	[OWActionCategory] NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE [OWBarrierTypes] (
	[OWBarrierTypeID] INT IDENTITY(1,1) PRIMARY KEY,
	[OWBarrierType] NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE [OWBarrierSubtypes] (
	[OWBarrierSubtypeID] INT IDENTITY(1,1) PRIMARY KEY,
	[OWBarrierTypeID] INT NOT NULL FOREIGN KEY REFERENCES [OWBarrierTypes]([OWBarrierTypeID]),
	[OWBarrierSubtype] NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE [OWGoalTypes] (
	[OWGoalTypeID] INT IDENTITY(1,1) PRIMARY KEY,
	[OWGoalType] NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE [OWGoalSubtypes] (
	[OWGoalSubtypeID] INT IDENTITY(1,1) PRIMARY KEY,
	[OWGoalTypeID] INT NOT NULL FOREIGN KEY REFERENCES [OWGoalTypes]([OWGoalTypeID]),
	[OWGoalType] NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE [OWStatuses] (
	[OWStatusID] INT IDENTITY(1,1) PRIMARY KEY,
	[OWStatus] NVARCHAR(100) NOT NULL
)
GO

CREATE TABLE [OWClients] (
	[OWClientID] INT IDENTITY(1,1) PRIMARY KEY,
	[ClientID] INT NOT NULL FOREIGN KEY REFERENCES [Clients]([ClientID]),
	[OWStatusID] INT NOT NULL FOREIGN KEY REFERENCES [OWStatuses]([OWStatusID])
)
GO

CREATE TABLE [OWBarrierTracking] (
	[OWBarrierTrackingID] INT IDENTITY(1,1) PRIMARY KEY,
	[OWClientID] INT NOT NULL FOREIGN KEY REFERENCES [OWClients]([OWClientID]),
	[DateIdentified] DATE NOT NULL,
	[OWBarrierTypeID] INT NOT NULL FOREIGN KEY REFERENCES [OWBarrierTypes]([OWBarrierTypeID]),
	[OWBarrierSubtypeID] INT NOT NULL FOREIGN KEY REFERENCES [OWBarrierSubtypes]([OWBarrierSubtypeID]),
	[Comments] NVARCHAR(MAX),
	[BarrierRemoved] BIT NOT NULL,
	[DateBarrierRemoved] DATE
)
GO

CREATE TABLE [OWGoalTracking] (
	[OWGoalTrackingID] INT IDENTITY(1,1) PRIMARY KEY,
	[OWClientID] INT NOT NULL FOREIGN KEY REFERENCES [OWClients]([OWClientID]),
	[DateSet] DATE NOT NULL,
	[OWGoalTypeID] INT NOT NULL FOREIGN KEY REFERENCES [OWGoalTypes]([OWGoalTypeID]),
	[OWGoalSubtypeID] INT NOT NULL FOREIGN KEY REFERENCES [OWGoalSubtypes]([OWGoalSubtypeID]),
	[Comments] NVARCHAR(MAX),
	[GoalAchieved] BIT NOT NULL,
	[DateGoalAchieved] DATE
)
GO

CREATE TABLE [OWIntake] (
	[OWIntakeID] INT IDENTITY(1,1) PRIMARY KEY,
	[OWClientID] INT NOT NULL FOREIGN KEY REFERENCES [OWClients]([OWClientID]),
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

CREATE TABLE [Programs] (
	[ProgramID] INT IDENTITY(1,1) PRIMARY KEY,
	ProgramName] NVARCHAR(100) UNIQUE NOT NULL
)
GO

CREATE TABLE [Funders] (
	[FunderID] INT IDENTITY(1,1) PRIMARY KEY,
	[FunderName] NVARCHAR(100) UNIQUE NOT NULL
)
GO

CREATE TABLE [EFAAssistanceCategories] (
	[EFAAssistanceCategoryID] INT IDENTITY(1,1) PRIMARY KEY,
	[EFAAssistanceCategory] NVARCHAR(100) NOT NULL
)
GO

CREATE TABLE [EFAActionCategories] (
	[EFAActionCategoryID] INT IDENTITY(1,1) PRIMARY KEY,
	[EFAActionCategory] UNIQUE NVARCHAR(100) NOT NULL
)
GO

CREATE TABLE [EFAPaymentStatuses] (
	[EFAPaymentStatusID] INT IDENTITY(1,1) PRIMARY KEY,
	[EFAPaymentStatus] UNIQUE NVARCHAR(100) NOT NULL
)
GO

CREATE TABLE [EFAJustificationCategories] (
	[EFAJustificationCategoryID] INT IDENTITY(1,1) PRIMARY KEY,
	[EFAJustificationCategory] NVARCHAR(100) UNIQUE NOT NULL
)
GO

CREATE TABLE [EFAJustifications] (
	[EFAJustificationID] INT IDENTITY(1,1) PRIMARY KEY,
	[EFAJustificationCategoryID] INT FOREIGN KEY REFERENCES [EFAJustificationCategories]([EFAJustificationCategoryID]),
	[EFAJustification] NVARCHAR(200) NOT NULL
)
GO

CREATE TABLE [EFAStatuses] (
	[EFAStatusID] INT IDENTITY(1,1) PRIMARY KEY,
	[EFAStatus] NVARCHAR(100) UNIQUE NOT NULL
)
GO

CREATE TABLE [EFAClients] (
	[EFAClientID] INT IDENTITY(1,1) PRIMARY KEY,
	[ClientID] INT NOT NULL FOREIGN KEY REFERENCES [Clients]([ClientID]),
	[DateRequestInitiated] DATE NOT NULL,
	[AssistanceCategoryID] INT FOREIGN KEY REFERENCES [EFAAssistanceCategories]([EFAAssistanceCategoryID]),
	[StatusID] INT FOREIGN KEY REFERENCES [EFAStatuses]([EFAStatusID]),
	[PendingJustificationID] INT FOREIGN KEY REFERENCES [EFAJustifications]([EFAJustificationID]),
	[FinalStatusID] INT FOREIGN KEY REFERENCES [EFAStatuses]([EFAStatusID]),
	[OutcomeJustificationID] INT FOREIGN KEY REFERENCES [EFAJustification]([EFAJustificationID]),
	[AmountOfAssistancePaid] DECIMAL(10,2),
	[DateAssistancePaid] DATE,
	[EFAAssistanceCategoryID] INT FOREIGN KEY REFERENCES [EFAAssistanceCategories]([EFAAssistanceCategoryID])
)
GO

CREATE TABLE [EFADocumentationChecklist] (
	[EFADocumentationChecklistID] INT IDENTITY(1,1) PRIMARY KEY,
	[EFAClientID] INT NOT NULL FOREIGN KEY REFERENCES [EFAClients]([EFAClientID]),
	[ProofOfAddress] BIT NOT NULL,
	[ProofOfAddressDate] DATE,
	[ProofOfHHID] BIT NOT NULL,
	[ProofOfHHIDDate] DATE,
	[ProofOfIncome] BIT NOT NULL,
	[ProofOfIncomeDate] DATE,
	[ProofOfHardship] BIT NOT NULL,
	[ProofOfHardshipDate] DATE,
	[ProofOfAssistanceType] BIT NOT NULL,
	[ProofOfAssistanceTypeDate] DATE,
	[Comments] NVARCHAR(MAX)
)
GO