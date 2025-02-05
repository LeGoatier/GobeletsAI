using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AIbasic
{
    static Board board = Board.instance;

    
    static public void JouerProchainCoup(Color couleur)
    {
        ChoisirPremierCoupPossible(couleur);
    }

    static private void ChoisirPremierCoupPossible(Color couleur)
    {
        if(couleur == Color.red)
        {
            foreach (GameObject piece in GameManager.instance.piecesRouges)
            {
                Piece script = piece.GetComponent<Piece>();
                for(int i = 0; i < 3; i++)
                {
                    for(int j = 0; j < 3; j++)
                    {
                        if(board.AjouterPiece(i, j, script))
                        {
                            return;//Devrait empêcher de jouer plusieurs coups à la fois
                        }
                    }
                }
            }
        }
        else
        {
            foreach (GameObject piece in GameManager.instance.piecesBleus)
            {
                Piece script = piece.GetComponent<Piece>();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (board.AjouterPiece(i, j, script))
                        {
                            return;//Devrait empêcher de jouer plusieurs coups à la fois
                        }
                    }
                }
            }
        }
    }
}
