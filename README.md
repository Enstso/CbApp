# Documentation de cbApp

Contexte : Pour faciliter la gestion des cours du cabinet, nous avons proposé à notre maitre de stage, une application C# permettant de gérer les cours d'anglais du jour avec un sysème d'authentification, afin que chaque personne du cabinet puissent utiliser le logiciel. 

## Base de données 
 ```sql
Drop database if exists dbappcb;
Create database dbappcb;
use dbappcb;

Create Table User(
    id integer not null auto_increment,
    nom varchar(50),
    prenom varchar(50),
    mdp varchar(100),
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

insert into User (nom,prenom,mdp,administrator) values ('Cyril','admin','8296b82b0a068891c542086fe6f3a87d4c1de3536cf2c2f7d031872a10186ff1',1);
 ```
<br>

### Cas d'utilisations :

```plantuml
@startuml Appcb
left to right direction
:Admin:
package Appcb{
    Admin--(Se connecter)
    (Se connecter)<..(Consulter ses cours) : <<include>>
	(Se connecter)<..(Planifier des cours) : <<include>>
	(Se connecter)<..(Ajouter des utilisateurs) : <<include>>
    (Se connecter)<..(Supprimer des utilisateurs) : <<include>>
    
    
}
@enduml
```

```plantuml
@startuml Appcb
left to right direction
:User:
package Appcb{
    User--(Se connecter)
    (Se connecter)<..(Consulter ses cours du jour) : <<include>>
	(Se connecter)<..(Voir ses élèves du jour) : <<include>>

}
@enduml
```

 Nous avons procédé, au hachage du mot de passe.

 Le mot passe admin en clair est Grizzli.

L'interface de connexion :

 ![img](imgdoc/login.PNG)

<br>

Je suis connecté en tant qu' administrateur.

J'ai le choix entre voir les cours du jour, voir les eleves ou les utilisateurs : 


![img](imgdoc/MainAdmin.PNG)


<br>

Nous avons la liste des utilisateurs :

![img](imgdoc/VoirUser.PNG)  

<br>

Nous allons ajouter un nouvel utilisateur :

![img](imgdoc/newUser.PNG)

![img](imgdoc/f1.PNG)

<br>

Le nouvel utilisateur a bien été ajouté :

![img](imgdoc/f2.PNG)

Nous revenons sur le menu principal et cliquons sur voir les cours :

![img](imgdoc/MainAdmin.PNG)

Nous ajoutons un nouveau cours :


![img](imgdoc/f4.PNG)

le cours a bien été ajouté :


![img](imgdoc/f3.PNG)

Nous revenons sur le menu  principal et cliquons sur voir les elèves et cliquons sur ajouter :

![img](imgdoc/MainAdmin.PNG)



<br>

<br>
 
 Nous pouvons voir les 2 élèves enregistrés, pour ajouter un nouvel élève cliquons sur Ajouter  :


![img](imgdoc/VoirEleve.PNG)


Saisissons les informations :

![img](imgdoc/newEleve.PNG)

<br>

Le nouvel élève a bien été ajouté :

![img](imgdoc/f5.PNG)

En cliquant sur L'élève nous accèdons à sa fiche :

![img](imgdoc/f6.PNG)

Nous revenons au menu principal et ajoutons cet élève au cours de Bob :



![img](imgdoc/f7.PNG)

Nous cliquons sur ajouter, pour ajouter l'élève :

![img](imgdoc/f8.PNG)

Chosissons Adam : 

![img](imgdoc/f9.PNG)

L'élève a bien été inscrit :

![img](imgdoc/f10.PNG)



Connectons nous en tant que Bob pour consulter ses cours.


![img](imgdoc/f11.PNG)

Le cours du jour de Bob est "Essai de" pour le 18/12/2022 à 15 h :

![img](imgdoc/f12.PNG)

Bob regarde les élèves de son cours, nous retrouvons Adam:

![img](imgdoc/f13.PNG)

La fiche d'Adam :


![img](imgdoc/f14.PNG)

Pour tester notre mot de passe, nous avons récupéré la somme de contrôle et mise sur Crackstation :

![img](imgdoc/f15.PNG)

Le mot de passe admin a bien été retrouvé.

Pour remédier à cela, il faut premièrement sensibiliser les différents utilisateurs, pour qu'ils priviligienet des mots de passes forts. De plus nous allons procéder aus salage du mot de passe.


Le salage de mot de passe est une méthode pour rendre l'empreinte des mots de passe plus sûre en ajoutant aux mots de passe une chaîne de caractères aléatoires avant qu' ils soient hashés.

Le code permettant le salage, lors de la création d'un nouvel utilisateur :

![img](imgdoc/f16.PNG)

Pour la phase de test nous hashons notre potentiel futur mot de passe :

![img](imgdoc/f17.PNG)

La somme de contrôle du mot n'a pas été déterminée :

![img](imgdoc/f18.PNG)

Code permettant le salage lors de l'authentification :

![img](imgdoc/f19.PNG)

Tentative de connexion :


![img](imgdoc/f20.PNG)

Résultat :

![img](imgdoc/f21.PNG)
