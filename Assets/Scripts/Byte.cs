using UnityEngine;

public class Byte : MonoBehaviour
{
    [SerializeField] Bit[] bits = new Bit[8];
    [SerializeField] private int value = 0;

    private void Update()
    {
        bin2dec();
    }

    private void bin2dec()
    {
        value = 0;
        if (bits[0].state)
        {
            value += 1;
        }
        if (bits[1].state)
        {
            value += 2;
        }
        if (bits[2].state)
        {
            value += 4;
        }
        if (bits[3].state) 
        {
            value += 8;
        }
        if (bits[4].state)
        {
            value += 16;
        }
        if (bits[5].state)
        {
            value += 32;
        }
        if (bits[6].state)
        {
            value += 64;
        }
        if (bits[7].state)
        {
            value += 128;
        }
    }

    public void SetValue(int newValue)
    {
        if (newValue > 255)
        {
            newValue = 255;
        }

        value = newValue;

        if (bits.Length != 8)
        {
            Debug.LogError("Bits array is not correctly assigned or has less than 8 elements.");
            return;
        }

        for (int i = 0; i < 8; i++)
        {
            if (bits[i] == null)
            {
                Debug.LogError($"Bit at index {i} is not assigned.");
                return;
            }

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

    public string GetHex()
    {
        return value.ToString("X2");
    }
}
