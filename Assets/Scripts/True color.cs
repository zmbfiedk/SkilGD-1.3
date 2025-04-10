using UnityEngine;

public class TrueColor : MonoBehaviour
{
    [SerializeField] private GameObject mypixeltruecolorPrefab;
    private Mypixeltruecolor[] pixels;

    public int gridWidth = 10;
    public int gridHeight = 10;

    void Start()
    {
        pixels = new Mypixeltruecolor[gridWidth * gridHeight];

        for (int i = 0; i < pixels.Length; i++)
        {
            int row = i / gridWidth;
            int col = i % gridWidth;
            Vector3 spawnPos = new Vector3(col, row, 0);

            GameObject pixelObject = Instantiate(mypixeltruecolorPrefab, spawnPos, Quaternion.identity);
            Mypixeltruecolor pixel = pixelObject.GetComponent<Mypixeltruecolor>();

            pixels[i] = pixel;
        }
    }
}
