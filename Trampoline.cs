using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public float jumpFactor = 5f;

    void OnTriggerEnter(Collider other)
    {
        //���������� ������ ������ ������
        other.GetComponent<FirstPersonMovement>().jumpStrenght *= jumpFactor;
    }

    void OnTriggerExit(Collider other)
    {
        //���������� ������ ������ ������
        other.GetComponent<FirstPersonMovement>().jumpStrenght /= jumpFactor;
    }
}
