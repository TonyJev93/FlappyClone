using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUp : MonoBehaviour
{
    // 통과 했을 때 동작
    private void OnTriggerEnter2D(Collider2D other) {
        Score.score += 1;
    }
}
