using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class noteMenu : MonoBehaviour
{
    public GameObject pan;
    public GameObject pan2;

    public GameObject pan3;
    public GameObject pan4;

    public GameObject pan5;
    public GameObject pan6;
    public GameObject pan7;

    public void openPan() {
        if (pan != null) {
            bool isActive = pan.activeSelf;
            pan.SetActive(!isActive);
            pan2.SetActive(false);
        }
    }

    public void openPan3()
    {
        if (pan3 != null)
        {
            bool isActive1 = pan3.activeSelf;
            pan3.SetActive(!isActive1);
            pan2.SetActive(false);
        }
    }

    public void openPan4()
    {
        if (pan4 != null)
        {
            bool isActive1 = pan4.activeSelf;
            pan4.SetActive(!isActive1);
            pan2.SetActive(false);
        }
    }

    public void openPan5()
    {
        if (pan5 != null)
        {
            bool isActive1 = pan5.activeSelf;
            pan5.SetActive(!isActive1);
            pan2.SetActive(false);
        }
    }

    public void openPan6()
    {
        if (pan6 != null)
        {
            bool isActive1 = pan6.activeSelf;
            pan6.SetActive(!isActive1);
            pan2.SetActive(false);
        }
    }

    public void openPan7()
    {
        if (pan7 != null)
        {
            bool isActive1 = pan7.activeSelf;
            pan7.SetActive(!isActive1);
            pan2.SetActive(false);
        }
    }

}
