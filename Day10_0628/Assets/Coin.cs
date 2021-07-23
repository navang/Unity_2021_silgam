using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public Text SCORE;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "PLAYER") // 코인이 플레이어만나면 스스로 꺼짐
        {
            Debug.Log("코인겟또");
            gameObject.SetActive(false);
            SCORE.text = "성공!";
        }
    }
}

