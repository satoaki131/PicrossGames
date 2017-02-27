using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField]
    private Camera _camera;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Select(Block.BlockState.Black);
        }
        else if(Input.GetMouseButtonDown(1))
        {
            Select(Block.BlockState.Wrong);
        }

    }


    void Select(Block.BlockState blockState)
    {
        var ray = _camera.ScreenPointToRay(Input.mousePosition); //MouseのポインタからRayを飛ばす
        RaycastHit hitObj; //Rayと当たったObject
        if(Physics.Raycast(ray, out hitObj, Mathf.Infinity))
        {
            if(hitObj.collider.gameObject.tag == "Block")
            {
                hitObj.collider.gameObject.GetComponent<Block>().ChangeState(blockState);
            }   
        } 
    }
}
