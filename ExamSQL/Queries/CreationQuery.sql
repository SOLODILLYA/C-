CREATE TABLE [Person] (
	[Id] int IDENTITY(1,1) NOT NULL IDENTITY(1,1) UNIQUE,
	[PersonName] nvarchar(100) NOT NULL,
	[PersonPhone] nvarchar(50) NOT NULL,
	[PersonEmail] nvarchar(50) NOT NULL,
	PRIMARY KEY ([Id])
);

CREATE TABLE [Barbers] (
	[Id] int IDENTITY(1,1) NOT NULL IDENTITY(1,1) UNIQUE,
	[PersonId] int NOT NULL,
	[StartDate] date NOT NULL,
	[BirthDate] date NOT NULL,
	[PositionId] int NOT NULL,
	[GenderId] int NOT NULL,
	PRIMARY KEY ([Id])
);

CREATE TABLE [Genders] (
	[Id] int IDENTITY(1,1) NOT NULL IDENTITY(1,1) UNIQUE,
	[GenderName] nvarchar(100) NOT NULL,
	PRIMARY KEY ([Id])
);

CREATE TABLE [Feedbacks] (
	[Id] int IDENTITY(1,1) NOT NULL IDENTITY(1,1) UNIQUE,
	[BarberId] int NOT NULL,
	[CustomerId] int NOT NULL,
	[FeedbackString] nvarchar(500) NOT NULL,
	[RatingId] int NOT NULL,
	PRIMARY KEY ([Id])
);

CREATE TABLE [ArchiveOfServices] (
	[Id] int NOT NULL,
	[ServiceId] int NOT NULL,
	[VisitId] int NOT NULL,
	[Price] money NOT NULL
);

CREATE TABLE [Positions] (
	[Id] int IDENTITY(1,1) NOT NULL IDENTITY(1,1) UNIQUE,
	[PositionName] nvarchar(100) NOT NULL,
	PRIMARY KEY ([Id])
);

CREATE TABLE [Ratings] (
	[Id] int IDENTITY(1,1) NOT NULL IDENTITY(1,1) UNIQUE,
	[RatingName] nvarchar(50) NOT NULL,
	PRIMARY KEY ([Id])
);

CREATE TABLE [Services] (
	[Id] int IDENTITY(1,1) NOT NULL IDENTITY(1,1) UNIQUE,
	[ServiceName] nvarchar(50) NOT NULL,
	[BarberId] int NOT NULL,
	[Duration] time(7) NOT NULL,
	[Price] money NOT NULL,
	PRIMARY KEY ([Id])
);

CREATE TABLE [Customers] (
	[Id] int IDENTITY(1,1) NOT NULL IDENTITY(1,1) UNIQUE,
	[PersonId] int NOT NULL,
	PRIMARY KEY ([Id])
);

CREATE TABLE [ArchiveOfVisits] (
	[Id] int NOT NULL,
	[BarberId] int NOT NULL,
	[VisitDate] datetime2(7) NOT NULL,
	[FeedbackId] int NOT NULL,
	[TotalPrice] money NOT NULL,
	[CustomerId] int NOT NULL,
	PRIMARY KEY ([Id])
);

CREATE TABLE [Timetable] (
	[Id] int IDENTITY(1,1) NOT NULL IDENTITY(1,1) UNIQUE,
	[BarberId] int NOT NULL,
	[StartTime] datetime2(7) NOT NULL,
	[EndTime] datetime2(7) NOT NULL,
	[AssignedCustomerId] int,
	PRIMARY KEY ([Id])
);


ALTER TABLE [Barbers] ADD CONSTRAINT [Barbers_fk1] FOREIGN KEY ([PersonId]) REFERENCES [Person]([Id]);

ALTER TABLE [Barbers] ADD CONSTRAINT [Barbers_fk4] FOREIGN KEY ([PositionId]) REFERENCES [Positions]([Id]);

ALTER TABLE [Barbers] ADD CONSTRAINT [Barbers_fk5] FOREIGN KEY ([GenderId]) REFERENCES [Genders]([Id]);

ALTER TABLE [Feedbacks] ADD CONSTRAINT [Feedbacks_fk1] FOREIGN KEY ([BarberId]) REFERENCES [Barbers]([Id]);

ALTER TABLE [Feedbacks] ADD CONSTRAINT [Feedbacks_fk2] FOREIGN KEY ([CustomerId]) REFERENCES [Customers]([Id]);

ALTER TABLE [Feedbacks] ADD CONSTRAINT [Feedbacks_fk4] FOREIGN KEY ([RatingId]) REFERENCES [Ratings]([Id]);
ALTER TABLE [ArchiveOfServices] ADD CONSTRAINT [ArchiveOfServices_fk1] FOREIGN KEY ([ServiceId]) REFERENCES [Services]([Id]);

ALTER TABLE [ArchiveOfServices] ADD CONSTRAINT [ArchiveOfServices_fk2] FOREIGN KEY ([VisitId]) REFERENCES [ArchiveOfVisits]([Id]);


ALTER TABLE [Services] ADD CONSTRAINT [Services_fk2] FOREIGN KEY ([BarberId]) REFERENCES [Barbers]([Id]);
ALTER TABLE [Customers] ADD CONSTRAINT [Customers_fk1] FOREIGN KEY ([PersonId]) REFERENCES [Person]([Id]);
ALTER TABLE [ArchiveOfVisits] ADD CONSTRAINT [ArchiveOfVisits_fk1] FOREIGN KEY ([BarberId]) REFERENCES [Barbers]([Id]);

ALTER TABLE [ArchiveOfVisits] ADD CONSTRAINT [ArchiveOfVisits_fk3] FOREIGN KEY ([FeedbackId]) REFERENCES [Feedbacks]([Id]);

ALTER TABLE [ArchiveOfVisits] ADD CONSTRAINT [ArchiveOfVisits_fk5] FOREIGN KEY ([CustomerId]) REFERENCES [Customers]([Id]);
ALTER TABLE [Timetable] ADD CONSTRAINT [Timetable_fk1] FOREIGN KEY ([BarberId]) REFERENCES [Barbers]([Id]);

ALTER TABLE [Timetable] ADD CONSTRAINT [Timetable_fk4] FOREIGN KEY ([AssignedCustomerId]) REFERENCES [Customers]([Id]);