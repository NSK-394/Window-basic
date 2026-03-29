using UnityEngine;

public class DirtGenerator : MonoBehaviour
{
    public GameObject dirtPrefab;
    public int rows = 10;
    public int cols = 10;
    public float spacing = 0.6f;

    void Start()
    {
        if (dirtPrefab == null)
        {
            Debug.LogError("Prefab not assigned!");
            return;
        }

        for (int x = 0; x < rows; x++)
        {
            for (int z = 0; z < cols; z++)
            {
                Vector3 pos = new Vector3(
                    x * spacing - (rows * spacing / 2),
                    0.05f,
                    z * spacing - (cols * spacing / 2)
                );

                GameObject tile = Instantiate(dirtPrefab, pos, Quaternion.identity, transform);

                // optional randomness
                tile.transform.position += new Vector3(
                    Random.Range(-0.1f, 0.1f),
                    0,
                    Random.Range(-0.1f, 0.1f)
                );
            }
        }
    }
}