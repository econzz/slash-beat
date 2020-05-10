using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaberScript : MonoBehaviour
{
    public LayerMask layer;
    private Vector3 previousPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public bool checkCollision()
    {
        RaycastHit hit;

        if(Physics.Raycast(transform.position,transform.forward,out hit, 1, layer))
        {
            if (Vector3.Angle(transform.position - previousPosition, hit.transform.up) > 130)
            {
                SoundManagerScript.PlaySound(SoundManagerScript.SFX.HIT);
                Destroy(hit.transform.gameObject);
                return true;
                
                
//                CubeCutScript.Cut(hit.transform,transform.position);
            }
            else
            {
                SoundManagerScript.PlaySound(SoundManagerScript.SFX.MISS);
                return false;
                
            }
        }
        previousPosition = transform.position;
        return false;
    }
}
