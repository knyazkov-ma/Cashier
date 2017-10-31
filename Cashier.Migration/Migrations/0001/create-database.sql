    create table Catalog (
        Id BIGINT not null,
       Name VARCHAR(1000) not null,
       Code VARCHAR(50) not null,
	   Price DECIMAL(19,2) not null,
       primary key (Id)
    )

    create table SaleDocumentItem (
        Id BIGINT not null,
       Name VARCHAR(1000) not null,
       Count INT not null,
       Price DECIMAL(19,2) not null,
       Amount DECIMAL(19,2) not null,
       SaleDocumentId BIGINT null,
       primary key (Id)
    )

    create table Stock (
        Id BIGINT not null,
       Count INT not null,
       CatalogId BIGINT not null,
       primary key (Id)
    )

    create table SaleDocument (
        Id BIGINT not null,
       State INT not null,
       primary key (Id)
    )

    alter table SaleDocumentItem 
        add constraint SaleDocumentItem_SaleDocument_FK 
        foreign key (SaleDocumentId) 
        references SaleDocument

    alter table Stock 
        add constraint Stock_Catalog_FK 
        foreign key (CatalogId) 
        references Catalog
	
	create sequence SQ_GLOBAL as int start with 100000 increment by 1

INSERT [Catalog] (Id, Name, Code, Price) VALUES (1, 'Молоко',		'000001', CAST(501.80 AS Decimal(19, 2)))
INSERT [Catalog] (Id, Name, Code, Price) VALUES (2, 'Мороженое',	'000002', CAST(45.14 AS Decimal(19, 2)))
INSERT [Catalog] (Id, Name, Code, Price) VALUES (3, 'Хлеб',			'000003', CAST(152.40 AS Decimal(19, 2)))
INSERT [Catalog] (Id, Name, Code, Price) VALUES (4, 'Мука',			'000004', CAST(88.82 AS Decimal(19, 2)))
INSERT [Catalog] (Id, Name, Code, Price) VALUES (5, 'Гречка',		'000005', CAST(302.50 AS Decimal(19, 2)))


INSERT [Stock] (Id, Count, CatalogId) VALUES (1, 22, 1)
INSERT [Stock] (Id, Count, CatalogId) VALUES (2, 3, 2)
INSERT [Stock] (Id, Count, CatalogId) VALUES (3, 12, 3)
INSERT [Stock] (Id, Count, CatalogId) VALUES (4, 4, 4)
INSERT [Stock] (Id, Count, CatalogId) VALUES (5, 2, 5)