using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public float jumpFactor = 5f;

    void OnTriggerEnter(Collider other)
    {
        //Увеличение высоты прыжка игрока
        other.GetComponent<FirstPersonMovement>().jumpStrenght *= jumpFactor;
    }

    void OnTriggerExit(Collider other)
    {
        //Уменьшение высоты прыжка игрока
        other.GetComponent<FirstPersonMovement>().jumpStrenght /= jumpFactor;
    }
}
