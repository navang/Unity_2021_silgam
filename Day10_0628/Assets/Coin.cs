using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public Text SCORE;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "PLAYER") // ������ �÷��̾���� ������ ����
        {
            Debug.Log("���ΰٶ�");
            gameObject.SetActive(false);
            SCORE.text = "����!";
        }
    }
}

