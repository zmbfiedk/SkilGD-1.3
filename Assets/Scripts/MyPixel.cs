using UnityEngine;

public class MyPixel : MonoBehaviour
{
    [SerializeField] Byte ByteR;
    [SerializeField] Byte ByteG;
    [SerializeField] Byte ByteB;
    [SerializeField] GameObject Pixel;

    private SpriteRenderer spriteRenderer;
    private string colorCode;

    void Start()
    {
        if (ByteR == null || ByteG == null || ByteB == null)
        {
            Debug.LogError("One or more Byte objects are not assigned.");
        }

        if (Pixel != null)
        {
            spriteRenderer = Pixel.GetComponent<SpriteRenderer>();
            if (spriteRenderer == null)
            {
                Debug.LogError("SpriteRenderer component not found on Pixel.");
            }
        }
        else
        {
            Debug.LogError("Pixel GameObject is not assigned.");
        }

        SetPixelColor();
    }

    void SetPixelColor()
    {
        if (ByteR != null && ByteG != null && ByteB != null && spriteRenderer != null)
        {
            colorCode = "#" + ByteR.GetHex() + ByteG.GetHex() + ByteB.GetHex();

            if (UnityEngine.ColorUtility.TryParseHtmlString(colorCode, out Color newColor))
            {
                spriteRenderer.color = newColor;
            }
            else
            {
                Debug.LogError("Invalid hex color: " + colorCode);
            }
        }
        else
        {
            Debug.LogError("Unable to set color due to missing references.");
        }
    }
}
