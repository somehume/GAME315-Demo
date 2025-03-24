using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LoadSceneController : MonoBehaviour
{

    [SerializeField] private string LoadLevel = "Scene02";
    public TextMeshProUGUI buttonText;


    public void LoadSceneButton()
    {
        SceneManager.LoadScene(LoadLevel);

    }

    public void LoadMainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");

    }

    public void LoadSampleSceneButton()
    {
        SceneManager.LoadScene("SampleScene");

    }

    public void ChangeTextButton()
    {
        buttonText.text = "Clicked";
    }
}
