using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    bool dead = false;
    private float respawnTime = 1.3f;
    private void Update()
    {
        if (transform.position.y < -1f && !dead)
        {
            Die();
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("KillBlock") || other.gameObject.CompareTag("EnemyBody"))
        {
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<PlayerMovement>().enabled = false;
            Die();
        }
    }

    private void Die()
    {
        Invoke(nameof(ReloadLevel), respawnTime);
        dead = true;
    }

    private void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
