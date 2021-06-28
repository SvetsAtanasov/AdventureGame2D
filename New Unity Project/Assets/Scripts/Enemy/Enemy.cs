using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageSource
{
    public int enemyDamage = 10;

    public float speed = 5f;
    public float playerSpeed = 5;
    public float distanceLimit = 0.85f;
    public float timeBetweenShots = 0f;
    public float startTimeBetweenShots = 0f;

    public GameObject aimDirection;
    public GameObject weaponProjectile;

    [SerializeField] private float timer;
    [SerializeField] private Animator animator;
    [SerializeField] private Transform charTarget;

    void Start()
    {
        animator = GetComponent<Animator>();
        charTarget = FindObjectOfType<Player>().GetComponent<Transform>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        AimDirection();
    }

    void FixedUpdate() // Infinite Loop - Gets called every frame
    {
        if (charTarget == null)
            return;

        Vector2 axis = new Vector2(0, 0);
        Vector2 enemyScale = this.transform.localScale;
        float distance = Vector2.Distance(this.transform.position, charTarget.position);

        if (distance < distanceLimit)
        {
            //if (timer > timeBetweenShots)
            //{
            //    IDamagable enemyChar = charTarget.gameObject.GetComponent<IDamagable>();
            //    enemyChar.Damage(enemyDamage, this);
            //    timer = 0;
            //}
        }

        else
        {
            this.transform.position = Vector2.MoveTowards(this.transform.position, charTarget.position, speed * Time.deltaTime);

            axis = charTarget.position - this.transform.position;

            if (axis.x > 0.1f)
            {
                enemyScale.x = 1;
            }

            else if (axis.x < -0.1f)
            {
                enemyScale.x = -1;
            }
        }

        float x = Mathf.Abs(axis.x);
        float y = Mathf.Abs(axis.y);

        if (x > y)
        {
            axis.y = 0;
        }

        else
        {
            axis.x = 0;
        }

        animator.SetFloat("x", axis.x);
        animator.SetFloat("y", axis.y);

        this.transform.localScale = enemyScale;
    }

    void AimDirection()
    {
        if (charTarget == null)
            return;

        Vector3 dir = (charTarget.transform.position - aimDirection.transform.position).normalized;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        aimDirection.transform.rotation = Quaternion.Euler(0, 0, angle - 90);

        if (timeBetweenShots <= 0)
        {
            Instantiate(weaponProjectile, aimDirection.transform.position, aimDirection.transform.rotation);
            timeBetweenShots = startTimeBetweenShots;
        }

        else
        {
            timeBetweenShots -= Time.fixedDeltaTime;
        }
        if (charTarget == null)
            return;
    }
}