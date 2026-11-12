using UnityEngine;

public class FlagAnimation : MonoBehaviour
{
    public void Jump()
    {
        transform.localScale = Vector3.one * 1.1f;
        Invoke(nameof(ResetScale), 0.15f);


    }

    void ResetScale()
    {
        transform.localScale = Vector3.one;

    }

}
