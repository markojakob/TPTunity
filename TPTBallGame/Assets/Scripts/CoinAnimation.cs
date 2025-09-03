using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CoinAnimation : MonoBehaviour
{
    public float RotationSpeed;
    public float RotationSpeed2;
    public float RotationSpeed3;

    // Start is called before the first frame update
    void Start()
    {
                
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(RotationSpeed*Time.deltatime, RotationSpeed2 * Time.deltatime, RotationSpeed3 * Time.deltatime, Space.World);
    }
}
