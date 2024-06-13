using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioTriggerController : MonoBehaviour
{
    [SerializeField] private GameObject voiceover = null;

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
            voiceover.SetActive(true);
            // switch audio clips

            // stop audio 1

            // start audio 2
        }
    }
}
