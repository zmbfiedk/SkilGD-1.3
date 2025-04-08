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
