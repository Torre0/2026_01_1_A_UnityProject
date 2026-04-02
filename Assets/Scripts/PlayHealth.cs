using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayHealth : MonoBehaviour
{
    public int maxLives = 3;
    public int currentLives;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentLives = maxLives;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Missile"))
        {
            currentLives--;
            Destroy(other.gameObject);

            if (currentLives <= 0)
            {
                GameOver();
            }
        }
    }

    void GameOver()
    {
        gameObject.SetActive(false);
        Invoke("RestarGame", 3.0f);
    }

    void RestarGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
