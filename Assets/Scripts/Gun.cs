using UnityEngine;

public class Gun : MonoBehaviour
{
    public float Damage = 10f;
    public float Range = 100f;

    public Camera FpsCam;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

    }

    void Shoot()
    {
        
        RaycastHit hit;
        if(Physics.Raycast(FpsCam.transform.position, FpsCam.transform.forward, out hit, Range))
        {
            Debug.Log(hit.transform.name);
            EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();

            if(target != null)
            {
                target.TakeDamage(Damage);
            }
            
        }
    }
}
