using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Credits : MonoBehaviour
{
    public GameObject instructionsPanel;

    public void Quit()
    {
        Application.Quit();
        AudioManager.instance.PlaySFX(2);
    }

    public void StartGame()
    {
        AudioManager.instance.PlaySFX(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void Instruction()
    {
        AudioManager.instance.PlaySFX(2);
        instructionsPanel.SetActive(true);
    }

    public void InstructionClose()
    {
        AudioManager.instance.PlaySFX(2);
        instructionsPanel.SetActive(false);
    }
}
