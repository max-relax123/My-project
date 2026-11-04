using UnityEngine;
using TMPro;

public class AddCurrency : MonoBehaviour
{
    public TextMeshProUGUI currencyText;

    public int currencyAmount = 0;

    public void ClickButton()
    {
        currencyAmount++;

        if (currencyText != null)
        {
            currencyText.text = "Валюта: " + currencyAmount;
        }

        HireWorkerScript hireWorkerScript = FindAnyObjectByType<HireWorkerScript>();
        if (hireWorkerScript != null)
        {
            hireWorkerScript.OnSomethingHappened();
        }
    }
}
