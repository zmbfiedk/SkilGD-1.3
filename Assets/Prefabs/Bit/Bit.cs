using UnityEngine;

public class Bit : MonoBehaviour
{
    public bool state = false;
    SpriteRenderer spriteRenderer;

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
