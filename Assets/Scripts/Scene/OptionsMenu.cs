using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuCanvas;
    [SerializeField] private GameObject gameCanvas;

    private void Start()
    {
        mainMenuCanvas.GetComponent<Canvas>().renderMode =
            RenderMode.ScreenSpaceOverlay;
        gameCanvas.SetActive(false);

    }
    public void OpenGame()
    {
        mainMenuCanvas.SetActive(false);
        gameCanvas.SetActive(true);
    }

}
