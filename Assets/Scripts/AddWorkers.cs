using UnityEngine;
using TMPro;

public class AddWorkers : MonoBehaviour
{
    public TextMeshProUGUI workerText;
    public int workerAmount = 0;

    private void Start()
    {
        UpdateWorkerText();
    }

    public void AddWorker()
    {
        workerAmount++;
        UpdateWorkerText();
    }

    public void ClickButton()
    {
        AddWorker();

        HireWorkerScript hireWorkerScript = FindAnyObjectByType<HireWorkerScript>();
        if (hireWorkerScript != null)
        {
            hireWorkerScript.OnSomethingHappened();
        }
    }

    private void UpdateWorkerText()
    {
        if (workerText != null)
        {
            workerText.text = "Рабочих: " + workerAmount;
        }
    }
}
