-- db name :fyp_db --
SET FOREIGN_KEY_CHECKS=0;
DROP TABLE IF EXISTS `menuFood`;
DROP TABLE IF EXISTS `orderFood`;
DROP TABLE IF EXISTS `food`;
DROP TABLE IF EXISTS `orders`;
DROP TABLE IF EXISTS `menu`;
DROP TABLE IF EXISTS `staff`;
DROP TABLE IF EXISTS `stuHistory`;
DROP TABLE IF EXISTS `student`;
DROP TABLE IF EXISTS `menuCategory`;
DROP TABLE IF EXISTS `foodType`;
SET FOREIGN_KEY_CHECKS=1;

-- create table --
CREATE TABLE `staff`(
	`username` varchar(20) NOT NULL,
	`password` varchar(30) NOT NULL,
	`position` varchar(10) NOT NULL,
	`name` varchar(30) NOT NULL,
	PRIMARY KEY (`username`)
) CHARACTER SET = utf8;
CREATE TABLE `student`(
	`stuId` varchar(10) NOT NULL,
	`password` varchar(30) NOT NULL,
	`name` varchar(30) NOT NULL,
	`balance` numeric(5,1) NOT NULL DEFAULT 0,
	`email` varchar(30) NOT NULL,
	`status` varchar(10) NOT NULL DEFAULT 'processing',
	PRIMARY KEY (`stuId`)
) CHARACTER SET = utf8;
CREATE TABLE `stuHistory`(
	`datetime` datetime NOT NULL,
	`stuId` varchar(10) NOT NULL,
	`action` varchar(10) NOT NULL,
	`balance` integer NOT NULL
) CHARACTER SET = utf8;
CREATE TABLE `orders`(
	`orderDate` date NOT NULL,
	`orderId` varchar(10) NOT NULL,
	`stuId` varchar(10) NOT NULL,
	`oTakeTime` time NOT NULL,
	`takeTime` time NULL,
	`status` varchar(10) NOT NULL DEFAULT 'processing',
	`totalPrice` numeric(5,1) NOT NULL,
	`menuId` varchar(10) NULL,
	PRIMARY KEY (`orderDate`,`orderId`)
) CHARACTER SET = utf8;
CREATE TABLE `food`(
	`foodId` varchar(10) NOT NULL,
	`name` varchar(70) NOT NULL,
	`shortName` varchar(50) NOT NULL,
	`price` numeric(5,1) NOT NULL,
	`sPrice` numeric(5,1) NOT NULL,
	`img` varchar(50) NULL,
	`qty` integer NOT NULL,
	`dQty` integer NOT NULL,
	`fTypeId`  varchar(10) NOT NULL,
	`isShow` varchar(1) NOT NULL DEFAULT 'Y',
	PRIMARY KEY(`foodId`)
) CHARACTER SET = utf8;
CREATE TABLE `orderFood`(
	`orderDate` date NOT NULL,
	`orderId` varchar(10) NOT NULL,
	`foodId` varchar(10) NOT NULL,
	`price` numeric(5,1) NOT NULL,
	`sprice` numeric(5,1) NOT NULL
) CHARACTER SET = utf8;
CREATE TABLE `menu`(
	`menuId` varchar(10) NOT NULL,
	`name` varchar(70) NOT NULL,
	`shortName` varchar(50) NOT NULL,
	`price` numeric(5,1) NULL,
	`img` varchar(50) NULL,
	`mCateId` varchar(10) NOT NULL,
	`isShow` varchar(1) NOT NULL DEFAULT 'Y',
	PRIMARY KEY(`menuId`)
) CHARACTER SET = utf8;
CREATE TABLE `menuFood`(
	`menuId` varchar(10) NOT NULL,
	`fTypeId` varchar(10) NOT NULL,
	`many` integer NOT NULL DEFAULT 1
) CHARACTER SET = utf8;
CREATE TABLE `menuCategory`(
	`mCateId` varchar(10) NOT NULL,
	`img` varchar(50) NULL,
	`name` varchar(50) NOT NULL,
	`isShow` varchar(1) NOT NULL DEFAULT 'Y',
	PRIMARY KEY(`mCateId`)
) CHARACTER SET = utf8;
CREATE TABLE `foodType`(
	`fTypeId` varchar(10) NOT NULL,
	`name` varchar(20) NOT NULL,
	PRIMARY KEY(`fTypeId`)
) CHARACTER SET = utf8;
ALTER TABLE `stuHistory`
ADD CONSTRAINT `stuIdH_fk1` FOREIGN KEY(`stuId`) REFERENCES `student`(`stuId`)
;
ALTER TABLE `orders`
ADD CONSTRAINT `stuIdH_fk2` FOREIGN KEY(`stuId`) REFERENCES `student`(`stuId`),
ADD CONSTRAINT `menuId_fk1` FOREIGN KEY(`menuId`) REFERENCES `menu`(`menuId`)
;
ALTER TABLE `menuFood`
ADD CONSTRAINT `menuId_fk2` FOREIGN KEY(`menuId`) REFERENCES `menu`(`menuId`),
ADD CONSTRAINT `fType_fk1` FOREIGN KEY(`fTypeId`) REFERENCES `foodType`(`fTypeId`)
;
ALTER TABLE `orderFood`
ADD CONSTRAINT `orderDate_fk1` FOREIGN KEY(`orderDate`, `orderId`) REFERENCES `orders`(`orderDate`, `orderId`),
ADD CONSTRAINT `foodId_fk1` FOREIGN KEY(`foodId`) REFERENCES `food`(`foodId`)
;
ALTER TABLE `food`
ADD CONSTRAINT `fType_fk2` FOREIGN KEY(`fTypeId`) REFERENCES `foodType`(`fTypeId`)
;
ALTER TABLE `menu`
ADD CONSTRAINT `mCate_fk1` FOREIGN KEY(`mCateId`) REFERENCES `menuCategory`(`mCateId`)
;
-- end create table --

