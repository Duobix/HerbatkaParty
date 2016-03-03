using UnityEngine;
using System.Collections;
//remember: this script should be placed inside "this scene" GameObject in every scene
public class controls : MonoBehaviour {
	public static bool spacePressed;
    public static bool leftPressed;
    public static bool rightPressed;
    public static bool upPressed;
    public static bool downPressed;
    public static bool pausePressed;

    void Update () {
        hitPause();
        hitSpace();
        hitDown();
        hitUp();
        hitLeft();
        hitRight();
	}

    private void hitSpace() {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spacePressed = true;
        }
        else {
            spacePressed = false;
        }
    }

    private void hitLeft()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            leftPressed = true;
        }
        else
        {
            leftPressed = false;
        }
    }

    private void hitRight()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rightPressed = true;
        }
        else
        {
            rightPressed = false;
        }
    }

    private void hitUp()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            upPressed = true;
        }
        else
        {
            upPressed = false;
        }
    }

    private void hitDown()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            downPressed = true;
        }
        else
        {
            downPressed = false;
        }
    }

    private void hitPause()
    {
        if (Input.GetKeyDown(KeyCode.P)|| Input.GetKeyDown(KeyCode.Escape))
        {
            pausePressed = true;
        }
        else
        {
            pausePressed = false;
        }
    }

}
