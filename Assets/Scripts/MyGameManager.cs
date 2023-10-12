using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class MyGameManager : MonoBehaviour
{
    public GameObject Player;
    public GameObject mainCanvas;
    private Health health;
    

    // Start is called before the first frame update
    void Start()
    {
        if (Player == null)
        {
            Player = GameObject.FindWithTag("Player");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
