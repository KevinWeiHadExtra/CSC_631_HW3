using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    [SerializeField] private GameObject ballPrefab;
    private GameObject _ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (_ball==null && Input.GetMouseButtonDown(0))
        {
            Vector3 location = new Vector3(0, 20, 0);
            _ball = Instantiate(ballPrefab, location, transform.rotation) as GameObject;
        }
        if (_ball != null && Input.GetMouseButtonDown(1))
        {
            Destroy(_ball);
        }
    }
}
