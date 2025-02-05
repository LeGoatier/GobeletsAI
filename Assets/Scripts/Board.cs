using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    Case[,] cases = new Case[3,3];

    static public Board instance;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
            instance = this;

        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                cases[i, j] = new Case(i, j, new Vector2(-3 + i * 3, -3 + j * 3));
            }
        }
    }
    
    public bool AjouterPiece(int x, int y, Piece piece)
    {
        Case caseChoisie = cases[x, y];
        bool pieceAjoutée = EstPieceAjoutable(caseChoisie, piece);
        if (pieceAjoutée)
        {
            if (piece.enJeu)
            {
                cases[piece.position.x, piece.position.y].RetirerPieceDessus();
            }
            caseChoisie.AjouterPiece(piece);
            piece.position = (x, y);
            GameManager.instance.ChangerTour();
            GameManager.instance.pieceSelectione = null;
            VerifierVictoire();
        }
        return pieceAjoutée;
    }

    private bool EstPieceAjoutable(Case caseChoisie, Piece piece)
    {
        return caseChoisie.dessus == null || caseChoisie.dessus.rang < piece.rang;
    }


    private void VerifierVictoire()
    {
        List<(Piece, Piece, Piece)> listeLignes = new List<(Piece, Piece, Piece)>();
        //Verticales
        listeLignes.Add((cases[0, 0].dessus, cases[0, 1].dessus, cases[0, 2].dessus));
        listeLignes.Add((cases[1, 0].dessus, cases[1, 1].dessus, cases[1, 2].dessus));
        listeLignes.Add((cases[2, 0].dessus, cases[2, 1].dessus, cases[2, 2].dessus));
        //Horizontales
        listeLignes.Add((cases[0, 0].dessus, cases[1, 0].dessus, cases[2, 0].dessus));
        listeLignes.Add((cases[0, 1].dessus, cases[1, 1].dessus, cases[2, 1].dessus));
        listeLignes.Add((cases[0, 2].dessus, cases[1, 2].dessus, cases[2, 2].dessus));
        //Diagonales
        listeLignes.Add((cases[0, 0].dessus, cases[1, 1].dessus, cases[2, 2].dessus));
        listeLignes.Add((cases[2, 0].dessus, cases[1, 1].dessus, cases[0, 2].dessus));

        foreach((Piece, Piece, Piece) ligne in listeLignes)
        {
            if(ligne.Item1 != null && ligne.Item2 != null && ligne.Item3 != null)
            {
                if (ligne.Item1.color == ligne.Item2.color && ligne.Item1.color == ligne.Item3.color)
                {
                    if(ligne.Item1.color == Color.blue)
                        print("Bleu a gagné");
                    else
                        print("Rouge a gagné");
                }
            }
        }
    }

}
