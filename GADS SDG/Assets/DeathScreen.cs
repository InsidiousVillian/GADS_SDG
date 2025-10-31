using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    public void Continue()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
