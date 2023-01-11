using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MenadzerPunktow : MonoBehaviour
{
    public int Punkty;
    public TextMeshProUGUI PunktyNaInterfejsie;

    
    public void DodajPunkt(int IleDodac)
    {
        Punkty += IleDodac;
        PunktyNaInterfejsie.text = "Minera³y: " + Punkty;
    }
}
