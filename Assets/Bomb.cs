using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField]
    private Transform _Object;

    [SerializeField]
    private GameObject _WhatYdal;

    [SerializeField]
    private Transform _Bomb;

    // Update is called once per frame
    void Update()
    {
        var distance = Vector3.Distance(_Object.position, _Bomb.position);
        float a = 1.4f;
        if (distance < a) {

            Destroy(_WhatYdal);
        }
    }
}
