using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Button HireWorker;
    public AddGold AddGold;

    private int workerCost = 10;

    void Start()
    {
        HireWorker.interactable = false;
    }

    public void OnSomethingHappened()
    {
        if (AddGold.goldAmount >= workerCost)
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
        AddGold.goldAmount -= workerCost;

        workerCost += 10;

        AddGold.goldText.text = "Золото: " + AddGold.goldAmount;

        HireWorker.interactable = false;

    }
}
