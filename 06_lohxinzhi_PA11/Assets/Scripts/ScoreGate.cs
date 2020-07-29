using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreGate : MonoBehaviour
{
    public float score;
    public Text Score_Txt;

    // Start is called before the first frame update
    void Start()
    {
        Score_Txt.text = "Score " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            score += 10;
            print(score);
            Score_Txt.text = "Score " + score;
        }
    }
}
