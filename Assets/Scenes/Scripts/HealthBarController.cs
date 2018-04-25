using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarController : MonoBehaviour
{
    public Transform Front;
    public Transform Back;

    void Start()
    {
        Front = Instantiate(Front, transform);
        Back = Instantiate(Back, transform);
        Front.localPosition = new Vector3(0, 0.8f, 0);
        Back.localPosition = new Vector3(0, 0.8f, 0);

    }
}

