using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotAligner : MonoBehaviour
{

    // Update is called once per frame
   /* void Update()
    {
        GameObject refObj = GameObject.FindGameObjectWithTag("tagreference");

        if (refObj)
        {
            SetupPlot(refObj);
            Destroy(this);
        }
    }*/


    void SetupPlot(GameObject Ref)
    {
        transform.up = (transform.up + Ref.transform.up) / 2f;
    }

    void Start()
    { transform.rotation = Quaternion.identity; }
}
