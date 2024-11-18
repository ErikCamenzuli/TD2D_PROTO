using UnityEngine;

public class Tower : MonoBehaviour
{
    public float range = 5f;
    public float fireRate = 1f;
    public GameObject projectilePrefab;
    private float fireCooldown = 0f;

    void Update()
    {
        fireCooldown -= Time.deltaTime;
        Collider2D[] hits = Physics2D.OverlapCircleAll(transform.position, range);
        foreach (var hit in hits)
        {
            if (hit.CompareTag("Enemy") && fireCooldown <= 0f)
            {
                Shoot(hit.transform);
                fireCooldown = 1f / fireRate;
                break;
            }
        }
    }

    void Shoot(Transform enemy)
    {
        GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        projectile.GetComponent<Projectile>().SetTarget(enemy);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
