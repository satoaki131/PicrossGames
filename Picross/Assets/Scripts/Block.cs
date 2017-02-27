using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    [SerializeField]
    private GameObject _wrong;

    public enum BlockState
    {
        White, //選択してない
        Black, //選択されて黒
        Wrong //選択されて×になってる状態
    }

    private BlockState _state = BlockState.White;

    private Renderer _renderer = null;

    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    public void ChangeState(BlockState value)
    {
        //Blockの色が入ってきた色と一緒なら白にする
        if(_state == value)
        {
            value = BlockState.White;
        }
        StartCoroutine(StateUpdate(value));
    }

    private IEnumerator StateUpdate(BlockState value)
    {
        _state = value;
        _renderer.material.color = _state == BlockState.Black ? Color.black : Color.white;
        _wrong.SetActive(_state == BlockState.Wrong ? true : false);
        yield return null;
    }
}
 