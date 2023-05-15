using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMan : MonoBehaviour
{
    float counter = 0, interval = 1.5f;
    [SerializeField] private GameObject floor, parent;
    void Update()
    {
        counter -= Time.deltaTime;
        if (counter <= 0)
        {
            Instantiate(floor, new Vector3(-7f, 0, 0),transform.rotation,parent.transform);
            counter = interval;
        }
    }
}
