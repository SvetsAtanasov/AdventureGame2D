using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float range = 0.5f;
    public float playerSpeed = 5;

    public LayerMask enemyLayers;

    public GameObject weaponProjectile;
    public GameObject aimDirection;
    public Transform interractPoint;

    [SerializeField] public int playerDamage = 50;
    [SerializeField] private float timeBetweenShots;
    [SerializeField] private float startTimeBetweenShots;

    [SerializeField] private Rigidbody2D playerBody;

    private void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Attack();
    }

    void FixedUpdate()
    {
        Vector2 pos = this.transform.position;
        Vector2 sca = this.transform.localScale;
        Vector2 movement = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.W)) //Move up
        {
            movement.y += playerSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S)) //Move Down
        {
            movement.y -= playerSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D)) //Move Right
        {
            sca.x = 1f;
            movement.x += playerSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A)) //Move Left
        {
            sca.x = -1f;
            movement.x -= playerSpeed * Time.deltaTime;
        }

        //if (Input.GetKeyDown(KeyCode.E)) //Interact
        //{
        //    InteractCast();
        //}

        //if (Input.GetKeyDown(KeyCode.G)) //Drop Item
        //{
        //    Debug.Log("You dropped an item");
        //    //Needs fixing
        //}

        GetComponent<Animator>().SetFloat("x", movement.x);
        GetComponent<Animator>().SetFloat("y", movement.y);

        pos += movement;

        playerBody.MovePosition(pos);
        transform.localScale = sca;
    }

    public void Attack() //Method for attacking enemies
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 dir = (mousePos - aimDirection.transform.position).normalized;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        aimDirection.transform.rotation = Quaternion.Euler(0, 0, angle - 90);

        if (timeBetweenShots <= 0)
        {
            if (Input.GetMouseButton(0))
            {

                Instantiate(weaponProjectile, aimDirection.transform.position, aimDirection.transform.rotation);
                timeBetweenShots = startTimeBetweenShots;
            }
        }

        else
        {
            timeBetweenShots -= Time.fixedDeltaTime;
        }
    }

    //public void InteractCast() //Method to pick up items
    //{
    //    Collider2D[] interactItems = Physics2D.OverlapCircleAll(interractPoint.position, range, itemLayers);

    //    foreach (Collider2D interactItem in interactItems)
    //    {
    //        IInteractable item = interactItem.gameObject.GetComponent<IInteractable>();

    //        if (item != null)
    //        {
    //            item.DestroyItem();
    //            score++;
    //        }
    //    }
    //    playerScore.text = "Score:" + score.ToString();
    //}

    private void OnDrawGizmos() // Method to visualize the attackpoint range
    {
        if (interractPoint == null)
            return;

        Gizmos.DrawWireSphere(interractPoint.position, range);
    }
}
