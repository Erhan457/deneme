using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class TestScript : MonoBehaviour
{
    [SerializeField] private GameObject _item;
    
    void Start()
    {
        int itemCount = 8;

        for(int i = 5; i > 0; i--)
        {
            SpawnItem();
        }
        
    }

    
    void SpawnItem()
    {
        Instantiate(_item, new Vector2(Random.Range(6.5f, -6.5f), Random.Range(3.5f, -3.5f)), Quaternion.identity);
    }
}
