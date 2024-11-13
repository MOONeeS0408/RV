using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public GameObject defeatCanvas; 
    public GameObject playerModel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            ShowDefeat();
        }
    }

    void ShowDefeat()
    {
        defeatCanvas.SetActive(true);

        if (playerModel != null)
        {
            playerModel.SetActive(false);
        }

        Invoke("RestartLevel", 3f);
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
