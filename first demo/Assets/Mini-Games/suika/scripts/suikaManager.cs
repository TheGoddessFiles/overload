using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class suikaManager : MonoBehaviour
{
    public static suikaManager instance;

    public int currentScore { get; set; }

    [SerializeField] private TextMeshProUGUI scoreText;
  //  [SerializeField] private Image gameover;
    [SerializeField] private float fadetime = 2f;

    public float timeTillgameOver = 1.5f;



    // Start is called before the first frame update
    private void Awake()
    {
        if (instance==null)
        {
            instance = this;
        }

        scoreText.text = currentScore.ToString("0");
    }

    // Update is called once per frame
   public void Increasescore(int Amount)
    {
        currentScore += Amount;
        scoreText.text = currentScore.ToString("0");

    }

    public void GameOver()
    {
        // StartCoroutine(ResetGame());
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

   // private IEnumerator ResetGame()
   // {

  //  }
}
