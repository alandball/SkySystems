/** 
 ****Used to populate the datbase****
 **/

use SkySystems;

insert into Branch values
('Pietermaritzburg', 'KwaZulu-Natal'),
('Johannesburg', 'Gauteng')

insert into UserType values
('Manager', 'Leadership Staff'),
('Staff', 'Normal Staff'),
('Driver', 'Driver Staff')

insert into [User] values
(1, 1, 'Alan', 'Dirk', 'Ball', '1991-11-01 00:00:00.000', '14 Daisy Rd', 'Winterskloof', 'Hilton', '3245', 'P.O. Box 5435', NULL, 'Hilton', '3245', 'alandball@hotmail.com', '03354578', '0794545', NULL, '9111015547082', '2014-10-21 00:00:00.000', NULL, NULL, 0, NULL, NULL, 0, NULL)

insert into ClientType values
('Poultry'),
('Pork')

insert into Client values
(1, 'South African Poultry', 'sapa@poultry.co.za', '078945465', '0865754', '2014-10-26 00:00:00.000', NULL, NULL, 2, NULL, NULL, 0),
(1, 'KikiAgri', 'kiki@agri.co.za', '0315478895', '0822217458', '2014-10-26 00:00:00.000', NULL, NULL, 2, NULL, NULL, 0),
(1, 'Daybreak Farms', 'daybreakfarms@farmerstech.org', '0785429874', NULL, '2014-10-24 00:00:00.000', NULL, NULL, 2, NULL, NULL, 0),
(1, 'Astral Poultry', 'a@f.c', '0123456789', '0982567841', '2014-10-24 00:00:00.000', NULL, NULL,2, NULL, NULL, 0),
(1, 'Red Crest Farms', 'a@g.example.com', '0987654321', '0258147396', '2014-10-24 00:00:00.000', NULL, NULL, 2, NULL, NULL, 0),
(2, 'South African Pork', 'sapork@farmers.co.za', '0789654265', NULL, '2014-10-14 00:00:00.000', NULL, NULL, 2, NULL, NULL, 0),
(2, 'Happy Hog', 'happyhog@farmers.co.za', '0124587925', NULL, '2014-10-14 00:00:00.000', NULL, NULL, 2, NULL, NULL, 0),
(2, 'Glen Oakes Pig Farm', 'glen@farmers.co.za', '0119764382', NULL, '2014-10-17 00:00:00.000', NULL, NULL, 2, NULL, NULL, 0),
(2, 'Kolbroek Pigs', 'kolbroek@farmers.co.za', '0797539987', NULL, '2014-10-15 00:00:00.000', NULL, NULL, 2, NULL, NULL, 0),
(2, 'Estcourt', 'eskort@farmers.co.za', '0899965485', NULL, '2014-09-25 00:00:00.000', NULL, NULL, 2, NULL, NULL, 0),
(2, 'Example 11', '11@example.co.za', '0123456789', NULL, '2015-01-01 00:00:00.000', NULL, NULL, 2, NULL, NULL, 0),
(2, 'Example 12', '12@example.co.za', '0123456789', NULL, '2015-01-01 00:00:00.000', NULL, NULL, 2, NULL, NULL, 0),
(2, 'Example 13', '13@example.co.za', '0123456789', NULL, '2015-01-01 00:00:00.000', NULL, NULL, 2, NULL, NULL, 0)

insert into AddressType values
('Postal', 'Address for billing, and post'),
('Delivery', 'Address at which deliveries are made')

insert into [Address] values
(1, 2, 3201, 'Address 1', 'Address 2', 'Address 3', 'City', 'Country', '25 October 2014', null, null, 2, null, null, 0),
(5, 2, 3201, 'Address 1', 'Address 2', 'Address 3', 'City', 'Country', '25 October 2014', null, null, 2, null, null, 0),
(7, 2, 3201, 'Address 1', 'Address 2', 'Address 3', 'City', 'Country', '25 October 2014', null, null, 2, null, null, 0),
(10, 2, 3201, 'Address 1', 'Address 2', 'Address 3', 'City', 'Country', '25 October 2014', null, null, 2, null, null, 0),
(12, 2, 3201, 'Address 1', 'Address 2', 'Address 3', 'City', 'Country', '25 October 2014', null, null, 2, null, null, 0),
(13, 2, 3201, 'Address 1', 'Address 2', 'Address 3', 'City', 'Country', '25 October 2014', null, null, 2, null, null, 0),
(14, 2, 3201, 'Address 1', 'Address 2', 'Address 3', 'City', 'Country', '25 October 2014', null, null, 2, null, null, 0),
(15, 2, 3201, 'Address 1', 'Address 2', 'Address 3', 'City', 'Country', '25 October 2014', null, null, 2, null, null, 0),
(16, 2, 3201, 'Address 1', 'Address 2', 'Address 3', 'City', 'Country', '25 October 2014', null, null, 2, null, null, 0),
(17, 2, 3201, 'Address 1', 'Address 2', 'Address 3', 'City', 'Country', '25 October 2014', null, null, 2, null, null, 0),
(18, 2, 3201, 'Address 1', 'Address 2', 'Address 3', 'City', 'Country', '25 October 2014', null, null, 2, null, null, 0),
(19, 2, 3201, 'Address 1', 'Address 2', 'Address 3', 'City', 'Country', '25 October 2014', null, null, 2, null, null, 0),
(20, 2, 3201, 'Address 1', 'Address 2', 'Address 3', 'City', 'Country', '25 October 2014', null, null, 2, null, null, 0)

insert into StockLog values
(1, 25, '25 October 2014', null, null, 2, null, null, 0),
(1, -10, '25 October 2014', null, null, 2, null, null, 0),
(1, 300, '25 October 2014', null, null, 2, null, null, 0),
(1, -200, '25 October 2014', null, null, 2, null, null, 0),
(1, 25, '25 October 2014', null, null, 2, null, null, 0),
(1, 25, '25 October 2014', null, null, 2, null, null, 0),
(1, 25, '25 October 2014', null, null, 2, null, null, 0),
(1, 25, '25 October 2014', null, null, 2, null, null, 0),
(1, -25, '25 October 2014', null, null, 2, null, null, 0),
(1, -25, '25 October 2014', null, null, 2, null, null, 0),
(1, 25, '25 October 2014', null, null, 2, null, null, 0),
(1, 25, '25 October 2014', null, null, 2, null, null, 0),
(1, 25, '25 October 2014', null, null, 2, null, null, 0)

insert into [Order] values
(1, 2, 'https://www.google.co.za/maps/@-26.0785162,27.9248972,17z', '31 October 2014 15:00', 0, '27 October 2014 14:52', null, null, 2, null, null, 0, 1, 9),
(10, 5, 'https://www.google.co.za/maps/@-29.6302854,30.350979,17z', '28 October 2014 14:00', 1, '23 October 2014', null, null, 2, null, null, 0, 1, 11),
(13, 7, 'https://www.google.co.za/maps/@-29.6016323,30.6544763,17z', '2 November 2014 09:00', 0, '28 September 2014', null, null, 2, null, null, 0, 1, 16),
(17, 11, 'https://www.google.co.za/maps/@-28.9884729,29.8700332,17z', '31 October 2014 10:00', 0, '30 October 2014', null, null, 2, null, null, 0, 1, 17)
