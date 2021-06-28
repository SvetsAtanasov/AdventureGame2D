using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemKey : Item
{
    private Player player;

    private void Start()
    {
        player = FindObjectOfType<Player>();
    }
    private void Update()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position, 5 * Time.deltaTime);
    }
}
