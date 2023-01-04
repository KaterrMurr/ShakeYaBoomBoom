using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundsOnBeat : MonoBehaviour
{
    //������, ������� ���������/�������� �� array[], ����� ����� �������� �� ����� ���.
    //������ ������ ��� ������ ������� ����� �������, ������ SoundManager-� ����� ����� �������� ������-�������� �� ��� �� ������.

    public SoundManager _soundManager; //��������� ��� ������������� SM ���������� � ������ ����� �������, ����� ������� �������� ������ � ���� SM.
    public AudioClip _tap, _tick; //�������� ��������� ����, � ������� ����� ��������� ����� ��� � ���
    public AudioClip[] _strum; //�������� array ��� ������ �������, �.�. �� 3, �� �������� ��� ������, ������������ � ������ ����� ���������� - _strum
    int _randomStrum;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {//����������� �������, ��� ����� ����� ������������� ����� �����, �� ����� �� ����� � BPeerM - ��� ��� ��� ���� ������� �� �������� ��������
        if (BPeerM._beatFull)
        {
            _soundManager.PlaySound(_tap, 1); //���� � �� ���������� ���� beatFull, ������ ���
            if (BPeerM._beatCountFull % 2 == 0) //�� ������ 2 ����
            {
                _randomStrum = Random.Range(0, _strum.Length);
            }
        }
        if (BPeerM._beatD8 && BPeerM._beatCountD8 % 2 == 0)//�� ������ ��� ��� ����� ������ 4 ����
        {
            _soundManager.PlaySound(_tick, 0.1f);
        }
        if (BPeerM._beatD8 && (BPeerM._beatCountD8 % 8 == 2 || BPeerM._beatCountD8 % 8 == 4))
        {
            _soundManager.PlaySound(_strum[_randomStrum], 1);
        }
    }
}
