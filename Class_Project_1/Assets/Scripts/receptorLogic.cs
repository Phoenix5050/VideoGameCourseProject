using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class receptorLogic : MonoBehaviour
{
    [SerializeField]
    private bool clear = false;
    [SerializeField]
    public Color colour = Color.red;
    [SerializeField]
    SpriteRenderer spriteRenderer;

    void Start(){
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.grey;
    }
    public bool getClear()
    {
        return clear;
    }
    public void setClear(bool setter)
    {
        clear = setter;
        if(clear == true){
            spriteRenderer.color = colour;
        }else{
            spriteRenderer.color = Color.grey;
        }
    }
    public Color getColour()
    {
        return colour;
    }
}
