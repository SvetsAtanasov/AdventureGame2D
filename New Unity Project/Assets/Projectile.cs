using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Projectile : MonoBehaviour
{
    public float speed = 1f;

    [SerializeField] private float projectileLifeTime = 0.5f;

    [SerializeField] private IDamageSource damageSource;

    [SerializeField] private LayerMask projectileHitLayers;
    void Start()
    {
        Invoke(nameof(DespawnProjectile), projectileLifeTime);
    }

    private void Update()
    {
        ProjectileHit();
        ProjectileMove();
    }
    void ProjectileMove()
    {
        Vector3 pos = this.transform.position;
        pos += this.transform.up * speed * Time.deltaTime;
        this.transform.position = pos;
    }

    void ProjectileHit()
    {
        RaycastHit2D[] hits = Physics2D.RaycastAll(this.transform.position, this.transform.up, (speed * Time.deltaTime) + 0.001f, projectileHitLayers);

        if (hits.Length > 0)
        {
            foreach (RaycastHit2D hit in hits)
            {
                IDamagable damagable = hit.transform.GetComponent<IDamagable>();

                if (damagable != null)
                {
                    damagable.Damage(10, damageSource);

                }
            }
            DespawnProjectile();
        }
    }

    void DespawnProjectile()
    {
        Destroy(this.gameObject);
    }
}
