using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompassChef : MonoBehaviour
{
    public RawImage CompassImage;
    public Transform turret;
    public Transform tank;
    public Transform headset;
    public void Update()
    {
        //Get a handle on the Image's uvRect
        float globalangle = turret.localEulerAngles.y / 360 + tank.localEulerAngles.y / 360 + headset.localEulerAngles.y / 360;
        CompassImage.uvRect = new Rect(globalangle, 0, 1, 1);
        
        
    }
}
