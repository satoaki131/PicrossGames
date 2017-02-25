using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ピクロスの盤面を作るスクリプト
/// </summary>
public class CreateMap : MonoBehaviour {

    [SerializeField]
    private GameObject _map;

    [SerializeField]
    private Vector2 MAP_COUNT;

    void Start()
    {
        for(int x = 0; x < MAP_COUNT.x; x++)
        {
            for(int z = 0; z < MAP_COUNT.y; z++)
            {
                var map = Instantiate(_map);
                map.transform.localPosition = new Vector3((MAP_COUNT.x / 2.0f) - x, 0, (MAP_COUNT.y / 2.0f) - z);
                map.transform.parent = transform;
            }
        }
    }

    void Update()
    {

    }

}
