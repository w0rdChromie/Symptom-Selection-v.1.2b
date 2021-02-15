using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clinicBack : MonoBehaviour
{
    public void clinicToTitle() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
    }
}
