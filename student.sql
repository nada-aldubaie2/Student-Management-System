-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 29, 2023 at 05:07 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `studentdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE `student` (
  `StudentId` int(5) NOT NULL,
  `StudentName` varchar(100) NOT NULL,
  `Birthdate` date NOT NULL,
  `Address` text NOT NULL,
  `Phone` varchar(20) NOT NULL,
  `Email` varchar(30) NOT NULL,
  `Department` varchar(20) NOT NULL,
  `Geneder` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`StudentId`, `StudentName`, `Birthdate`, `Address`, `Phone`, `Email`, `Department`, `Geneder`) VALUES
(101, 'احمد محسن محمد الراجحي', '2000-04-28', 'حدة-الكميم', '777888999', 'yemen@data.com', 'Computer Sciece', 'ذكر'),
(102, 'تسنيم خالد معاذ الكهلاني', '2000-04-28', 'الميناء-شارع موسى', '777888999', 'yemen@data.com', 'Computer Engneering', 'أنثى'),
(103, 'رضوان علي يعقوب اليافعي', '2000-02-16', 'الميناء-شارع موسى', '7774445555', 'yemen@dats.com', 'Computer Sciece', 'ذكر'),
(104, 'صابر صبار صبور الصابري', '1995-07-11', 'الحوك-غليل', '777888999', 'yemen@data.com', 'Computer Engneering', 'ذكر'),
(105, 'صويلحة صالح مصلح الصالحي', '1995-07-11', 'الحوك-غليل', '777888999', 'yemen@data.com', 'Computer Engneering', ' أنثى'),
(106, 'رضوان راضي مرضي المرتضي', '1998-10-06', 'الحوك-سوق عثمان', '777666444', 'yemen@data.com', 'Computer Engneering', ' ذكر');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`StudentId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `student`
--
ALTER TABLE `student`
  MODIFY `StudentId` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=107;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
