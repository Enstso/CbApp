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

Create table Participe (
    idCours integer not null,
    idEleve integer not null,
    primary key(idCours,idEleve)
);

Create Table Eleve(
    id integer not null auto_increment,
    nom varchar(50),
    prenom varchar(50),
    mail varchar(50),
    telephone varchar(10),
    primary key(id)
);

insert into User (nom,prenom,mdp,administrator) values ('losio','admin','mdp',1);
insert into User (nom,prenom,mdp,administrator) values('Nom','BOB','mdp',0);
insert into Cours (nom,ladate,idUser)values('PC','2002-03-27',1);
insert into Eleve (nom,prenom,mail,telephone) values('Nom','Prenom','pre@outlook.com','0625467825');
insert into Eleve (nom,prenom,mail,telephone) values('Name','Pre','prezo@outlook.com','0622167825');
