using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinCollectible : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI scoreText;
    private int score = 0;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            score++;
            scoreText.text = "SKOR: " + score.ToString();
        }
    }
}
