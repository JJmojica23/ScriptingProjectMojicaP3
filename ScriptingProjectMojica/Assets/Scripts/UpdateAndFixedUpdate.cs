using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFixedUpdate : MonoBehaviour
{
    // FixedUpdate intervals are consistent
    // Called every physics step

    void FixedUpdate()
    {
        Debug.Log("FixedUpdate time :" + Time.deltaTime); 
    }

    // Update is called once per frame
    // Update times vary
    void Update()
    {
        Debug.Log("Update time :" + Time.deltaTime);
    }
}
