
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/04/2018 22:09:27
-- Generated from EDMX file: \\mac\iCloud\Step\ADO.NET\DZ\ComputerShop\ComputerShop\ComputersShop.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ComputersShop];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CategoryComponent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Component] DROP CONSTRAINT [FK_CategoryComponent];
GO
IF OBJECT_ID(N'[dbo].[FK_ComputerComputerItem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ComputerItem] DROP CONSTRAINT [FK_ComputerComputerItem];
GO
IF OBJECT_ID(N'[dbo].[FK_ComponentComputerItem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ComputerItem] DROP CONSTRAINT [FK_ComponentComputerItem];
GO
IF OBJECT_ID(N'[dbo].[FK_BuyerCheck]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Check] DROP CONSTRAINT [FK_BuyerCheck];
GO
IF OBJECT_ID(N'[dbo].[FK_CheckCheckItem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CheckItem] DROP CONSTRAINT [FK_CheckCheckItem];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Category]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Category];
GO
IF OBJECT_ID(N'[dbo].[Component]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Component];
GO
IF OBJECT_ID(N'[dbo].[Computer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Computer];
GO
IF OBJECT_ID(N'[dbo].[ComputerItem]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ComputerItem];
GO
IF OBJECT_ID(N'[dbo].[Buyer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Buyer];
GO
IF OBJECT_ID(N'[dbo].[Check]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Check];
GO
IF OBJECT_ID(N'[dbo].[CheckItem]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CheckItem];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Category'
CREATE TABLE [dbo].[Category] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(30)  NOT NULL
);
GO

-- Creating table 'Component'
CREATE TABLE [dbo].[Component] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(30)  NOT NULL,
    [CategoryId] int  NOT NULL,
    [Vendor_code] nvarchar(max)  NOT NULL,
    [Price] decimal(18,2)  NOT NULL,
    [Quantity] smallint  NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Computer'
CREATE TABLE [dbo].[Computer] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(30)  NOT NULL,
    [Price] decimal(18,2)  NOT NULL
);
GO

-- Creating table 'ComputerItem'
CREATE TABLE [dbo].[ComputerItem] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ComputerId] int  NOT NULL,
    [ComponentId] int  NOT NULL
);
GO

-- Creating table 'Buyer'
CREATE TABLE [dbo].[Buyer] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [LastName] nvarchar(30)  NOT NULL,
    [FirstName] nvarchar(30)  NOT NULL,
    [Phone] nchar(12)  NULL
);
GO

-- Creating table 'Check'
CREATE TABLE [dbo].[Check] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [BuyerId] int  NOT NULL,
    [Date] datetime  NOT NULL,
    [CheckCoast] float  NOT NULL
);
GO

-- Creating table 'CheckItem'
CREATE TABLE [dbo].[CheckItem] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CheckId] int  NOT NULL,
    [ItemId] nvarchar(max)  NOT NULL,
    [IsComputer] tinyint  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Category'
ALTER TABLE [dbo].[Category]
ADD CONSTRAINT [PK_Category]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Component'
ALTER TABLE [dbo].[Component]
ADD CONSTRAINT [PK_Component]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Computer'
ALTER TABLE [dbo].[Computer]
ADD CONSTRAINT [PK_Computer]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ComputerItem'
ALTER TABLE [dbo].[ComputerItem]
ADD CONSTRAINT [PK_ComputerItem]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Buyer'
ALTER TABLE [dbo].[Buyer]
ADD CONSTRAINT [PK_Buyer]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Check'
ALTER TABLE [dbo].[Check]
ADD CONSTRAINT [PK_Check]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CheckItem'
ALTER TABLE [dbo].[CheckItem]
ADD CONSTRAINT [PK_CheckItem]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CategoryId] in table 'Component'
ALTER TABLE [dbo].[Component]
ADD CONSTRAINT [FK_CategoryComponent]
    FOREIGN KEY ([CategoryId])
    REFERENCES [dbo].[Category]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoryComponent'
CREATE INDEX [IX_FK_CategoryComponent]
ON [dbo].[Component]
    ([CategoryId]);
GO

-- Creating foreign key on [ComputerId] in table 'ComputerItem'
ALTER TABLE [dbo].[ComputerItem]
ADD CONSTRAINT [FK_ComputerComputerItem]
    FOREIGN KEY ([ComputerId])
    REFERENCES [dbo].[Computer]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ComputerComputerItem'
CREATE INDEX [IX_FK_ComputerComputerItem]
ON [dbo].[ComputerItem]
    ([ComputerId]);
GO

-- Creating foreign key on [ComponentId] in table 'ComputerItem'
ALTER TABLE [dbo].[ComputerItem]
ADD CONSTRAINT [FK_ComponentComputerItem]
    FOREIGN KEY ([ComponentId])
    REFERENCES [dbo].[Component]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ComponentComputerItem'
CREATE INDEX [IX_FK_ComponentComputerItem]
ON [dbo].[ComputerItem]
    ([ComponentId]);
GO

-- Creating foreign key on [BuyerId] in table 'Check'
ALTER TABLE [dbo].[Check]
ADD CONSTRAINT [FK_BuyerCheck]
    FOREIGN KEY ([BuyerId])
    REFERENCES [dbo].[Buyer]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BuyerCheck'
CREATE INDEX [IX_FK_BuyerCheck]
ON [dbo].[Check]
    ([BuyerId]);
GO

-- Creating foreign key on [CheckId] in table 'CheckItem'
ALTER TABLE [dbo].[CheckItem]
ADD CONSTRAINT [FK_CheckCheckItem]
    FOREIGN KEY ([CheckId])
    REFERENCES [dbo].[Check]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CheckCheckItem'
CREATE INDEX [IX_FK_CheckCheckItem]
ON [dbo].[CheckItem]
    ([CheckId]);
GO

--Add categories
INSERT INTO [dbo].[Category] VALUES
('����������'),
('����������� �����'),
('�������'),
('����������'),
('����������� ������'),
('HDD � �������� �������'),
('SSD-����������'),
('������� ����������'),
('����� �������');
GO
--Add components
INSERT INTO [dbo].[Component] VALUES
('Intel Core i3-8100 3.6GHz/8GT', 1, 'BX80684I38100', 3890, 15, '����� ��������� Intel Core i3-8100 8-�� ���������, � ������� ��������� ���������������� Coffee Lake-S. ������������ ��� ���������� ��������� Intel LGA 1151. ����������� � ��������� ���������������������� ����������� Core i3.'),
('Intel Core i5-8400 2.8GHz/8GT', 1, 'BX80684I58400', 6390, 10, '����� ��������� Intel Core i5-8400 8-�� ���������, � ������� ��������� ���������������� Coffee Lake-S. ������������ ��� ���������� ��������� Intel LGA 1151. ����������� � ��������� ���������������������� ����������� Core i5.'),
('Asus H110M-K', 2, '5733051DFE12E', 1565, 112, 'H110M-K � �������������� ����������� ����� Asus ������� micro-ATX ���������� ������, ��������������� ��� ����� ��������� Intel � ���������� �� ��������� ������ H110. ������������ 2 ����� ����������� ������ DDR4.'),
('MSI Z370 PC PRO', 2, '25040881ER32W', 5534, 5, '��������� ������ ����������� � ���������c���� R&D ������� MSI, ��������� ��� ����������� �����, �� ������ ������������ ��� ���� ������� ������ ��������������� ������������������ �������� ������. ����������� ���������� ��� �������, ���������� ������� ��������, ��������� Loadline Calibration, DigitALL CPU PWM, ��� ��� ��������� ����������� ������ MSI Z370 ������������ ���������� ������� ���� ����������� ������� ��� ��������� ������������ ������������������ ���� �� ����� �������������� �������.'),
('Asus Prime X399-A', 1, '21756673I38100', 9860, 15, 'Prime � ��� ����� ���� � �������� ����������� ���� ASUS, ��� ����������� ���������� � �������� 1989 ����. ������� ���������, ��������� ������ ����� Prime, ������� ���� ����� ������� �� ����������� ������� � �������������� � �������� � ���������, ���� ������ ��� �������� ����� ��� �����������.'),
('QUBE Armor Black', 3, 'QBT97FMNU4EF3', 3445, 10, 'QUBE Armor �������� � ����-������� Miditower. ������������� ������, ������������ ������ � �������������� ����������� ������������ ����������� ���������� �������������.'),
('NZXT H440 Black', 3, 'CAH442WM8RTG3', 2999, 5, 'NZXT H440 �������� � ����-������� Midi Tower � ��������� � ������������ ������� ����������� Mini-ITX, ATX, Micro-ATX. ������ ������� ����� 120 �� � ����� 140 �� �������������. ������� ����������� ��������� ������������ ������ ��� ������������ ��� ���������� ������ �������.'),
('INNO3D PCI-Ex GeForce GTX1060', 4, 'N10606DDNN5GM', 8699, 10, 'NNO3D GeForce GTX1060 Compact �������� �� ����� ����������� Pascal, � ����� ����� �� ����� 6 �� ������ GDDR5. ������������ ��������� ������� ���������� ������! ���������� �������� ���������� �������� ���������� � ����� ������������.'),
('Asus PCI-Ex GeForce GTX 1060', 4, 'DUALGTX1060O3', 7946, 15, '���������� GeForce GTX 1060 Dual O3G �� Asus ������� ������ 3 �� GDDR5, �������� �� ����� ����������� Pascal � ������������ ��������� ������� ���������� ������. ������ ����� �������� ������ ������� � �������� ���������������� ������������� Wing-Blade, ���������������� ������������ ���������� � ����������� �� 105% ������ �������� ���������� ������.'),
('Kingston DDR3-1600 4096MB', 5, 'KVR16N11S8243', 1099, 15, 'DDR3 ������ �������� ������������ ����� ������ ��� ����������� � ���������� �����������, �������� � ������� �������. DDR3 ���������� �� ������ �� ����� ������� ��������, ��� DDR, � ��������������� ������� ������������������.'),
('Kingston DDR4-2400 4096MB', 5, 'HX424C15FBDS4', 1499, 15, '����������� ������ Kingston DDR4-2400 4096MB PC4-19200 HyperX Fury Black'),
('Western Digital Blue 500GB', 6, 'WD5000AZRZERS', 1284, 150, '���������� WD Blue � ��� �������� ������� ��� �������� ������ �����������, ����� � ������ ������ �� ��, ������� �������� �������� ��� ������������� �������������.'),
('Kingston SSDNow A400 240GB', 7, 'SA400S37D240G', 1499, 150, '������� � ������� �� ���������, �� 10 ��� ����������� �������� ������������ ������� ������, A400 ������������ ������������ ��������� ������ ������� � �������� ��������, � ����� �������� ����� ������������ �������.'),
('Aerocool VX-550 550W', 9, 'ACPNVX55NEY11', 949, 10, '������ ������� ������� VX � ����� ��������� � ������������ Aerocool � ������������� ��� ������ ���������� ������. ��� ������� �� ������������������ ����������� � ������������ ���������� � ������� ������� ��� ����� ���������� �����.');
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------