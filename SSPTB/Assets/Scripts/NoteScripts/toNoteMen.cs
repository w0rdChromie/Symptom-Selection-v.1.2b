using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toNoteMen : MonoBehaviour
{
    public GameObject currentPan;
    public GameObject noteMen;


    public void toNoteMenu()
    {
        if (noteMen != null)
        {
            bool isActive = noteMen.activeSelf;
            noteMen.SetActive(!isActive);
            currentPan.SetActive(false);
        }
    }
}
