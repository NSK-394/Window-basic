using UnityEngine;

public class Cleaner : MonoBehaviour
{
    void Update()
    {
        Collider[] hits = Physics.OverlapSphere(transform.position, 0.6f);

        foreach (Collider hit in hits)
        {
            if (hit.gameObject.name.Contains("DirtTile"))
            {
                Destroy(hit.gameObject);
            }
        }
    }
}