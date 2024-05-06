CREATE TABLE [Categories] (
	[Id] int NOT NULL IDENTITY(1,1) UNIQUE,
	[CategoryName] nvarchar(100) NOT NULL UNIQUE,
	PRIMARY KEY ([Id])
);

CREATE TABLE [Producers] (
	[Id] int NOT NULL IDENTITY(1,1) UNIQUE,
	[ProducerName] nvarchar(100) NOT NULL UNIQUE,
	PRIMARY KEY ([Id])
);

CREATE TABLE [Products] (
	[Id] int NOT NULL IDENTITY(1,1) UNIQUE,
	[ProductName] nvarchar(100) NOT NULL,
	[CategoryId] int NOT NULL,
	[ProducerId] int NOT NULL,
	[Amount] int NOT NULL DEFAULT 1,
	[Price] money NOT NULL DEFAULT '10',
	[Photo] nvarchar(512),
	PRIMARY KEY ([Id])
);

CREATE TABLE [Clients] (
	[Id] int NOT NULL IDENTITY(1,1) UNIQUE,
	[ClientName] nvarchar(100) NOT NULL,
	[ClientSurname] nchar(100) NOT NULL,
	[Adress] nchar(256) NOT NULL,
	[Phone] nvarchar(50) NOT NULL UNIQUE,
	PRIMARY KEY ([Id])
);

CREATE TABLE [Managers] (
	[Id] int NOT NULL IDENTITY(1,1) UNIQUE,
	[ManagerName] nvarchar(100) NOT NULL,
	[ManagerSurname] nchar(100) NOT NULL,
	[Phone] nvarchar(50) NOT NULL UNIQUE,
	PRIMARY KEY ([Id])
);

CREATE TABLE [Couriers] (
	[Id] int NOT NULL IDENTITY(1,1) UNIQUE,
	[CourierName] nvarchar(100) NOT NULL,
	[CourierSurname] nchar(100) NOT NULL,
	[Phone] nvarchar(50) NOT NULL UNIQUE,
	PRIMARY KEY ([Id])
);

CREATE TABLE [Orders] (
	[Id] int NOT NULL IDENTITY(1,1) UNIQUE,
	[ClientId] int NOT NULL,
	[ManagerId] int NOT NULL,
	[CourierId] int NOT NULL,
	[StartDate] datetime2(7) NOT NULL,
	[FinishDate] datetime2(7),
	[StatusId] int NOT NULL,
	[Notes] nvarchar(256),
	PRIMARY KEY ([Id])
);

CREATE TABLE [OrderItems] (
	[Amount] int NOT NULL DEFAULT 1,
	[ProductId] int NOT NULL,
	[OrderId] int NOT NULL
);

CREATE TABLE [Statuses] (
	[Id] int NOT NULL IDENTITY(1,1) UNIQUE,
	[StatusName] nvarchar(100) NOT NULL,
	PRIMARY KEY ([Id])
);



ALTER TABLE [Products] ADD CONSTRAINT [Products_fk2] FOREIGN KEY ([CategoryId]) REFERENCES [Categories]([Id]);

ALTER TABLE [Products] ADD CONSTRAINT [Products_fk3] FOREIGN KEY ([ProducerId]) REFERENCES [Producers]([Id]);



ALTER TABLE [Orders] ADD CONSTRAINT [Orders_fk1] FOREIGN KEY ([ClientId]) REFERENCES [Clients]([Id]);

ALTER TABLE [Orders] ADD CONSTRAINT [Orders_fk2] FOREIGN KEY ([ManagerId]) REFERENCES [Managers]([Id]);

ALTER TABLE [Orders] ADD CONSTRAINT [Orders_fk3] FOREIGN KEY ([CourierId]) REFERENCES [Couriers]([Id]);

ALTER TABLE [Orders] ADD CONSTRAINT [Orders_fk6] FOREIGN KEY ([StatusId]) REFERENCES [Statuses]([Id]);
ALTER TABLE [OrderItems] ADD CONSTRAINT [OrderItems_fk1] FOREIGN KEY ([ProductId]) REFERENCES [Products]([Id]);

ALTER TABLE [OrderItems] ADD CONSTRAINT [OrderItems_fk2] FOREIGN KEY ([OrderId]) REFERENCES [Orders]([Id]);
