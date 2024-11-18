using UnityEngine;

public class TurretPlacer : MonoBehaviour
{
    public GameObject turretPrefab;  // Assign your turret prefab here

    void Update()
    {
        if (Input.GetMouseButtonDown(0))  // Left click
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            if (hit.collider != null && hit.collider.CompareTag("PlacementPoint"))
            {
                // Place turret at the point
                Vector3 placementPosition = hit.collider.transform.position;
                Instantiate(turretPrefab, placementPosition, Quaternion.identity);

                // Optionally disable the placement point
                hit.collider.gameObject.SetActive(false);
            }
        }
    }
}
