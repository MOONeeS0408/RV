using Polyperfect.Universal;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerVictory : MonoBehaviour
{
    public GameObject victoryCanvas; 


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Goal"))
        {
            ShowVictory();
        }
    }

    void ShowVictory()
    {
        victoryCanvas.SetActive(true);

        Invoke("RestartLevel", 3f);
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
