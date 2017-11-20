using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceProperties : MonoBehaviour
{
    public bool pieceIsFalling;

    private Vector3 position;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetUpCurrentPiece()
    {
        position = new Vector3(-0.55f, 3.5f);
    }

    public void SetUpNextPiece()
    {
        position = new Vector3(2.05f, 2.48f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        pieceIsFalling = false;
    }
}
