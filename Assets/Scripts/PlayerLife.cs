using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    // private Rigidbody rb;
    // private MeshRenderer meshRend;
    private float respawnTime = 1.3f;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("KillBlock") || other.gameObject.CompareTag("EnemyBody"))
        {
            Die();
        }
    }

    private void Die()
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<PlayerMovement>().enabled = false;
        Invoke(nameof(ReloadLevel), respawnTime);
    }

    private void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
