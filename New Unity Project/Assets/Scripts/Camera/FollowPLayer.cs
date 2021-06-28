using UnityEngine;

public class FollowPLayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    void Start()
    {
        
    }

    void Update()
    {
        if (player == null)
            return;
        transform.position = player.position + offset;
    }
}
