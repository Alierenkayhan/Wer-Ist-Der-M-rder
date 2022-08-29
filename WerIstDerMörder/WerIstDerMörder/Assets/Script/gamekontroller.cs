using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamekontroller : MonoBehaviour
{
    [SerializeField] GameObject notlar;
    [SerializeField] GameObject notlarpart1;
    [SerializeField] GameObject notlarpart2;
    [SerializeField] GameObject notlarpart3;
    [SerializeField] GameObject notlarpart4;

    [SerializeField] GameObject rightarrow;
    [SerializeField] GameObject leftarrow;

    [SerializeField] GameObject supheli1;
    [SerializeField] GameObject speechbuble;


    [SerializeField] GameObject Supheli1speechbubleTXT1;
    [SerializeField] GameObject Supheli1speechbubleTXT2;
    [SerializeField] GameObject Supheli1speechbubleTXT3;
    [SerializeField] GameObject Supheli1speechbubleTXT4;

    [SerializeField] GameObject supheli2;
    [SerializeField] GameObject Supheli2speechbubleTXT1;
    [SerializeField] GameObject Supheli2speechbubleTXT2;

    [SerializeField] GameObject supheli3;
    [SerializeField] GameObject Supheli3speechbubleTXT1;
    [SerializeField] GameObject Supheli3speechbubleTXT2;
    [SerializeField] GameObject Supheli3speechbubleTXT3;

    [SerializeField] GameObject supheli4;
    [SerializeField] GameObject Supheli4speechbubleTXT1;
    [SerializeField] GameObject Supheli4speechbubleTXT2;
    [SerializeField] GameObject Supheli4speechbubleTXT3;
    [SerializeField] GameObject Supheli4speechbubleTXT4;
    [SerializeField] GameObject Supheli4speechbubleTXT5;

    [SerializeField] GameObject BoxTxt1;
    [SerializeField] GameObject BoxTxt2;
    [SerializeField] GameObject BoxTxt3;
    [SerializeField] GameObject BoxTxt4;
    [SerializeField] GameObject BoxTxt5;
    [SerializeField] GameObject BoxTxt6;

    [SerializeField] GameObject callthesuspectbutton;

    [SerializeField] TMPro.TMP_Dropdown dropboxSuspect1;
    [SerializeField] TMPro.TMP_Dropdown dropboxSuspect12;
    [SerializeField] TMPro.TMP_Dropdown dropboxSuspect2;
    [SerializeField] TMPro.TMP_Dropdown dropboxSuspect3;
    [SerializeField] TMPro.TMP_Dropdown dropboxSuspect4;

    [SerializeField] GameObject feedbackscreen;
    [SerializeField] GameObject okaybtn;
    [SerializeField] GameObject okaybtn2;
    [SerializeField] GameObject okaybtn3;
    [SerializeField] GameObject okaybtn4;

    [SerializeField] GameObject tutuklabtn;
    [SerializeField] GameObject notlarbtn;

    [SerializeField] GameObject tutuklapart;
    [SerializeField] GameObject feedbackscreen2;

    [SerializeField] GameObject menupart;


    int click = 0;
    int clickTXT = 0;
    int clickthepage = 0;

    bool notlarabakabilme = false;

    public void OpenMenuPart()
    {
        menupart.gameObject.SetActive(true);
    }
    public void CloseMenuPart()
    {
        menupart.gameObject.SetActive(false);
    }

    public void OpenNotlar()
    {
        if (!notlarabakabilme)
        {
          notlar.SetActive(true);
        }
        else if(clickthepage == 0)
        {
            speechbuble.SetActive(false);
            notlarpart1.SetActive(true);
            feedbackscreen.SetActive(false);    
            supheli1.SetActive(false);
        }
        else if (clickthepage == 1)
        {
            speechbuble.SetActive(false);
            notlarpart2.SetActive(true);
            feedbackscreen.SetActive(false);
            supheli2.SetActive(false);
        }
        else if (clickthepage == 2)
        {
            speechbuble.SetActive(false);
            notlarpart3.SetActive(true);
            feedbackscreen.SetActive(false);
            supheli3.SetActive(false);
        }
        else if (clickthepage == 3)
        {
            speechbuble.SetActive(false);
            notlarpart4.SetActive(true);
            feedbackscreen.SetActive(false);
            supheli4.SetActive(false);
        }
    }

    public void CloseNotlar1()
    {
       
        if (!notlarabakabilme)
        {
            notlar.SetActive(false);
        }
        else if (clickthepage == 0)
        {
            notlarpart1.SetActive(false);
            callthesuspectbutton.SetActive(true);
            feedbackscreen.SetActive(false);
            leftarrow.SetActive(false);
            rightarrow.SetActive(false);
            notlarabakabilme = false;
            clickthepage++;
        }
        else if (clickthepage == 1)
        {
            notlarpart2.SetActive(false);
            callthesuspectbutton.SetActive(true);
            feedbackscreen.SetActive(false);
            leftarrow.SetActive(false);
            rightarrow.SetActive(false);
            notlarabakabilme = false;
            clickthepage++;
        }
        else if (clickthepage == 2)
        {
            notlarpart3.SetActive(false);
            callthesuspectbutton.SetActive(true);
            feedbackscreen.SetActive(false);
            leftarrow.SetActive(false);
            rightarrow.SetActive(false);
            notlarabakabilme = false;
            clickthepage++;
        }
        else if (clickthepage == 3)
        {
            notlarpart4.SetActive(false);
            callthesuspectbutton.SetActive(true);
            feedbackscreen.SetActive(false);
            leftarrow.SetActive(false);
            rightarrow.SetActive(false);
            notlarabakabilme = false;
            clickthepage++;
            BoxTxt5.SetActive(false);
            BoxTxt6.SetActive(true);
            tutuklabtn.SetActive(true);
            callthesuspectbutton.SetActive(false);
            notlarbtn.SetActive(false);
        }
    }

    public void CallASuspect()
    {
        callthesuspectbutton.SetActive(false);
        click++;
        if (click == 1)
        {
            rightarrow.SetActive(true);
            supheli1.SetActive(true);
            speechbuble.SetActive(true);
            Supheli1speechbubleTXT1.SetActive(true);
        }
        if (click == 2)
        {
            rightarrow.SetActive(true);
            supheli2.SetActive(true);
            speechbuble.SetActive(true);
            Supheli2speechbubleTXT1.SetActive(true);
            Supheli1speechbubleTXT4.SetActive(false);

        }
        if (click == 3)
        {
            rightarrow.SetActive(true);
            supheli3.SetActive(true);
            speechbuble.SetActive(true);
            Supheli3speechbubleTXT1.SetActive(true);
            Supheli1speechbubleTXT4.SetActive(false);
            Supheli2speechbubleTXT1.SetActive(false);
            Supheli2speechbubleTXT2.SetActive(false);
        }
        if (click == 4)
        {
            rightarrow.SetActive(true);
            supheli4.SetActive(true);
            speechbuble.SetActive(true);
            Supheli4speechbubleTXT1.SetActive(true);
            Supheli1speechbubleTXT4.SetActive(false);
            Supheli3speechbubleTXT3.SetActive(false);
        }
    }
    
    public void NextText()
    {
        try
        {
            clickTXT++;
            if (clickTXT == 1)
            {
                leftarrow.SetActive(true);
                Supheli1speechbubleTXT1.SetActive(false);
                Supheli1speechbubleTXT2.SetActive(true);  
            }
            if (clickTXT == 2)
            {
                Supheli1speechbubleTXT2.SetActive(false);
                Supheli1speechbubleTXT3.SetActive(true);
            }
            if (clickTXT == 3)
            {
                Supheli1speechbubleTXT3.SetActive(false);
                Supheli1speechbubleTXT4.SetActive(true);
                rightarrow.SetActive(false);
                BoxTxt1.SetActive(false);
                BoxTxt2.SetActive(true);
                notlarabakabilme = true;
            }
            //------------------------------------------------Suspect2-------------
            if (clickTXT == 4)
            {
                Supheli2speechbubleTXT1.SetActive(false);
                Supheli2speechbubleTXT2.SetActive(true);
                rightarrow.SetActive(false);
                BoxTxt2.SetActive(false);
                BoxTxt3.SetActive(true);
                notlarabakabilme = true;
                leftarrow.SetActive(true);           
            }
            //------------------------------------------------Suspect3-------------
            if (clickTXT == 5)
            {
                Supheli3speechbubleTXT1.SetActive(false);
                Supheli3speechbubleTXT2.SetActive(true);
                BoxTxt3.SetActive(false);
                BoxTxt4.SetActive(true);
                notlarabakabilme = true;
                leftarrow.SetActive(true);
 
            }
            if (clickTXT == 6)
            {
                Supheli3speechbubleTXT2.SetActive(false);
                Supheli3speechbubleTXT3.SetActive(true);
                rightarrow.SetActive(false);
                notlarabakabilme = true;
                leftarrow.SetActive(true);
            }
            //------------------------------------------------Suspect4-------------
            if (clickTXT == 7)
            {
                Supheli4speechbubleTXT1.SetActive(false);
                Supheli4speechbubleTXT2.SetActive(true);
                notlarabakabilme = true;
                leftarrow.SetActive(true);
            }
            if (clickTXT == 8)
            {
                Supheli4speechbubleTXT2.SetActive(false);
                Supheli4speechbubleTXT3.SetActive(true);
                notlarabakabilme = true;
                leftarrow.SetActive(true);
            }
            if (clickTXT == 9)
            {
                Supheli4speechbubleTXT3.SetActive(false);
                Supheli4speechbubleTXT4.SetActive(true);
                notlarabakabilme = true;
            }
            if (clickTXT == 10)
            {
                Supheli4speechbubleTXT4.SetActive(false);
                Supheli4speechbubleTXT5.SetActive(true);
                notlarabakabilme = true;
                leftarrow.SetActive(true);
                rightarrow.SetActive(false);
                BoxTxt4.SetActive(false);
                BoxTxt5.SetActive(true);
            }
        }
        catch (System.Exception)
        {

            throw;
        }
       
    }

    public void PreviousText()
    {
        try
        {
            clickTXT--;
            if (clickTXT == 0)
            {
                leftarrow.SetActive(false);
                Supheli1speechbubleTXT1.SetActive(true);
                Supheli1speechbubleTXT2.SetActive(false);
            }
            if (clickTXT == 1)
            {
                Supheli1speechbubleTXT2.SetActive(true);
                Supheli1speechbubleTXT3.SetActive(false);
            }
            if (clickTXT == 2)
            {
                Supheli1speechbubleTXT3.SetActive(true);
                Supheli1speechbubleTXT4.SetActive(false);
                rightarrow.SetActive(true);
                notlarabakabilme = false;
            }
            //------------------------------------------------Suspect2-------------
            if (clickTXT == 3)
            {
                Supheli2speechbubleTXT1.SetActive(true);
                Supheli2speechbubleTXT2.SetActive(false);
                rightarrow.SetActive(true);
                notlarabakabilme = false;
                leftarrow.SetActive(false);
            }
            //------------------------------------------------Suspect3-------------
            if (clickTXT == 4)
            {
                Supheli3speechbubleTXT1.SetActive(true);
                Supheli3speechbubleTXT2.SetActive(false);
                notlarabakabilme = false;
                leftarrow.SetActive(false);
            }
            if (clickTXT == 5)
            {
                Supheli3speechbubleTXT2.SetActive(true);
                Supheli3speechbubleTXT3.SetActive(false);
                rightarrow.SetActive(true);
                notlarabakabilme = false;
            }
            //------------------------------------------------Suspect4-------------
            if (clickTXT == 6)
            {
                Supheli4speechbubleTXT1.SetActive(true);
                Supheli4speechbubleTXT2.SetActive(false);
                notlarabakabilme = false;
                leftarrow.SetActive(false);
            }
            if (clickTXT == 7)
            {
                Supheli4speechbubleTXT2.SetActive(true);
                Supheli4speechbubleTXT3.SetActive(false);
                notlarabakabilme = false;
            }
            if (clickTXT == 8)
            {
                Supheli4speechbubleTXT3.SetActive(true);
                Supheli4speechbubleTXT4.SetActive(false);
                notlarabakabilme = false;
            }
            if (clickTXT == 9)
            {
                Supheli4speechbubleTXT4.SetActive(true);
                Supheli4speechbubleTXT5.SetActive(false);
                rightarrow.SetActive(true);
                notlarabakabilme = false;
            }
        }
        catch (System.Exception)
        {

            throw;
        }
        
    }

    public void dropdownskontrollforSuspect1()
    {
        try
        {
            if (dropboxSuspect1.value == 1)
            {
                dropboxSuspect1.image.color = Color.green;
            }
            else
            {
                dropboxSuspect1.image.color = Color.red;
                feedbackscreen.SetActive(true);
            }

            if (dropboxSuspect12.value == 1)
            {
                dropboxSuspect12.image.color = Color.green;
            }
            else
            {
                dropboxSuspect12.image.color = Color.red;
                feedbackscreen.SetActive(true);
            }

            if (dropboxSuspect12.value == 1 && dropboxSuspect1.value == 1)
            {
                okaybtn.SetActive(true);
            }
        }
        catch (System.Exception)
        {
            throw;
        }

    }

    public void dropdownskontrollforSuspect2()
    {
        try
        {
            if (dropboxSuspect2.value == 0)
            {
                dropboxSuspect2.image.color = Color.green;
                okaybtn2.SetActive(true);

            }
            else
            {
                dropboxSuspect2.image.color = Color.red;
                feedbackscreen.SetActive(true);
            }
        }
        catch (System.Exception)
        {
            throw;
        }

    }

    public void dropdownskontrollforSuspect3()
    {
        try
        {
            if (dropboxSuspect3.value == 2)
            {
                dropboxSuspect3.image.color = Color.green;
                okaybtn3.SetActive(true);

            }
            else
            {
                dropboxSuspect3.image.color = Color.red;
                feedbackscreen.SetActive(true);
            }
        }
        catch (System.Exception)
        {
            throw;
        }

    }

    public void dropdownskontrollforSuspect4()
    {
        try
        {
            if (dropboxSuspect4.value == 0)
            {
                dropboxSuspect4.image.color = Color.green;
                okaybtn4.SetActive(true);

            }
            else
            {
                dropboxSuspect4.image.color = Color.red;
                feedbackscreen.SetActive(true);
            }
        }
        catch (System.Exception)
        {
            throw;
        }

    }

    public void arrest()
    {
        tutuklabtn.SetActive(false);
        tutuklapart.SetActive(true);
    }

    public void arrestchoicecorrect()
    {
        tutuklapart.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void arrestchoicefalse()
    {
        feedbackscreen2.SetActive(true);
    }
    public void arrestAgain()
    {
        feedbackscreen2.SetActive(false);
    }
}
