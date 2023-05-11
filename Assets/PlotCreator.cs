using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotCreator : MonoBehaviour
{
    public GameObject Plot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject startObj = GameObject.FindGameObjectWithTag("tagmain");
        GameObject refObj = GameObject.FindGameObjectWithTag("tagreference");

        if (startObj && refObj)
        {
            SpawnPlot(startObj, refObj);
            Destroy(this);
        }
    }


    void SpawnPlot(GameObject Start, GameObject Ref)
    {
        GameObject myPlot = Instantiate(Plot, Start.transform);
        myPlot.transform.up = (Start.transform.up + Ref.transform.up) / 2f;
    }
}
