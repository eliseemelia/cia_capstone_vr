using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hallwayController : MonoBehaviour
{
    [SerializeField] private GameObject wall = null;
    [SerializeField] private GameObject anchor = null;
    [SerializeField] private GameObject floor1 = null;
    [SerializeField] private GameObject floor2 = null;
    [SerializeField] private GameObject audio1 = null;
    [SerializeField] private GameObject audio2 = null;

    private string type = null;
    
    // Start is called before the first frame update
    void Start()
    {

        
    }

    private void Awake()
    {
        if (this.gameObject.activeInHierarchy)
        {
            wall.SetActive(false);
            anchor.SetActive(false);
            floor1.SetActive(false);
            floor2.SetActive(false);

            audio1.SetActive(false);
            audio2.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
