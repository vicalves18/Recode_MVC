IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Clientes] (
    [id] int NOT NULL IDENTITY,
    [nome] nvarchar(max) NOT NULL,
    [email] nvarchar(max) NOT NULL,
    [telefone] nvarchar(15) NOT NULL,
    [cpf] float NOT NULL,
    [destino] nvarchar(max) NULL,
    CONSTRAINT [PK_Clientes] PRIMARY KEY ([id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211214224110_MigracaoInicial', N'5.0.0');
GO

COMMIT;
GO

