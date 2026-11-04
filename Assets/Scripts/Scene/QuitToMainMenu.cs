using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitToMainMenu : MonoBehaviour
{
    public void QuitTo()
    {
        SceneManager.LoadScene("MainMenu");

    }
}
