-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema Sanidad
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema Sanidad
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Sanidad` DEFAULT CHARACTER SET utf8 ;
USE `Sanidad` ;

-- -----------------------------------------------------
-- Table `Sanidad`.`HOSPITAL`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Sanidad`.`HOSPITAL` (
  `Hospital_Cod` INT(2) NOT NULL,
  `Nombre` VARCHAR(10) NOT NULL,
  `Direccion` VARCHAR(20) NULL,
  `Cdad_Camas` INT(3) NULL,
  PRIMARY KEY (`Hospital_Cod`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Sanidad`.`SALA`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Sanidad`.`SALA` (
  `Hospital_Cod` INT(2) NOT NULL,
  `Sala_Cod` INT(2) NOT NULL,
  `Nombre` VARCHAR(20) NOT NULL,
  `Cdad_Camas` INT(3) NULL,
  PRIMARY KEY (`Sala_Cod`, `Hospital_Cod`),
  CONSTRAINT `Hospital_Cod`
    FOREIGN KEY (`Hospital_Cod`)
    REFERENCES `Sanidad`.`HOSPITAL` (`Hospital_Cod`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Sanidad`.`DOCTOR`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Sanidad`.`DOCTOR` (
  `Hospital_Cod` INT(2) NOT NULL,
  `Doctor_Cod` INT(3) NOT NULL,
  `Apellidos` VARCHAR(13) NOT NULL,
  `Especialidad` VARCHAR(16) NOT NULL,
  PRIMARY KEY (`Doctor_Cod`, `Hospital_Cod`),
  INDEX `Hospital_Cod_idx` (`Hospital_Cod` ASC) VISIBLE,
  CONSTRAINT `Hospital_Cod_prueba`
    FOREIGN KEY (`Hospital_Cod`)
    REFERENCES `Sanidad`.`HOSPITAL` (`Hospital_Cod`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Sanidad`.`PLANTILLA`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Sanidad`.`PLANTILLA` (
  `Hospital_Cod` INT(2) NOT NULL,
  `Sala_Cod` INT(2) NOT NULL,
  `Empleado_No` INT(4) NULL,
  `Apellidos` VARCHAR(15) NULL,
  `Funcion` VARCHAR(10) NULL,
  `Turno` VARCHAR(1) NULL,
  `Salario` INT(10) NULL,
  PRIMARY KEY (`Sala_Cod`, `Hospital_Cod`),
  CONSTRAINT `Hospital_Cod, Sala_Cod`
    FOREIGN KEY (`Hospital_Cod` , `Sala_Cod`)
    REFERENCES `Sanidad`.`SALA` (`Hospital_Cod` , `Sala_Cod`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Sanidad`.`ENFERMO`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Sanidad`.`ENFERMO` (
  `Inscripción` INT(5) NOT NULL,
  `Apellidos` VARCHAR(15) NOT NULL,
  `Direccion` VARCHAR(20) NULL,
  `Fecha_Nac` DATE NULL,
  `Sexo` VARCHAR(1) NOT NULL,
  `NSS` CHAR(9) NULL,
  PRIMARY KEY (`Inscripción`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Sanidad`.`INGRESOS`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Sanidad`.`INGRESOS` (
  `Inscripcion` INT(5) NOT NULL,
  `Hospital_Cod` INT(2) NOT NULL,
  `Sala_Cod` INT(2) NOT NULL,
  `Cama` INT(4) NULL,
  PRIMARY KEY (`Inscripcion`),
  INDEX `Hospital_Cod, Sala_Cod_idx` (`Hospital_Cod` ASC, `Sala_Cod` ASC) VISIBLE,
  CONSTRAINT `Hospital_Cod_prueba, Sala_Cod`
    FOREIGN KEY (`Hospital_Cod` , `Sala_Cod`)
    REFERENCES `Sanidad`.`SALA` (`Hospital_Cod` , `Sala_Cod`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `Inscripcion`
    FOREIGN KEY (`Inscripcion`)
    REFERENCES `Sanidad`.`ENFERMO` (`Inscripción`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
