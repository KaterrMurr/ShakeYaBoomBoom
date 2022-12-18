using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundsOnBeat : MonoBehaviour
{
    //Скрипт, который назначает/выбирает из array[], какие звуки спавнить на какой бит.
    //Вместо звуков для нашего проекта будут спрайты, вместо SoundManager-а нужно будет написать спрайт-менеджер по той же логике.

    public SoundManager _soundManager; //назначили для существующего SM переменную в рамках этого скрипта, таким образом получили доступ к тому SM.
    public AudioClip _tap, _tick; //добавили публичные поля, в которые можно перенести звуки тап и тик
    public AudioClip[] _strum; //добавили array для звуков аккорда, т.к. их 3, но меняться они должны, подставляясь в рамках одной переменной - _strum
    int _randomStrum;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {//прописываем правила, как часто будут проигрываться какие звуки, на какие из битов в BPeerM - для нас это надо связать со справном спрайтов
        if (BPeerM._beatFull)
        {
            _soundManager.PlaySound(_tap, 1); //если в СМ происходит счет beatFull, играем тап
            if (BPeerM._beatCountFull % 2 == 0) //на каждые 2 бита
            {
                _randomStrum = Random.Range(0, _strum.Length);
            }
        }
        if (BPeerM._beatD8 && BPeerM._beatCountD8 % 2 == 0)//на каждый бит тик будет играть 4 раза
        {
            _soundManager.PlaySound(_tick, 0.1f);
        }
        if (BPeerM._beatD8 && (BPeerM._beatCountD8 % 8 == 2 || BPeerM._beatCountD8 % 8 == 4))
        {
            _soundManager.PlaySound(_strum[_randomStrum], 1);
        }
    }
}
