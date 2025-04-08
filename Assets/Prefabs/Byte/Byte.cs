using UnityEngine;

public class Byte : MonoBehaviour
{
    [SerializeField] Bit[] bits = new Bit[8];
    [SerializeField] private int value = 0;

    void Update()
    {
        Bin2Dec();
    }

    private void Bin2Dec()
    {
        value = 0;

        for (int i = 0; i < bits.Length; i++)
        {
            if (bits[i].state)
            {
                value += (int)Mathf.Pow(2, i);
            }
        }

        Debug.Log("Decimal value: " + value);
    }

    public void SetValue(int newValue)
    {
        if (newValue > 255)
        {
            newValue = 255;
        }

        value = newValue;

        int remainingValue = newValue;

        for (int i = 7; i >= 0; i--)
        {
            int power = (int)Mathf.Pow(2, i);
            if (remainingValue >= power)
            {
                bits[7 - i].state = true;
                remainingValue -= power;
            }
            else
            {
                bits[7 - i].state = false;
            }
        }
    }
}
