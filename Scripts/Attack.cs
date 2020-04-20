using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    

    public void OnTriggerEnter2D(Collider2D other)
    {
        IDamageable hit = other.GetComponent<IDamageable>();

        if (hit != null)
        {
           
            
                hit.Damage();
                
                AudioManager.instance.PlaySFX(1);

            
        }
    }
}
