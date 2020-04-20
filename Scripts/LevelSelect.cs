using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{

    public string firstLevel;
    public string secondLevel;
    public string thirdLevel;
    public string fourthLevel;
    public string fifthLevel;
    public string sixthLevel;
    public string seventhLevel;
    public string eighthLevel;
    public string ninthLevel;
    public string tenthLevel;

    

    public Button[] levelButtons;

    void Start()
    {
        int levelReached = PlayerPrefs.GetInt("levelReached", 1);

        for (int i = 0; i < levelButtons.Length; i++)
        {
            if(i + 1 > levelReached)
            levelButtons[i].interactable = false;
        }
    }

   

    public void FirstLevel()
    {
        SceneManager.LoadScene(firstLevel);
        AudioManager.instance.PlaySFX(2);
    }

    public void SecondLevel()
    {
        SceneManager.LoadScene(secondLevel);
        AudioManager.instance.PlaySFX(2);
    }

    public void ThirdLevel()
    {
        SceneManager.LoadScene(thirdLevel);
        AudioManager.instance.PlaySFX(2);
    }

    public void FourthLevel()
    {
        SceneManager.LoadScene(fourthLevel);
        AudioManager.instance.PlaySFX(2);
    }

    public void FifthLevel()
    {
        SceneManager.LoadScene(fifthLevel);
        AudioManager.instance.PlaySFX(2);
    }

    public void SixthLevel()
    {
        SceneManager.LoadScene(sixthLevel);
        AudioManager.instance.PlaySFX(2);
    }

    public void SeventhLevel()
    {
        SceneManager.LoadScene(seventhLevel);
        AudioManager.instance.PlaySFX(2);
    }

    public void EighthLevel()
    {
        SceneManager.LoadScene(eighthLevel);
        AudioManager.instance.PlaySFX(2);
    }

    public void NinthLevel()
    {
        SceneManager.LoadScene(ninthLevel);
        AudioManager.instance.PlaySFX(2);
    }

    public void TenthLevel()
    {
        SceneManager.LoadScene(tenthLevel);
        AudioManager.instance.PlaySFX(2);
    }
}
