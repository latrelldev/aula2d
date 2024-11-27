using System.Collections;
using System.Collections.Generic;
using UnityEditor.iOS;
using UnityEngine;
using UnityEngine.Events;

public class ScoreController : MonoBehaviour
{
    public UnityEvent OnScoreChanged;
    
    public int Score { get; set; }

    public void AddScore (int amount)
    {
        Score += amount;
        OnScoreChanged.Invoke();
    }
   
}
