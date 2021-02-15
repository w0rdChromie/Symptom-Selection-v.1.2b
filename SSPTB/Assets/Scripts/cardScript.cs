using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardScript : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Sprite[] faces;
    public Sprite back;
    public int faceIndex;

    public void OnMouseDown() {

        if (spriteRenderer.sprite == back)
        {

            spriteRenderer.sprite = faces[faceIndex];

        }
        else {

            spriteRenderer.sprite = back;

        }
    
    }

    private void Awake() {

        spriteRenderer = GetComponent<SpriteRenderer>();
    
    }

}
