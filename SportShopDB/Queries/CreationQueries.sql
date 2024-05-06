CREATE TABLE [Customers] (
	[Id] int IDENTITY(1,1) NOT NULL UNIQUE,
	[ClientName] nvarchar(100) NOT NULL,
	[ClienteEmail] nvarchar(50) NOT NULL,
	[ClientSexId] int NOT NULL,
	[Discount] float(53) NOT NULL DEFAULT 0,
	[Subscription] bit NOT NULL DEFAULT 'False',
	PRIMARY KEY ([Id])
);

CREATE TABLE [Manufacturer] (
	[Id] int IDENTITY(1,1) NOT NULL UNIQUE,
	[ManufacturerName] nvarchar(50) NOT NULL,
	PRIMARY KEY ([Id])
);

CREATE TABLE [ProductTypes] (
	[Id] int IDENTITY(1,1) NOT NULL UNIQUE,
	[TypeName] nvarchar(50) NOT NULL,
	PRIMARY KEY ([Id])
);

CREATE TABLE [OrderItems] (
	[Id] int IDENTITY(1,1) NOT NULL,
	[ProductId] int NOT NULL,
	[SaleId] int NOT NULL,
	[Quantity] int NOT NULL DEFAULT 1,
	[SalePrice] money NOT NULL DEFAULT '100',
	PRIMARY KEY ([Id])
);

CREATE TABLE [Genders] (
	[Id] int IDENTITY(1,1) NOT NULL UNIQUE,
	[GenderName] nvarchar(50) NOT NULL,
	PRIMARY KEY ([Id])
);

CREATE TABLE [Sales] (
	[Id] int IDENTITY(1,1) NOT NULL UNIQUE,
	[EmployeeId] int NOT NULL,
	[CustomerId] int NOT NULL,
	[TotalPrice] money NOT NULL,
	PRIMARY KEY ([Id])
);

CREATE TABLE [Products] (
	[Id] int IDENTITY(1,1) NOT NULL UNIQUE,
	[ProductTypeId] int NOT NULL,
	[Quantity] int NOT NULL DEFAULT 1,
	[ProductionPrice] money NOT NULL DEFAULT '1000',
	[ManufacturerId] int NOT NULL,
	[SalePrice] money NOT NULL DEFAULT '1000',
	PRIMARY KEY ([Id])
);

CREATE TABLE [Employees] (
	[Id] int IDENTITY(1,1) NOT NULL UNIQUE,
	[EmployeeName] nvarchar(100) NOT NULL,
	[PositionId] int NOT NULL,
	[StartDate] date NOT NULL,
	[GenderId] int NOT NULL,
	[Salary] money NOT NULL,
	PRIMARY KEY ([Id])
);

CREATE TABLE [History] (
	[Id] int IDENTITY(1,1) NOT NULL UNIQUE,
	[SalesId] int NOT NULL,
	TotalPrice money NOT NULL,
	[EmployeeId] int NOT NULL,
	[CustomerId] int NOT NULL,
	PRIMARY KEY ([Id])
);

CREATE TABLE [Positions] (
	[Id] int IDENTITY(1,1) NOT NULL UNIQUE,
	[PositionName] nvarchar(100) NOT NULL,
	PRIMARY KEY ([Id])
);

CREATE TABLE [LastItems](
	[Id] int IDENTITY(1,1) NOT NULL UNIQUE,
	[ProductId] INT NOT NULL FOREIGN KEY REFERENCES Products(Id),
	PRIMARY KEY ([Id])
);

CREATE TABLE Archive(
	[Id] int IDENTITY(1,1) NOT NULL UNIQUE,
	[ProductTypeId] int NOT NULL FOREIGN KEY REFERENCES ProductTypes(Id),
	[ProductionPrice] money NOT NULL DEFAULT '1000',
	[ManufacturerId] int NOT NULL FOREIGN KEY REFERENCES Manufacturer(Id),
	[SalePrice] money NOT NULL DEFAULT '1000',
	PRIMARY KEY ([Id])
);

ALTER TABLE [Customers] ADD CONSTRAINT [Customers_fk3] FOREIGN KEY ([ClientSexId]) REFERENCES [Genders]([Id]);


ALTER TABLE [OrderItems] ADD CONSTRAINT [OrderItems_fk1] FOREIGN KEY ([ProductId]) REFERENCES [Products]([Id]);

ALTER TABLE [OrderItems] ADD CONSTRAINT [OrderItems_fk2] FOREIGN KEY ([SaleId]) REFERENCES [Sales]([Id]);

ALTER TABLE [Sales] ADD CONSTRAINT [Sales_fk1] FOREIGN KEY ([EmployeeId]) REFERENCES [Employees]([Id]);

ALTER TABLE [Sales] ADD CONSTRAINT [Sales_fk2] FOREIGN KEY ([CustomerId]) REFERENCES [Customers]([Id]);
ALTER TABLE [Products] ADD CONSTRAINT [Products_fk1] FOREIGN KEY ([ProductTypeId]) REFERENCES [ProductTypes]([Id]);

ALTER TABLE [Products] ADD CONSTRAINT [Products_fk4] FOREIGN KEY ([ManufacturerId]) REFERENCES [Manufacturer]([Id]);
ALTER TABLE [Employees] ADD CONSTRAINT [Employees_fk2] FOREIGN KEY ([PositionId]) REFERENCES [Positions]([Id]);

ALTER TABLE [Employees] ADD CONSTRAINT [Employees_fk4] FOREIGN KEY ([GenderId]) REFERENCES [Genders]([Id]);
ALTER TABLE [History] ADD CONSTRAINT [History_fk1] FOREIGN KEY ([SalesId]) REFERENCES [Sales]([Id]);

ALTER TABLE [History] ADD CONSTRAINT [History_fk2] FOREIGN KEY ([EmployeeId]) REFERENCES [Employees]([Id]);

ALTER TABLE [History] ADD CONSTRAINT [History_fk3] FOREIGN KEY ([CustomerId]) REFERENCES [Customers]([Id]);
