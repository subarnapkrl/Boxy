using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Text scoreText;

    private int scoreNum;

    // Start is called before the first frame update
    void Start()
    {
        scoreNum=0;
        scoreText.text="COINS: "+scoreNum;
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag=="Coin")
        {
            scoreNum++;
            Destroy(other.gameObject);
            scoreText.text="COINS: "+ scoreNum;
        }
    }
    
}
