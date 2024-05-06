CREATE TABLE [Resorts] (
	[Id] int NOT NULL IDENTITY(1,1) UNIQUE,
	[ResortName] nvarchar(100) NOT NULL,
	[CityId] int NOT NULL,
	PRIMARY KEY ([Id])
);

CREATE TABLE [Countries] (
	[Id] int NOT NULL IDENTITY(1,1) UNIQUE,
	[CountryName] nvarchar(100) NOT NULL,
	PRIMARY KEY ([Id])
);

CREATE TABLE [Managers] (
	[Id] int NOT NULL IDENTITY(1,1) UNIQUE,
	[ManagerName] nvarchar(100) NOT NULL,
	[ManagerSurname] nvarchar(100) NOT NULL,
	[Phone] nvarchar(100) NOT NULL,
	PRIMARY KEY ([Id])
);

CREATE TABLE [ToursCategories] (
	[Id] int NOT NULL IDENTITY(1,1) UNIQUE,
	[CategoryName] nvarchar(100) NOT NULL UNIQUE,
	PRIMARY KEY ([Id])
);

CREATE TABLE [Tours] (
	[Id] int NOT NULL IDENTITY(1,1) UNIQUE,
	[Price] int NOT NULL,
	[StartDate] datetime2(7) NOT NULL,
	[EndDate] datetime2(7) NOT NULL,
	[HotelId] int NOT NULL,
	[CategoryId] int NOT NULL,
	[ManagerId] int NOT NULL,
	PRIMARY KEY ([Id])
);

CREATE TABLE [Clients] (
	[Id] int NOT NULL IDENTITY(1,1) UNIQUE,
	[ClientName] nvarchar(100) NOT NULL,
	[ClientSurname] nvarchar(100) NOT NULL,
	[Phone] nvarchar(100) NOT NULL,
	PRIMARY KEY ([Id])
);

CREATE TABLE [Hotels] (
	[Id] int NOT NULL IDENTITY(1,1) UNIQUE,
	[HotelName] nvarchar(100) NOT NULL,
	[ResortId] int NOT NULL,
	PRIMARY KEY ([Id])
);

CREATE TABLE [Cities] (
	[Id] int NOT NULL IDENTITY(1,1) UNIQUE,
	[CityName] nvarchar(100) NOT NULL,
	[CountryId] int NOT NULL,
	PRIMARY KEY ([Id])
);

CREATE TABLE [Orders] (
	[Id] int NOT NULL IDENTITY(1,1) UNIQUE,
	[ClientId] int NOT NULL,
	[TourId] int NOT NULL,
	[NumberOfVisiters] int NOT NULL DEFAULT 1,
	PRIMARY KEY ([Id])
);

ALTER TABLE [Resorts] ADD CONSTRAINT [Resorts_fk2] FOREIGN KEY ([CityId]) REFERENCES [Cities]([Id]);



ALTER TABLE [Tours] ADD CONSTRAINT [Tours_fk4] FOREIGN KEY ([HotelId]) REFERENCES [Hotels]([Id]);

ALTER TABLE [Tours] ADD CONSTRAINT [Tours_fk5] FOREIGN KEY ([CategoryId]) REFERENCES [ToursCategories]([Id]);

ALTER TABLE [Tours] ADD CONSTRAINT [Tours_fk6] FOREIGN KEY ([ManagerId]) REFERENCES [Managers]([Id]);

ALTER TABLE [Hotels] ADD CONSTRAINT [Hotels_fk2] FOREIGN KEY ([ResortId]) REFERENCES [Resorts]([Id]);
ALTER TABLE [Cities] ADD CONSTRAINT [Cities_fk2] FOREIGN KEY ([CountryId]) REFERENCES [Countries]([Id]);
ALTER TABLE [Orders] ADD CONSTRAINT [Orders_fk1] FOREIGN KEY ([ClientId]) REFERENCES [Clients]([Id]);

ALTER TABLE [Orders] ADD CONSTRAINT [Orders_fk2] FOREIGN KEY ([TourId]) REFERENCES [Tours]([Id]);