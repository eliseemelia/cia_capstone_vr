using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerController : MonoBehaviour
{
    [SerializeField] private GameObject hall = null;
    [SerializeField] private GameObject text1 = null;
    [SerializeField] private GameObject text2 = null;
    [SerializeField] private GameObject text3 = null;
    [SerializeField] private GameObject audioTrigger = null;

    [SerializeField] private GameObject background_sound = null;
    [SerializeField] private GameObject hallway_sound = null;

    private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            this.gameObject.SetActive(false);
            count++;

            if(count == 1)
            {
                text1.SetActive(false);
                text2.SetActive(true);
            }



            if (count >= 2)
            {
                text2.SetActive(false);
                text3.SetActive(true);
                hall.SetActive(true);
                audioTrigger.SetActive(true);

                background_sound.SetActive(false);
                hallway_sound.SetActive(true);
            }

        }
    }
}
