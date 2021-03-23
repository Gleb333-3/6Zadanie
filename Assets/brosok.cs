using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brosok : MonoBehaviour
{

    public var play : boolean = true;
public var speed: int = 10;
public var moveDirection: Vector3;
public var grounded: boolean;
public var gravity: int = 1;
        private void Update()
    {
        if (Input.GetMouseButton(1))
        {
            var dx: int = Input.mousePosition.x - Screen.width / 2.0;
            var dy: int = Input.mousePosition.y - Screen.height / 2.0;
            var strawRadians: float = Mathf.Atan2(dx, dy);
            var strawDigrees:float = 360.0 * strawRadians / (2.0 * Mathf.PI);
            transform.rotation.eulerAngles.y = strawDigrees;
        }
    }
}
