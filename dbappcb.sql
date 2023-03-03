drop database if exists dbappcb;
Create database dbappcb;
use dbappcb;

Create Table User(
    id integer not null auto_increment,
    nom varchar(50),
    prenom varchar(50),
    mdp varchar(50),
    administrator boolean,
    primary key(id)
);

Create  Table Cours(
    id integer not null auto_increment,
    nom varchar(100),
    idUser integer,
    ladate DateTime,
    primary key(id),
    foreign key (idUser) references User(id)
);


Create Table Eleve(
    id integer not null auto_increment,
    nom varchar(50),
    prenom varchar(50),
    mail varchar(50),
    telephone varchar(10),
    idCours integer,
    primary key(id),
    foreign key (idCours) references Cours(id)

);
insert into User (nom,prenom,mdp,administrator) values ('losio','admin','mdp',1);
insert into User (nom,prenom,mdp,administrator) values('Nom','BOB','mdp',0);
insert into Cours (nom,ladate,idUser)values('PC',1,'2002-03-27');
insert into Eleve (nom,prenom,mail,telephone,idCours) values('Nom','Prenom','pre@outlook.com','0625467825',1);
insert into Eleve (nom,prenom,mail,telephone,idCours) values('Name','Pre','prezo@outlook.com','0622167825',1);
