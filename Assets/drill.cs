using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drill : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision2D)
    {       
            Destroy(this.gameObject);        
    }
}
