using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bodyHover : MonoBehaviour
{
    public GameObject headButton;
    public GameObject torsoButton;
    public GameObject lbButton;

    public GameObject noteMenu;
    public GameObject headNotes;
    public GameObject torsoNotes;
    public GameObject lbNotes;

    public void showHead()
    {
        if (headButton != null)
        {
            bool isActive = headButton.activeSelf;
            headButton.SetActive(!isActive);
            if (headNotes != null)
            {
                bool isActive1 = headNotes.activeSelf;
                headNotes.SetActive(!isActive1);
            }
            torsoButton.SetActive(false);
            lbButton.SetActive(false);
            torsoNotes.SetActive(false);
            lbNotes.SetActive(false);
        }
    }

    public void showTorso()
    {
        if (torsoButton != null)
        {
            bool isActive = torsoButton.activeSelf;
            torsoButton.SetActive(!isActive);
            lbButton.SetActive(false);
            headButton.SetActive(false);
        }
    }

    public void showLegs()
    {
        if (lbButton != null)
        {
            bool isActive = lbButton.activeSelf;
            lbButton.SetActive(!isActive);
            headButton.SetActive(false);
            torsoButton.SetActive(false);
        }
    }
}
