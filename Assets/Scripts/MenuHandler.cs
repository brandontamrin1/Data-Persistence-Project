using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MenuHandler : MonoBehaviour
{
    public TMP_InputField nameInput;
    public TMP_Text nameBestScore;

    public void Start()
    {
        DataPersistence.Instance.LoadScore();
        nameBestScore.text = "Best Score: " + DataPersistence.Instance.playerName + ": " + DataPersistence.Instance.bestScore;
    }
    public void StartGame()
    {
        DataPersistence.Instance.newName = nameInput.text;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }
}
