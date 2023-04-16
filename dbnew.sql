--RestTill.sql

-- Drop foreign key constraints in OrderItems table
ALTER TABLE OrderItems DROP CONSTRAINT fk_OrderItems_OrderID;
ALTER TABLE OrderItems DROP CONSTRAINT fk_OrderItems_ItemID;

DROP TABLE MenuItems;
DROP TABLE Orders;
DROP TABLE OrderItems;

--MenuItems table
CREATE TABLE MenuItems(
     ItemID numeric(4) PRIMARY KEY,
     Availability char(1) NOT NULL,
     Type char(1) NOT NULL,
     Name varchar2(20),
     Description varchar2(45),
     Price numeric (5,2)
 );
 
 --Orders table
CREATE TABLE Orders (
    OrderID numeric(4) PRIMARY KEY,
    TableNo numeric(4),
    OrderDate date NOT NULL,
    OrderPrice numeric (5,2) NOT NULL,
    OrderStatus char(1) NOT NULL
    );

--OrderItems table
CREATE TABLE OrderItems (
    OrderID numeric(4) NOT NULL,
    ItemID numeric(4) NOT NULL,
    Quantity numeric(4) NOT NULL,
    PRIMARY KEY (OrderID, ItemID),
    
    CONSTRAINT fk_OrderItems_OrderID FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    CONSTRAINT fk_OrderItems_ItemID FOREIGN KEY (ItemID) REFERENCES MenuItems(ItemID)
);

 
--Test Data

INSERT INTO MenuItems VALUES (1, 'A', 'F', 'Spaghetti', 'Tomato pasta dish', 14.00);
INSERT INTO MenuItems VALUES (2, 'A', 'F', 'Sushi', 'Assorted raw fish and veggie rolls', 12.50);
INSERT INTO MenuItems VALUES (3, 'U', 'B', 'Guiness', 'Dark Irish beer', 4.90);
INSERT INTO MenuItems VALUES (4, 'A', 'D', 'CheeseCake', 'Cream cheese dessert', 7.50);
INSERT INTO MenuItems VALUES (5, 'A', 'F', 'Chips', 'Fried potatoes', 6.00);
INSERT INTO MenuItems VALUES (6, 'U', 'D', 'Apple-Pie', 'Apple-filled dessert', 5.40);
INSERT INTO MenuItems VALUES (7, 'U', 'B', 'Bloody Mary', 'Spicy vodka-tomato cocktail', 9.75);
INSERT INTO MenuItems VALUES (8, 'A', 'F', 'Vindaloo', 'Spicy Indian curry dish', 12.00);
INSERT INTO MenuItems VALUES (9, 'U', 'B', 'Mojito', 'Refreshing rum-lime-mint cocktail', 4.90);
INSERT INTO MenuItems VALUES (10, 'A', 'F', 'Biryani', 'Fragrant rice dish', 9.99);
INSERT INTO MenuItems VALUES (11, 'A', 'F', 'Quesadilla', 'Melted cheese between tortillas', 6.50);
INSERT INTO MenuItems VALUES (12, 'U', 'F', 'Chow Mein', 'Stir-fried noodles, vegetables and meat', 10.75);
INSERT INTO MenuItems VALUES (13, 'A', 'F', 'Margherita Pizza', 'Tomato sauce and mozzarella', 10.00);
INSERT INTO MenuItems VALUES (14, 'U', 'B', 'Margarita', 'Tequila cocktail with lime', 5.00);
INSERT INTO MenuItems VALUES (15, 'A', 'F', 'Chicken Alfredo', 'Creamy pasta with chicken and Parmesan', 12.00);
INSERT INTO MenuItems VALUES (16, 'A', 'D', 'Tiramisu', 'Layered coffee dessert', 8.50);
INSERT INTO MenuItems VALUES (17, 'U', 'B', 'Cosmopolitan', 'Vodka-cranberry-lime cocktail', 7.00);
INSERT INTO MenuItems VALUES (18, 'A', 'F', 'Beef Stir Fry', 'Quick and flavorful Chinese dish', 11.50);
INSERT INTO MenuItems VALUES (19, 'A', 'F', 'Pad Thai', 'Thai noodle dish with tangy-sweet sauce', 10.00);
INSERT INTO MenuItems VALUES (20, 'U', 'F', 'Pepporoni Pizza', 'Tomato sauce, mozzarella, and pepperoni', 10.00);
INSERT INTO MenuItems VALUES (21, 'A', 'D', 'Lemon Tart', 'Tangy dessert with whipped cream', 6.50);
INSERT INTO MenuItems VALUES (22, 'A', 'F', 'Sausage and Mash', 'Local sausages and mashed potatoes', 9.00);
INSERT INTO MenuItems VALUES (23, 'U', 'B', 'Bloody Caesar', 'Spicy cocktail with Clamato and vodka', 8.75);
INSERT INTO MenuItems VALUES (24, 'A', 'F', 'Fish and Chips', 'Classic fried fish and potatoes', 12.50);
INSERT INTO MenuItems VALUES (25, 'A', 'F', 'Peking Duck', 'Roasted duck with pancakes and sauce', 20.00);
INSERT INTO MenuItems VALUES (26, 'U', 'B', 'Whiskey Sour', 'Whiskey cocktail with lemon and sugar', 9.00);
INSERT INTO MenuItems VALUES (27, 'A', 'F', 'Lobster Bisque', 'Creamy soup made with lobster and spices', 16.00);
INSERT INTO MenuItems VALUES (28, 'A', 'D', 'Chocolate Cake', 'Rich and decadent chocolate dessert', 8.00);
INSERT INTO MenuItems VALUES (29, 'U', 'B', 'Tequila Sunrise', 'Tequila cocktail with orange, grenadine', 6.50);
INSERT INTO MenuItems VALUES (30, 'A', 'F', 'Pho', 'Vietnamese noodle soup with herbs and beef', 10.50);



COMMIT;
