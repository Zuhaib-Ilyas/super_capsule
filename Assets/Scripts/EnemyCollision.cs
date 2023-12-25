using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCollision : MonoBehaviour
{
    [SerializeField] AudioSource deathSound;

    bool dead = false;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EnemyBody"))
        {
            playerInvisible();
            Debug.Log("Death");
            Die();
        }
    }
    void playerInvisible()
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<playerMovement>().enabled = false;
    }
    void Die()
    {
        
        dead = true;
        Invoke("reloadLevel", 1.3f);
        deathSound.Play();
    } 

    void reloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -3f && !dead)

        {
            Die();
        }
    }
}
