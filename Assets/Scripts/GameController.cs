using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public Text coinCounter;
    private int coins = 0;


    public void PickUpCoin()
    {
        coins++;
        coinCounter.text = "Coins: " + coins.ToString();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
