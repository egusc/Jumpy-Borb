using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour
{
    private int score = 0;
    [SerializeField] 
    private TextMeshProUGUI text;

    private void Start() {
        text.text = "0";
    }
    public void GameOver()
    {
           StartCoroutine(ResetLevel());
    }

    public void IncreaseScore()
    {
        score++;
        text.text = score.ToString();
    }

    IEnumerator ResetLevel()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
