using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonController : MonoBehaviour
{
    public Button HireWorker;
    public AddCurrency AddCurrency;

    private int workerCost = 10;
    private int workerCount = 0;
    private bool isTimerRunning = false;

    void Start()
    {
        HireWorker.interactable = false;
    }

    public void OnSomethingHappened()
    {
        if (AddCurrency.currencyAmount >= workerCost)
        {
            HireWorker.interactable = true;
        }
        else
        {
            HireWorker.interactable = false;
        }
    }

    public void OnHireWorkerClick()
    {
        AddCurrency.currencyAmount -= workerCost;
        workerCost += 10;
        workerCount++;

        UpdateGoldUI();

        if (!isTimerRunning)
        {
            StartCoroutine(AutoGoldIncome());
        }

        OnSomethingHappened();
    }

    IEnumerator AutoGoldIncome()
    {
        isTimerRunning = true;

        while (workerCount > 0)
        {
            yield return new WaitForSeconds(1f);

            AddCurrency.currencyAmount += workerCount;

            UpdateGoldUI();

            OnSomethingHappened();
        }

        isTimerRunning = false;
    }

    private void UpdateGoldUI()
    {
        AddCurrency.currencyText.text = "Валюта: " + AddCurrency.currencyAmount;
    }
}
