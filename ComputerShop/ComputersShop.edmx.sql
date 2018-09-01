
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/01/2018 09:49:36
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

IF OBJECT_ID(N'[dbo].[FK_BuyerCheck]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Check] DROP CONSTRAINT [FK_BuyerCheck];
GO
IF OBJECT_ID(N'[dbo].[FK_CategoryComponent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Component] DROP CONSTRAINT [FK_CategoryComponent];
GO
IF OBJECT_ID(N'[dbo].[FK_CheckCheckItem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CheckItem] DROP CONSTRAINT [FK_CheckCheckItem];
GO
IF OBJECT_ID(N'[dbo].[FK_ComponentComputerItem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ComputerItem] DROP CONSTRAINT [FK_ComponentComputerItem];
GO
IF OBJECT_ID(N'[dbo].[FK_ComputerComputerItem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ComputerItem] DROP CONSTRAINT [FK_ComputerComputerItem];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Buyer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Buyer];
GO
IF OBJECT_ID(N'[dbo].[Category]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Category];
GO
IF OBJECT_ID(N'[dbo].[Check]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Check];
GO
IF OBJECT_ID(N'[dbo].[CheckItem]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CheckItem];
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
    [Price] float  NOT NULL,
    [Quantity] smallint  NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Computer'
CREATE TABLE [dbo].[Computer] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(30)  NOT NULL
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

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------