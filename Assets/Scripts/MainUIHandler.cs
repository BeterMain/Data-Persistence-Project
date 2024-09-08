using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainUIHandler : MonoBehaviour
{

    public Text playerInfoText;

    // Start is called before the first frame update
    void Start()
    {
        playerInfoText.text = "Best Score: " + GameManager.Instance.PlayerName + ": " + GameManager.Instance.HighScore.ToString();
    }

    public void BackToTitle()
    {
        SceneManager.LoadScene(0);
    }
}
