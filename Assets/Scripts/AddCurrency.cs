using UnityEngine;
using TMPro;

public class AddCurrency : MonoBehaviour
{
    public TextMeshProUGUI currencyText;

    public int currencyAmount = 0;

    public void ClickButton()
    {
        currencyAmount++;
        currencyText.text = "Валюта: " + currencyAmount;
        FindAnyObjectByType<ButtonController>().OnSomethingHappened();

    }
}
