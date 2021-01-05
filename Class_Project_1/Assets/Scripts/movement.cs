using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public bool xOnly;
    public bool yOnly;
    public bool noMove;
    public float gridSize = 2f;
    private bool snapToGrid = true;
    private bool centreDrag = true;
    private bool isDraggable = true;
    public bool isDragged = false;
    Vector2 initialPositionMouse;
    Vector2 initialPositionObject;

    GameLogic gameLogic;

    int newX;
    int newY;
    int oldX;
    int oldY;
    
    void Start(){
        gameLogic = GameObject.Find("Receptors").GetComponent<GameLogic>();
    }
    void Update()
    {
        if (isDragged)
        {
            oldX = (int)initialPositionObject.x;
            oldY = (int)initialPositionObject.y;

            transform.position = initialPositionObject + (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - initialPositionMouse;
            
            if (xOnly)
            {
                newX = (int)(Mathf.RoundToInt(transform.position.x / gridSize) * gridSize);
                newY = oldY;
                // checking to see if the movement location is valid. 
                if(gameLogic.checkInBounds(newX,newY) && !gameLogic.CheckedIsOccupied(newX,newY)){
                    transform.position = new Vector2(Mathf.RoundToInt(transform.position.x / gridSize) * gridSize, initialPositionObject.y);
                }
                else
                {
                    transform.position = initialPositionObject;
                }
            }
            else if (yOnly)
            {
                newX = oldX;
                newY = (int)(Mathf.RoundToInt(transform.position.y / gridSize) * gridSize);
                // checking to see if the movement location is valid. 
                if(gameLogic.checkInBounds(newX,newY) && !gameLogic.CheckedIsOccupied(newX,newY)){
                    transform.position = new Vector2(initialPositionObject.x, Mathf.RoundToInt(transform.position.y / gridSize) * gridSize);
                }
                else
                {
                    transform.position = initialPositionObject;
                }
            }else if (noMove)
            {
                transform.position = initialPositionObject;
            }
            else{
                newX = (int)(Mathf.RoundToInt(transform.position.x / gridSize) * gridSize);
                newY = (int)(Mathf.RoundToInt(transform.position.y / gridSize) * gridSize);
                // checking to see if the movement location is valid. 
                if(gameLogic.checkInBounds(newX,newY) && !gameLogic.CheckedIsOccupied(newX,newY)){
                    transform.position = new Vector2(Mathf.RoundToInt(transform.position.x / gridSize) * gridSize, Mathf.RoundToInt(transform.position.y / gridSize) * gridSize);
                }
                else
                {
                    transform.position = initialPositionObject;
                }
            }
        }
    }

    public void SetGameLogic(GameLogic gameLogic)
    {
        this.gameLogic = gameLogic;
    }
    private void OnMouseOver()
    {
        if (isDraggable && Input.GetMouseButtonDown(0))
        {
            if (centreDrag)
            {
                initialPositionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                initialPositionObject = transform.position;
            }
            isDragged = true;
        }
    }
    private void OnMouseUp()
    {
        isDragged = false;
        if(gameLogic.checkInBounds(newX,newY) && !gameLogic.CheckedIsOccupied(newX,newY))
            gameLogic.SetPiecePosition(oldX,oldY,newX,newY);
    }
}