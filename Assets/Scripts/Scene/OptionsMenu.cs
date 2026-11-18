using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuCanvas;
    [SerializeField] private GameObject gameCanvas;

    public void OpenGame()
    {
        mainMenuCanvas.SetActive(false);
        gameCanvas.SetActive(true);
    }

}
