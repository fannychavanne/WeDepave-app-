using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleblueframe : MonoBehaviour
{
    public GameObject blueframe;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void whenButtonClicked()
    {
         if (blueframe.activeSelf==true)
            blueframe.SetActive(false);
         else
            blueframe.SetActive(true);

             
           
    }
}
