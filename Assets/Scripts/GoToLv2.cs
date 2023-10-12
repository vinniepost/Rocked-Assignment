using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLv2 : MonoBehaviour
{
    private Renderer obstacleRenderer;
    public string nextLevelName;

    private void Start()
    {
        obstacleRenderer = GetComponent<Renderer>();
        Console.WriteLine("Test Start");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Console.WriteLine("Test");
            SceneManager.LoadSceneAsync(nextLevelName);
        }
    }
}