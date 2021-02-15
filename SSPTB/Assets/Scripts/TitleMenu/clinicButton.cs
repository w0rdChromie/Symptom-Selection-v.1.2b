using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clinicButton : MonoBehaviour
{
    public void clinicScreen() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }
}
