using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public bool isReal = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int temp = Random.Range(0, 2);
        if(temp == 0)
        {
            isReal = true;
           // Debug.Log("survive");
        }
        else
        {
            isReal = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if(isReal)
            {

            }
            else
            {
                Destroy(gameObject);
           
            }

        }
    }
        
        
}
