using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour
{
    private GameController gameController; // Reference to the GameController script

    void Start()
    {
        // Find the GameController object and get the GameController component
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");

        // Check if the GameController object and component are found
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        else
        {
            // Log an error if the GameController object is not found
            Debug.LogError("GameController object not found!");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            // Check if the gameController variable is not null before calling PickUpCoin
            if (gameController != null)
            {
                // Call the PickUpCoin method from the GameController script
                gameController.PickUpCoin();

                // Destroy the object
                Destroy(gameObject);
            }
            else
            {
                // Log an error if gameController is null
                Debug.LogError("GameController reference is null!");
            }
        }
    }
}
