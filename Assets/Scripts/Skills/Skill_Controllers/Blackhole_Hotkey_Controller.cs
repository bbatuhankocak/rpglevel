using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Blackhole_Hotkey_Controller : MonoBehaviour
{
    private SpriteRenderer sr;

    private KeyCode myHotKey;
    private TextMeshProUGUI myText;

    private Transform enemiesTransform;
    private Blackhole_Skill_Controller blackHole;
    

    public void SetupHotKey(KeyCode _myNewHotKey, Transform _myEnemy, Blackhole_Skill_Controller _myBlackHole)
    {
        sr = GetComponent<SpriteRenderer>();

        myText = GetComponentInChildren<TextMeshProUGUI>();

        enemiesTransform = _myEnemy;
        blackHole = _myBlackHole;

        myHotKey = _myNewHotKey;
        myText.text = _myNewHotKey.ToString();
    }

    private void Update()
    {
        if (Input.GetKeyDown(myHotKey))
        {
            blackHole.AddEnemyToList(enemiesTransform);

            myText.color = Color.clear;

            sr.color = Color.clear;

        }
    }
}
