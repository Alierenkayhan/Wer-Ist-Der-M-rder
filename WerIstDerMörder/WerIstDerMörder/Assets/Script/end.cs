using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class end : MonoBehaviour
{
    [SerializeField] GameObject bubble1;
    [SerializeField] GameObject bubble2;
    [SerializeField] GameObject bubble3;

    [SerializeField] GameObject odul;

    [SerializeField] GameObject rightarrow;
    [SerializeField] GameObject leftarrow;

    [SerializeField] GameObject endgame;

    int click = 0;

    public void NextText()
    {
        click++;
        //Debug.Log("Click number: " + click);
        try
        {
            if (click == 0)
            {
                bubble1.SetActive(true);
                bubble2.SetActive(false);
            }
            if (click == 1)
            {
                bubble1.SetActive(false);
                bubble2.SetActive(true);
                leftarrow.SetActive(true);
                odul.SetActive(true);
            }
            if (click == 2)
            {
                bubble2.SetActive(false);
                odul.SetActive(false);
                bubble3.SetActive(true);
            }
            if (click == 3)
            {
                endgame.SetActive(true);
            }
        }
        catch
        {
            Debug.Log("Something goes wrong!");
        }
    }

    public void PreviousText()
    {
        click--;
        //Debug.Log("Click number: " + click);
        try
        {
            if (click == 0)
            {
                bubble1.SetActive(true);
                bubble2.SetActive(false);
                leftarrow.SetActive(false);
                odul.SetActive(false);
            }
            if (click == 1)
            {
                bubble2.SetActive(true);
                bubble3.SetActive(false);
                odul.SetActive(true);
            }
            if (click == 2)
            {
                bubble3.SetActive(true);
            }
        }
        catch
        {
            Debug.Log("Something goes wrong!");
        }
    }

    private void Start()
    {
        endgame.SetActive(false);
    }

    public void endAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
    }
    public void endQuit()
    {
        Debug.Log("You closed the game.");
        Application.Quit();
    }
}
