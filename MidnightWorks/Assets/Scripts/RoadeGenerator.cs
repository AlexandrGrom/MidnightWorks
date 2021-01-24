using UnityEngine;

public class RoadeGenerator : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float tileStep;

    private Tile[] tiles;
    private Tile newxTile;
    private int counter=1;

    private void Awake()
    {
        tiles = GetComponentsInChildren<Tile>();
        newxTile = tiles[0];
    }

    private void Update()
    {
        if (player.transform.position.z > newxTile.transform.position.z + tileStep)
        {
            GetNextTile();
        }
    }

    private void GetNextTile()
    {
        newxTile.transform.position = new Vector3(0, 0, newxTile.Lenght * (tiles.Length+counter-1));

        newxTile.GetPattern(counter);



        newxTile = tiles[counter % tiles.Length];
        counter++;
    }

}
