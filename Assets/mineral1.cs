using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mineral1 : MonoBehaviour
{
    public int PunktyZaMaterial1 = 1;
    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        FindObjectOfType<MenadzerPunktow>().DodajPunkt(PunktyZaMaterial1);
    }
}
