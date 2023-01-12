using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static int PintCount;

    public TextMeshProUGUI scoretext;

    void Start()
    {
        PintCount = 0;
    }

    void Update()
    {
        scoretext.text = PintCount.ToString();
    }
}
