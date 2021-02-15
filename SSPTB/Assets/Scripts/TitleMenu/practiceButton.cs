using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class practiceButton : MonoBehaviour
{
    public void practiceScreen() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}
