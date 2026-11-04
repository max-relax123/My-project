using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HireWorkerScript : MonoBehaviour
{
    public Button HireWorker;
    public AddCurrency AddCurrency;
    public AddWorkers AddWorkers;

    private int workerCost = 10;
    private bool isTimerRunning = false;

    private void Start()
    {
        OnSomethingHappened();
    }

    public void OnSomethingHappened()
    {
        if (HireWorker != null)
        {
            HireWorker.interactable = AddCurrency != null &&
                                      AddCurrency.currencyAmount >= workerCost;
        }

        if (AddWorkers != null && AddWorkers.workerAmount > 0 && !isTimerRunning)
        {
            StartCoroutine(AutoGoldIncome());
        }
    }

    public void OnHireWorkerClick()
    {
        if (AddCurrency == null || AddWorkers == null)
        {
            Debug.LogError("HireWorkerScript: назначьте AddCurrency и AddWorkers в Inspector.", this);
            return;
        }

        if (AddCurrency.currencyAmount < workerCost)
        {
            OnSomethingHappened();
            return;
        }

        AddCurrency.currencyAmount -= workerCost;
        workerCost += 10;

        AddWorkers.AddWorker();
        UpdateGoldUI();
        OnSomethingHappened();
    }

    private IEnumerator AutoGoldIncome()
    {
        isTimerRunning = true;

        while (AddWorkers != null && AddWorkers.workerAmount > 0)
        {
            yield return new WaitForSeconds(1f);

            if (AddCurrency == null || AddWorkers == null)
            {
                break;
            }

            AddCurrency.currencyAmount += AddWorkers.workerAmount;
            UpdateGoldUI();
            OnSomethingHappened();
        }

        isTimerRunning = false;
    }

    private void UpdateGoldUI()
    {
        if (AddCurrency != null && AddCurrency.currencyText != null)
        {
            AddCurrency.currencyText.text = "Валюта: " + AddCurrency.currencyAmount;
        }
    }
}

