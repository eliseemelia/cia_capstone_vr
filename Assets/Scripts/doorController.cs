using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorController : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;
    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;
    //[SerializeField] private string anim = null;

    //[SerializeField] GameObject otherTrigger = null;


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name + " " + other.gameObject.tag);
        if(other.CompareTag("Player"))
        {
            if(openTrigger)
            {
                myDoor.Play("doorOpen", 0, 0.0f);
                gameObject.SetActive(false);
                //otherTrigger.SetActive(true);
            }
            else if(closeTrigger)
            {
                myDoor.Play("doorClose", 0, 0.0f);
                gameObject.SetActive(false);
                //otherTrigger.SetActive(true);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
