--RestTill.sql

DROP TABLE MenuItems;

CREATE TABLE MenuItems
(Availability CHAR(1) NOT NULL,
ItemID numeric(4),
 Type char(1) NOT NULL,
 Name varchar2(20),
 Description varchar2(25),
 Price numeric (5,2),
 CONSTRAINT pk_MenuItems PRIMARY KEY (ItemID));
