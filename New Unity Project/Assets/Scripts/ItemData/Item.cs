using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string displayName = "Item Name";
    public string displayDescription = "Description";
    public Sprite displayIcon = null;

    public GameObject interactPoint;

    public void Interact(Player player)
    {
        player.inventory.AddItem(this);
        Vector2 pos = this.transform.position;
        Collider2D[] items = Physics2D.OverlapCircleAll(interactPoint.transform.position, 3f);

        foreach (Collider2D item in items)
        {
            item.transform.position = Vector3.MoveTowards(item.transform.position, player.transform.position, 5f * Time.deltaTime);
        }
    }

    void ItemsMoveTowards()
    {

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(interactPoint.transform.position, 3f);
    }
}
