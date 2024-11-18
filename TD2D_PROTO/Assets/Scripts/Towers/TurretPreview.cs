using UnityEngine;

public class TurretPreview : MonoBehaviour
{
    public GameObject previewPrefab;  // Assign a transparent turret sprite
    private GameObject previewInstance;

    void Start()
    {
        previewInstance = Instantiate(previewPrefab);
        previewInstance.SetActive(false);
    }

    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f;

        previewInstance.transform.position = mousePosition;

        // Enable/Disable preview based on valid placement
        previewInstance.SetActive(true);

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(previewInstance, mousePosition, Quaternion.identity);
        }
    }
}
