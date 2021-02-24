using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBox : MonoBehaviour
{
    [SerializeField] private GameObject boxPrefab;
    private GameObject box;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 location = new Vector3(0, 1.42f, -31.34f);
        box = Instantiate(boxPrefab, location, transform.rotation) as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
