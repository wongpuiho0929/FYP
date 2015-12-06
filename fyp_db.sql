-- db name :fyp_db --
DROP TABLE IF EXISTS `menuFood`;
DROP TABLE IF EXISTS `food`;
DROP TABLE IF EXISTS `orderFood`;
DROP TABLE IF EXISTS `orders`;
DROP TABLE IF EXISTS `menu`;
DROP TABLE IF EXISTS `stuHistory`;
DROP TABLE IF EXISTS `student`;
DROP TABLE IF EXISTS `staff`;

-- create table --
CREATE TABLE `staff`(
	`username` varchar(20) NOT NULL,
	`password` varchar(30) NOT NULL,
	`position` varchar(10) NOT NULL,
	`name` varchar(30) NOT NULL,
	PRIMARY KEY (`username`)
);
CREATE TABLE `student`(
	`stuId` varchar(10) NOT NULL,
	`password` varchar(30) NOT NULL,
	`balance` numeric(5,2) NOT NULL DEFAULT 0,
	`email` varchar(30) NOT NULL,
	`status` varchar(10) NOT NULL DEFAULT 'processing',
	PRIMARY KEY (`stuId`)
);
CREATE TABLE `stuHistory`(
	`stuId` varchar(10) NOT NULL,
	`action` varchar(10) NOT NULL,
	`balance` integer NOT NULL
);
CREATE TABLE `orders`(
	`orderDate` date NOT NULL,
	`orderId` varchar(10) NOT NULL,
	`stuId` varchar(10) NOT NULL,
	`oTakeTime` time NOT NULL,
	`takeTime` time NULL,
	`status` varchar(10) NOT NULL,
	`totalPrice` numeric(5,2) NOT NULL,
	`menuId` varchar(10) NOT NULL,
	PRIMARY KEY (`orderDate`,`orderId`)
);
CREATE TABLE `orderFood`(
	`orderDate` date NOT NULL,
	`orderId` varchar(10) NOT NULL,
	`foodId` varchar(10) NOT NULL,
	`price` numeric(5,2)
);
CREATE TABLE `food`(
	`foodId` varchar(10) NOT NULL,
	`name` varchar(30) NOT NULL,
	`price` numeric(5,2) NOT NULL,
	`sPrice` numeric(5,2) NOT NULL,
	`qty` integer NOT NULL,
	`dQty` integer NOT NULL,
	`type`  varchar(10) NOT NULL,
	`isShow` varchar(1) NOT NULL,
	PRIMARY KEY(`foodId`)
);
CREATE TABLE `menu`(
	`menuId` varchar(10) NOT NULL,
	`name` varchar(30) NOT NULL,
	`price` numeric(5,2) NULL,
	`isShow` varchar(1) NOT NULL,
	PRIMARY KEY(`menuId`)
);
CREATE TABLE `menuFood`(
	`menuId` varchar(10) NOT NULL,
	`type` varchar(10) NOT NULL,
	`many` integer NOT NULL DEFAULT 1
);
ALTER TABLE `stuHistory`
ADD CONSTRAINT `stuIdH_fk1` FOREIGN KEY(`stuId`) REFERENCES `student`(`stuId`)
;
ALTER TABLE `orders`
ADD CONSTRAINT `stuIdH_fk2` FOREIGN KEY(`stuId`) REFERENCES `student`(`stuId`),
ADD CONSTRAINT `menuId_fk1` FOREIGN KEY(`menuId`) REFERENCES `menu`(`menuId`)
;
ALTER TABLE `menuFood`
ADD CONSTRAINT `menuId_fk2` FOREIGN KEY(`menuId`) REFERENCES `menu`(`menuId`)
;
ALTER TABLE `orderFood`
ADD CONSTRAINT `orderDate_fk1` FOREIGN KEY(`orderDate`, `orderId`) REFERENCES `orders`(`orderDate`, `orderId`),
ADD CONSTRAINT `foodId_fk1` FOREIGN KEY(`foodId`) REFERENCES `food`(`foodId`)
;
-- end create table --

-- add data --
INSERT INTO `student` (`stuId`, `password`, `balance`, `email`, `status`) VALUES
('140476338', '140476338', '99999', 'a@a.com', 'approve'),
('092141446', '092141446', '99999', 'a@a.com', 'processing')
;
INSERT INTO `staff` (`username`, `password`, `position`, `name`) VALUES
('admin', 'admin', 'manager', 'admin'),
('tommy', 'tommy', 'staff', 'tommy')
;
INSERT INTO `food` (`foodId`, `name`, `price`, `sPrice`, `qty`, `dQty`, `type`, `isShow`) VALUES
('F00000001', '香濃咖喱牛腩飯', 30, 0, 100, 100, 'Rice', 'Y'),
('F00000002', '香濃咖喱雞飯', 30, 0, 100, 100, 'Rice', 'Y'),
('F00000003', '即磨咖啡', 12, 0, 100, 100, 'Drink', 'Y'),
('F00000004', '凍檸茶', 15, 3, 100, 100, 'Drink', 'Y'),
('F00000005', '紅豆冰', 18, 8, 100, 100, 'Drink', 'Y'),
('F00000006', '叉燒', 30, 0, 100, 100, 'Batching', 'Y'),
('F00000007', '燒鴨', 30, 0, 100, 100, 'Batching', 'Y'),
('F00000008', '燒肉', 30, 0, 100, 100, 'Batching', 'Y'),
('F00000009', '雞', 30, 0, 100, 100, 'Batching', 'Y')
;
INSERT INTO `Menu` (`menuId`, `name`, `price`, `isShow`) VALUES
('M000000001', '飯類', null, 'Y'),
('M000000002', '飲品', null, 'Y'),
('M000000003', '套餐', null, 'Y'),
('M000000004', '雙餸飯', null, 'Y'),
('M000000005', '雙餸飯套餐', null, 'Y')
;
INSERT INTO `menuFood` (`menuId`, `type`, `many`) VALUES
('M000000001', 'Rice', 1),
('M000000002', 'Drink', 1),
('M000000003', 'Rice', 1),
('M000000003', 'Drink', 1),
('M000000004', 'Batching', 2),
('M000000005', 'Batching', 2),
('M000000005', 'Drink', 1)
;
-- end add data --