using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pobeda : MonoBehaviour
{
    [SerializeField]
    private GameObject _picter;
  
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Player") {
            _picter.SetActive(true);
           
        };
    }
    void Start()
    {
        _picter.SetActive(false);
    }

}