![Une image du jeu gobelets](https://trictrac.net/_next/image?url=https%3A%2F%2Fcdn10.trictrac.net%2Ftrictrac%2Fdc%2Fdb%2Fa4594b09ecbbf12af447f28b2eeae881e93e.jpeg&w=750&q=75)

## Projet personnel de créer un bot pour le jeu Gobelets

Le jeu Gobelets est un jeu de société qui ressemble beaucoup au Tic-Tac-Toe, mais avec une touche de complexité supplémentaire :  
il est possible de **manger les pièces de son adversaire**.  

J'apprenais comment fonctionnaient les **algorithmes Minimax** et, après avoir réussi à faire un bot parfait pour le Tic-Tac-Toe,  
je me suis lancé le défi de faire la même chose pour ce jeu.

J'ai réalisé assez rapidement que c'était loin d'être aussi simple, car **le jeu de Gobelets peut se jouer à l'infini**,  
les pièces pouvant bouger comme aux échecs.  

J'ai donc dû créer une **fonction d'évaluation**, mais j'ai vite constaté que pour s'exécuter dans un temps raisonnable,  
je ne pouvais chercher qu'à **3 niveaux de profondeur** avec ma première version de Minimax.  

J'ai ensuite développé une **version 2**, puis une **version 3**.

---

### 🚀 Améliorations prévues :
- **Optimisation mémoire** : convertir la structure du jeu en un tableau **binaire** pour réduire l’espace mémoire et les opérations.  
- **Optimisation de l’algorithme** : détecter les **symétries et les positions redondantes** pour couper des branches de l'arbre.  
- **Amélioration de la fonction d’évaluation** : mieux estimer les chances de victoire.  
- **Autres optimisations à explorer**...

---

## 🔧 Comment tester ?

Ce projet est conçu pour être exécuté sur **Unity**.  

Je n'ai pas mis tous les fichiers, mais Unity devrait **générer les fichiers manquants** à l'ouverture du projet.  

👉 **Un exécutable sera peut-être ajouté bientôt.**  

Si vous avez des problèmes d'exécution, laissez-moi savoir ! 😊
