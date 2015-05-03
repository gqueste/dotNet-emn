# Projet .NET - Réservations #

Hadrien GERARD, Damien GOUJARD, Maxime PEROCHEAU, Joris PICHARD, Gabriel QUESTE

## User Story ##

### Page 0 : Création d'un compte ou authentification de l'utilisateur ###

L'utilisateur, s'il possède un compte, se connecte. Dans le cas contraire, il doit créer un compte via un formulaire.

Champs :

* Nom
* Prénom
* Email
* Mot de passe

### Page 1 : Saisie du voyage ###

L'utilisateur replit un formulaire sur le voyage qu'il veut réserver.

Champs :

* Date
* Ville Départ
* Ville Arrivée

L'utilisateur valide le formulaire.

### Page 2 : Saisie d'un vol ###

Liste des vols correspondant à la recherche.

L'utilisateur sélectionne le vol désiré.

### Page 3 : Saisie d'un hôtel ###

Liste des hôtels correspondant à la recherche.

L'utilisateur sélectionne l'hôtel désiré.

### Page 4 : Paiement ###

L'utilisateur remplit des informations sur le paiement, puis confirme.

**Lors de la confirmation, l'enregistrement est vraiment fait en BDD.**

### Page 5 : Affichage de la commande ###

Récapitulatif de la commande effectuée

### Page 5-bis : Annulation de la commande ###

Possibilité pour l'utilisateur d'annuler sa commande.
Une popup de confirmation apparaît et l'écran des commandes est rafraîchi.

**Lors de l'affichage de la popup, la suppression de la réservation est propagée en base.**

## SQL ##

* VOLS (lecture)
    * idVol
    * nomVol
    * companie
    * dateVol
    * durée
    * villeDepart
    * villeArrivee
* HOTELS (lecture)
    * idHotel
    * nomHotel
    * descriptionHotel
    * ville
* CMDVOLS (écriture transactionnelle)
    * idCmdVol
    * idVol
    * date
    * nomUtilisateur
* CMDHOTELS (écriture transactionnelle)
    * idCmdHotel
    * idHotel
    * date
    * nomUtilisateur


## WebServices ##

* serviceVols
    * getVolsDisponibles(villeDepart, villeArrivee, date)
    * getVol(idVol)
* serviceHotels
    * getHotelsDisponibles(ville)
    * getHotel(idHotel)
* serviceCommandes
    * reservation(idVol, idHotel date, nomUtilisateur)