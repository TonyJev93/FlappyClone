using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI 실시간 반영을 위해 필요
public class Score : MonoBehaviour
{
    public static int score = 0; // static 을 해줘야 외부에서도 변경 가능
    public static int bestScore = 0;
    // Start is called before the first frame update
    void Start()
    {
       score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = score.ToString(); // Int -> Text
    }
}
