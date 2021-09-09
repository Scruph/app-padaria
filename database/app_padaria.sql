-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Tempo de geração: 25-Jul-2020 às 01:21
-- Versão do servidor: 10.4.10-MariaDB
-- versão do PHP: 7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `app_padaria`
--

DELIMITER $$
--
-- Procedimentos
--
DROP PROCEDURE IF EXISTS `IP_Pedido`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `IP_Pedido` (`Id_Prod` INT(11), `Valor` DECIMAL(10,2), `Qtde` INT(11))  BEGIN
    INSERT INTO Pedido VALUES(0,Id_Prod,Valor,Qtde);
END$$

DROP PROCEDURE IF EXISTS `VendaRealizada`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `VendaRealizada` (`Idf` INT(11), `Idc` INT(11), `Idp` INT(11), `Pg` VARCHAR(10), `Total` DECIMAL(10,2), `DV` VARCHAR(10), `Turno` INT(1), `HV` VARCHAR(10))  BEGIN
    INSERT INTO Venda_Efetuada VALUES (0,Idf,Idc,Idp,Pg,Total,DV,Turno,HV);
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `anotacao`
--

DROP TABLE IF EXISTS `anotacao`;
CREATE TABLE IF NOT EXISTS `anotacao` (
  `Id_Anotacao` int(11) NOT NULL AUTO_INCREMENT,
  `Descricao` varchar(100) NOT NULL,
  `Data` date NOT NULL,
  `Situacao` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`Id_Anotacao`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `anotacao`
--

INSERT INTO `anotacao` (`Id_Anotacao`, `Descricao`, `Data`, `Situacao`) VALUES
(5, 'Quimica', '2020-07-24', 'Vazio'),
(7, 'Creme de Ricot', '2020-07-24', 'Vazio'),
(8, 'Mussarela', '2020-07-24', 'Comprado'),
(10, 'Coca 250ml', '2020-07-24', 'Vazio');

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente_padaria`
--

DROP TABLE IF EXISTS `cliente_padaria`;
CREATE TABLE IF NOT EXISTS `cliente_padaria` (
  `Id_Cliente` int(11) NOT NULL AUTO_INCREMENT,
  `CPF_Cliente` varchar(11) NOT NULL,
  `Nome_Cliente` varchar(50) NOT NULL,
  `Bairro_Cliente` varchar(50) DEFAULT NULL,
  `Rua_Cliente` varchar(50) DEFAULT NULL,
  `Numero_Residencia_Cliente` varchar(5) DEFAULT NULL,
  `Telefone_Fixo_Cliente` varchar(10) DEFAULT NULL,
  `Telefone_Celular_Cliente` varchar(11) DEFAULT NULL,
  `Situacao` int(1) NOT NULL,
  `Limite` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id_Cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `cliente_padaria`
--

INSERT INTO `cliente_padaria` (`Id_Cliente`, `CPF_Cliente`, `Nome_Cliente`, `Bairro_Cliente`, `Rua_Cliente`, `Numero_Residencia_Cliente`, `Telefone_Fixo_Cliente`, `Telefone_Celular_Cliente`, `Situacao`, `Limite`) VALUES
(1, '00000000000', 'CONSUMIDOR FINAL', '', '', '', '', '', 1, 999999999),
(4, '00000000000', 'Israel', 'Vila Darcy', 'Odorico Martins do Amaral', '1495', '1512345567', '15123456789', 0, 150),
(5, '11111111111', 'Heavenfalls', 'vila darcy', 'odorico martins do amaral', '1495', '1111111111', '11111111111', 0, 150);

-- --------------------------------------------------------

--
-- Estrutura da tabela `dia`
--

DROP TABLE IF EXISTS `dia`;
CREATE TABLE IF NOT EXISTS `dia` (
  `Id_Dia` int(11) NOT NULL AUTO_INCREMENT,
  `ValorTotalDia` decimal(10,2) DEFAULT NULL,
  `ValorDinheiroDia` decimal(10,2) DEFAULT NULL,
  `ValorDebitoDia` decimal(10,2) DEFAULT NULL,
  `ValorCreditoDia` decimal(10,2) DEFAULT NULL,
  `ValorFiadoDia` decimal(10,2) DEFAULT NULL,
  `ValorRetiradaDia` decimal(10,2) DEFAULT NULL,
  `DataDia` date NOT NULL,
  PRIMARY KEY (`Id_Dia`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `dia`
--

INSERT INTO `dia` (`Id_Dia`, `ValorTotalDia`, `ValorDinheiroDia`, `ValorDebitoDia`, `ValorCreditoDia`, `ValorFiadoDia`, `ValorRetiradaDia`, `DataDia`) VALUES
(3, '1500.00', '1500.00', '0.00', '0.00', '0.00', '0.00', '2020-07-23'),
(4, '20785.22', '14092.43', '2867.35', '3543.20', '1032.24', '750.00', '2020-07-24');

-- --------------------------------------------------------

--
-- Estrutura da tabela `fornecedores`
--

DROP TABLE IF EXISTS `fornecedores`;
CREATE TABLE IF NOT EXISTS `fornecedores` (
  `Id_Fornecedores` int(11) NOT NULL AUTO_INCREMENT,
  `Nome_Fornecedores` varchar(50) NOT NULL,
  `Nome_Vendedor` varchar(50) NOT NULL,
  `Telefone_Fixo_Fornecedor` char(10) DEFAULT NULL,
  `Telefone_Celular_Fornecedor` char(11) DEFAULT NULL,
  PRIMARY KEY (`Id_Fornecedores`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `fornecedores`
--

INSERT INTO `fornecedores` (`Id_Fornecedores`, `Nome_Fornecedores`, `Nome_Vendedor`, `Telefone_Fixo_Fornecedor`, `Telefone_Celular_Fornecedor`) VALUES
(1, 'Sorocaba Refrescos', 'Thiago', NULL, NULL),
(4, 'Rocha Pan', 'Ismael', '', '');

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionario_padaria`
--

DROP TABLE IF EXISTS `funcionario_padaria`;
CREATE TABLE IF NOT EXISTS `funcionario_padaria` (
  `Id_Funcionario` int(11) NOT NULL AUTO_INCREMENT,
  `Id_Permissoes` int(11) NOT NULL,
  `Username` varchar(30) NOT NULL,
  `Password` varchar(30) NOT NULL,
  `CPF_Funcionario` varchar(11) NOT NULL,
  `Nome_Funcionario` varchar(50) NOT NULL,
  `Bairro_Funcionario` varchar(50) DEFAULT NULL,
  `Rua_Funcionario` varchar(50) DEFAULT NULL,
  `Numero_Residencia_Funcionario` char(5) DEFAULT NULL,
  `Telefone_Fixo_Funcionario` char(10) DEFAULT NULL,
  `Telefone_Celular_Funcionario` char(11) DEFAULT NULL,
  PRIMARY KEY (`Id_Funcionario`),
  KEY `fk_Permissoes_Funcionario` (`Id_Permissoes`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `funcionario_padaria`
--

INSERT INTO `funcionario_padaria` (`Id_Funcionario`, `Id_Permissoes`, `Username`, `Password`, `CPF_Funcionario`, `Nome_Funcionario`, `Bairro_Funcionario`, `Rua_Funcionario`, `Numero_Residencia_Funcionario`, `Telefone_Fixo_Funcionario`, `Telefone_Celular_Funcionario`) VALUES
(1, 1, '0000', '0000', '12236546484', 'User', '', '', '', '', ''),
(6, 1, 'Administrador', 'Administrador', '15478481848', 'Administrador', '', '', '', '', '');

-- --------------------------------------------------------

--
-- Estrutura da tabela `gastoscliente`
--

DROP TABLE IF EXISTS `gastoscliente`;
CREATE TABLE IF NOT EXISTS `gastoscliente` (
  `Id_Gastos` int(11) NOT NULL AUTO_INCREMENT,
  `Id_Cliente` int(11) NOT NULL,
  `ValorAtual` decimal(10,2) NOT NULL,
  `ValorPago` decimal(10,2) NOT NULL,
  `UltimaData` date DEFAULT NULL,
  PRIMARY KEY (`Id_Gastos`),
  KEY `fk_Gastos_Cliente` (`Id_Cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `gastoscliente`
--

INSERT INTO `gastoscliente` (`Id_Gastos`, `Id_Cliente`, `ValorAtual`, `ValorPago`, `UltimaData`) VALUES
(5, 4, '278.00', '0.00', '2020-07-24'),
(6, 5, '645.06', '200.00', '2020-07-24'),
(7, 1, '22250.25', '0.00', '2020-07-24');

-- --------------------------------------------------------

--
-- Estrutura da tabela `log`
--

DROP TABLE IF EXISTS `log`;
CREATE TABLE IF NOT EXISTS `log` (
  `idLog` int(11) NOT NULL AUTO_INCREMENT,
  `descricao` varchar(100) NOT NULL,
  `datalog` datetime NOT NULL,
  PRIMARY KEY (`idLog`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `pedido`
--

DROP TABLE IF EXISTS `pedido`;
CREATE TABLE IF NOT EXISTS `pedido` (
  `Id_Pedido` int(11) NOT NULL AUTO_INCREMENT,
  `ValorPedido` decimal(10,2) NOT NULL,
  `Descricao` mediumtext DEFAULT NULL,
  `DataPedido` date DEFAULT NULL,
  PRIMARY KEY (`Id_Pedido`)
) ENGINE=InnoDB AUTO_INCREMENT=98 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `pedido`
--

INSERT INTO `pedido` (`Id_Pedido`, `ValorPedido`, `Descricao`, `DataPedido`) VALUES
(5, '4.00', '', '2020-07-20'),
(6, '17.00', ' 2 	 Coca Cola 290ml  1 	 UN 	 4,00 	 7123456789\n', '2020-07-20'),
(7, '70.00', 'Yuri', '2000-03-03'),
(8, '70.00', 'israel', '2020-07-21'),
(9, '92.79', ' 1 	 	Coca Cola 290ml  1 	 UN 	 4,00 	 7123456789\n 2 	 	Pão Frances 1 	 KG 	 88,79 	 2002860\n', '2020-07-21'),
(10, '23.00', ' 2 	 	Coca Cola 290ml  1 	 UN 	 4,00 	 7123456789\n', '2020-07-21'),
(11, '4.00', ' 1 	 	Coca Cola 290ml  1 	 UN 	 4,00 	 7123456789\n', '2020-07-21'),
(12, '4.00', ' 1 	 	Coca Cola 290ml  1 	 UN 	 4,00 	 7123456789\n', '2020-07-21'),
(13, '4.00', ' 1 	 	Coca Cola 290ml  1 	 UN 	 4,00 	 7123456789\n', '2020-07-21'),
(14, '4.00', '', '2020-07-22'),
(15, '8.00', '', '2020-07-22'),
(16, '4.00', '', '2020-07-22'),
(17, '500.00', '', '2020-07-22'),
(18, '500.00', '', '2020-07-22'),
(19, '100.00', '', '2020-07-22'),
(20, '1500.00', '', '2020-07-22'),
(21, '1500.00', '', '2020-07-22'),
(22, '1.00', '', '2020-07-22'),
(23, '1.00', '', '2020-07-22'),
(24, '15.00', '', '2020-07-22'),
(25, '200.00', '', '2020-07-23'),
(26, '20.00', '', '2020-07-23'),
(27, '44.00', '', '2020-07-23'),
(28, '20.00', '', '2020-07-23'),
(29, '20.00', '', '2020-07-23'),
(30, '15.00', '', '2020-07-23'),
(31, '15.00', '', '2020-07-23'),
(32, '200.00', '', '2020-07-23'),
(33, '8.00', '', '2020-07-23'),
(34, '12.00', '', '2020-07-23'),
(35, '4.00', '', '2020-07-23'),
(36, '200.00', '', '2020-07-23'),
(37, '400.00', '', '2020-07-23'),
(38, '4.00', '', '2020-07-23'),
(39, '4.00', '', '2020-07-23'),
(40, '4.00', '', '2020-07-23'),
(41, '4.00', '', '2020-07-23'),
(42, '4.00', '', '2020-07-23'),
(43, '4.00', '', '2020-07-23'),
(44, '4.00', '', '2020-07-23'),
(45, '4.00', '', '2020-07-23'),
(46, '4.00', '', '2020-07-23'),
(47, '4.00', '', '2020-07-23'),
(48, '12.00', '', '2020-07-23'),
(49, '4.00', '', '2020-07-23'),
(50, '15.00', '', '2020-07-23'),
(51, '4.00', '', '2020-07-23'),
(52, '8.00', '', '2020-07-23'),
(53, '4.00', '', '2020-07-23'),
(54, '15.00', '', '2020-07-23'),
(55, '1500.00', '', '2020-07-23'),
(56, '1500.00', '', '2020-07-23'),
(57, '1500.00', '', '2020-07-23'),
(58, '1500.00', '', '2020-07-23'),
(59, '1500.00', '', '2020-07-23'),
(60, '1000.00', '', '2020-07-23'),
(61, '100.00', '', '2020-07-23'),
(62, '0.00', NULL, '2020-07-24'),
(63, '15.00', '', '2020-07-24'),
(64, '30.00', '', '2020-07-24'),
(65, '1500.00', '', '2020-07-24'),
(66, '1500.00', '', '2020-07-24'),
(67, '1500.00', '', '2020-07-24'),
(68, '250.00', '', '2020-07-24'),
(69, '250.00', '', '2020-07-24'),
(70, '250.00', '', '2020-07-24'),
(71, '24.00', '', '2020-07-24'),
(72, '200.00', '', '2020-07-24'),
(73, '237.50', '', '2020-07-24'),
(74, '458.12', '', '2020-07-24'),
(75, '108.50', '', '2020-07-24'),
(76, '4.00', '', '2020-07-24'),
(77, '125.00', '', '2020-07-24'),
(78, '800.00', '', '2020-07-24'),
(79, '500.00', '', '2020-07-24'),
(80, '325.70', '', '2020-07-24'),
(81, '97.84', '', '2020-07-24'),
(82, '1149.13', '', '2020-07-24'),
(83, '243.71', '', '2020-07-24'),
(84, '420.00', '', '2020-07-24'),
(85, '87.12', '', '2020-07-24'),
(86, '1280.50', '', '2020-07-24'),
(87, '528.80', '', '2020-07-24'),
(88, '150.00', '', '2020-07-24'),
(89, '88.70', '', '2020-07-24'),
(90, '1420.79', '', '2020-07-24'),
(91, '150.00', '', '2020-07-24'),
(92, '120.00', '', '2020-07-24'),
(93, '12.90', '', '2020-07-24'),
(94, '4.00', '', '2020-07-24'),
(95, '4.00', '', '2020-07-24'),
(96, '8.00', '', '2020-07-24'),
(97, '4.00', '', '2020-07-24');

-- --------------------------------------------------------

--
-- Estrutura da tabela `permissoes`
--

DROP TABLE IF EXISTS `permissoes`;
CREATE TABLE IF NOT EXISTS `permissoes` (
  `Id_Permissoes` int(11) NOT NULL AUTO_INCREMENT,
  `Nivel_Usuario` int(1) NOT NULL,
  PRIMARY KEY (`Id_Permissoes`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `permissoes`
--

INSERT INTO `permissoes` (`Id_Permissoes`, `Nivel_Usuario`) VALUES
(1, 1),
(2, 2);

-- --------------------------------------------------------

--
-- Estrutura da tabela `produtos`
--

DROP TABLE IF EXISTS `produtos`;
CREATE TABLE IF NOT EXISTS `produtos` (
  `Id_Produto` int(11) NOT NULL AUTO_INCREMENT,
  `Id_Fornecedores` int(11) NOT NULL,
  `Preco` decimal(10,2) DEFAULT NULL,
  `Nome_Produto` varchar(35) NOT NULL,
  `Tipo_Produto` varchar(50) NOT NULL,
  `Unidade` char(2) NOT NULL,
  `Cod_Barras` char(15) DEFAULT NULL,
  `Qtde_Disponivel` char(10) NOT NULL,
  `Data_Validade` date DEFAULT NULL,
  PRIMARY KEY (`Id_Produto`),
  KEY `fk_Fornecedores_Produto` (`Id_Fornecedores`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `produtos`
--

INSERT INTO `produtos` (`Id_Produto`, `Id_Fornecedores`, `Preco`, `Nome_Produto`, `Tipo_Produto`, `Unidade`, `Cod_Barras`, `Qtde_Disponivel`, `Data_Validade`) VALUES
(5, 1, '13.00', 'Pão Frances', 'Panificações', '2', '2002860', '99999', '2020-07-19'),
(6, 1, '4.00', 'Coca Cola 290ml ', 'Refrigerantes', '1', '7123456789', '99999', '2020-07-19'),
(7, 1, '18.00', 'Pão Italiano', 'Panificações', '2', '2002860000000', '99999', '2020-07-21'),
(8, 1, '18.00', 'Pão Integral', 'Panificações', '2', '2002870', '99999', '2020-07-21');

-- --------------------------------------------------------

--
-- Estrutura da tabela `venda_efetuada`
--

DROP TABLE IF EXISTS `venda_efetuada`;
CREATE TABLE IF NOT EXISTS `venda_efetuada` (
  `Id_Venda` int(11) NOT NULL AUTO_INCREMENT,
  `Id_Funcionario` int(11) NOT NULL,
  `Id_Cliente` int(11) NOT NULL,
  `Id_Pedido` int(11) NOT NULL,
  `Pagamento` varchar(10) NOT NULL,
  `Valor_Venda` decimal(10,2) NOT NULL,
  `Data_Venda` varchar(10) NOT NULL,
  `Turno` int(1) NOT NULL,
  `Hora_Venda` varchar(10) NOT NULL,
  PRIMARY KEY (`Id_Venda`),
  KEY `fk_Vendas_Funcionario` (`Id_Funcionario`),
  KEY `fk_Vendas_Pedido` (`Id_Pedido`),
  KEY `fk_Vendas_Clientes` (`Id_Cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=114 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `venda_efetuada`
--

INSERT INTO `venda_efetuada` (`Id_Venda`, `Id_Funcionario`, `Id_Cliente`, `Id_Pedido`, `Pagamento`, `Valor_Venda`, `Data_Venda`, `Turno`, `Hora_Venda`) VALUES
(30, 1, 1, 12, 'Dinheiro', '4.00', '21/07/2020', 2, '22:42:08'),
(31, 1, 1, 13, 'Crédito', '4.00', '22/07/2020', 2, '21:39:03'),
(32, 1, 5, 14, 'Dinheiro', '8.00', '22/07/2020', 2, '21:39:31'),
(33, 1, 1, 15, 'Dinheiro', '4.00', '22/07/2020', 5, '21:43:58'),
(34, 1, 5, 16, 'Dinheiro', '500.00', '22/07/2020', 3, '21:52:39'),
(35, 1, 4, 17, 'Dinheiro', '500.00', '22/07/2020', 3, '21:53:09'),
(36, 1, 5, 18, 'Dinheiro', '100.00', '22/07/2020', 3, '22:04:20'),
(37, 1, 1, 19, 'Dinheiro', '1500.00', '22/07/2020', 3, '22:07:43'),
(38, 1, 4, 20, 'Dinheiro', '1500.00', '22/07/2020', 3, '22:15:46'),
(39, 1, 4, 21, 'Dinheiro', '1.00', '22/07/2020', 3, '22:18:14'),
(40, 1, 4, 22, 'Dinheiro', '1.00', '22/07/2020', 4, '22:45:59'),
(41, 1, 5, 23, 'Dinheiro', '15.00', '22/07/2020', 3, '23:01:37'),
(42, 1, 4, 24, 'Dinheiro', '200.00', '23/07/2020', 0, '19:51:00'),
(43, 1, 5, 25, 'Dinheiro', '20.00', '23/07/2020', 0, '20:15:38'),
(44, 1, 5, 26, 'Dinheiro', '44.00', '23/07/2020', 0, '20:16:00'),
(45, 1, 5, 27, 'Dinheiro', '20.00', '23/07/2020', 0, '20:17:27'),
(46, 1, 5, 28, 'Dinheiro', '20.00', '23/07/2020', 0, '20:18:04'),
(47, 1, 5, 29, 'Dinheiro', '15.00', '23/07/2020', 0, '20:18:43'),
(48, 1, 5, 30, 'Dinheiro', '15.00', '23/07/2020', 0, '20:19:30'),
(49, 1, 5, 31, 'Dinheiro', '200.00', '23/07/2020', 0, '21:42:14'),
(50, 1, 1, 32, 'Débito', '8.00', '23/07/2020', 0, '22:18:04'),
(51, 1, 1, 33, 'Crédito', '12.00', '23/07/2020', 0, '22:18:27'),
(52, 1, 1, 34, 'Débito', '4.00', '23/07/2020', 0, '22:20:45'),
(53, 1, 1, 35, 'Dinheiro', '200.00', '23/07/2020', 0, '22:27:41'),
(54, 1, 1, 36, 'Dinheiro', '400.00', '23/07/2020', 0, '22:28:06'),
(55, 1, 1, 37, 'Débito', '4.00', '23/07/2020', 0, '22:28:17'),
(56, 1, 1, 38, 'Crédito', '4.00', '23/07/2020', 0, '22:28:25'),
(57, 1, 1, 39, 'Dinheiro', '4.00', '23/07/2020', 0, '22:30:09'),
(58, 1, 1, 40, 'Dinheiro', '4.00', '23/07/2020', 0, '22:30:32'),
(59, 1, 1, 41, 'Débito', '4.00', '23/07/2020', 0, '22:30:56'),
(60, 1, 1, 42, 'Débito', '4.00', '23/07/2020', 0, '22:31:21'),
(61, 1, 1, 43, 'Crédito', '4.00', '23/07/2020', 0, '22:31:36'),
(62, 1, 1, 44, 'Crédito', '4.00', '23/07/2020', 0, '22:31:43'),
(63, 1, 4, 45, 'A Prazo', '4.00', '23/07/2020', 0, '22:33:51'),
(64, 1, 1, 46, 'Débito', '4.00', '23/07/2020', 3, '22:58:55'),
(65, 1, 1, 47, 'Débito', '12.00', '23/07/2020', 2, '23:11:41'),
(66, 1, 1, 48, 'Dinheiro', '4.00', '23/07/2020', 5, '23:12:18'),
(67, 1, 1, 49, 'Dinheiro', '15.00', '23/07/2020', 2, '23:15:26'),
(68, 1, 1, 50, 'Dinheiro', '4.00', '23/07/2020', 4, '23:33:35'),
(69, 1, 1, 51, 'Dinheiro', '8.00', '23/07/2020', 3, '23:39:55'),
(70, 1, 1, 52, 'Dinheiro', '4.00', '23/07/2020', 4, '23:48:17'),
(71, 1, 1, 53, 'Dinheiro', '15.00', '23/07/2020', 3, '23:49:36'),
(72, 1, 1, 54, 'Dinheiro', '1500.00', '23/07/2020', 3, '23:51:13'),
(73, 1, 1, 55, 'Dinheiro', '1500.00', '23/07/2020', 5, '23:52:44'),
(74, 1, 1, 56, 'Dinheiro', '1500.00', '23/07/2020', 3, '23:55:16'),
(75, 1, 1, 57, 'Dinheiro', '1500.00', '23/07/2020', 2, '23:57:01'),
(76, 1, 1, 58, 'Dinheiro', '1500.00', '23/07/2020', 3, '23:57:47'),
(77, 1, 1, 59, 'Dinheiro', '1000.00', '23/07/2020', 2, '23:58:23'),
(78, 1, 1, 60, 'Dinheiro', '100.00', '23/07/2020', 3, '23:58:52'),
(79, 1, 1, 62, 'Dinheiro', '15.00', '24/07/2020', 3, '00:01:15'),
(80, 1, 1, 63, 'Dinheiro', '30.00', '24/07/2020', 3, '00:02:00'),
(81, 1, 1, 64, 'Dinheiro', '1500.00', '24/07/2020', 3, '00:04:16'),
(82, 1, 1, 65, 'Débito', '1500.00', '24/07/2020', 5, '00:04:51'),
(83, 1, 1, 66, 'Crédito', '1500.00', '24/07/2020', 5, '00:13:43'),
(84, 1, 1, 67, 'Crédito', '250.00', '24/07/2020', 3, '00:15:32'),
(85, 1, 4, 68, 'A Prazo', '250.00', '24/07/2020', 4, '00:18:12'),
(86, 1, 5, 69, 'A Prazo', '250.00', '24/07/2020', 3, '00:19:48'),
(87, 1, 4, 70, 'A Prazo', '24.00', '24/07/2020', 3, '01:43:08'),
(88, 1, 1, 71, 'Débito', '200.00', '24/07/2020', 3, '01:44:18'),
(89, 1, 1, 72, 'Crédito', '237.50', '24/07/2020', 3, '01:45:33'),
(90, 1, 1, 73, 'Dinheiro', '458.12', '24/07/2020', 3, '01:45:50'),
(91, 1, 5, 74, 'A Prazo', '108.50', '24/07/2020', 3, '01:46:03'),
(92, 1, 1, 75, 'Dinheiro', '4.00', '24/07/2020', 0, '18:40:15'),
(93, 1, 1, 76, 'Dinheiro', '125.00', '24/07/2020', 0, '20:23:40'),
(94, 1, 1, 77, 'Dinheiro', '800.00', '24/07/2020', 0, '20:23:54'),
(95, 1, 1, 78, 'Débito', '500.00', '24/07/2020', 0, '20:24:03'),
(96, 1, 1, 79, 'Crédito', '325.70', '24/07/2020', 0, '20:24:13'),
(97, 1, 5, 80, 'A Prazo', '97.84', '24/07/2020', 0, '20:24:23'),
(98, 1, 1, 81, 'Dinheiro', '1149.13', '24/07/2020', 0, '20:36:38'),
(99, 1, 1, 82, 'Débito', '243.71', '24/07/2020', 0, '20:37:00'),
(100, 1, 1, 83, 'Crédito', '420.00', '24/07/2020', 0, '20:37:14'),
(101, 1, 5, 84, 'A Prazo', '87.12', '24/07/2020', 0, '20:37:32'),
(102, 6, 1, 85, 'Dinheiro', '1280.50', '24/07/2020', 0, '21:08:57'),
(103, 6, 1, 86, 'Débito', '528.80', '24/07/2020', 0, '21:09:10'),
(104, 6, 1, 87, 'Crédito', '150.00', '24/07/2020', 0, '21:09:16'),
(105, 6, 5, 88, 'A Prazo', '88.70', '24/07/2020', 0, '21:09:26'),
(106, 1, 1, 89, 'Dinheiro', '1420.79', '24/07/2020', 0, '21:11:01'),
(107, 1, 1, 90, 'Débito', '150.00', '24/07/2020', 0, '21:11:14'),
(108, 1, 1, 91, 'Crédito', '120.00', '24/07/2020', 0, '21:11:22'),
(109, 1, 5, 92, 'A Prazo', '12.90', '24/07/2020', 0, '21:11:31'),
(110, 6, 1, 93, 'Dinheiro', '4.00', '24/07/2020', 0, '21:32:02'),
(111, 6, 1, 94, 'Débito', '4.00', '24/07/2020', 0, '21:51:20'),
(112, 6, 1, 95, 'Débito', '8.00', '24/07/2020', 0, '21:57:27'),
(113, 6, 1, 96, 'Débito', '4.00', '24/07/2020', 0, '21:58:25');

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `funcionario_padaria`
--
ALTER TABLE `funcionario_padaria`
  ADD CONSTRAINT `fk_Permissoes_Funcionario` FOREIGN KEY (`Id_Permissoes`) REFERENCES `permissoes` (`Id_Permissoes`);

--
-- Limitadores para a tabela `gastoscliente`
--
ALTER TABLE `gastoscliente`
  ADD CONSTRAINT `fk_Gastos_Cliente` FOREIGN KEY (`Id_Cliente`) REFERENCES `cliente_padaria` (`Id_Cliente`);

--
-- Limitadores para a tabela `produtos`
--
ALTER TABLE `produtos`
  ADD CONSTRAINT `fk_Fornecedores_Produto` FOREIGN KEY (`Id_Fornecedores`) REFERENCES `fornecedores` (`Id_Fornecedores`);

--
-- Limitadores para a tabela `venda_efetuada`
--
ALTER TABLE `venda_efetuada`
  ADD CONSTRAINT `fk_Vendas_Clientes` FOREIGN KEY (`Id_Cliente`) REFERENCES `cliente_padaria` (`Id_Cliente`),
  ADD CONSTRAINT `fk_Vendas_Funcionario` FOREIGN KEY (`Id_Funcionario`) REFERENCES `funcionario_padaria` (`Id_Funcionario`),
  ADD CONSTRAINT `fk_Vendas_Pedido` FOREIGN KEY (`Id_Pedido`) REFERENCES `pedido` (`Id_Pedido`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
