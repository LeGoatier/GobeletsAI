using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Case
{
    Stack<Piece> piecesContenues = new Stack<Piece>();
    public Piece dessus;
    public int PositionX { get; set; }
    public int PositionY { get; set; }

    public Vector2 Position { get; set; }
    public Case(int x, int y, Vector2 position)
    {
        PositionX = x;
        PositionY = y;
        Position = position;
    }

    public void AjouterPiece(Piece piece)
    {
        piece.enJeu = true;
        if (piecesContenues.Count != 0)
        {
            dessus.gameObject.SetActive(false);
        }
        Console.WriteLine(piece.gameObject.transform.position);
        piece.gameObject.transform.position = Position;
        Console.WriteLine(piece.gameObject.transform.position);
        dessus = piece;
        piecesContenues.Push(piece);
    }

    public void RetirerPieceDessus()
    {
        piecesContenues.Pop();
        if(piecesContenues.Count != 0)
        {
            dessus = piecesContenues.Peek();
            dessus.gameObject.SetActive(true);
        }
        else
        {
            dessus = null;
        }
    }


}
