
CREATE DATABASE `tradelog`;

USE `tradelog`;


CREATE TABLE `user`(
  `nev` varchar(40) NOT NULL,
  `loginname` varchar (40) NOT NULL,
  `loginpass` varchar (30) NOT NULL,
  `aktualistoke` double(50,8) NOT NULL DEFAULT 0,
  CONSTRAINT `user_PK` PRIMARY KEY (`nev`)
) ENGINE=INNODB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

CREATE TABLE `pozicio`(
  `key` int NOT NULL AUTO_INCREMENT,
  `nevid` varchar (40),
  `ticket` varchar (20),
  `devizapar` varchar (10),
  `mennyiseg` double(50,2),
  `pricenyit` double(50,8),
  `stop` double(50,8),
  `cel` double(50,8),
  `zar` double(50,8),
  `vegosszeg` double(50,8),
  `keputvonal` varchar(180),
  `megjegyzes` text,
  `valasztottidosik` varchar(10),
  `jegyzettido` datetime,
  CONSTRAINT `pozicio_PK` PRIMARY KEY (`key`),
  CONSTRAINT `pozicio_FK` FOREIGN KEY (`nevid`) REFERENCES `user`(`nev`)
) ENGINE=INNODB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

