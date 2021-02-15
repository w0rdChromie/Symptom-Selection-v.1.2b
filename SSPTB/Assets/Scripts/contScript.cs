using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contScript : MonoBehaviour
{
    GameObject card;
    List<int> faceIndexes = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};
    public static System.Random rnd = new System.Random();
    public int shuffleNo = 0;
    int[] visibleFaces = { -1, -2};

    void Start() {

        int originalLength = faceIndexes.Count;

        float yPosition = 3f;
        float xPosition = -5f;
        for (int i = 0; i < 12; i++) {

            shuffleNo = rnd.Next(0, (faceIndexes.Count));
            var temp = Instantiate(card, new Vector3(xPosition, yPosition, 0), Quaternion.identity);
            temp.GetComponent<cardScript>().faceIndex = faceIndexes[shuffleNo];
            faceIndexes.Remove(faceIndexes[shuffleNo]);
            xPosition = xPosition + 3.5f;
            if (i ==(originalLength/2 - 2)) {

                yPosition = -3f;
                xPosition = -8.5f;
            
            }
        
        }

    }

    private void Awake() {

        card = GameObject.Find("cardtemplate");

    }
}
