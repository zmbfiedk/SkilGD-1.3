using UnityEngine;

public class Byte : MonoBehaviour
{
    [SerializeField] Bit[] bits = new Bit[8];

    [SerializeField] private int value = 0;

    public void SetValue(int newValue)
    {
        if (newValue > 255)
        {
            newValue = 255;
        }

        value = newValue;

        for (int i = 0; i < 8; i++)
        {
            if (newValue >= Mathf.Pow(2, (7 - i)))
            {
                bits[i].SetState(true);
                newValue -= (int)Mathf.Pow(2, (7 - i));
            }
            else
            {
                bits[i].SetState(false);
            }
        }
    }
}
