using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogFollow : MonoBehaviour
{
    [SerializeField]
    GameObject Target;

    Vector3 distance;





    // Start is called before the first frame update
    void Start()
    {
        distance = transform.position - Target.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = Vector3.Lerp(transform.position,Target.transform.position + distance, 0.3f);



    }
}
