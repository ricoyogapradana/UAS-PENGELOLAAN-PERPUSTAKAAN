-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 13, 2021 at 09:50 AM
-- Server version: 10.4.19-MariaDB
-- PHP Version: 7.3.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `perpustakaan`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_admin`
--

CREATE TABLE `tbl_admin` (
  `id_admin` int(8) NOT NULL,
  `username` varchar(16) NOT NULL,
  `nama_admin` varchar(255) NOT NULL,
  `tempat_lahir` varchar(64) NOT NULL,
  `tanggal_lahir` varchar(64) NOT NULL,
  `no_hp` varchar(14) NOT NULL,
  `status` varchar(18) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_admin`
--

INSERT INTO `tbl_admin` (`id_admin`, `username`, `nama_admin`, `tempat_lahir`, `tanggal_lahir`, `no_hp`, `status`) VALUES
(1, 'alyh', 'aliya', '12', '12', '12', '1');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_anggota`
--

CREATE TABLE `tbl_anggota` (
  `id_anggota` int(8) NOT NULL,
  `username` varchar(16) NOT NULL,
  `nama_anggota` varchar(255) NOT NULL,
  `tempat_lahir` varchar(64) NOT NULL,
  `tanggal_lahir` varchar(64) NOT NULL,
  `no_hp` varchar(14) NOT NULL,
  `tahun_bergabung` varchar(4) NOT NULL,
  `status` varchar(18) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_anggota`
--

INSERT INTO `tbl_anggota` (`id_anggota`, `username`, `nama_anggota`, `tempat_lahir`, `tanggal_lahir`, `no_hp`, `tahun_bergabung`, `status`) VALUES
(1, 'ricya', 'RICO YOGA', '12', '12', '12', '12', '1');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_buku`
--

CREATE TABLE `tbl_buku` (
  `id_buku` int(8) NOT NULL,
  `nama_buku` varchar(255) NOT NULL,
  `id_penulis` varchar(8) NOT NULL,
  `id_penerbit` varchar(8) NOT NULL,
  `tahun_terbit` varchar(4) NOT NULL,
  `status` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_buku`
--

INSERT INTO `tbl_buku` (`id_buku`, `nama_buku`, `id_penulis`, `id_penerbit`, `tahun_terbit`, `status`) VALUES
(1, '1', '123141', '12', '121', '1'),
(3, 'Konz', 'asd', 'dsa', 'qe', '1'),
(12, '12', '123141', '12', '1', '1'),
(312, 'MARMUT MERAH JAMBU', '123141', 'dsa', '2002', '1');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_peminjaman`
--

CREATE TABLE `tbl_peminjaman` (
  `id_peminjaman` int(8) NOT NULL,
  `id_anggota` varchar(255) NOT NULL,
  `id_admin` varchar(255) NOT NULL,
  `id_buku` varchar(255) NOT NULL,
  `id_penulis` varchar(255) NOT NULL,
  `id_penerbit` varchar(255) NOT NULL,
  `tanggal_pinjam` varchar(64) NOT NULL,
  `tanggal_pengembalian` varchar(64) NOT NULL,
  `status` varchar(14) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_penerbit`
--

CREATE TABLE `tbl_penerbit` (
  `id_penerbit` int(8) NOT NULL,
  `nama_penerbit` varchar(255) NOT NULL,
  `tahun_berdiri` varchar(4) NOT NULL,
  `no_hp` varchar(14) NOT NULL,
  `status` varchar(18) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_penerbit`
--

INSERT INTO `tbl_penerbit` (`id_penerbit`, `nama_penerbit`, `tahun_berdiri`, `no_hp`, `status`) VALUES
(1, '12', '21', '12', '1'),
(2, 'dsa', '2020', '1234', '1');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_penulis`
--

CREATE TABLE `tbl_penulis` (
  `id_penulis` int(8) NOT NULL,
  `nama_penulis` varchar(255) NOT NULL,
  `tempat_lahir` varchar(64) NOT NULL,
  `tanggal_lahir` varchar(64) NOT NULL,
  `no_hp` varchar(14) NOT NULL,
  `status` varchar(18) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_penulis`
--

INSERT INTO `tbl_penulis` (`id_penulis`, `nama_penulis`, `tempat_lahir`, `tanggal_lahir`, `no_hp`, `status`) VALUES
(1, '123141', '12', '12', '21', '12'),
(2, 'asd', '12', 'Tuesday, July 13, 2021', '12', '2');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_admin`
--
ALTER TABLE `tbl_admin`
  ADD PRIMARY KEY (`id_admin`);

--
-- Indexes for table `tbl_anggota`
--
ALTER TABLE `tbl_anggota`
  ADD PRIMARY KEY (`id_anggota`);

--
-- Indexes for table `tbl_buku`
--
ALTER TABLE `tbl_buku`
  ADD PRIMARY KEY (`id_buku`);

--
-- Indexes for table `tbl_peminjaman`
--
ALTER TABLE `tbl_peminjaman`
  ADD PRIMARY KEY (`id_peminjaman`);

--
-- Indexes for table `tbl_penerbit`
--
ALTER TABLE `tbl_penerbit`
  ADD PRIMARY KEY (`id_penerbit`);

--
-- Indexes for table `tbl_penulis`
--
ALTER TABLE `tbl_penulis`
  ADD PRIMARY KEY (`id_penulis`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_peminjaman`
--
ALTER TABLE `tbl_peminjaman`
  MODIFY `id_peminjaman` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
