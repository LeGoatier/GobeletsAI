using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    public Color color;
    public int rang;
    public bool enJeu = false;
    public (int x, int y) position;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        GameManager.instance.GererSelectionPiece(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
