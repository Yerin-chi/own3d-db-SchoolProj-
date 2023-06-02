-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 18, 2023 at 01:55 AM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `own3d_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `Customer_ID` int(11) NOT NULL,
  `Customer_Fname` varchar(255) NOT NULL,
  `Customer_Lname` varchar(255) NOT NULL,
  `Customer_Email` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`Customer_ID`, `Customer_Fname`, `Customer_Lname`, `Customer_Email`) VALUES
(16, 'Dale', 'Edwards', 'daledwards@gmail.com'),
(17, 'Faye', 'Lane', 'fayelane@gmail.com'),
(18, 'Sylvester', 'Curtis', 'sylvestercurtis@gmail.com'),
(19, 'Brandon', 'Robertson', 'brandonrobertson@gmail.com'),
(20, 'Mary', 'Fox', 'maryfox@gmail.com'),
(21, 'Lawrence', 'Garza', 'lawrencegarza@gmail.com'),
(22, 'Lois', 'Salazar', 'loissalazar@gmail.com'),
(23, 'Jena', 'Hardy', 'jenahardy@gmail.com'),
(24, 'Shane', 'Owen', 'shaneowen@gmail.com'),
(25, 'Kurt', 'Tyler', 'kurttyler@gmail.com'),
(26, 'Jayson', 'Tan', 'jaysontan@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `discount_code`
--

CREATE TABLE `discount_code` (
  `Discount_Code_ID` int(11) NOT NULL,
  `Discount_Value` int(255) NOT NULL,
  `Discount_Expiration` int(255) NOT NULL,
  `valid_from` date NOT NULL,
  `valid_until` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `discount_code`
--

INSERT INTO `discount_code` (`Discount_Code_ID`, `Discount_Value`, `Discount_Expiration`, `valid_from`, `valid_until`) VALUES
(7, 50, 96, '2023-05-16', '2023-05-20'),
(8, 20, 72, '2023-05-16', '2023-05-19'),
(9, 30, 72, '2023-05-16', '2023-05-19');

-- --------------------------------------------------------

--
-- Table structure for table `members`
--

CREATE TABLE `members` (
  `Member_ID` int(11) NOT NULL,
  `Member_Fname` varchar(255) NOT NULL,
  `Member_Lname` varchar(255) NOT NULL,
  `Member_Email` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `members`
--

INSERT INTO `members` (`Member_ID`, `Member_Fname`, `Member_Lname`, `Member_Email`) VALUES
(15, 'Teresa', 'Nunez', 'teresa@gmail.com'),
(16, 'Jeff', 'Newman', 'jeff@gmail.com'),
(17, 'Olivia', 'Flowers', 'olivia@gmail.com'),
(18, 'Carrie', 'Greer', 'carrie@gmail.com'),
(19, 'Monica', 'Bowen', 'monica@gmail.com'),
(20, 'Derrick', 'Roy', 'derrick@gmail.com'),
(21, 'Lee', 'Edwards', 'lee@gmail.com'),
(22, 'Leticia', 'Ford', 'leticia@gmail.com'),
(23, 'Sandy', 'Campbell', 'sandy@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `order_transac`
--

CREATE TABLE `order_transac` (
  `Order_ID` int(11) NOT NULL,
  `Customer_ID` int(11) NOT NULL,
  `Customer_Fname` varchar(255) NOT NULL,
  `Customer_Lname` varchar(255) NOT NULL,
  `Order_Date` date NOT NULL,
  `Product_ID` int(11) NOT NULL,
  `Product_Name` varchar(255) NOT NULL,
  `Product_Quantity` int(11) NOT NULL,
  `Product_Price` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `order_transac`
--

INSERT INTO `order_transac` (`Order_ID`, `Customer_ID`, `Customer_Fname`, `Customer_Lname`, `Order_Date`, `Product_ID`, `Product_Name`, `Product_Quantity`, `Product_Price`) VALUES
(9, 16, 'Dale', 'Edwards', '2023-05-11', 8, 'Black White Twitch Alerts', 5, 1024),
(10, 17, 'Faye', 'Lane', '2023-05-11', 9, 'Clean Neon Twitch Alerts', 5, 1024),
(11, 18, 'Sylvester', 'Curtis', '2023-05-11', 10, 'New World Twitch Alerts', 5, 1024),
(12, 19, 'Brandon', 'Robertson', '2023-05-13', 11, 'Zenith Twitch Banners', 1, 1024),
(13, 20, 'Mary', 'Fox', '2023-05-15', 12, 'Celtic Twitch Banners', 1, 1024),
(14, 21, 'Lawrence', 'Garza', '2023-05-18', 13, 'Allure Twitch Banner', 1, 1024),
(15, 22, 'Lois', 'Salazar', '2023-05-11', 8, 'Black White Twitch Alerts', 5, 1024);

-- --------------------------------------------------------

--
-- Table structure for table `payment`
--

CREATE TABLE `payment` (
  `Payment_ID` int(11) NOT NULL,
  `Bank_ID` int(15) NOT NULL,
  `Account_ID` int(15) NOT NULL,
  `Pay_Fname` varchar(255) NOT NULL,
  `Pay_Lname` varchar(255) NOT NULL,
  `Bank_Type` varchar(255) NOT NULL,
  `Method` varchar(255) NOT NULL,
  `Order_Date` date NOT NULL,
  `Product` varchar(255) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `Price` int(11) NOT NULL,
  `Discount_Value` int(11) NOT NULL,
  `Discounted_Price` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `Product_ID` int(11) NOT NULL,
  `Product_Name` varchar(255) NOT NULL,
  `Product_Description` varchar(255) NOT NULL,
  `Product_Category` varchar(255) NOT NULL,
  `Product_Quantity` int(255) NOT NULL,
  `Product_Price` int(255) NOT NULL,
  `Publish_Date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`Product_ID`, `Product_Name`, `Product_Description`, `Product_Category`, `Product_Quantity`, `Product_Price`, `Publish_Date`) VALUES
