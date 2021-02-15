using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rosaceaScript : MonoBehaviour
{

    public GameObject page1;
    public GameObject page2;


    public void rosceaNextPG()
    {
        if (page2 != null)
        {
            bool isActive = page2.activeSelf;
            page2.SetActive(!isActive);
            page1.SetActive(false);
        }
    }

}
