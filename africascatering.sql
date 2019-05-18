-- phpMyAdmin SQL Dump
-- version 4.8.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 02, 2019 at 04:10 PM
-- Server version: 10.1.34-MariaDB
-- PHP Version: 7.2.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `africascatering`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `AdminID` int(20) NOT NULL,
  `LastName` varchar(20) NOT NULL,
  `FirstName` varchar(20) NOT NULL,
  `Contact` varchar(11) NOT NULL,
  `Username` varchar(20) NOT NULL,
  `Password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`AdminID`, `LastName`, `FirstName`, `Contact`, `Username`, `Password`) VALUES
(0, 'cuizon', 'dominic', '123456', 'a', 'a');

-- --------------------------------------------------------

--
-- Table structure for table `tblcustomer`
--

CREATE TABLE `tblcustomer` (
  `custId` int(10) NOT NULL,
  `Firstname` varchar(50) NOT NULL,
  `Lastname` varchar(50) NOT NULL,
  `Contact` varchar(11) NOT NULL,
  `Gender` varchar(20) NOT NULL,
  `Type` varchar(20) NOT NULL,
  `Street` varchar(20) NOT NULL,
  `Barangay` varchar(20) NOT NULL,
  `City` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tblcustomer`
--

INSERT INTO `tblcustomer` (`custId`, `Firstname`, `Lastname`, `Contact`, `Gender`, `Type`, `Street`, `Barangay`, `City`) VALUES
(1, 'Joe', 'fdfads', '1423456456', 'gsdgf', 'fdsfds', 'sfdsf', 'ssfds', 'sfsdfds');

-- --------------------------------------------------------

--
-- Table structure for table `tblcusttransaction`
--

