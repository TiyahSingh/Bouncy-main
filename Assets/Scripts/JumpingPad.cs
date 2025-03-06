using UnityEngine;

public class JumpingPad : MonoBehaviour
{
    public float jumpforce = 25f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpforce, 0), ForceMode.Impulse);
    }
}
