using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text Addscore; 

    private int score = 0;
    private int lives = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    //AddLives
    public void AddLives(int value)
    {
        lives += value;
        if (lives <= 0)
        {
            Debug.Log("Game Over");
            lives = 0;
        }
        Debug.Log("Lives = " + lives);
    }

    //Addscore
    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score = " + score);
    }

}
