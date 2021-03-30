using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{

    [SerializeField]
    private Transform _player;

    [SerializeField]
    private Transform _Bomb;

    // Update is called once per frame
    void Update()
    {
        var distance = Vector3.Distance(_player.position, _Bomb.position);
        float a = 1.4f;
        if (distance < a) {
           
            
            _player.position = new Vector3(12.4f, -3.2f, -44.4f);
        }
    }
}
