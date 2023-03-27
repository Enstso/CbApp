drop database if exists dbappcb;
Create database dbappcb;
use dbappcb;



Create Table user(
    id integer not null auto_increment,
    nom varchar(50),
    prenom varchar(50),
    mdp varchar(100),
    administrator boolean,
    primary key(id)
);

Create  Table cours(
    id integer not null auto_increment,
    nom varchar(100),
    idUser integer,
    ladate DateTime,
    primary key(id),
    foreign key (idUser) references user(id)
);

Create Table eleve(
    id integer not null auto_increment,
    nom varchar(50),
    prenom varchar(50),
    mail varchar(50),
    telephone varchar(10),
    primary key(id)
);

Create table participe (
    idCours integer not null,
    idEleve integer not null,
    primary key(idCours,idEleve),
    foreign key(idCours) references cours(id),
    foreign key(idEleve) references eleve(id)
);



insert into user (nom,prenom,mdp,administrator) values ('Cyril','admin','8296b82b0a068891c542086fe6f3a87d4c1de3536cf2c2f7d031872a10186ff1',1);
insert into user (nom,prenom,mdp,administrator) values('BOB','BOB','d08d46c99196b815f0f8577c6e9ce47ade2881c2fb164d4dc4fc4d59aa59c247',0);
insert into cours (nom,ladate,idUser)values('PC','2002-03-27',1);
insert into eleve (nom,prenom,mail,telephone) values('Nom','Prenom','pre@outlook.com','0625467825');
insert into eleve (nom,prenom,mail,telephone) values('Name','Pre','prezo@outlook.com','0622167825');

