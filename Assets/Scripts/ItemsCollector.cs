using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemsCollector : MonoBehaviour
{
    int coin = 0;
    [SerializeField] TextMeshProUGUI CoinText;

    [SerializeField] AudioSource collectorSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("coin"))
        {
            Destroy(other.gameObject);
            coin++;
            CoinText.text = "Coins = " + coin;
            Debug.Log("coin collected:  " + coin);
            collectorSound.Play();
        }
            
    }





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
