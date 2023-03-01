using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGeneration : MonoBehaviour
{
    public GameObject tile;
    public float width;
    public float height;
    public Vector2 gizmoSize;
    public RectTransform rt;
    public List<GameObject> tileGridList = new List<GameObject>();
    public Vector2 gridSize = new Vector2(5,5);
    private Vector2 iHat = new Vector2(1, 0.5f); // X
    private Vector2 jHat = new Vector2(-1, 0.5f); // Y
    void Start()
    {
        width = (tile.GetComponent<SpriteRenderer>().bounds.size.x) / 2;
        height = (tile.GetComponent<SpriteRenderer>().bounds.size.y) / 2;
        Generate();
    }

    public void Generate()
    {
        for (int y = 0; y < gridSize.y; y++)
        {
            for (int x = 0; x < gridSize.x; x++)
            {
                float tempX = ((width * iHat.x) * x) + ((width * jHat.x) * y);
                float tempY = ((height * iHat.y) * x) + ((height * jHat.y) * y);
                Vector2 gridPlacement = new Vector2(tempX, tempY);
                GameObject newTile = Instantiate(tile, gridPlacement, Quaternion.identity);
                tileGridList.Add(newTile);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
