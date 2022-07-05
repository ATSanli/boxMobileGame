using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public float speedFinish;

    
    // Start is called before the first frame update
    void Update()
    {
        transform.Translate(Vector3.forward * speedFinish * Time.deltaTime);
    }
   
}
