
using System;
using TMPro;
using UnityEngine;

public class TriggerHandler : MonoBehaviour
{
    [SerializeField] private TMP_Text sign;
    private TMP_Text score;
    void Start()
    {
        score = GameObject.Find("scoreCounter").GetComponent<TMP_Text>();
    }
    private void OnTriggerEnter(Collider other)
    {
        int scoreCal = Int32.Parse(score.text);
        int number = Int32.Parse(sign.text.Substring(1));
        Debug.Log(number);
        switch ((int)sign.text[0])
        {
            case 247:
                scoreCal /= number;
                break;
            case 215:
                scoreCal *= number;
                break;
            case 43:
                scoreCal += number;
                break;
            case 45:
                scoreCal -= number;
                break;
        }
        score.text = scoreCal.ToString();
        Destroy(this);
    }
}
