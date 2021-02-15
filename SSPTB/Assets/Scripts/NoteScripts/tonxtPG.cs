using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tonxtPG : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;


    public void toNextPG()
    {
        if (panel2 != null)
        {
            bool isActive = panel2.activeSelf;
            panel2.SetActive(!isActive);
            panel1.SetActive(false);
        }
    }
}
