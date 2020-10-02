-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 18-Maio-2020 às 16:31
-- Versão do servidor: 10.4.11-MariaDB
-- versão do PHP: 7.4.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `sistemaweb`
--
CREATE DATABASE IF NOT EXISTS `sistemaweb` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `sistemaweb`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `cad_cliente`
--

DROP TABLE IF EXISTS `cad_cliente`;
CREATE TABLE IF NOT EXISTS `cad_cliente` (
  `id_cliente` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(60) NOT NULL,
  `Logradouro` varchar(80) NOT NULL,
  `Numero` int(5) NOT NULL,
  `Complemento` varchar(15) NOT NULL,
  `Bairro` varchar(30) NOT NULL,
  `Cidade` varchar(30) NOT NULL,
  `Estado` varchar(2) NOT NULL,
  `Celular` varchar(40) NOT NULL,
  PRIMARY KEY (`id_cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cad_cliente`
--

INSERT INTO `cad_cliente` (`id_cliente`, `Nome`, `Logradouro`, `Numero`, `Complemento`, `Bairro`, `Cidade`, `Estado`, `Celular`) VALUES(1, 'Jhonatan de Oliveira', 'Rua Alberto', 1234, 'perto do posto', 'Ribeirania', 'Ribeirão Preto', 'SP', '16 995437029');
INSERT INTO `cad_cliente` (`id_cliente`, `Nome`, `Logradouro`, `Numero`, `Complemento`, `Bairro`, `Cidade`, `Estado`, `Celular`) VALUES(2, 'Brenda', 'Rua Alberto', 3214, 'Casa com Jardim', 'Ribeirania', 'Ribeirão Preto', 'SP', '16 990032790');

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE IF NOT EXISTS `usuarios` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `NOME_USER` varchar(60) NOT NULL,
  `SENHA_USER` char(40) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `usuarios`
--

INSERT INTO `usuarios` (`ID`, `NOME_USER`, `SENHA_USER`) VALUES(1, 'Jhonatan', 'e10adc3949ba59abbe56e057f20f883e');
INSERT INTO `usuarios` (`ID`, `NOME_USER`, `SENHA_USER`) VALUES(2, 'brenda', 'e10adc3949ba59abbe56e057f20f883e');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
