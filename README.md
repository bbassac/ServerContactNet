Projet de démonstration de Dotnet Core avec VisualStudio 2015

. Ouvrir le fichier .sln dans le studio
. Executer un "Build solution" (utilise NuGet pour la gestion des dépendances)
. Executer le main pour lancer le projet d'exemple avec Kestrel
. Executer un "publish" dans le cas où vous désirez construire une image Docker avec l'exemple
. Executer un "docker build -t server ." pour générer l'image docker
. Executer un "docker run -p 5000:5000 server" pour éxécuter l'image docker

. Faire un POST vide sur http://localhost:5000/api/Contacts -> Doit retourner un 204 : no Content
. Faire un GET sur http://localhost:5000/api/Contacts retourne la liste des contacts
. Faire un GET sur http://localhost:5000/api/Contacts/{id} retourne le détail d'un contact


