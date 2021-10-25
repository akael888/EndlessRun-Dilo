using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawnerController : MonoBehaviour
{
    private bool boxActive = false;
    public List<GameObject> boxList;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D (Collider2D other)
    {
        Debug.Log("Triggered");
        if (other.tag == "Player")
        {
            Debug.Log("Hit Player");
            for (int x = 0; x < boxList.Count; x++)
            {
                boxList[x].SetActive(true);
            }
            Destroy(gameObject);
            
        }
    }
}
