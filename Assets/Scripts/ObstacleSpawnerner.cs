using UnityEngine;

public class ObstacleSpawnerner : MonoBehaviour
{
    public Transform row1;
    public Transform row2;

    public GameObject obstacle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnStuff();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnStuff()
    {
        for (int i = 1;i < 11;i++)
        {
            var go = Instantiate(object);
            go.transform.position = row1.position;

            go.transform.position += new Vector3(0, 0, 2 * i);
            go.transform.rotation = row2.rotation;

            var go2 = Instantiate(obstacle);
            go2.transform.position = row2.position;

            go2.transform.position += new Vector3(0, 0, 2 * i);
            go2.transform.rotation = row2.rotation;


        }
    }
}
