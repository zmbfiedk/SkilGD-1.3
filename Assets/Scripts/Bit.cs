using UnityEngine;

public class Bit : MonoBehaviour
{
    public bool state = false;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (state)
        {
            spriteRenderer.color = Color.green;
        }
        else
        {
            spriteRenderer.color = Color.red;
        }
    }

    public void SetState(bool newState)
    {
        state = newState;
    }

    private void OnMouseUp()
    {
        state = !state;
    }
}
