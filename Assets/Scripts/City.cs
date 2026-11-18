using UnityEngine;

public class City : MonoBehaviour
{
    [SerializeField] private GameObject cityButton;
    [SerializeField] private GameObject returnFromCityButton;

    [SerializeField] private GameObject flag;
    [SerializeField] private GameObject flagButton;

    [SerializeField] private GameObject upgradeClickButton;
    [SerializeField] private GameObject hireWorkerButton;

    public void OpenCity()
    {
        cityButton.SetActive(false);
        returnFromCityButton.SetActive(true);

        flag.SetActive(false);
        flagButton.SetActive(false);

        upgradeClickButton.SetActive(false);
        hireWorkerButton.SetActive(true);
    }

    public void ExitCity()
    {
        cityButton.SetActive(true);
        returnFromCityButton.SetActive(false);

        flag.SetActive(true);
        flagButton.SetActive(true);

        upgradeClickButton.SetActive(true);
        hireWorkerButton.SetActive(false);

    }

}
