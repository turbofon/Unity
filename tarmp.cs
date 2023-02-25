using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tarmp : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        //Увеличение силы прыжка
        other.GetComponent<Jump>().jumpStrength = 10;

    }

    void OnTriggerExit(Collider other)
    {
        //Уменьшение силы прыжка
        other.GetComponent<Jump>().jumpStrength = 2;

    }
}
