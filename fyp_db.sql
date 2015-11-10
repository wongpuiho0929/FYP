
-- 資料表結構 `account`

CREATE TABLE IF NOT EXISTS `account` (
  `userName` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL,
  `position` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;



--
-- 資料表結構 `menu`
--

CREATE TABLE IF NOT EXISTS `menu` (
  `menuID` varchar(30) NOT NULL,
  `name` varchar(30) NOT NULL,
  `price` double NOT NULL,
  `qty` int(30) NOT NULL,
  `isShow` boolean NOT NULL,
  `type` varchar(30) NOT NULL,
  `ingredientValue` double NOT NULL,
  `specialPrice` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- 資料表結構 `order`
--

CREATE TABLE IF NOT EXISTS `order` (
  `orderId` varchar(30) NOT NULL,
  `sId` varchar(30) NOT NULL,
  `orderDate` date NOT NULL,
  `expectedTime` date NOT NULL,
  `status` boolean NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- 資料表結構 `ordermenu`
--

CREATE TABLE IF NOT EXISTS `ordermenu` (
  `orderID` varchar(30) NOT NULL,
  `menuID` varchar(30) NOT NULL,
  `orderDate` date NOT NULL,
  `qty` int(10) NOT NULL,
  `price` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- 資料表結構 `studnet`
--

CREATE TABLE IF NOT EXISTS `studnet` (
  `Sid` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL,
  `balance` double NOT NULL,
  `email` varchar(30) NOT NULL,
  `status` boolean NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


--
-- 資料表索引 `account`
--
ALTER TABLE `account`
 ADD PRIMARY KEY (`userName`);

--
-- 資料表索引 `order`
--
ALTER TABLE `order`
 ADD PRIMARY KEY (`orderId`);

--
-- 資料表索引 `studnet`
--
ALTER TABLE `studnet`
 ADD PRIMARY KEY (`Sid`);
 
 
 ALTER TABLE `menu`
 ADD PRIMARY KEY (`menuID`);

