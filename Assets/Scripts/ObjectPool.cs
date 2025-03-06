using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }

        this.InitiatePool();
    }

    public GameObject spawnable;
    int sizeOfPool = 10;

    List<GameObject> objects = new List<GameObjects>();

    public void SpawnObject(Vector3 position)
    {
        var go = GetObjects();
        go.SetActive(true);
        go.transform.position = position;
    }

    GameObject GetObject()
    {
        for (int i = 0; i < objects.Count - 1; i++)
        {
            if (!objects[i].activeInHierarchy)
            {
                return objects[i];
            }
        }

        sizeOfPool++;
        var go = Instantiate(spawnable);
        go.setActive(false);
        objects.Add(go);
        return go;
    }

    void InitiatePool()
    {
        for(int i = 0; i < sizeOfPool; i++)
        {
            var go = Instantiate(spawnable);
            go.setActive(false);
            objects.Add(go);
        }
    }
}
