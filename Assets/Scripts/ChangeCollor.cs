using UnityEngine;

public class ChangeCollor : MonoBehaviour
{

    private Color originalColor;
    private Renderer obstacleRenderer;

    // Start is called before the first frame update
    void Start()
    {
        obstacleRenderer = GetComponent<Renderer>();
        originalColor = obstacleRenderer.material.color;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            obstacleRenderer.material.color = Color.black;
            Invoke("ResetColor", 1.5f);
        }
    }
    void ResetColor()
    {
        obstacleRenderer.material.color = originalColor;
    }
}
