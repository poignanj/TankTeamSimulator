using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTarget : MonoBehaviour
{
    CompassGunner cg;
    CompassPilot cp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetMark(GameObject o)
    {
        cg = o.GetComponent<CompassGunner>();
        cp = o.GetComponent<CompassPilot>();

        if (cp) cp.Target = this.transform;
        if (cg) cg.Target = this.transform;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
