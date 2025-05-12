using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class INSTANTIATOR : MonoBehaviour
{
    public GameObject cubePreFab;

    // Start is called before the first frame update
    void Start()
    {
        clonarCubo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clonarCubo()
    {
        Instantiate(cubePreFab);
    }
}
