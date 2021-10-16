using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{ 
    [SerializeField] Camera FPCamera;
    [SerializeField] float range = 1000f;
    [SerializeField] float damageAmount = 1f;
    [SerializeField] ParticleSystem muzzleFlash;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")){
            Shoot();
        }
    }
    private void Shoot(){
        PlayMuzzleFlash();
        ProcessRaycasting();
        
    }
    private void ProcessRaycasting(){
        RaycastHit hit;
        if (Physics.Raycast(FPCamera.transform.position, FPCamera.transform.forward, out hit, range)){
            Debug.Log(hit.transform.name);
            EnimyHealth target = hit.transform.GetComponent<EnimyHealth>();
            if (target == null) return;
            target.TakeDamage(damageAmount);
        }
        else{
            return;
        }
    }
    private void PlayMuzzleFlash(){
        muzzleFlash.Play();
    }
}
