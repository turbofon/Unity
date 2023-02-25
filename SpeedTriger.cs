using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTriger : MonoBehaviour
{
    public float speedFactor = 5.5f;

    public void OnTriggerEnter(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
    }
    public void OnTriggerExit(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
    }
}
