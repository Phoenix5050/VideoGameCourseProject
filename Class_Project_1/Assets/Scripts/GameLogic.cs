using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{
    bool gameWon = false;

    public movement[,] gameboard; 
    public int boardWidth = 8; 
    public int boardHeight = 8; 

    private Scene scene;

    public GameObject winText;
    void Start()
    {
        //gameboard[3,4] = GameObject.Find("Clear").GetComponent<movement>();

        scene = SceneManager.GetActiveScene();
        
        switch(scene.name){
                case "Level_1":
                    boardWidth = 4;
                    boardHeight = 4;
                    gameboard = new movement[boardWidth,boardHeight];
                    // set the position of the mirrors. 
                    gameboard[2,2] = GameObject.Find("Mirror 1").GetComponent<movement>();
                    gameboard[0,0] = GameObject.Find("Mirror 2").GetComponent<movement>();
                break;
                case "Level_2":
                    boardWidth = 3;
                    boardHeight = 3;
                    gameboard = new movement[boardWidth,boardHeight];
                    // set the position of the mirrors. 
                    gameboard[0,2] = GameObject.Find("Mirror 1").GetComponent<movement>();
                    gameboard[0,0] = GameObject.Find("Mirror 2").GetComponent<movement>();
                    gameboard[2,2] = GameObject.Find("Mirror 2 (1)").GetComponent<movement>();
                    gameboard[1,1] = GameObject.Find("Block").GetComponent<movement>();
                    gameboard[1,2] = GameObject.Find("Obstacle").GetComponent<movement>();
                    gameboard[2,0] = GameObject.Find("Glass Obstacle").GetComponent<movement>();
                break;
                case "Level_3":
                    gameboard = new movement[boardWidth,boardHeight];
                    // set the position of the mirrors. 
                    boardWidth = 4;
                    boardHeight = 4;
                    gameboard = new movement[boardWidth,boardHeight];
                    // set the position of the mirrors. 
                    gameboard[2,2] = GameObject.Find("Mirror 1").GetComponent<movement>();
                    gameboard[1,1] = GameObject.Find("Mirror 2").GetComponent<movement>();
                    gameboard[1,2] = GameObject.Find("Glass Obstacle").GetComponent<movement>();
                    gameboard[2,1] = GameObject.Find("Glass Obstacle (1)").GetComponent<movement>();
                    gameboard[2,0] = GameObject.Find("Glass").GetComponent<movement>();
                    gameboard[0,0] = GameObject.Find("Glass (1)").GetComponent<movement>();
                    gameboard[1,0] = GameObject.Find("Glass (2)").GetComponent<movement>();
                    gameboard[3,0] = GameObject.Find("Glass (3)").GetComponent<movement>();
                    gameboard[3,1] = GameObject.Find("Glass (4)").GetComponent<movement>();
                    gameboard[3,3] = GameObject.Find("Glass (5)").GetComponent<movement>();
                    gameboard[0,1] = GameObject.Find("Glass (6)").GetComponent<movement>();
                    gameboard[0,2] = GameObject.Find("Glass (7)").GetComponent<movement>();
                    gameboard[3,2] = GameObject.Find("Glass (8)").GetComponent<movement>();
                    gameboard[2,3] = GameObject.Find("Glass (9)").GetComponent<movement>();
                    gameboard[1,3] = GameObject.Find("Glass (10)").GetComponent<movement>();
                break;
                case "Level_4":
                    boardWidth = 4;
                    boardHeight = 4;
                    gameboard = new movement[boardWidth,boardHeight];
                    // set the position of the mirrors. 
                    gameboard[2,1] = GameObject.Find("Mirror 1").GetComponent<movement>();
                    gameboard[2,0] = GameObject.Find("Mirror 1 (1)").GetComponent<movement>();
                    gameboard[2,3] = GameObject.Find("Mirror 2").GetComponent<movement>();
                    gameboard[1,1] = GameObject.Find("Mirror 2 (1)").GetComponent<movement>();
                    gameboard[1,0] = GameObject.Find("Mirror 3").GetComponent<movement>();

                    gameboard[1,3] = GameObject.Find("Glass Obstacle").GetComponent<movement>();
                    gameboard[2,2] = GameObject.Find("Glass Obstacle (1)").GetComponent<movement>();
                    gameboard[3,3] = GameObject.Find("Glass Obstacle (2)").GetComponent<movement>();
                    gameboard[0,3] = GameObject.Find("Glass Obstacle (3)").GetComponent<movement>();

                    gameboard[3,0] = GameObject.Find("Glass").GetComponent<movement>();
                    gameboard[3,1] = GameObject.Find("Glass (1)").GetComponent<movement>();
                    gameboard[0,1] = GameObject.Find("Glass (2)").GetComponent<movement>();
                    gameboard[0,0] = GameObject.Find("Glass (3)").GetComponent<movement>();
                    gameboard[0,2] = GameObject.Find("Glass (4)").GetComponent<movement>();
                    gameboard[1,2] = GameObject.Find("Glass (5)").GetComponent<movement>();
                break;
                case "Level_5":
                    gameboard = new movement[boardWidth,boardHeight];
                    // // set the position of the mirrors. 
                    gameboard[6,7] = GameObject.Find("Mirror 1").GetComponent<movement>();
                    gameboard[7,3] = GameObject.Find("Mirror 2").GetComponent<movement>();
                    gameboard[0,5] = GameObject.Find("Mirror 3").GetComponent<movement>();
                    gameboard[7,5] = GameObject.Find("Mirror 4").GetComponent<movement>();

                    gameboard[1,0] = GameObject.Find("Mirror 1 (1)").GetComponent<movement>();
                    gameboard[0,1] = GameObject.Find("Mirror 1 (2)").GetComponent<movement>();

                    gameboard[6,6] = GameObject.Find("Mirror 2 (1)").GetComponent<movement>();
                    gameboard[5,7] = GameObject.Find("Mirror 2 (2)").GetComponent<movement>();

                    gameboard[2,7] = GameObject.Find("Mirror 3 (1)").GetComponent<movement>();
                    gameboard[1,6] = GameObject.Find("Mirror 3 (2)").GetComponent<movement>();

                    gameboard[7,7] = GameObject.Find("Mirror 4 (1)").GetComponent<movement>();
                    gameboard[6,4] = GameObject.Find("Mirror 4 (2)").GetComponent<movement>();

                    gameboard[0,0] = GameObject.Find("Block").GetComponent<movement>();
                    gameboard[7,4] = GameObject.Find("Block (1)").GetComponent<movement>();
                    gameboard[7,6] = GameObject.Find("Block (2)").GetComponent<movement>();

                    gameboard[2,3] = GameObject.Find("Glass Obstacle").GetComponent<movement>();
                    gameboard[3,3] = GameObject.Find("Glass Obstacle (1)").GetComponent<movement>();
                    gameboard[4,3] = GameObject.Find("Glass Obstacle (2)").GetComponent<movement>();
                    gameboard[4,4] = GameObject.Find("Glass Obstacle (3)").GetComponent<movement>();
                    gameboard[4,5] = GameObject.Find("Glass Obstacle (4)").GetComponent<movement>();
                    gameboard[4,6] = GameObject.Find("Glass Obstacle (5)").GetComponent<movement>();
                    gameboard[4,7] = GameObject.Find("Glass Obstacle (6)").GetComponent<movement>();
                    gameboard[2,2] = GameObject.Find("Glass Obstacle (7)").GetComponent<movement>();
                    gameboard[2,1] = GameObject.Find("Glass Obstacle (8)").GetComponent<movement>();
                    gameboard[2,0] = GameObject.Find("Glass Obstacle (9)").GetComponent<movement>();
                break;
                case "Level_6":
                    gameboard = new movement[boardWidth,boardHeight];
                    // // set the position of the mirrors. 
                    gameboard[0,1] = GameObject.Find("Mirror 1").GetComponent<movement>();
                    gameboard[0,0] = GameObject.Find("Mirror 2").GetComponent<movement>();
                    gameboard[6,1] = GameObject.Find("Mirror 3").GetComponent<movement>();
                    gameboard[0,1] = GameObject.Find("Mirror 4").GetComponent<movement>();

                    gameboard[1,7] = GameObject.Find("Mirror 1 (1)").GetComponent<movement>();
                    gameboard[3,4] = GameObject.Find("Mirror 1 (2)").GetComponent<movement>();
                    gameboard[1,0] = GameObject.Find("Mirror 1 (3)").GetComponent<movement>();
                    gameboard[6,0] = GameObject.Find("Mirror 1 (4)").GetComponent<movement>();

                    gameboard[0,6] = GameObject.Find("Mirror 2 (1)").GetComponent<movement>();
                    gameboard[6,6] = GameObject.Find("Mirror 2 (2)").GetComponent<movement>();
                    gameboard[7,0] = GameObject.Find("Mirror 2 (3)").GetComponent<movement>();

                    gameboard[1,6] = GameObject.Find("Mirror 3 (1)").GetComponent<movement>();
                    gameboard[0,7] = GameObject.Find("Mirror 3 (2)").GetComponent<movement>();
                    gameboard[7,1] = GameObject.Find("Mirror 4 (1)").GetComponent<movement>();

                    gameboard[3,3] = GameObject.Find("Obstacle").GetComponent<movement>();
                    gameboard[2,4] = GameObject.Find("Glass Obstacle").GetComponent<movement>();

                    gameboard[1,4] = GameObject.Find("Glass Obstacle (1)").GetComponent<movement>();
                    gameboard[0,4] = GameObject.Find("Glass Obstacle (2)").GetComponent<movement>();
                    gameboard[3,5] = GameObject.Find("Glass Obstacle (3)").GetComponent<movement>();
                    gameboard[3,6] = GameObject.Find("Glass Obstacle (4)").GetComponent<movement>();
                    gameboard[3,7] = GameObject.Find("Glass Obstacle (5)").GetComponent<movement>();
                    gameboard[3,2] = GameObject.Find("Glass Obstacle (7)").GetComponent<movement>();
                    gameboard[5,0] = GameObject.Find("Glass Obstacle (8)").GetComponent<movement>();
                    gameboard[4,1] = GameObject.Find("Glass Obstacle (9)").GetComponent<movement>();
                    gameboard[4,4] = GameObject.Find("Glass Obstacle (10)").GetComponent<movement>();
                    gameboard[5,4] = GameObject.Find("Glass Obstacle (11)").GetComponent<movement>();
                    gameboard[6,5] = GameObject.Find("Glass Obstacle (12)").GetComponent<movement>();
                    gameboard[7,5] = GameObject.Find("Glass Obstacle (13)").GetComponent<movement>();
                    gameboard[5,3] = GameObject.Find("Glass Obstacle (14)").GetComponent<movement>();
                    gameboard[5,2] = GameObject.Find("Glass Obstacle (15)").GetComponent<movement>();
                    gameboard[5,1] = GameObject.Find("Glass Obstacle (16)").GetComponent<movement>();
                break;
                case "Level_7":
                    gameboard = new movement[boardWidth,boardHeight];
                    // // set the position of the mirrors. 
                    gameboard[1,1] = GameObject.Find("Mirror 1").GetComponent<movement>();
                    gameboard[0,0] = GameObject.Find("Mirror 2").GetComponent<movement>();
                    gameboard[1,0] = GameObject.Find("Mirror 3").GetComponent<movement>();
                    gameboard[0,1] = GameObject.Find("Mirror 4").GetComponent<movement>();

                    gameboard[6,6] = GameObject.Find("Mirror 1 (1)").GetComponent<movement>();
                    gameboard[7,7] = GameObject.Find("Mirror 2 (1)").GetComponent<movement>();
                    gameboard[6,7] = GameObject.Find("Mirror 3 (1)").GetComponent<movement>();
                    gameboard[7,6] = GameObject.Find("Mirror 4 (1)").GetComponent<movement>();

                    gameboard[0,6] = GameObject.Find("Mirror 1 (2)").GetComponent<movement>();
                    gameboard[1,7] = GameObject.Find("Mirror 2 (2)").GetComponent<movement>();
                    gameboard[1,6] = GameObject.Find("Mirror 3 (2)").GetComponent<movement>();
                    gameboard[0,7] = GameObject.Find("Mirror 4 (2)").GetComponent<movement>();

                    gameboard[7,1] = GameObject.Find("Mirror 1 (3)").GetComponent<movement>();
                    gameboard[6,0] = GameObject.Find("Mirror 2 (3)").GetComponent<movement>();
                    gameboard[6,1] = GameObject.Find("Mirror 3 (3)").GetComponent<movement>();
                    gameboard[7,0] = GameObject.Find("Mirror 4 (3)").GetComponent<movement>();

                    gameboard[4,4] = GameObject.Find("Obstacle").GetComponent<movement>();
                    gameboard[7,4] = GameObject.Find("Obstacle (1)").GetComponent<movement>();
                    gameboard[3,4] = GameObject.Find("Obstacle (2)").GetComponent<movement>();
                    gameboard[1,4] = GameObject.Find("Obstacle (3)").GetComponent<movement>();
                    gameboard[3,5] = GameObject.Find("Obstacle (4)").GetComponent<movement>();
                    gameboard[4,2] = GameObject.Find("Obstacle (5)").GetComponent<movement>();
                    gameboard[4,1] = GameObject.Find("Obstacle (6)").GetComponent<movement>();

                    gameboard[2,4] = GameObject.Find("Glass Obstacle").GetComponent<movement>();
                    gameboard[0,4] = GameObject.Find("Glass Obstacle (1)").GetComponent<movement>();
                    gameboard[3,7] = GameObject.Find("Glass Obstacle (2)").GetComponent<movement>();
                    gameboard[3,6] = GameObject.Find("Glass Obstacle (3)").GetComponent<movement>();
                    gameboard[6,4] = GameObject.Find("Glass Obstacle (4)").GetComponent<movement>();
                    gameboard[5,4] = GameObject.Find("Glass Obstacle (5)").GetComponent<movement>();
                    gameboard[4,3] = GameObject.Find("Glass Obstacle (6)").GetComponent<movement>();
                    gameboard[4,0] = GameObject.Find("Glass Obstacle (7)").GetComponent<movement>();
                break;
                case "Level_8":
                    gameboard = new movement[boardWidth,boardHeight];
                    // // set the position of the mirrors. 
                    gameboard[1,1] = GameObject.Find("Mirror 1").GetComponent<movement>();
                    gameboard[0,0] = GameObject.Find("Mirror 2").GetComponent<movement>();
                    gameboard[1,0] = GameObject.Find("Mirror 3").GetComponent<movement>();
                    gameboard[0,1] = GameObject.Find("Mirror 4").GetComponent<movement>();

                    gameboard[6,6] = GameObject.Find("Mirror 1 (1)").GetComponent<movement>();
                    gameboard[7,7] = GameObject.Find("Mirror 2 (1)").GetComponent<movement>();
                    gameboard[6,7] = GameObject.Find("Mirror 3 (1)").GetComponent<movement>();
                    gameboard[7,6] = GameObject.Find("Mirror 4 (1)").GetComponent<movement>();

                    gameboard[0,6] = GameObject.Find("Mirror 1 (2)").GetComponent<movement>();
                    gameboard[1,7] = GameObject.Find("Mirror 2 (2)").GetComponent<movement>();
                    gameboard[1,6] = GameObject.Find("Mirror 3 (2)").GetComponent<movement>();
                    gameboard[0,7] = GameObject.Find("Mirror 4 (2)").GetComponent<movement>();

                    gameboard[7,1] = GameObject.Find("Mirror 1 (3)").GetComponent<movement>();
                    gameboard[6,0] = GameObject.Find("Mirror 2 (3)").GetComponent<movement>();
                    gameboard[6,1] = GameObject.Find("Mirror 3 (3)").GetComponent<movement>();
                    gameboard[7,0] = GameObject.Find("Mirror 4 (3)").GetComponent<movement>();

                    gameboard[4,4] = GameObject.Find("Obstacle").GetComponent<movement>();
                    gameboard[7,4] = GameObject.Find("Obstacle (1)").GetComponent<movement>();
                    gameboard[3,4] = GameObject.Find("Obstacle (2)").GetComponent<movement>();
                    gameboard[1,4] = GameObject.Find("Obstacle (3)").GetComponent<movement>();
                    gameboard[3,5] = GameObject.Find("Obstacle (4)").GetComponent<movement>();
                    gameboard[4,2] = GameObject.Find("Obstacle (5)").GetComponent<movement>();
                    gameboard[4,1] = GameObject.Find("Obstacle (6)").GetComponent<movement>();

                    gameboard[2,4] = GameObject.Find("Glass Obstacle").GetComponent<movement>();
                    gameboard[0,4] = GameObject.Find("Glass Obstacle (1)").GetComponent<movement>();
                    gameboard[3,7] = GameObject.Find("Glass Obstacle (2)").GetComponent<movement>();
                    gameboard[3,6] = GameObject.Find("Glass Obstacle (3)").GetComponent<movement>();
                    gameboard[6,4] = GameObject.Find("Glass Obstacle (4)").GetComponent<movement>();
                    gameboard[5,4] = GameObject.Find("Glass Obstacle (5)").GetComponent<movement>();
                    gameboard[4,3] = GameObject.Find("Glass Obstacle (6)").GetComponent<movement>();
                    gameboard[4,0] = GameObject.Find("Glass Obstacle (7)").GetComponent<movement>();
                break;                
                default:
                    gameboard = new movement[boardWidth,boardHeight];
                    // set the position of the mirrors. 
                    gameboard[2,4] = GameObject.Find("Mirror 1").GetComponent<movement>();
                    gameboard[3,2] = GameObject.Find("Mirror 2").GetComponent<movement>();
                break;
            }
        
        InvokeRepeating("checkGameWon", 0f, 1f);
    }

    void Update(){
        if (Input.GetKey("escape"))
        {
            returnToMenu();
        }
    }

    void checkGameWon()
    {
        gameWon = true;
        foreach (Transform child in transform)
        {
            if(child.gameObject.GetComponent<receptorLogic>().getClear())
                continue;
            gameWon = false;
        }
        if(gameWon)
            endGame();
    }

    public void SetPiecePosition( int fromX, int fromY, int toX, int toY){

        // consider the adjustment of adding three * gridSize to x and y. 
        // like where does that happen here or there? 
        // should handle the adjust ment here, cause movement doesn't know where it is in the gameboard. 

        // lets say that the tilemap's bottom left corner is 0,0.
        toX /= 2;
        toY /= 2;
        fromX /= 2;
        fromY /= 2;

        gameboard[toX,toY] = gameboard[fromX,fromY];
        gameboard[fromX,fromY]= null;
    }
    public bool CheckedIsOccupied(int x, int y){
        x /= 2;
        y /= 2;
        if(gameboard[x,y] != null){
            return true;
        }
        return false; 
    }

    public bool checkInBounds(int x, int y){
        x /= 2;
        y /= 2;
        if(x < boardWidth && y < boardHeight && x >= 0 && y >= 0){
            return true;
        }
        return false;
    }

    private void endGame()
    {
        winText.SetActive(true);
        Invoke("returnToMenu", 2f);
    }

    private void returnToMenu(){
        SceneManager.LoadScene("Main");
    }
}