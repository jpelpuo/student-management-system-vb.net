-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jan 31, 2019 at 10:16 AM
-- Server version: 10.1.13-MariaDB
-- PHP Version: 7.0.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `vbproject`
--

-- --------------------------------------------------------

--
-- Table structure for table `courses`
--

CREATE TABLE `courses` (
  `Course_Code` varchar(20) NOT NULL,
  `Course_Name` varchar(100) NOT NULL,
  `Department` varchar(100) NOT NULL,
  `Course_level` int(3) NOT NULL,
  `Credits` int(2) NOT NULL,
  `Semester` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `courses`
--

INSERT INTO `courses` (`Course_Code`, `Course_Name`, `Department`, `Course_level`, `Credits`, `Semester`) VALUES
('CSCD 101', 'Introduction To Computer Science I', 'Computer Science', 100, 3, 'First'),
('CSCD 102', 'Introduction to Computer Science II', 'Computer Science', 100, 3, 'Second'),
('CSCD 201', 'Information Systems', 'Computer Science', 200, 3, 'First'),
('CSCD 202', 'Programming II(With Java)', 'Computer Science', 200, 3, 'Second'),
('CSCD 205', 'Programming I(With C++)', 'Computer Science', 200, 3, 'First'),
('CSCD 207', 'Numerical Methods', 'Computer Science', 200, 3, 'First'),
('CSCD 211', 'Computer Organization & Architecture', 'Computer Science', 200, 3, 'First'),
('CSCD 212', 'Computer Ethics', 'Computer Science', 200, 1, 'Second'),
('CSCD 214', 'Digital Electronics', 'Computer Science', 200, 2, 'Second'),
('CSCD 216', 'Data Structures & Algorithms', 'Computer Science', 200, 3, 'Second'),
('CSCD 218', 'Data Communications & Networking I', 'Computer Science', 200, 3, 'Second'),
('CSCD 301', 'Object Oriented Analysis & Design', 'Computer Science', 300, 3, 'First'),
('CSCD 302', 'Programming III(With VB .NET)', 'Computer Science ', 300, 3, 'Second'),
('CSCD 304', 'Design & Analysis of Algorithms', 'Computer Science', 300, 3, 'Second'),
('CSCD 306', 'Software Engineering', 'Computer Science', 300, 3, 'Second'),
('CSCD 311', 'Web Technologies & Development', 'Computer Science', 300, 3, 'First'),
('CSCD 312', 'Introduction to Artificial Intelligence', 'Computer Science', 300, 3, 'Second'),
('CSCD 313', 'Database Management Systems', 'Computer Science', 300, 3, 'First'),
('CSCD 314', 'Research Methods In Computing ', 'Computer Science', 300, 3, 'Second'),
('CSCD 315', 'Operating Systems', 'Computer Science ', 300, 3, 'First'),
('CSCD 317', 'Embedded Systems', 'Computer Science', 300, 3, 'First'),
('CSCD 322', 'Advanced Web Technologies', 'Computer Science', 300, 3, 'Second'),
('CSCD 415', 'Compilers', 'Computer Science', 400, 3, 'First'),
('CSCD 416', 'System Programming', 'Computer Science ', 400, 3, 'Second'),
('CSCD 417', 'Theory and Survey of Programming Languages', 'Computer Science', 400, 3, 'First'),
('CSCD 418', 'Computer Systems Security', 'Computer Science', 400, 3, 'Second'),
('CSCD 419', 'Formal Methods and Models', 'Computer Science', 400, 3, 'First'),
('CSCD 421', 'Accounting Principles in Computing', 'Computer Science ', 400, 3, 'First'),
('CSCD 422', 'Human Computer Interaction', 'Computer Science', 400, 3, 'Second'),
('CSCD 424', 'Management Principles in Computing', 'Computer Science', 400, 3, 'Second'),
('MATH 121', 'Algebra & Trigonometry', 'Mathematics', 100, 3, 'First'),
('MATH 122', 'Calculus I', 'Mathematics', 100, 3, 'Second'),
('MATH 224', 'Introductory Abstract Algebra', 'Mathematics', 200, 3, 'Second'),
('MATH 226', 'Introductory Computational Mathematics', 'Mathematics', 200, 3, 'Second'),
('MATH 359', 'Discrete Mathematics', 'Mathematics', 300, 3, 'First'),
('PHYS 143', 'Mechanics and Thermal Physics', 'Physics', 100, 3, 'First'),
('STAT 101', 'Introduction To Statistics', 'Statistics ', 100, 3, 'First'),
('STAT 102', 'Elementary Probability', 'Statistics', 100, 3, 'Second');

-- --------------------------------------------------------

--
-- Table structure for table `registration_grade`
--

CREATE TABLE `registration_grade` (
  `RegID` int(11) NOT NULL,
  `StudentID` varchar(10) NOT NULL,
  `Course_Code` varchar(20) NOT NULL,
  `Course_Name` varchar(100) NOT NULL,
  `Credits` int(2) NOT NULL,
  `Marks` int(3) NOT NULL,
  `Grade` varchar(3) NOT NULL,
  `Gradepoint` double(2,1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `registration_grade`
--

INSERT INTO `registration_grade` (`RegID`, `StudentID`, `Course_Code`, `Course_Name`, `Credits`, `Marks`, `Grade`, `Gradepoint`) VALUES
(128, '10634124', 'CSCD 202', '  Programming II(With Java)', 3, 0, '', 0.0),
(129, '10634124', 'CSCD 212', '  Computer Ethics', 1, 0, '', 0.0),
(130, '10634124', 'CSCD 218', '  Data Communications & Networking I', 3, 0, '', 0.0),
(131, '10576145', 'CSCD 304', '  Design & Analysis of Algorithms', 3, 80, 'A', 0.0),
(132, '10576145', 'CSCD 312', '  Introduction to Artificial Intelligence', 3, 98, 'A', 0.0),
(133, '10576145', 'CSCD 322', '  Advanced Web Technologies', 3, 62, 'C', 0.0),
(134, '10576145', 'CSCD 301', '  Object Oriented Analysis & Design', 3, 89, 'A', 0.0),
(135, '10576145', 'CSCD 311', '  Web Technologies & Development', 3, 76, 'B+', 0.0),
(136, '10576145', 'CSCD 317', '  Embedded Systems', 3, 74, 'B', 0.0),
(137, '10576145', 'CSCD 302', '  Programming III(With VB .NET)', 3, 79, 'B+', 0.0),
(138, '10576145', 'CSCD 306', '  Software Engineering', 3, 85, 'A', 0.0),
(139, '10576145', 'CSCD 313', '  Database Management Systems', 3, 67, 'C+', 0.0),
(140, '10576145', 'CSCD 315', '  Operating Systems', 3, 76, 'B+', 0.0),
(141, '10567691', 'CSCD 302', '  Programming III(With VB .NET)', 3, 0, ' ', 0.0),
(142, '10567691', 'CSCD 304', '  Design & Analysis of Algorithms', 3, 0, ' ', 0.0),
(143, '10567691', 'CSCD 306', '  Software Engineering', 3, 0, ' ', 0.0),
(144, '10567691', 'CSCD 312', '  Introduction to Artificial Intelligence', 3, 0, ' ', 0.0),
(145, '10567691', 'CSCD 314', '  Research Methods In Computing ', 3, 0, '', 0.0),
(146, '10575685', 'CSCD 302', '  Programming III(With VB .NET)', 3, 0, ' ', 0.0),
(147, '10575685', 'CSCD 304', '  Design & Analysis of Algorithms', 3, 0, ' ', 0.0),
(148, '10575685', 'CSCD 306', '  Software Engineering', 3, 0, ' ', 0.0),
(149, '10575685', 'CSCD 322', '  Advanced Web Technologies', 3, 89, 'A', 0.0),
(150, '10579847', 'CSCD 101', '  Introduction To Computer Science I', 3, 0, '', 0.0),
(151, '10579847', 'CSCD 102', '  Introduction to Computer Science II', 3, 0, '', 0.0),
(152, '10568586', 'CSCD 302', '  Programming III(With VB .NET)', 3, 34, 'F', 0.0),
(153, '10568586', 'CSCD 312', '  Introduction to Artificial Intelligence', 3, 0, ' ', 0.0),
(154, '10568586', 'CSCD 322', '  Advanced Web Technologies', 3, 78, 'B+', 0.0),
(155, '10576145', 'MATH 359', '  Discrete Mathematics', 3, 0, '', 0.0),
(156, '10521688', 'CSCD 415', '  Compilers', 3, 89, 'A', 0.0),
(157, '10521688', 'CSCD 417', '  Theory and Survey of Programming Languages', 3, 67, 'C+', 0.0),
(158, '10521688', 'CSCD 419', '  Formal Methods and Models', 3, 78, 'B+', 0.0),
(159, '10521688', 'CSCD 421', '  Accounting Principles in Computing', 3, 0, '', 0.0),
(160, '10576145', 'CSCD 314', '  Research Methods In Computing ', 3, 0, '', 0.0);

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE `staff` (
  `ID` varchar(3) NOT NULL,
  `FirstName` varchar(100) NOT NULL,
  `LastName` varchar(100) NOT NULL,
  `Department` varchar(100) NOT NULL,
  `Position` varchar(50) NOT NULL,
  `PIN` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`ID`, `FirstName`, `LastName`, `Department`, `Position`, `PIN`) VALUES
('001', 'Joseph ', 'Annan', 'Computer Science', 'Lecturer, HOD', '88990'),
('002', 'Joseph', 'Ecklu', 'Computer Science', 'Lecturer', '77886'),
('003', 'Michael', 'Soli', 'Computer Science', 'Lecturer', '33445'),
('004', 'Caroline ', 'Kitcher', 'Computer Science', 'Lecturer', '56741'),
('005', 'Alhassan ', 'Atara', 'Physics', 'Lecturer', '56879'),
('006', 'Michael ', 'Asiedu', 'Statistics', 'Lecturer', '78962');

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE `student` (
  `ID` varchar(10) NOT NULL,
  `FirstName` varchar(100) NOT NULL,
  `LastName` varchar(100) NOT NULL,
  `Level` int(3) NOT NULL,
  `Major` varchar(100) NOT NULL,
  `PIN` varchar(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`ID`, `FirstName`, `LastName`, `Level`, `Major`, `PIN`) VALUES
('10521688', 'Bright', 'Ayipeh', 400, 'BA. Psychology', '12345'),
('10522865', 'Kwame', 'Addo', 400, 'Bsc. Physics', '21341'),
('10524995', 'Joel', 'Mensah', 400, 'BA. Sociology', '11221'),
('10545342', 'Michael', 'Offori', 100, 'BSc. Mathematics', '32145'),
('10566846', 'Jesse', 'Essie', 400, 'BA. Geography, Sociology', '34218'),
('10567691', 'Levit', 'Osei-Wusu', 300, 'BSc. Computer Science', '93238'),
('10568586', 'George ', 'Hanson', 300, 'BSc. Computer Science', '20808'),
('10575685', 'Ernest', 'Gaisie', 300, 'BSc. Computer Science ', '10575'),
('10576145', 'Jamal', 'Pelpuo', 300, 'BSc. Ccomputer Science', '32141'),
('10579847', 'Kwadwo', 'Agyapong', 100, 'BSc. Computer Science', '10579'),
('10634124', 'Joel', 'Guu', 200, 'BSc. Earth Science', '54637'),
('10682800', 'Jameela', 'Abdulai', 100, 'BSc. Earth Science', '11224');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `courses`
--
ALTER TABLE `courses`
  ADD PRIMARY KEY (`Course_Code`);

--
-- Indexes for table `registration_grade`
--
ALTER TABLE `registration_grade`
  ADD PRIMARY KEY (`RegID`);

--
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `registration_grade`
--
ALTER TABLE `registration_grade`
  MODIFY `RegID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=161;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
