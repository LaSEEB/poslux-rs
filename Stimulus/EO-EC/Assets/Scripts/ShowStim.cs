using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Assets.LSL4Unity.Scripts.AbstractInlets;
using Assets.LSL4Unity.Scripts.Examples;

public class ShowStim : MonoBehaviour {

    public Text cross, eo, ec, thend;

    //public GameObject EndofSessionPanel;

    //public GameObject lslobject;

    // Use this for initialization
    void Start()
    {

        cross.enabled = true;
        eo.enabled = false;
        ec.enabled = false;
        thend.enabled = false;
        //EndofSessionPanel.SetActive(false);

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

        //reload scene
        //		if (Input.GetKey(KeyCode.R))
        //		{
        //			ReloadScene();
        //		}


        getStim();

     //   if (ReceiveLSL.getLSLsample() == 1010) //32770 experiment stop
     //       EndofSessionPanel.SetActive(true); //pop window

    }


    void getStim()
    {
        int stim = ReceiveLSL.getLSLsample();
        //Debug.Log(stim);
        switch (stim)
        {
            case 768: //hide cross
                cross.enabled = false;
                eo.enabled = false;
                ec.enabled = false;
                thend.enabled = false;
                break;
            case 800: //hide cross
                cross.enabled = false;
                eo.enabled = false;
                ec.enabled = false;
                break;
            case 786: // show cross
                cross.enabled = true;
                eo.enabled = false;
                ec.enabled = false;
                break;
            case 7700: //eyes closed
                cross.enabled = false;
                eo.enabled = false;
                ec.enabled = true;
                break;
            case 7690: // eyes open
                cross.enabled = false;
                eo.enabled = true;
                ec.enabled = false;
                break;
            case 781: // hide arrow
                cross.enabled = true;
                eo.enabled = false;
                ec.enabled = false;
                break;
            case 1010: // hide arrow
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
