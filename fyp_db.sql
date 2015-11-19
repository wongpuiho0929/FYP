-- phpMyAdmin SQL Dump
-- version 4.2.7.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Nov 18, 2015 at 08:06 AM
-- Server version: 5.6.20
-- PHP Version: 5.5.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `fyp_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `account`
--

CREATE TABLE IF NOT EXISTS `account` (
  `userName` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL,
  `position` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `account`
--

INSERT INTO `account` (`userName`, `password`, `position`) VALUES
('admin', 'admin', 'manager'),
('S0001', 'admin', 'staff'),
('tommy', 'tommy', 'staff'),
('tommy1', 'tommy', 'staff'),
('tommy2', 'tommy', 'staff'),
('tommy3', 'tommy', 'staff');

-- --------------------------------------------------------

--
-- Table structure for table `food`
--

CREATE TABLE IF NOT EXISTS `food` (
  `FID` varchar(30) NOT NULL,
  `name` varchar(30) CHARACTER SET big5 NOT NULL,
  `price` double NOT NULL,
  `isshow` varchar(1) NOT NULL DEFAULT 'Y',
  `type` varchar(30) NOT NULL,
  `isFreeDrink` varchar(1) NOT NULL DEFAULT 'N',
  `addValue` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `food`
--

INSERT INTO `food` (`FID`, `name`, `price`, `isshow`, `type`, `isFreeDrink`, `addValue`) VALUES
('F0001', '香濃咖喱牛腩飯', 30, 'Y', 'rice', 'N', 0),
('F0002', '香濃咖喱雞飯', 30, 'Y', 'rice', 'N', 0),
('F0003', '即磨咖啡', 10, 'Y', 'drink', 'N', 0),
('F0004', '茶', 10, 'Y', 'drink', 'N', 0),
('F0005', '蛋包飯', 30, 'N', 'rice', 'N', 0),
('F0006', '南瓜杯子小蛋糕', 0, 'Y', 'mix', 'N', 0);

-- --------------------------------------------------------

--
-- Table structure for table `order`
--

CREATE TABLE IF NOT EXISTS `order` (
  `orderId` varchar(30) NOT NULL,
  `sId` varchar(30) NOT NULL,
  `orderDate` date NOT NULL,
  `expectedTime` date NOT NULL,
  `status` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `ordermenu`
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
-- Table structure for table `studnet`
--

CREATE TABLE IF NOT EXISTS `studnet` (
  `Sid` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL,
  `balance` double NOT NULL,
  `email` varchar(30) NOT NULL,
  `status` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `account`
--
ALTER TABLE `account`
 ADD PRIMARY KEY (`userName`);

--
-- Indexes for table `food`
--
ALTER TABLE `food`
 ADD PRIMARY KEY (`FID`), ADD UNIQUE KEY `FID` (`FID`), ADD KEY `FID_3` (`FID`), ADD FULLTEXT KEY `FID_2` (`FID`);

--
-- Indexes for table `order`
--
ALTER TABLE `order`
 ADD PRIMARY KEY (`orderId`);

--
-- Indexes for table `studnet`
--
ALTER TABLE `studnet`
 ADD PRIMARY KEY (`Sid`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
