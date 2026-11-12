using UnityEngine;
using TMPro;

public class AddCurrency : MonoBehaviour
{
    public TextMeshProUGUI currencyText;

    public int currencyAmount = 0;
    public int clickValue = 1;
    public int empowerClickCost = 5;

    void Start()
    {
        UpdateCurrencyUI();
    }

    public void ClickButton()
    {
        currencyAmount += clickValue;

        UpdateCurrencyUI();

        FindAnyObjectByType<HireWorkerScript>()
            .OnSomethingHappened();
    }

    public void BuyClickUpgrade()
    {
        if (currencyAmount < empowerClickCost)
            return;

        currencyAmount -= empowerClickCost;

        clickValue++;
        empowerClickCost += 5;

        UpdateCurrencyUI();

        FindAnyObjectByType<HireWorkerScript>()
            .OnSomethingHappened();
    }

    private void UpdateCurrencyUI()
    {
        currencyText.text = "Валюта: " + currencyAmount;
    }
}