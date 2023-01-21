using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreRestartController : MonoBehaviour
{
    // Start is called before the first frame update
    /*�� ���� ����� ����������� ���������� �������� ��������� ��� ������
    ��� �������� ����������� ��� ��
    � ������� �������� ��� ����������� � ������� ����������
    ��� �������� �������� � ������� ���������� ��������� �������� ��� ������*/

    public static int startingScore;

    public SceneChanger sceneChanger;

    void Start()
    {
        startingScore = GameManager.currentScore;
    }

    // Update is called once per frame
    void Update()
    {
        if (sceneChanger.sceneChanged == true)
        {
            GameManager.currentScore = startingScore;
        }
    }
}
