create database if not exists db_EVE_fake;

-- MySQL Workbench Forward Engineering

USE `db_eve_fake` ;

-- -----------------------------------------------------
-- Table `db_eve_fake`.`tblcharakter`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_eve_fake`.`tblcharakter` (
  `C_id` INT NOT NULL,
  `C_Name` VARCHAR(30) NULL DEFAULT NULL,
  `C_Money` FLOAT NULL DEFAULT NULL,
  PRIMARY KEY (`C_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `db_eve_fake`.`tblItems`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_eve_fake`.`tblItems` (
  `I_Id` INT NOT NULL,
  PRIMARY KEY (`I_Id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_eve_fake`.`tblRaumschiff`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_eve_fake`.`tblRaumschiff` (
  `R_Id` INT NOT NULL,
  `R_Name` VARCHAR(45) NULL,
  `R_Preis` FLOAT NULL,
  `R_Schnelligkeit_Jumps` VARCHAR(45) NULL,
  `tblItems_I_Id` INT NOT NULL,
  PRIMARY KEY (`R_Id`),
  INDEX `fk_tblRaumschiff_tblItems1_idx` (`tblItems_I_Id` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_eve_fake`.`tblHangar`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_eve_fake`.`tblHangar` (
  `H_Raumschiff_R_Id` INT NOT NULL,
  `H_charakter_C_id` INT NOT NULL,
  PRIMARY KEY (`H_Raumschiff_R_Id`, `H_charakter_C_id`),
  INDEX `fk_tblRaumschiff_has_tblcharakter_tblcharakter1_idx` (`H_charakter_C_id` ASC),
  INDEX `fk_tblRaumschiff_has_tblcharakter_tblRaumschiff_idx` (`H_Raumschiff_R_Id` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_eve_fake`.`tblMarkt`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_eve_fake`.`tblMarkt` (
  `M_Id` INT NOT NULL,
  PRIMARY KEY (`M_Id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_eve_fake`.`tblMarkt_Autraege`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_eve_fake`.`tblMarkt_Autraege` (
  `MA_Id` INT NOT NULL,
  `MA_Menge` VARCHAR(45) NULL,
  `MA_Items_I_Id` INT NULL,
  PRIMARY KEY (`MA_Id`),
  INDEX `fk_tblMarktAutraege_tblItems1_idx` (`MA_Items_I_Id` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_eve_fake`.`tblPro_Markt_Auftraege`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_eve_fake`.`tblPro_Markt_Auftraege` (
  `PMA_MarktAutraege_MA_Id` INT NOT NULL,
  `PMA_Markt_M_Id` INT NOT NULL,
  PRIMARY KEY (`PMA_MarktAutraege_MA_Id`, `PMA_Markt_M_Id`),
  INDEX `fk_tblMarktAutraege_has_tblMarkt_tblMarkt1_idx` (`PMA_Markt_M_Id` ASC),
  INDEX `fk_tblMarktAutraege_has_tblMarkt_tblMarktAutraege1_idx` (`PMA_MarktAutraege_MA_Id` ASC))
ENGINE = InnoDB;