-- add data --
INSERT INTO `student` (`stuId`, `password`, `name`, `balance`, `email`, `status`) VALUES
('140476338', '140476338', 'fung', '99999', 'a@a.com', 'approve'),
('092141446', '092141446', 'tom', '99999', 'a@a.com', 'processing'),
('140377481', 'tom', 'tom', '550.00', 'tom@gmail.com', 'approve'),
('140377482', 'GF', 'GF', '100.00', 'gf@gmail.com', 'approve'),
('140377483', 'Jason', 'Jason', '0.00', 'Jason@gmail.com', 'processing'),
('140377489', 'tommy', 'wong pui ho', '50.00', 'wongpuiho@gmail.com', 'approve')
;
INSERT INTO `staff` (`username`, `password`, `position`, `name`) VALUES
('admin', 'admin', 'manager', 'admin'),
('tommy', 'tommy', 'staff', 'tommy')
;
INSERT INTO `foodType`(`fTypeId`, `name`) VALUES
('FT00000001', 'Rice'),
('FT00000002', 'Drink'),
('FT00000003', 'Batching'),
('FT00000004', 'siu mei Batching')
;
INSERT INTO `food` (`foodId`, `name`, `shortName`, `price`, `sPrice`, `qty`, `dQty`, `fTypeId`) VALUES
('F00000001', '香濃咖喱牛腩飯(Fragrant curry beef brisket rice)', '咖喱牛腩飯', 30, 0, 100, 100, 'FT00000001'),
('F00000002', '香濃咖喱雞飯(Fragrant curry chicken)', '咖喱雞飯', 30, 0, 100, 100, 'FT00000001'),
('F00000003', '即磨咖啡(ground coffee)', '啡', 12, 0, 100, 100, 'FT00000002'),
('F00000004', '凍檸茶(Ice lemon tea)', 'ILT', 15, 3, 100, 100, 'FT00000002'),
('F00000005', '紅豆冰(Red bean ice)', '紅豆冰', 18, 8, 100, 100, 'FT00000002'),
('F00000006', '叉燒(Barbecue pork)', '叉', 30, 0, 100, 100, 'FT00000004'),
('F00000007', '燒鴨(Roast duck)', '鴨', 30, 0, 100, 100, 'FT00000004'),
('F00000008', '燒肉(Roasted pork)', '燒肉', 30, 0, 100, 100, 'FT00000004'),
('F00000009', '切雞(Cut chicken)', '雞', 30, 0, 100, 100, 'FT00000004')
;
INSERT INTO `menuCategory`(`mCateId`, `name`) VALUES
('MC00000001', '正價(Regular price)'),
('MC00000002', '飯類(Rice Category)'),
('MC00000003', '燒味(siu mei)')
;
INSERT INTO `Menu` (`menuId`, `name`, `shortName`, `price`, `mCateId`) VALUES
('M00000001', '飯類(Rice Category)', '反', null, 'MC00000001'),
('M00000002', '飲品(Drink Category)', '飲', null, 'MC00000001'),
('M00000003', '套餐(Set rice)', '套餐', 30, 'MC00000002'),
('M00000004', '雙餸燒味飯(siu mei rice with two choices of sides)', '雙燒味飯', 25, 'MC00000003'),
('M00000005', '雙餸燒味飯套餐(Set of siu mei rice with two choices of sides)', '雙燒味飯(餐)', 30, 'MC00000003')
;
INSERT INTO `menuFood` (`menuId`, `fTypeId`, `many`) VALUES
('M00000001', 'FT00000001', 1),
('M00000002', 'FT00000002', 1),
('M00000003', 'FT00000001', 1),
('M00000003', 'FT00000002', 1),
('M00000004', 'FT00000004', 2),
('M00000005', 'FT00000004', 2),
('M00000005', 'FT00000002', 1)
;
-- end add data --

