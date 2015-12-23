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
	`menuId` varchar(10) NOT NULL,
	PRIMARY KEY (`orderDate`,`orderId`)
) CHARACTER SET = utf8;
CREATE TABLE `food`(
	`foodId` varchar(10) NOT NULL,
	`name` varchar(70) NOT NULL,
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
('140377489', 'tommy', 'wong pui ho', '50.00', 'wongpuiho@gmail.com', 'approve'),
('140377490', '8888', 'Student0', '0.00', 'Student0@gmail.com', 'processing'),
('140377491', '8888', 'Student1', '0.00', 'Student1@gmail.com', 'processing'),
('140377492', '8888', 'Student2', '0.00', 'Student2@gmail.com', 'processing'),
('140377493', '8888', 'Student3', '0.00', 'Student3@gmail.com', 'processing'),
('140377494', '8888', 'Student4', '0.00', 'Student4@gmail.com', 'processing'),
('140377495', '8888', 'Student5', '0.00', 'Student5@gmail.com', 'processing'),
('140377496', '8888', 'Student6', '0.00', 'Student6@gmail.com', 'processing'),
('140377497', '8888', 'Student7', '0.00', 'Student7@gmail.com', 'processing'),
('140377498', '8888', 'Student8', '0.00', 'Student8@gmail.com', 'processing'),
('140377499', '8888', 'Student9', '0.00', 'Student9@gmail.com', 'processing'),
('140377500', '8888', 'Student10', '0.00', 'Student10@gmail.com', 'processing'),
('140377501', '8888', 'Student11', '0.00', 'Student11@gmail.com', 'processing'),
('140377502', '8888', 'Student12', '0.00', 'Student12@gmail.com', 'processing'),
('140377503', '8888', 'Student13', '0.00', 'Student13@gmail.com', 'processing'),
('140377504', '8888', 'Student14', '0.00', 'Student14@gmail.com', 'processing'),
('140377505', '8888', 'Student15', '0.00', 'Student15@gmail.com', 'processing'),
('140377506', '8888', 'Student16', '0.00', 'Student16@gmail.com', 'processing'),
('140377507', '8888', 'Student17', '0.00', 'Student17@gmail.com', 'processing'),
('140377508', '8888', 'Student18', '0.00', 'Student18@gmail.com', 'processing'),
('140377509', '8888', 'Student19', '0.00', 'Student19@gmail.com', 'processing'),
('140377510', '8888', 'Student20', '0.00', 'Student20@gmail.com', 'processing'),
('140377511', '8888', 'Student21', '0.00', 'Student21@gmail.com', 'processing'),
('140377512', '8888', 'Student22', '0.00', 'Student22@gmail.com', 'processing'),
('140377513', '8888', 'Student23', '0.00', 'Student23@gmail.com', 'processing'),
('140377514', '8888', 'Student24', '0.00', 'Student24@gmail.com', 'processing'),
('140377515', '8888', 'Student25', '0.00', 'Student25@gmail.com', 'processing'),
('140377516', '8888', 'Student26', '0.00', 'Student26@gmail.com', 'processing'),
('140377517', '8888', 'Student27', '0.00', 'Student27@gmail.com', 'processing'),
('140377518', '8888', 'Student28', '0.00', 'Student28@gmail.com', 'processing'),
('140377519', '8888', 'Student29', '0.00', 'Student29@gmail.com', 'processing'),
('140377520', '8888', 'Student30', '0.00', 'Student30@gmail.com', 'processing'),
('140377521', '8888', 'Student31', '0.00', 'Student31@gmail.com', 'processing'),
('140377522', '8888', 'Student32', '0.00', 'Student32@gmail.com', 'processing'),
('140377523', '8888', 'Student33', '0.00', 'Student33@gmail.com', 'processing'),
('140377524', '8888', 'Student34', '0.00', 'Student34@gmail.com', 'processing'),
('140377525', '8888', 'Student35', '0.00', 'Student35@gmail.com', 'processing'),
('140377526', '8888', 'Student36', '0.00', 'Student36@gmail.com', 'processing'),
('140377527', '8888', 'Student37', '0.00', 'Student37@gmail.com', 'processing'),
('140377528', '8888', 'Student38', '0.00', 'Student38@gmail.com', 'processing'),
('140377529', '8888', 'Student39', '0.00', 'Student39@gmail.com', 'processing'),
('140377530', '8888', 'Student40', '0.00', 'Student40@gmail.com', 'processing'),
('140377531', '8888', 'Student41', '0.00', 'Student41@gmail.com', 'processing'),
('140377532', '8888', 'Student42', '0.00', 'Student42@gmail.com', 'processing'),
('140377533', '8888', 'Student43', '0.00', 'Student43@gmail.com', 'processing'),
('140377534', '8888', 'Student44', '0.00', 'Student44@gmail.com', 'processing'),
('140377535', '8888', 'Student45', '0.00', 'Student45@gmail.com', 'processing'),
('140377536', '8888', 'Student46', '0.00', 'Student46@gmail.com', 'processing'),
('140377537', '8888', 'Student47', '0.00', 'Student47@gmail.com', 'processing'),
('140377538', '8888', 'Student48', '0.00', 'Student48@gmail.com', 'processing'),
('140377539', '8888', 'Student49', '0.00', 'Student49@gmail.com', 'processing'),
('140377540', '8888', 'Student50', '0.00', 'Student50@gmail.com', 'processing'),
('140377541', '8888', 'Student51', '0.00', 'Student51@gmail.com', 'processing'),
('140377542', '8888', 'Student52', '0.00', 'Student52@gmail.com', 'processing'),
('140377543', '8888', 'Student53', '0.00', 'Student53@gmail.com', 'processing'),
('140377544', '8888', 'Student54', '0.00', 'Student54@gmail.com', 'processing'),
('140377545', '8888', 'Student55', '0.00', 'Student55@gmail.com', 'processing'),
('140377546', '8888', 'Student56', '0.00', 'Student56@gmail.com', 'processing'),
('140377547', '8888', 'Student57', '0.00', 'Student57@gmail.com', 'processing'),
('140377548', '8888', 'Student58', '0.00', 'Student58@gmail.com', 'processing'),
('140377549', '8888', 'Student59', '0.00', 'Student59@gmail.com', 'processing'),
('140377550', '8888', 'Student60', '0.00', 'Student60@gmail.com', 'processing'),
('140377551', '8888', 'Student61', '0.00', 'Student61@gmail.com', 'processing'),
('140377552', '8888', 'Student62', '0.00', 'Student62@gmail.com', 'processing'),
('140377553', '8888', 'Student63', '0.00', 'Student63@gmail.com', 'processing'),
('140377554', '8888', 'Student64', '0.00', 'Student64@gmail.com', 'processing'),
('140377555', '8888', 'Student65', '0.00', 'Student65@gmail.com', 'processing'),
('140377556', '8888', 'Student66', '0.00', 'Student66@gmail.com', 'processing'),
('140377557', '8888', 'Student67', '0.00', 'Student67@gmail.com', 'processing'),
('140377558', '8888', 'Student68', '0.00', 'Student68@gmail.com', 'processing'),
('140377559', '8888', 'Student69', '0.00', 'Student69@gmail.com', 'processing'),
('140377560', '8888', 'Student70', '0.00', 'Student70@gmail.com', 'processing'),
('140377561', '8888', 'Student71', '0.00', 'Student71@gmail.com', 'processing'),
('140377562', '8888', 'Student72', '0.00', 'Student72@gmail.com', 'processing'),
('140377563', '8888', 'Student73', '0.00', 'Student73@gmail.com', 'processing'),
('140377564', '8888', 'Student74', '0.00', 'Student74@gmail.com', 'processing'),
('140377565', '8888', 'Student75', '0.00', 'Student75@gmail.com', 'processing'),
('140377566', '8888', 'Student76', '0.00', 'Student76@gmail.com', 'processing'),
('140377567', '8888', 'Student77', '0.00', 'Student77@gmail.com', 'processing'),
('140377568', '8888', 'Student78', '0.00', 'Student78@gmail.com', 'processing'),
('140377569', '8888', 'Student79', '0.00', 'Student79@gmail.com', 'processing'),
('140377570', '8888', 'Student80', '0.00', 'Student80@gmail.com', 'processing'),
('140377571', '8888', 'Student81', '0.00', 'Student81@gmail.com', 'processing'),
('140377572', '8888', 'Student82', '0.00', 'Student82@gmail.com', 'processing'),
('140377573', '8888', 'Student83', '0.00', 'Student83@gmail.com', 'processing'),
('140377574', '8888', 'Student84', '0.00', 'Student84@gmail.com', 'processing'),
('140377575', '8888', 'Student85', '0.00', 'Student85@gmail.com', 'processing'),
('140377576', '8888', 'Student86', '0.00', 'Student86@gmail.com', 'processing'),
('140377577', '8888', 'Student87', '0.00', 'Student87@gmail.com', 'processing'),
('140377578', '8888', 'Student88', '0.00', 'Student88@gmail.com', 'processing'),
('140377579', '8888', 'Student89', '0.00', 'Student89@gmail.com', 'processing'),
('140377580', '8888', 'Student90', '0.00', 'Student90@gmail.com', 'processing'),
('140377581', '8888', 'Student91', '0.00', 'Student91@gmail.com', 'processing'),
('140377582', '8888', 'Student92', '0.00', 'Student92@gmail.com', 'processing'),
('140377583', '8888', 'Student93', '0.00', 'Student93@gmail.com', 'processing'),
('140377584', '8888', 'Student94', '0.00', 'Student94@gmail.com', 'processing'),
('140377585', '8888', 'Student95', '0.00', 'Student95@gmail.com', 'processing'),
('140377586', '8888', 'Student96', '0.00', 'Student96@gmail.com', 'processing'),
('140377587', '8888', 'Student97', '0.00', 'Student97@gmail.com', 'processing'),
('140377588', '8888', 'Student98', '0.00', 'Student98@gmail.com', 'processing'),
('140377589', '8888', 'Student99', '0.00', 'Student99@gmail.com', 'processing')
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
INSERT INTO `food` (`foodId`, `name`, `price`, `sPrice`, `qty`, `dQty`, `fTypeId`) VALUES
('F00000001', '香濃咖喱牛腩飯(Fragrant curry beef brisket rice)', 30, 0, 100, 100, 'FT00000001'),
('F00000002', '香濃咖喱雞飯(Fragrant curry chicken)', 30, 0, 100, 100, 'FT00000001'),
('F00000003', '即磨咖啡(ground coffee)', 12, 0, 100, 100, 'FT00000002'),
('F00000004', '凍檸茶(Ice lemon tea)', 15, 3, 100, 100, 'FT00000002'),
('F00000005', '紅豆冰(Red bean ice)', 18, 8, 100, 100, 'FT00000002'),
('F00000006', '叉燒(Barbecue pork)', 30, 0, 100, 100, 'FT00000004'),
('F00000007', '燒鴨(Roast duck)', 30, 0, 100, 100, 'FT00000004'),
('F00000008', '燒肉(Roasted pork)', 30, 0, 100, 100, 'FT00000004'),
('F00000009', '切雞(Cut chicken)', 30, 0, 100, 100, 'FT00000004')
;
INSERT INTO `menuCategory`(`mCateId`, `name`) VALUES
('MC00000001', '正價(Regular price)'),
('MC00000002', '飯類(Rice Category)'),
('MC00000003', '燒味(siu mei)')
;
INSERT INTO `Menu` (`menuId`, `name`, `price`, `mCateId`) VALUES
('M00000001', '飯類(Rice Category)', null, 'MC00000001'),
('M00000002', '飲品(Drink Category)', null, 'MC00000001'),
('M00000003', '套餐(Set rice)', 30, 'MC00000002'),
('M00000004', '雙餸燒味飯(siu mei rice with two choices of sides)', 25, 'MC00000003'),
('M00000005', '雙餸燒味飯套餐(Set of siu mei rice with two choices of sides)', 30, 'MC00000003')
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
UPDATE `food` SET `img` = 'image/test.png' WHERE `foodId` = 'F00000001';
UPDATE `menu` SET `img` = 'image/test.png' WHERE `menuId` = 'M00000001';

--get menu--
SELECT M.menuId,M.name,M.price,M.img,
GROUP_CONCAT(CONCAT(' ',FT.name,' x ',MF.many)) 'content' 
FROM menu M, menufood MF, foodtype FT
WHERE M.menuId=MF.menuId AND MF.fTypeId=FT.fTypeId AND M.isShow='Y'
GROUP BY M.menuId;