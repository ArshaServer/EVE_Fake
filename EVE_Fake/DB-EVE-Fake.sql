create database if not exists db_EVE_fake;

-- MySQL Workbench Forward Engineering

USE `db_eve_fake` ;

drop table tblcharakter;
drop table tblplanet;
drop table tblLocation;
drop table tblraumschiff;
drop table tblmarkt;
drop table tblPro_Markt_Auftraege;
drop table tblMarkt_Autraege; 
drop table tblitem;

CREATE TABLE db_eve_fake.tblcharakter (
  C_id INT NOT NULL auto_increment,
  C_Name VARCHAR(30) NULL DEFAULT NULL,
  C_Money FLOAT NULL DEFAULT NULL,
  C_Location_ID INT,
  C_Raumschiff_ID Int,
  PRIMARY KEY (C_id),
  INDEX fk_tblCharakter_tblPlanet_idx(C_Location_ID),
  INDEX fk_Zugehöriges_Raumschiff_id(C_Raumschiff_ID)
)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;

Create Table if not Exists tblItem(
	I_ID int Not Null auto_increment,
    I_Type varchar(30),
    I_Item_Id int,
    Primary Key(I_ID),
    Index fk_AlleItems_ID(I_Item_Id)
);

Create Table if not Exists db_eve_fake.tblPlanet(
	P_Id int not null auto_increment,
    P_Name varchar(40),
    P_XKoordinate int,
    P_YKoordinate int,
	Primary Key(P_Id)
)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;

CREATE TABLE IF NOT EXISTS db_eve_fake.tblRaumschiff (
  R_Id INT NOT NULL auto_increment,
  R_Name VARCHAR(45) NULL,
  R_Schnelligkeit_Jumps VARCHAR(45) NULL,
  PRIMARY KEY (R_Id)
)
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS db_eve_fake.tblMarkt (
  M_Id INT NOT NULL auto_increment,
  M_Name varchar(50),
  PRIMARY KEY (M_Id)
)
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS db_eve_fake.tblLocation (
	L_ID INT NOT NULL auto_increment,
    L_Name varchar(50),
    L_Beschreibung varchar(300),
    L_ID_Planet int,
    L_ID_Markt int,
	Primary Key(L_ID),
    INDEX fk_Zugehöriger_Planet(L_ID_Planet),
    INDEX fk_Zugehöriger_Markt(L_ID_Markt)
)
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS db_eve_fake.tblMarkt_Autraege (
  MA_Id INT NOT NULL,
  MA_Menge VARCHAR(45) NULL,
  MA_Items_I_Id INT NULL,
  PRIMARY KEY (MA_Id),
  INDEX fk_tblMarktAutraege_tblItems1_idx (MA_Items_I_Id ASC))
ENGINE = InnoDB;


CREATE TABLE IF NOT EXISTS db_eve_fake.tblPro_Markt_Auftraege (
  PMA_MarktAutraege_MA_Id INT NOT NULL,
  PMA_Markt_M_Id INT NOT NULL,
  PRIMARY KEY (PMA_MarktAutraege_MA_Id, PMA_Markt_M_Id),
  INDEX fk_tblMarktAutraege_has_tblMarkt_tblMarkt1_idx (PMA_Markt_M_Id ASC),
  INDEX fk_tblMarktAutraege_has_tblMarkt_tblMarktAutraege1_idx (PMA_MarktAutraege_MA_Id ASC))
ENGINE = InnoDB;


insert into tblcharakter(C_Name, C_Money, C_Location_ID, C_Raumschiff_ID) values('Finn', 234, 1, 1);
insert into tblcharakter(C_Name, C_Money, C_Location_ID, C_Raumschiff_ID) values('FinnZwei', 23423, 1, 1);
insert into tblraumschiff(R_Name, R_Schnelligkeit_Jumps) values('Frachter', 50);
insert into tblraumschiff(R_Name, R_Schnelligkeit_Jumps) values('Kapsel', 100);
insert into tblPLanet(P_Name, P_XKoordinate, P_YKoordinate) values("Erde", 100, 100);
insert into tblPlanet(P_Name, P_XKoordinate, P_YKoordinate) values("Test Planet", 120, 80);
insert into tbllocation(L_Name, L_Beschreibung, L_ID_Planet, L_ID_Markt) values('Erde Boden', 'Kole Land', 1, 1);
insert into tbllocation(L_Name, L_Beschreibung, L_ID_Planet, L_ID_Markt) values('Erde Boden Zwei', 'Kole Land', 2, 1);
insert into tblmarkt values(0, 'Erden Markt');

/*select L.L_Name 
    from tbllocation L 
    join tblcharakter C 
    on C.C_Location_ID = L.L_ID
    where C.C_id = 0;

select * from tbllocation l
join tblplanet p on p.P_ID = l.L_ID_Planet; 


select * from tblplanet p
join tbllocation l on p.p_id = L_Id_Planet
join tblMarkt m on l.L_ID_Markt=m.M_Id
where P_id = 1;

select * from tblcharakter 
where C_id = 1;*/
