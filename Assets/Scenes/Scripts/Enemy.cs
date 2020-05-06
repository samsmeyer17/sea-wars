using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject deathFX;
    [SerializeField] Transform parent;
    
    // Start is called before the first frame update
    void Start()
    {
        AddNonTriggerMeshCollider();
    }

// enemy is now self responisble for adding colliders
    void AddNonTriggerMeshCollider() {
        Collider enemyMeshCollider = gameObject.AddComponent<MeshCollider>();
        enemyMeshCollider.isTrigger = false;
    }


    void OnParticleCollision(GameObject other) {
        Instantiate(
            deathFX, transform.position, Quaternion.identity
        );
        Destroy(gameObject);
    }
}
