using UnityEngine;
using TMPro;

public class AddGold : MonoBehaviour
{
    public TextMeshProUGUI goldText;

    public int goldAmount = 0;

    public void ClickButton()
    {
        goldAmount++;
        goldText.text = "Золото: " + goldAmount;
        FindAnyObjectByType<ButtonController>().OnSomethingHappened();

    }
}
