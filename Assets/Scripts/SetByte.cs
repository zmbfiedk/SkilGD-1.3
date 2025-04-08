using UnityEngine;

public class SetByte : MonoBehaviour
{
    [SerializeField] Byte myByte;
    [SerializeField] int myValue;

    private int lastValue = -1;

    void Update()
    {
        if (myValue != lastValue)
        {
            myByte.SetValue(myValue);
            lastValue = myValue;
        }
    }

    public void ApplyValue()
    {
        myByte.SetValue(myValue);
        lastValue = myValue;
    }
}
