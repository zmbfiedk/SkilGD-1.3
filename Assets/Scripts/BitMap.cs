using UnityEngine;

public class Bitmap : MonoBehaviour
{
    [SerializeField] Byte[] bytes;
    [SerializeField] int[] values;

    public void SetValues(int[] values)
    {
        for(int i=0; i<8; i++)
        {
            bytes[i].SetValue(values[i]);
        }
    }
}