-- add test image --
UPDATE `menuCategory` SET `img`='image/test.png' WHERE `mCateId`='MC00000001';
UPDATE `menu` SET `img` = 'image/test.png' WHERE `menuId` = 'M00000001';

UPDATE `food` SET `img` = 'image/F00000001.jpg' WHERE `foodId` = 'F00000001';
UPDATE `food` SET `img` = 'image/F00000002.jpg' WHERE `foodId` = 'F00000002';
UPDATE `food` SET `img` = 'image/F00000003.jpg' WHERE `foodId` = 'F00000003';
UPDATE `food` SET `img` = 'image/F00000004.jpg' WHERE `foodId` = 'F00000004';
UPDATE `food` SET `img` = 'image/F00000005.jpg' WHERE `foodId` = 'F00000005';
UPDATE `food` SET `img` = 'image/F00000006.jpg' WHERE `foodId` = 'F00000006';
UPDATE `food` SET `img` = 'image/F00000007.jpg' WHERE `foodId` = 'F00000007';
UPDATE `food` SET `img` = 'image/F00000008.jpg' WHERE `foodId` = 'F00000008';
UPDATE `food` SET `img` = 'image/F00000009.jpg' WHERE `foodId` = 'F00000009';









--get menu--
-- SELECT M.menuId,M.name,M.price,M.img,
-- GROUP_CONCAT(CONCAT(' ',FT.name,' x ',MF.many)) 'content' 
-- FROM menu M, menufood MF, foodtype FT, menuCategory MC 
-- WHERE M.menuId=MF.menuId AND MF.fTypeId=FT.fTypeId AND M.mCateId=MC.mCateId
-- AND M.isShow='Y' AND MC.isShow='Y'
-- GROUP BY M.menuId;

-- --add order--
-- BEGIN;
-- UPDATE food SET qty-1 WHERE foodId='F00000001';
-- --re--
-- UPDATE food SET qty-1 WHERE foodId='F00000005';
-- --re--

-- INSERT INTO orders (orderDate, orderId, stuId, oTakeTime, totalPrice, menuId) 
-- VALUES(CURDATE(), 'O00000001', '140476338', '11:00', 38, 'M00000003');
-- INSERT INTO orders (orderDate, orderId, stuId, oTakeTime, totalPrice, menuId)
-- VALUES(CURDATE(), 'O00000001', '140476338', '11:00', (SELECT price FROM menu WHERE menuId='M00000003')+8.0, 'menuId'

-- INSERT INTO orderFood (orderDate, orderId, foodId, price,sprice)
-- VALUES(CURDATE(), 'O00000001', 'F00000001',(SELECT price FROM food WHERE foodID='F00000001'),(SELECT sprice FROM food WHERE foodID='F00000001')),
-- (CURDATE(), 'O00000001', 'F00000005',(SELECT price FROM food WHERE foodID='F00000005'),(SELECT sprice FROM food WHERE foodID='F00000005'));

-- SELECT SUM(price), SUM(sprice) FROM food WHERE foodID='F00000001' OR foodId='F00000005';


-- --add order
-- UPDATE student SET balance=balance-(SELECT price FROM menu WHERE menuId='M00000003')-8 
-- WHERE stuId='140476338' AND balance-8-(SELECT price FROM menu WHERE menuId='M00000003')>=0;

-- INSERT INTO orders (orderDate, orderId, stuId, oTakeTime, totalPrice, menuId) VALUES
-- (CURDATE(), 'O00000001', '140476338', '11:00', ((SELECT price FROM menu WHERE menuId='M00000003')+8), 'M00000003');

-- INSERT INTO orderFood (orderDate, orderId, foodId, price,sprice) VALUES
-- (CURDATE(), 'O00000001', 'F00000001', (SELECT price FROM food WHERE foodID='F00000001'),(SELECT sprice FROM food WHERE foodID='F00000001')),
-- (CURDATE(), 'O00000001', 'F00000005', (SELECT price FROM food WHERE foodID='F00000005'),(SELECT sprice FROM food WHERE foodID='F00000005'));
-- ----

SELECT * FROM orders O, orderfood OF, food F, foodtype FT, menu M WHERE O.orderDate=OF.orderDate AND O.orderId=OF.orderId AND OF.foodId=F.foodId AND F.fTypeId=FT.fTypeId AND O.menuId=M.menuId AND O.orderId='O00000001' AND O.orderDate=CURDATE();