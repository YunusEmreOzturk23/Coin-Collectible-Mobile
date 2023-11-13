using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ObstacleController : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI healtText;
    [SerializeField]
    private TextMeshProUGUI gameOverText;
    private int healt = 3;
    [SerializeField]
    private Button restartButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (healt == 0)
        {
            gameOverText.text = "OYUN BÝTTÝ";
            Time.timeScale = 0;
            restartButton.gameObject.SetActive(true);
        }
        if (healt != 0)
        {
            Time.timeScale = 1;
        }
    }
    public void RestartGame()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            healt--;
            healtText.text = "CAN: " + healt.ToString();
        }
        
    }
}
