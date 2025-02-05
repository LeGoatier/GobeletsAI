using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public abstract class AI
{
    public abstract void JouerProchainCoup(Color couleur);
    public AI()
    {
        board = Board.instance;
    }
    public static Board board;
}
