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
INSERT INTO MenuItems VALUES (13, 'A', 'F', 'Margherita Pizza', 'Italian', 10.00);
INSERT INTO MenuItems VALUES (14, 'U', 'B', 'Margarita', 'Mexican', 5.00);
INSERT INTO MenuItems VALUES (15, 'A', 'F', 'Chicken Alfredo', 'Italian', 12.00);
INSERT INTO MenuItems VALUES (16, 'A', 'D', 'Tiramisu', 'Italian', 8.50);
INSERT INTO MenuItems VALUES (17, 'U', 'B', 'Cosmopolitan', 'American', 7.00);
INSERT INTO MenuItems VALUES (18, 'A', 'F', 'Beef Stir Fry', 'Chinese', 11.50);
INSERT INTO MenuItems VALUES (19, 'A', 'F', 'Pad Thai', 'Thai', 10.00);
INSERT INTO MenuItems VALUES (20, 'U', 'F', 'Pepporoni Pizza', 'American', 10.00);
INSERT INTO MenuItems VALUES (21, 'A', 'D', 'Lemon Tart', 'French', 6.50);
INSERT INTO MenuItems VALUES (22, 'A', 'F', 'Sausage and Mash', 'British', 9.00);
INSERT INTO MenuItems VALUES (23, 'U', 'B', 'Bloody Caesar', 'Canadian', 8.50);
INSERT INTO MenuItems VALUES (24, 'A', 'F', 'Paella', 'Spanish', 14.00);
INSERT INTO MenuItems VALUES (25, 'A', 'D', 'Creme Brulee', 'French', 7.50);
INSERT INTO MenuItems VALUES (26, 'U', 'B', 'Caipirinha', 'Brazilian', 6.50);
INSERT INTO MenuItems VALUES (27, 'A', 'F', 'Carbonara', 'Italian', 11.50);
INSERT INTO MenuItems VALUES (28, 'A', 'F', 'Fish and Chips', 'British', 10.00);
INSERT INTO MenuItems VALUES (29, 'U', 'B', 'Manhattan', 'American', 9.00);
INSERT INTO MenuItems VALUES (30, 'A', 'F', 'Pad Kee Mao', 'Thai', 11.00);

Commit;
