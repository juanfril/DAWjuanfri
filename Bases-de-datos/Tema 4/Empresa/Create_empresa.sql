-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema TematicaEmpresa
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema TematicaEmpresa
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `TematicaEmpresa` DEFAULT CHARACTER SET utf8 ;
USE `TematicaEmpresa` ;

-- -----------------------------------------------------
-- Table `TematicaEmpresa`.`DEPT`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `TematicaEmpresa`.`DEPT` (
  `Dept_No` INT(2) NOT NULL,
  `Dnombre` VARCHAR(14) NOT NULL,
  `Loc` VARCHAR(14) NULL,
  PRIMARY KEY (`Dept_No`),
  UNIQUE INDEX `Dnombre_UNIQUE` (`Dnombre` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `TematicaEmpresa`.`EMP`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `TematicaEmpresa`.`EMP` (
  `Emp_no` INT(4) NOT NULL,
  `Apellido` VARCHAR(10) NOT NULL,
  `Oficio` VARCHAR(10) NULL,
  `Jefe` INT(4) NULL,
  `Fecha_Alta` DATE NULL,
  `Salario` INT(10) NULL,
  `Comision` INT(10) NULL,
  `Dept_no` INT(2) NOT NULL,
  PRIMARY KEY (`Emp_no`),
  INDEX `Dept_No_idx` (`Jefe` ASC) VISIBLE,
  CONSTRAINT `Dept_No`
    FOREIGN KEY (`Jefe`)
    REFERENCES `TematicaEmpresa`.`DEPT` (`Dept_No`)
    ON DELETE NO ACTION
    ON UPDATE CASCADE,
  CONSTRAINT `Jefe`
    FOREIGN KEY (`Emp_no`)
    REFERENCES `TematicaEmpresa`.`EMP` (`Jefe`)
    ON DELETE NO ACTION
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `TematicaEmpresa`.`CLIENTE`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `TematicaEmpresa`.`CLIENTE` (
  `Cliente_Cod` INT(6) NOT NULL,
  `Nombre` VARCHAR(45) NOT NULL,
  `Direccion` VARCHAR(40) NOT NULL,
  `Ciudad` VARCHAR(30) NOT NULL,
  `Estado` VARCHAR(2) NULL,
  `Codigo_Postal` VARCHAR(9) NOT NULL,
  `Area` INT(3) NULL,
  `Telefono` VARCHAR(9) NULL,
  `Repr_Cod` INT(4) NULL,
  `Limite_Credito` DECIMAL(9,2) NULL,
  `Observaciones` TEXT NULL,
  PRIMARY KEY (`Cliente_Cod`),
  CONSTRAINT `Repr_Cod`
    FOREIGN KEY (`Cliente_Cod`)
    REFERENCES `TematicaEmpresa`.`EMP` (`Emp_no`)
    ON DELETE NO ACTION
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `TematicaEmpresa`.`PRODUCTO`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `TematicaEmpresa`.`PRODUCTO` (
  `Prod_Num` INT(6) NOT NULL,
  `Descripcion` VARCHAR(30) NOT NULL,
  PRIMARY KEY (`Prod_Num`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `TematicaEmpresa`.`PEDIDO`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `TematicaEmpresa`.`PEDIDO` (
  `Ped_Num` INT(4) NOT NULL,
  `Ped_Fecha` DATE NULL,
  `Ped_Tipo` VARCHAR(1) NULL,
  `Cliente_Cod` INT(6) NOT NULL,
  `Fecha_Pedido` DATE NULL,
  `Total` DECIMAL(8,2) NULL,
  PRIMARY KEY (`Ped_Num`),
  INDEX `Cliente_Cod_idx` (`Cliente_Cod` ASC) VISIBLE,
  CONSTRAINT `Cliente_Cod`
    FOREIGN KEY (`Cliente_Cod`)
    REFERENCES `TematicaEmpresa`.`CLIENTE` (`Cliente_Cod`)
    ON DELETE NO ACTION
    ON UPDATE CASCADE)
ENGINE = InnoDB
COMMENT = '					';


-- -----------------------------------------------------
-- Table `TematicaEmpresa`.`DETALLE`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `TematicaEmpresa`.`DETALLE` (
  `Ped_Num` INT(4) NOT NULL,
  `Detalle_Num` INT(4) NOT NULL,
  `Prod_Num` INT(6) NOT NULL,
  `Precio_Venta` DECIMAL(8,2) NULL,
  `Cantidad` INT(8) NULL,
  `Importe` DECIMAL(8,2) NULL,
  PRIMARY KEY (`Detalle_Num`, `Ped_Num`),
  INDEX `Prod_Num_idx` (`Prod_Num` ASC) VISIBLE,
  CONSTRAINT `Ped_Num`
    FOREIGN KEY (`Ped_Num`)
    REFERENCES `TematicaEmpresa`.`PEDIDO` (`Ped_Num`)
    ON DELETE NO ACTION
    ON UPDATE CASCADE,
  CONSTRAINT `Prod_Num`
    FOREIGN KEY (`Prod_Num`)
    REFERENCES `TematicaEmpresa`.`PRODUCTO` (`Prod_Num`)
    ON DELETE NO ACTION
    ON UPDATE CASCADE)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
