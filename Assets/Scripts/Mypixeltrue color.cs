using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mypixeltruecolor : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    [SerializeField] private Color color = new Color(1f, 1f, 0f); 
    private float colorChangeTime = 1f; 
    private float timer = 0f;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        ChangeColor(); 
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= colorChangeTime)
        {
            ChangeColor(); 
            timer = 0f; 
        }
    }

    void ChangeColor()
    {
        color = new Color(Random.value, Random.value, Random.value);
        spriteRenderer.color = color; 
    }
}