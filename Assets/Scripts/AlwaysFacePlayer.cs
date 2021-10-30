using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlwaysFacePlayer : MonoBehaviour
{

/*    var v = transform.position - Camera.main.transform.position;
 v.y = 0.0;
 transform.rotation = Quaternion.LookRotation(v);
 */

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(Camera.main.transform);
        Vector3 v = transform.position - Camera.main.transform.position;
        v.y = 0f;
        transform.rotation = Quaternion.LookRotation(v);
    }
}
