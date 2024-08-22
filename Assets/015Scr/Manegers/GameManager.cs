using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    ScroolManeger scrollManger;
    private void Start()
    {
        scrollManger = GameObject.FindAnyObjectByType<ScroolManeger>();
        StartCoroutine(Gamestart());
    }
    IEnumerator Gamestart()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("게임 준비");
        yield return new WaitForSeconds(2f);
        scrollManger?.SetScrollSpeed(4);
    }
}
