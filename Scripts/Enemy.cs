using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{

    public int health;
    

    public GameObject effect;

    

    protected bool isDead = false;

    protected bool isHit = false;

    public int Health { get; set; }

    private Shake shake;

    
    void Start()
    {
        shake = GameObject.Find("ShakeManager").GetComponent<Shake>();
        Health = health;
    }
    // Update is called once per frame
    
    public void Damage()
    {
        if (isDead == true)
            return;

        Health--;
        
        isHit = true;
       

        if (Health <= 0 && !isDead)
        {
            isDead = true;
            
            Destroy(gameObject);

            Instantiate(effect, transform.position, Quaternion.identity);

            shake.CamShake();
            

        }
    }
}
