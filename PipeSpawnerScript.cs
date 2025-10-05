using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
    
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float height = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
    }
    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - height;
        float heighestPoint = transform.position.y + height;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, heighestPoint), 0), transform.rotation);
    }
}
