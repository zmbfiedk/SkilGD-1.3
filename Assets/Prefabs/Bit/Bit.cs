using UnityEngine;

public class Bit : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public bool state = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        spriteRenderer.color = state ? Color.green : Color.red;
    }

    private void OnMouseUp()
    {
        state = !state;
    }
}
