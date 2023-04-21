UPDATE OrderItems SET Quantity = 3 WHERE OrderId = 2 AND ItemId = 21; commit;



SELECT Quantity FROM OrderItems WHERE OrderId = 2 AND ItemId = 21;