using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class practiceBack : MonoBehaviour
{
    public void practiceToTitle() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
