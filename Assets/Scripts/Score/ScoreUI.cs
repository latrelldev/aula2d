using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class ScoreUI : MonoBehaviour
{
    private TMP_Text _scoreText;

    [SerializeField]
    private GameObject _winScreen;

    [SerializeField]
    private int _scoreToWin;

    public UnityEvent OnWin;

    private void Awake()
    {
        _scoreText = GetComponent<TMP_Text>();
    }

    public void UpdateScore(ScoreController scoreController)
    {
        _scoreText.text = $"SCORE: {scoreController.Score}";

        if (scoreController.Score == _scoreToWin)
        {
            _winScreen.SetActive(true);
            OnWin.Invoke(); 
        }
    }
    
}
