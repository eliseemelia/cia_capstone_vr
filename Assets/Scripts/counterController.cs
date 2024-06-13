using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class counterController : MonoBehaviour
{

    public int counter = 0;

    [SerializeField] GameObject hallway = null;
    [SerializeField] GameObject hallwayb = null;
    [SerializeField] private GameObject wall = null;
    [SerializeField] private GameObject wallb = null;
    [SerializeField] private GameObject anchor = null;
    [SerializeField] private GameObject anchorb = null;
    [SerializeField] private GameObject anchor2 = null;
    [SerializeField] private GameObject anchor3 = null;
    [SerializeField] private GameObject floor1 = null;

    [SerializeField] private GameObject floor1b = null;
    [SerializeField] private GameObject floor2 = null;
    [SerializeField] private GameObject floor2b = null;
    [SerializeField] private GameObject backgroundAudio = null;
    [SerializeField] private GameObject hallwayAudio = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Count()
    {
        counter++;

        if(counter >= 2)
        {
            hallway.SetActive(true);
            hallwayb.SetActive(true);

            
            wall.SetActive(false);
            wallb.SetActive(false);

            anchor.SetActive(false);
            anchorb.SetActive(false);


            floor1.SetActive(false);
            floor1b.SetActive(false);

            floor2.SetActive(false);
            floor2b.SetActive(false);

            anchor2.SetActive(true);
            anchor3.SetActive(true);

            backgroundAudio.SetActive(false);
            hallwayAudio.SetActive(true);
        }
    }
    
}
