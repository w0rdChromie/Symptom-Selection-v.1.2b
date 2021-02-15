using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quizWrong : MonoBehaviour
{
    public GameObject page3;
    public GameObject page4;

    public void toWrong()
    {
        if (page4 != null)
        {
            bool isAct = page4.activeSelf;
            page4.SetActive(!isAct);
            page3.SetActive(false);
        }
    }
}
