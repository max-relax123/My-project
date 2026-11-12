using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AddCurrency : MonoBehaviour
{
    public TextMeshProUGUI currencyText;

    public int currencyAmount = 0;
    public int clickValue = 1;
    public int empowerClickCost = 5;
    public Button empowerClickButton;

    void Start()
    {
        UpdateCurrencyUI();
        UpdateEmpowerClickButton();
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

    void UpdateEmpowerClickButton()
    {
        if (currencyAmount >= empowerClickCost)
        {
            empowerClickButton.interactable = true;
        }

        else
        {
            empowerClickButton.interactable = false;
        }

    }

    private void UpdateCurrencyUI()
    {
        currencyText.text = "Валюта: " + currencyAmount;

        UpdateEmpowerClickButton();
    }
}