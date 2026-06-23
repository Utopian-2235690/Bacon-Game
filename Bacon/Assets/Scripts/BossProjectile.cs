using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BossProjectileSpawner : MonoBehaviour
{
    
    [SerializeField] private GameObject _Projectile;
    [SerializeField] private Transform _ProjectileSpawn;
    
    
    void Start()
    {
        InvokeRepeating(nameof(Projectile), 0.0f, 5.0f);
    }
    void Projectile()
    {
       
        Instantiate(_Projectile, transform.position, transform.rotation); 
        }    
    }


