--RestTill.sql

DROP TABLE MenuItems;

CREATE TABLE MenuItems
(ItemID numeric(4),
 Availability CHAR(1) NOT NULL,
 Type char(1) NOT NULL,
 Name varchar2(20),
 Description varchar2(25),
 Price numeric (5,2),
 CONSTRAINT pk_MenuItems PRIMARY KEY (ItemID));
 
 
--Test Data

INSERT INTO MenuItems VALUES (1, 'A', 'F', 'Spaghetti', 'Italian', 14.00);
INSERT INTO MenuItems VALUES (2, 'A', 'F', 'Sushi', 'Japanese', 12.50);
INSERT INTO MenuItems VALUES (3, 'U', 'B', 'Guiness', 'Irish', 4.90);
INSERT INTO MenuItems VALUES (4, 'A', 'D', 'CheeseCake', 'Greek', 7.50);
INSERT INTO MenuItems VALUES (5, 'A', 'F', 'Chips', 'Belgium', 6.00);
INSERT INTO MenuItems VALUES (6, 'U', 'D', 'Apple-Pie', 'English', 5.40);
INSERT INTO MenuItems VALUES (7, 'U', 'B', 'Bloody Mary', 'French', 9.75);
INSERT INTO MenuItems VALUES (8, 'A', 'F', 'Vindaloo', 'Portuguese', 12.00);
INSERT INTO MenuItems VALUES (9, 'U', 'B', 'Mojito', 'Cuban', 4.90);
INSERT INTO MenuItems VALUES (10, 'A', 'F', 'Biryani', 'Persian', 9.99);
INSERT INTO MenuItems VALUES (11, 'A', 'F', 'Quesadilla', 'Mexican', 6.50);
INSERT INTO MenuItems VALUES (12, 'U', 'F', 'Chow Mein', 'Chinese', 10.75);

Commit;
