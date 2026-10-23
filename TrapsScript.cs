using UnityEngine;

public class TrapsScript : MonoBehaviour
{
    public GameObject[] traps;
    public int platformCount = 0;
    public int ThornSpawnChance = 0;
    public int BombSpawnChance = 0;
    public int deltX = 0;
    public float deltY = 0f;
    private GameObject platformManagement;
    private int rand = 0;
    private GameObject platform;
    private void Awake()
    {
        platformManagement = GameObject.FindGameObjectWithTag("PlatformManagement");
        platform = platformManagement.GetComponent<LevelCreator>().lastPlatform;
    }
    public void Spawn()
    {
        platform = platformManagement.GetComponent<LevelCreator>().lastPlatform;
        if (platformManagement.GetComponent<LevelCreator>().amount > platformCount)
        {
            rand = Random.Range(1, 10);
            rand = rand + Random.Range(1, 10);
            if (rand < ThornSpawnChance)
            {
                Instantiate(traps[0], new Vector3(RandomSpawn(platform.transform.position.x - deltX, platform.transform.position.x + deltX), platform.transform.position.y + deltY, 0), Quaternion.identity);
            }
            rand = Random.Range(1, 10);
            rand = rand + Random.Range(1, 10);
            if (rand < BombSpawnChance)
            {
                Instantiate(traps[1], new Vector3(RandomSpawn(platform.transform.position.x - deltX, platform.transform.position.x + deltX), platform.transform.position.y + deltY, 0), Quaternion.identity);
            }
        }
    }
    private int RandomSpawn(float left, float right)
    {
        rand = Random.Range((int)left, (int)right);
        return rand;
    }
}
