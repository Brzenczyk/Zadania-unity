using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    public static int _score = 0;

    private TextMeshProUGUI _tmp;

    private void Start()
    {
        _score = 0;
        _tmp = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        _tmp.text = _score.ToString();

    }
}