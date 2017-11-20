using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{

    public List<GameObject> shapeList;
    public float speed;

    private int score;
    private GameObject currentPiece;
    private GameObject nextPiece;
    //private PieceProperties nextPieceProperties;

	// Use this for initialization
	void Start ()
    {
        score = 0;
        nextPiece = GetNextPiece();
	}
	
	// Update is called once per frame
	void Update ()
    {
        var pieceIsFalling = false;
        if (currentPiece != null)
        {
            pieceIsFalling = currentPiece.GetComponent<PieceProperties>().pieceIsFalling;
        }
        if (!pieceIsFalling)
        {
            currentPiece = nextPiece;
            currentPiece.transform.position = new Vector3(-0.55f, 3.5f);
            currentPiece.GetComponent<PieceProperties>().pieceIsFalling = true;

            nextPiece = GetNextPiece();
        }

        if (pieceIsFalling)
        {
            currentPiece.transform.position += new Vector3(0.0f, -0.1f * speed);
        }
	}

    GameObject GetNextPiece()
    {
        var random = new System.Random();
        int pickPiece = random.Next(0, 1);
        var newPiece = Instantiate(shapeList[pickPiece]);
        newPiece.transform.position = new Vector3(2.05f, 2.48f);
        return newPiece;
    }

    //private void OnTriggerEnter2D(Collider2D collider)
    //{
    //    nextPieceProperties.pieceIsFalling = false;

    //}
}
