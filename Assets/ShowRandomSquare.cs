using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowRandomSquare : MonoBehaviour
{
    public List<GameObject> PlotSquares;

    // Start is called before the first frame update
    void Start()
    {
        EnableRandomSquare();
    }
    
    //Select one of our PlotSquares, and turn it on - turning all other ones off.
    public void EnableRandomSquare()
    {
        int randomIndex = Random.Range(0, PlotSquares.Count);
        for (int i = 0; i < PlotSquares.Count; i++)
        {
            bool ShouldBeActive = randomIndex == i; //If we are at the right randomIndex, then set to "True" / On. If not, we set to "False" / Off.
            PlotSquares[i].SetActive(ShouldBeActive);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
