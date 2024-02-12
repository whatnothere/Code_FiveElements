using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelvisTwist : MonoBehaviour
{
    public GameObject pelvisTwist;

    private void LateUpdate()
    {
        this.transform.localPosition = pelvisTwist.transform.localPosition;
    }


    
}
