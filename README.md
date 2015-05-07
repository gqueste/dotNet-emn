# Projet .NET - Réservations #

Hadrien GERARD, Damien GOUJARD, Maxime PEROCHEAU, Joris PICHARD, Gabriel QUESTE

## User Story ##


### Page 1 : Saisie du voyage ###

L'utilisateur remplit un formulaire sur le voyage qu'il veut réserver.

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
    * getVillesDepart()
    * getVillesArrivee()
* serviceHotels
    * getHotelsDisponibles(ville)
    * getHotel(idHotel)
* serviceCommandes
    * reservation(idVol, idHotel date, nomUtilisateur)