(8, 'Black White Twitch Alerts', 'Visualize events with stylish Twitch alerts in your stream and give back to your viewers and followers.', 'Alerts', 5, 1024, '2023-05-11'),
(9, 'Clean Neon Twitch Alerts', 'Visualize events with stylish Twitch alerts in your stream and give back to your viewers and followers', 'Alerts', 5, 1024, '2023-05-11'),
(10, 'New World Twitch Alerts', 'Visualize events with stylish Twitch alerts in your stream and give back to your viewers and followers.', 'Alerts', 5, 1024, '2023-05-11'),
(11, 'Zenith Twitch Banners', 'Upgrade your Twitch stream with cool and stylish new Profile Banner and Picture.', 'Banners', 1, 1024, '2023-05-11'),
(12, 'Celtic Twitch Banners', 'Upgrade your Twitch stream with cool and stylish new Profile Banner and Picture.', 'Banners', 1, 1024, '2023-05-15'),
(13, 'Allure Twitch Banner', 'Upgrade your Twitch stream with cool and stylish new Profile Banner and Picture.', 'Banners', 1, 1024, '2023-05-16');

-- --------------------------------------------------------

--
-- Table structure for table `select_bank`
--

CREATE TABLE `select_bank` (
  `ID` int(11) NOT NULL,
  `Customer_ID` int(255) NOT NULL,
  `Account_Fname` varchar(255) NOT NULL,
  `Account_Lname` varchar(255) NOT NULL,
  `Bank_Type` varchar(255) NOT NULL,
  `Account_ID` varchar(255) NOT NULL,
  `Currency` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `select_bank`
--

INSERT INTO `select_bank` (`ID`, `Customer_ID`, `Account_Fname`, `Account_Lname`, `Bank_Type`, `Account_ID`, `Currency`) VALUES
(10, 16, 'Dale', 'Edwards', 'Skrill', '123456789', 'USD'),
(11, 17, 'Faye', 'Lane', 'Skrill', '987654321', 'USD'),
(12, 18, 'Sylvester', 'Curtis', 'Skrill', '123123123', 'USD'),
(13, 19, 'Brandon', 'Robertson', 'Amazon Pay', '1234', 'USD'),
(14, 20, 'Mary', 'Fox', 'Amazon Pay', '0987', 'USD'),
(15, 21, 'Lawrence', 'Garza', 'Paypal', 'lawrencegarza@gmail.com', 'USD'),
(16, 22, 'Lois', 'Salazar', 'Paypal', 'loissalazar@gmail.com', 'USD');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`Customer_ID`);

--
-- Indexes for table `discount_code`
--
ALTER TABLE `discount_code`
  ADD PRIMARY KEY (`Discount_Code_ID`);

--
-- Indexes for table `members`
--
ALTER TABLE `members`
  ADD PRIMARY KEY (`Member_ID`);

--
-- Indexes for table `order_transac`
--
ALTER TABLE `order_transac`
  ADD PRIMARY KEY (`Order_ID`);

--
-- Indexes for table `payment`
--
ALTER TABLE `payment`
  ADD PRIMARY KEY (`Payment_ID`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`Product_ID`);

--
-- Indexes for table `select_bank`
--
ALTER TABLE `select_bank`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `Customer_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT for table `discount_code`
--
ALTER TABLE `discount_code`
  MODIFY `Discount_Code_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `members`
--
ALTER TABLE `members`
  MODIFY `Member_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT for table `order_transac`
--
ALTER TABLE `order_transac`
  MODIFY `Order_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `payment`
--
ALTER TABLE `payment`
  MODIFY `Payment_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `product`
--
ALTER TABLE `product`
  MODIFY `Product_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `select_bank`
--
ALTER TABLE `select_bank`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
