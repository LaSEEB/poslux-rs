using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Assets.LSL4Unity.Scripts.AbstractInlets;
using Assets.LSL4Unity.Scripts.Examples;

[RequireComponent(typeof(AudioSource))]
public class ShowStim : MonoBehaviour {

    public Text cross, eo, ec, thend;

    AudioSource audioData;

    // Use this for initialization
    void Start()
    {

        audioData = GetComponent<AudioSource>();
        audioData.Pause();

        cross.enabled = true;
        eo.enabled = false;
        ec.enabled = false;
        thend.enabled = false;

        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {

        //quit 
        if (Input.GetKey("escape"))
        {
            Debug.Log("Quit!");
            Application.Quit();
        }

        getStim();

    }

    void beep(bool state) {
        if (state && flipswitch) {
            audioData.Play(0);
            flipswitch = false;
        }
    }
    private bool fswitch; 
    public bool flipswitch 
    {
        get { return fswitch; }   // get
        set { fswitch = value; }  // set
    }

    void getStim()
    {
        int stim = ReceiveLSL.getLSLsample;
        //Debug.Log(stim);
        switch (stim)
        {
            case 768: //hide cross
                flipswitch = true; //
                cross.enabled = false;
                eo.enabled = false;
                ec.enabled = false;
                thend.enabled = false;
                break;
            case 800: //hide cross
                flipswitch = true; //
                cross.enabled = false;
                eo.enabled = false;
                ec.enabled = false;
                break;
            case 786: // show cross
                flipswitch = true; //
                cross.enabled = true;
                eo.enabled = false;
                ec.enabled = false;
                break;
            case 7700: //eyes closed
                beep(true);
                cross.enabled = false;
                eo.enabled = false;
                ec.enabled = true;
                break;
            case 7690: // eyes open
                beep(true);
                cross.enabled = false;
                eo.enabled = true;
                ec.enabled = false;
                break;
            case 781: // hide arrow
                flipswitch = true; //
                cross.enabled = true;
                eo.enabled = false;
                ec.enabled = false;
                break;
            case 1010: // hide arrow
                flipswitch = true; //
                cross.enabled = false;
                eo.enabled = false;
                ec.enabled = false;
                thend.enabled = true;
                break;
                //		default:
                //			cross.enabled = false;
                //			leftarrow.enabled = false;
                //			rightarrow.enabled = false;
                //			break;
        }
    }


}
