using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] Transform Player;
    private Vector3 offset;

    private void Start()
    {
        offset.Set(0, 20, 5);
    }
    void Update()
    {
        transform.position = Player.position + offset;
    }
}
