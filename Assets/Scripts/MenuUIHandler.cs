#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Sets the script to be executed later than all default scripts
[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{

    public InputField inputField;
    public Text highScoreText;

    public void NewNameSubmitted(string PlayerName)
    {
        GameManager.Instance.PlayerName = PlayerName;
        GameManager.Instance.Save();
    }

    private void Start()
    {
        // Loading player name 

        inputField.onEndEdit.AddListener(NewNameSubmitted);

        inputField.text = GameManager.Instance.PlayerName;
        highScoreText.text = "Best Score: " + GameManager.Instance.HighScore.ToString();
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        // Save
        GameManager.Instance.Save();

        // Exit
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

}
