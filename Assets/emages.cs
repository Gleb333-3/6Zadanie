using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class emages : MonoBehaviour {
    public Image tex1;
    public Image tex2;

    void Start()
    {
        tex1.enabled = true;
        tex2.enabled = false;
    }
    void Update()
    {
        void OnGUI()
        {
            if (Input.GetKeyUp("q")(new Rect(10, 10, 50, 50))
                {
                tex2.enabled = true;
                tex1.enabled = false;
            }
        }
    }
}