using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUI : MonoBehaviour
{
    public string PlayerName;
    public InputField inputField;
    public Text BestScore;

    void Start()
    {
        Best.Instance.LoadBest();
        BestScore.text = "Best Score: " + Best.Instance.bestPlayer + ": " + Best.Instance.bestScore; 
    }

    public void NameSelect()
    {
        PlayerName = inputField.text;
        Best.Instance.PlayerName = PlayerName;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#endif
        Application.Quit();
    }
}
