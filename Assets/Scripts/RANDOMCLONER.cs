using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RANDOMCLONER : MonoBehaviour
{
    public GameObject preFab0;
    public GameObject preFab1;
    public GameObject preFab2;
    public int numero;
    int max = 0;
    int min = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clonar()
    {
        numero = Random.Range(min, max - 1);

        if (numero == 0)
        {
            Instantiate(preFab0);
        }
        else if (numero == 1)
        {
            Instantiate(preFab1);
        }
        else if (numero == 2)
        {
            Instantiate(preFab2);
        }
    }
}
