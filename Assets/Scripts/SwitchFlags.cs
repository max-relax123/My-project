using UnityEngine;

public class SwitchFlags : MonoBehaviour
{
    [SerializeField] private GameObject flagFirstOption;
    [SerializeField] private GameObject flagSecondOption;

    public void GoForward()
    {
        flagFirstOption.SetActive(false);
        flagSecondOption.SetActive(true);
    }
}
