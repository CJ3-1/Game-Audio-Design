using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class FootSetpChange : MonoBehaviour
{
    public FirstPersonController fpc;

    public AudioClip[] audio1s;
    public AudioClip[] audio2s;




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
        if (other.tag == "Player")
        {
            fpc.ChangeAudio(audio1s);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            fpc.ChangeAudio(audio2s);
        }
    }
}
