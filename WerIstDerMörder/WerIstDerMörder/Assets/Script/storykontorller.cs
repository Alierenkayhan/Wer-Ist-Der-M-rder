using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class storykontorller : MonoBehaviour
{
    [SerializeField] GameObject bubble1;
    [SerializeField] GameObject bubble2;
    [SerializeField] GameObject bubble3;

    [SerializeField] GameObject rightarrow;
    [SerializeField] GameObject leftarrow;

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
            }
            if (click == 2)
            {
                bubble2.SetActive(false);
                bubble3.SetActive(true);
            }
            if (click == 3)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
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
            }
            if (click == 1)
            {
                bubble2.SetActive(true);
                bubble3.SetActive(false);
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

}
