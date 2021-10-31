using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    public float speed = 10;
    public int maxPoints = 1;
    public Image uiPlayer;

    [Header("Key setup")]
    public KeyCode KeyCodeMoveUp = KeyCode.UpArrow;
    public KeyCode KeyCodeMoveDown = KeyCode.DownArrow;
    public KeyCode KeyCodeRestartDown = KeyCode.R;


    [Header("Points")]
    public int currentPoint;
    public TextMeshProUGUI uiTextPoints;

    public string playerName;

    public void Awake()
    {
        ResetPlayer();
    }

    public void ResetPlayer()
    {
        currentPoint = 0;
        UpdateUI();
    }

    public void SetName(string s)
    {
        playerName = s;
    }

    public Rigidbody2D myRigidbody2D;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCodeMoveUp))
        {
            myRigidbody2D.MovePosition(transform.position + transform.up * speed);
        }
        else if(Input.GetKey(KeyCodeMoveDown))
        {
            myRigidbody2D.MovePosition(transform.position + transform.up * speed * -1);
        }

    }

    public void AddPoint()
    {
        currentPoint++;
        //Debug.Log("Pontos: " + currentPoint);
        UpdateUI();
        CheckNextPoints();
    }

    public void ChangeColor(Color color)
    {
        uiPlayer.color = color;
    }

    private void UpdateUI()
    {
        uiTextPoints.text = currentPoint.ToString();
    }

    private void CheckNextPoints()
    {
        if (currentPoint >= maxPoints)
        {
            GameManager.Instance.EndGame();
            HighScoreManager.Instance.SavePlayerWin(this);
        }
    }

}
