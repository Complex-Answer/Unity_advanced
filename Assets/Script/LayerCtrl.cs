using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerCtrl : MonoBehaviour
{
    Camera cam;
    int layerMask;
    void Start()
    {
        cam = Camera.main;
        layerMask = 501;
        // 0000 0001 0000 0000
        cam.cullingMask = layerMask;
    }

    void Update()
    {
        
    }
}