CREATE TABLE `tblcusttransaction` (
  `TransactionId` int(11) NOT NULL,
  `TransactionType` int(11) NOT NULL,
  `custId` int(11) NOT NULL,
  `grandTotal` int(11) NOT NULL,
  `transactionDate` int(11) NOT NULL,
  `discount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tblcusttransdetail`
--

CREATE TABLE `tblcusttransdetail` (
  `TransDetailsId` int(10) NOT NULL,
  `productId` int(10) NOT NULL,
  `rate` float NOT NULL,
  `qty` int(10) NOT NULL,
  `total` float NOT NULL,
  `customerId` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tblprodcategory`
--

CREATE TABLE `tblprodcategory` (
  `CategoryId` int(11) NOT NULL,
  `CategoryName` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tblprodcategory`
--

INSERT INTO `tblprodcategory` (`CategoryId`, `CategoryName`) VALUES
(8, 'table'),
(9, 'chairs');

-- --------------------------------------------------------

--
-- Table structure for table `tblprodsize`
--

CREATE TABLE `tblprodsize` (
  `SizeId` int(5) NOT NULL,
  `SizeName` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tblprodsize`
--

INSERT INTO `tblprodsize` (`SizeId`, `SizeName`) VALUES
(1, '2x2'),
(2, '2x4'),
(3, '2x8'),
(4, '2x9'),
(5, '2x10'),
(7, '4x4'),
(8, '4x6'),
(10, '4x7');

-- --------------------------------------------------------

--
-- Table structure for table `tblprodsub`
--

CREATE TABLE `tblprodsub` (
  `SubCatId` int(10) NOT NULL,
  `SubCategory` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tblprodsub`
--

INSERT INTO `tblprodsub` (`SubCatId`, `SubCategory`) VALUES
(1, 'Long Table'),
(2, 'Square Tables');

-- --------------------------------------------------------

--
-- Table structure for table `tblprodtype`
--

CREATE TABLE `tblprodtype` (
  `TypeId` int(5) NOT NULL,
  `TypeName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tblprodtype`
--

INSERT INTO `tblprodtype` (`TypeId`, `TypeName`) VALUES
(1, 'WOOD'),
(2, 'PLASTIC'),
(3, 'GLASS'),
(5, 'SILK');

-- --------------------------------------------------------

--
-- Table structure for table `tblproducts`
--

CREATE TABLE `tblproducts` (
  `productId` int(5) NOT NULL,
  `ProductName` varchar(30) NOT NULL,
  `Category` varchar(20) NOT NULL,
  `SubCategory` varchar(20) NOT NULL,
  `Type` varchar(20) NOT NULL,
  `Size` varchar(20) NOT NULL,
  `Unit` varchar(5) NOT NULL,
  `Rate` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tblproducts`
--

INSERT INTO `tblproducts` (`productId`, `ProductName`, `Category`, `SubCategory`, `Type`, `Size`, `Unit`, `Rate`) VALUES
(7, '', 'table', 'Long Table', 'Trick or Treat', '2', 'per s', 5);

-- --------------------------------------------------------

--
-- Table structure for table `tblprodunit`
--

CREATE TABLE `tblprodunit` (
  `UnitId` int(10) NOT NULL,
  `UnitName` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tblprodunit`
--

INSERT INTO `tblprodunit` (`UnitId`, `UnitName`) VALUES
(1, 'per set'),
(2, 'per box'),
(4, 'per piece'),
(5, 'per can'),
(7, 'per kilo');

-- --------------------------------------------------------

--
-- Table structure for table `tblsupplier`
--

CREATE TABLE `tblsupplier` (
  `supplierId` int(20) NOT NULL,
  `companyname` varchar(20) NOT NULL,
  `Type` varchar(30) NOT NULL,
  `Firstname` varchar(20) NOT NULL,
  `Lastname` varchar(20) NOT NULL,
  `Contact` varchar(20) NOT NULL,
  `Street` varchar(100) NOT NULL,
  `Barangay` varchar(50) NOT NULL,
  `City` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tblsupplier`
--

INSERT INTO `tblsupplier` (`supplierId`, `companyname`, `Type`, `Firstname`, `Lastname`, `Contact`, `Street`, `Barangay`, `City`) VALUES
(1, 'a', 'a', '', 'a', 'a', 'a', 'a', 'a'),
(3, 'a', '', 'xcx', 'xcxc', 'xcxcxc', 'xzcvzx', 'cxzxc', 'city'),
(4, '223', '1', '213', '23', '2sfdsf', '31', '31', '3123');

-- --------------------------------------------------------

--
-- Table structure for table `tblusers`
--

CREATE TABLE `tblusers` (
  `userId` int(1) NOT NULL,
  `firstname` varchar(20) NOT NULL,
  `lastname` varchar(20) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `contact` int(20) NOT NULL,
  `street` varchar(20) NOT NULL,
  `barangay` varchar(20) NOT NULL,
  `city` varchar(20) NOT NULL,
  `gender` varchar(20) NOT NULL,
  `usertype` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tblusers`
--

INSERT INTO `tblusers` (`userId`, `firstname`, `lastname`, `username`, `password`, `contact`, `street`, `barangay`, `city`, `gender`, `usertype`) VALUES
(1, 'Cherie Mhay ', 'Perez', 'admin', 'Admin', 952135, '168', '215', 'Manila', 'System.Windows.Forms', 'System.Windows.Forms'),
(3, 'Joemar', 'Bagalanon', 'user', 'user', 9875562, '178', '299', 'Balara', 'Male', 'User');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`AdminID`);

--
-- Indexes for table `tblcustomer`
--
ALTER TABLE `tblcustomer`
  ADD PRIMARY KEY (`custId`);

--
-- Indexes for table `tblcusttransaction`
--
ALTER TABLE `tblcusttransaction`
  ADD PRIMARY KEY (`TransactionId`);

--
-- Indexes for table `tblcusttransdetail`
--
ALTER TABLE `tblcusttransdetail`
  ADD PRIMARY KEY (`TransDetailsId`);

--
-- Indexes for table `tblprodcategory`
--
ALTER TABLE `tblprodcategory`
  ADD PRIMARY KEY (`CategoryId`);

--
-- Indexes for table `tblprodsize`
--
ALTER TABLE `tblprodsize`
  ADD PRIMARY KEY (`SizeId`);

--
-- Indexes for table `tblprodsub`
--
ALTER TABLE `tblprodsub`
  ADD PRIMARY KEY (`SubCatId`);

--
-- Indexes for table `tblprodtype`
--
ALTER TABLE `tblprodtype`
  ADD PRIMARY KEY (`TypeId`);

--
-- Indexes for table `tblproducts`
--
ALTER TABLE `tblproducts`
  ADD PRIMARY KEY (`productId`);

--
-- Indexes for table `tblprodunit`
--
ALTER TABLE `tblprodunit`
  ADD PRIMARY KEY (`UnitId`);

--
-- Indexes for table `tblsupplier`
--
ALTER TABLE `tblsupplier`
  ADD PRIMARY KEY (`supplierId`);

--
-- Indexes for table `tblusers`
--
ALTER TABLE `tblusers`
  ADD PRIMARY KEY (`userId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblcustomer`
--
ALTER TABLE `tblcustomer`
  MODIFY `custId` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tblcusttransaction`
--
ALTER TABLE `tblcusttransaction`
  MODIFY `TransactionId` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tblcusttransdetail`
--
ALTER TABLE `tblcusttransdetail`
  MODIFY `TransDetailsId` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tblprodcategory`
--
ALTER TABLE `tblprodcategory`
  MODIFY `CategoryId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `tblprodsize`
--
ALTER TABLE `tblprodsize`
  MODIFY `SizeId` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `tblprodsub`
--
ALTER TABLE `tblprodsub`
  MODIFY `SubCatId` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tblprodtype`
--
ALTER TABLE `tblprodtype`
  MODIFY `TypeId` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tblproducts`
--
ALTER TABLE `tblproducts`
  MODIFY `productId` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `tblprodunit`
--
ALTER TABLE `tblprodunit`
  MODIFY `UnitId` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `tblsupplier`
--
ALTER TABLE `tblsupplier`
  MODIFY `supplierId` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tblusers`
--
ALTER TABLE `tblusers`
  MODIFY `userId` int(1) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
