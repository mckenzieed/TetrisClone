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
    private bool pieceTravelingDownScreen;

	// Use this for initialization
	void Start ()
    {
        score = 0;
        nextPiece = GetNextPiece();
        pieceTravelingDownScreen = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!pieceTravelingDownScreen)
        {
            currentPiece = nextPiece;
            //currentPiece.transform.position = new Vector3(-0.55f, 3.5f);
            pieceTravelingDownScreen = true;

            nextPiece = GetNextPiece();
        }

        if (pieceTravelingDownScreen)
        {
            //currentPiece.transform.position += new Vector3(0.0f, -0.1f * speed);
        }
	}

    GameObject GetNextPiece()
    {
        var random = new System.Random();
        int pickPiece = random.Next(0, 5);
        var newPiece = Instantiate(shapeList[pickPiece]);
        newPiece.transform.position = new Vector3(2.05f, 2.48f);
        newPiece.rigidbody2D.
        return newPiece;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        pieceTravelingDownScreen = false;

    }
}
