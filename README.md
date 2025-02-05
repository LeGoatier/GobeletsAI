![Une image du jeu gobelets](https://trictrac.net/_next/image?url=https%3A%2F%2Fcdn10.trictrac.net%2Ftrictrac%2Fdc%2Fdb%2Fa4594b09ecbbf12af447f28b2eeae881e93e.jpeg&w=750&q=75)
##Projet personnel de créer un bot pour le jeu Gobelets
Le jeu Gobelets est un jeu de société qui ressemble beaucoup au Tic Tac Toe, mais avec une touche de complexité de plus:
il est possible de manger les pièces de son adversaire. J'apprenais comment fonctionnaient les algorithmes minimax et après
avoir réussi à faire un bot parfait pour le tic tac toe, je me suis lancé le défi de faire la même chose pour ce jeu.

J'ai réalisé assez rapidement que c'était loin d'être aussi simple, car le jeu de Gobelets peut se jouer à l'infini, car les pièces bougent,
comme aux échecs. J'ai donc dû créer une fonction d'évaluation, mais j'ai réalisé assez vite que pour s'exécuter dans un temps raisonnable,
je ne pouvais que chercher 3 layers de profondeurs avec ma première version de minmax. J'ai donc travaillé à faire une version 2, puis une version 3.
Il me reste plusieurs améliorations à faire, entre autres:
-Convertir la structure décrivant l'état du jeu et tableau complètement binaire afin de réduire la taille en mémoire et le nombre d'opérations
-Vérifier les symétries et les positions qui se recoupent afin de couper des branches de l'arbre
-Améliorer la fonction d'évaluation afin qu'elle représente mieux les chances de victoires
-Et beaucoup plus encore

##Comment tester
Ce projet est conçu pour être exécuté sur Unity. J'ajouterai peut-être un exécutable bientôt. Je n'ai pas mis tous les fichiers, mais normalement
Unity génère tout ce qui n'est pas dans Assets à l'ouverture du projet. Laissez-moi savoir s'il y a un problème avec l'exécution.
