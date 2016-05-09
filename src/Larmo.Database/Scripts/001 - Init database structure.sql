CREATE TABLE IF NOT EXISTS `author` (
  `Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `FullName` varchar(200) DEFAULT NULL,
  `Login` varchar(200) DEFAULT NULL,
  `Email` varchar(200) DEFAULT NULL,
  `Url` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE IF NOT EXISTS `project` (
  `Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  `Url` varchar(200) DEFAULT NULL,
  `Description` varchar(200) DEFAULT NULL,
  `Token` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE IF NOT EXISTS `input` (
  `Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE IF NOT EXISTS `message` (
  `Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `ProjectId` int(10) unsigned DEFAULT NULL,
  `AuthorId` int(10) unsigned DEFAULT NULL,
  `InputId` int(10) unsigned DEFAULT NULL,
  `InputType` varchar(50) NOT NULL,
  `Content` text,
  `Url` text,
  `Timestamp` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `fk_project` (`ProjectId`),
  KEY `fk_author` (`AuthorId`),
  KEY `fk_input` (`InputId`),
  CONSTRAINT `fk_author` FOREIGN KEY (`AuthorId`) REFERENCES `author` (`Id`) ON DELETE SET NULL ON UPDATE SET NULL,
  CONSTRAINT `fk_input` FOREIGN KEY (`InputId`) REFERENCES `input` (`Id`) ON DELETE SET NULL ON UPDATE SET NULL,
  CONSTRAINT `fk_project` FOREIGN KEY (`ProjectId`) REFERENCES `project` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE IF NOT EXISTS `extradata` (
  `Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `MessageId` int(10) unsigned NOT NULL DEFAULT '0',
  `Key` varchar(250) DEFAULT NULL,
  `Value` text,
  PRIMARY KEY (`Id`),
  KEY `fk_message` (`MessageId`),
  CONSTRAINT `fk_message` FOREIGN KEY (`MessageId`) REFERENCES `message` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;