using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] Portal otherPortal;
    [SerializeField] bool isWorking = true;

    [SerializeField] float maxTime = 30.0f;//To change the how long a portal is on
    float currentTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentTime = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        PortalTimer();
        if (isWorking)
        {
            otherPortal.isWorking = false;
            if (collision.gameObject.GetComponent<BallController>() != null)
            {
                collision.gameObject.transform.position = otherPortal.transform.position;
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        isWorking = true;
        currentTime = 0.0f;
    }

    private void PortalTimer()
    {
        if (currentTime >= maxTime)
        {
            isWorking = false;
        }
    }
}
