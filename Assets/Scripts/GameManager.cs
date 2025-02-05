using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject prefabPiece;
    Color[] couleurs = new Color[] { Color.blue, Color.red };

    public GameObject[] piecesBleus = new GameObject[6];
    public GameObject[] piecesRouges = new GameObject[6];

    Color tour = Color.blue;

    public GameObject pieceSelectione;

    static public GameManager instance;

    //Pour le board
    Vector2 coinBasGauche = new Vector2(-4.5f, -4.5f);
    Vector2 coinHautDroite = new Vector2(4.5f, 4.5f);

    [SerializeField] bool AIBleu = false;
    [SerializeField] bool AIRouge = false;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
            instance = this;
        CreerPieces();
    }

    void CreerPieces()
    {
        for(int i = 0; i < piecesBleus.Length; i++)
        {
            float positionX;
            float positionY;
            piecesBleus[i] = Instantiate(prefabPiece);
            if(i < 2)
            {
                piecesBleus[i].GetComponent<Piece>().rang = 1;
                piecesBleus[i].transform.localScale = Vector2.one * 0.7f;
                positionX = -9 + i * 3;
                positionY = 3;
            }else if(i < 4)
            {
                piecesBleus[i].GetComponent<Piece>().rang = 2;
                piecesBleus[i].transform.localScale = Vector2.one * 1;
                positionX = -9 + (i - 2) * 3;
                positionY = 0;
            }
            else
            {
                piecesBleus[i].GetComponent<Piece>().rang = 3;
                piecesBleus[i].transform.localScale = Vector2.one * 1.3f;
                positionX = -9 + (i - 4) * 3;
                positionY = -3;
            }
            piecesBleus[i].GetComponent<Piece>().color = couleurs[0];
            piecesBleus[i].GetComponent<SpriteRenderer>().color = couleurs[0];
            piecesBleus[i].transform.position = new Vector2(positionX, positionY);
        }
        //Rouges
        for (int i = 0; i < piecesRouges.Length; i++)
        {
            float positionX;
            float positionY;
            piecesRouges[i] = Instantiate(prefabPiece);
            if (i < 2)
            {
                piecesRouges[i].GetComponent<Piece>().rang = 1;
                piecesRouges[i].transform.localScale = Vector2.one * 0.7f;
                positionX = 9 - i * 3;
                positionY = 3;
            }
            else if (i < 4)
            {
                piecesRouges[i].GetComponent<Piece>().rang = 2;
                piecesRouges[i].transform.localScale = Vector2.one * 1f;
                positionX = 9 - (i - 2) * 3;
                positionY = 0;
            }
            else
            {
                piecesRouges[i].GetComponent<Piece>().rang = 3;
                piecesRouges[i].transform.localScale = Vector2.one * 1.3f;
                positionX = 9 - (i - 4) * 3;
                positionY = -3;
            }
            piecesRouges[i].GetComponent<Piece>().color = couleurs[1];
            piecesRouges[i].GetComponent<SpriteRenderer>().color = couleurs[1];
            piecesRouges[i].transform.position = new Vector2(positionX, positionY);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(AIBleu && tour == Color.blue)
        {
            AIbasic.JouerProchainCoup(tour);
        }
        if(AIRouge && tour == Color.red)
        {
            AIbasic.JouerProchainCoup(tour);
        }
        GererPlacementPiece();
    }

    private void GererPlacementPiece()
    {
        if (Input.GetMouseButton(0) && pieceSelectione != null)
        {
            float mX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
            float mY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;
            if (mX > coinBasGauche.x && mX < coinHautDroite.x
                && mY> coinBasGauche.y && mY < coinHautDroite.y)
            {
                (int x, int y) = TrouverCase(mX, mY);
                Board.instance.AjouterPiece(x, y, pieceSelectione.GetComponent<Piece>());
            }
        }
        
    }

    private (int x, int y) TrouverCase(float mX, float mY)
    {
        int x;
        int y;
        if(mX < -1.5f)
        {
            x = 0;
        }else if(mX < 1.5f)
        {
            x = 1;
        }
        else
        {
            x = 2;
        }
        if (mY < -1.5f)
        {
            y = 0;
        }
        else if (mY < 1.5f)
        {
            y = 1;
        }
        else
        {
            y = 2;
        }
        return (x, y);
    }

    public void GererSelectionPiece(GameObject piece)
    {
        //On veut pas bouger les pieces d'un AI
        if(!(AIRouge && tour == Color.red) && !(AIBleu && tour == Color.blue))
        {
            if (tour == piece.GetComponent<Piece>().color)
                pieceSelectione = piece;
        }
    }

    public void ChangerTour()
    {
        if(tour == Color.blue)
        {
            tour = Color.red;
        }
        else
        {
            tour = Color.blue;
        }
    }
}
