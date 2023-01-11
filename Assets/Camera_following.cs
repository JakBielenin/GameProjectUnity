using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_following : MonoBehaviour
{
    public Transform player;
    public Vector3 corector = new Vector3(0, 0, -10);

    private void FixedUpdate()
    {
        transform.position = player.position + corector;
    }
}
