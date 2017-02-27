using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField]
    private Camera _camera;

    void Start()
    {
        //_camera = GetComponent<Camera>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Select();
        }

    }


    void Select()
    {
        var ray = _camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitObj;
        if(Physics.Raycast(ray, out hitObj, Mathf.Infinity))
        {
            if(hitObj.collider.gameObject.tag == "Block")
            {
                hitObj.collider.gameObject.GetComponent<Renderer>().material.color = Color.black;
            }   
        } 
    }
}
