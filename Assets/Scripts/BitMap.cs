using UnityEngine;

public class Bitmap : MonoBehaviour
{
    [SerializeField] Byte[] bytes;
    [SerializeField] int[] values;

    private void Update()
    {
        SetValues();
    }

    public void SetValues()
    {
        for(int i=0; i<8; i++)
        {
            bytes[i].SetValue(values[i]);
        }
    }
}
