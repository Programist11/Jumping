using UnityEngine;

public class LevelCreator : MonoBehaviour
{
    public GameObject[] level;
    public Transform cameraTrans;
    public float creatDistance = 0f;
    public float fisrtPlatformPosition = 0f;
    public float delta = 0f;
    public int amount;
    public int minLevel;
    private GameObject traps;
    private GameObject firstPlatform;
    [System.NonSerialized]
    public GameObject lastPlatform;
    private int rand = 0;
    private float deltRand = 0;
    private int zone = 3;
    private int num;
    private int index;
    private int rand1level;
    private void Awake()
    {
        traps = GameObject.FindGameObjectWithTag("GameManagement");
        num = level.Length;
    }
    private void FixedUpdate()
    {
        transform.position = new Vector3(0, cameraTrans.position.y - creatDistance / 2 - minLevel, 0);
    }
    private void Start()
    {
        firstPlatform = Instantiate(level[0], new Vector3(transform.position.x, transform.position.y + fisrtPlatformPosition, 0), Quaternion.identity);
        firstPlatform.GetComponent<Collider2D>().isTrigger = false;
        float k = 0;
        while (k <= creatDistance - delta)
        {
            k += delta;
            rand = Random.Range(0, num);
            rand = rand + Random.Range(0, num);
            rand = rand + Random.Range(0, num);
            rand1level = Random.Range(0, 4);
            if (rand1level == 1)
            {
                rand = 0;
            }
            deltRand = Random.Range(-1, 1) / 10;
            if ((int) ((rand  / zone) + deltRand - 1) > 2)
            {
                index = (int) ((rand  / zone) + deltRand - 1);
            }
            else
            {
                index = (int) ((rand  / zone) + deltRand);
            }
            Instantiate(level[index], new Vector3(transform.position.x, transform.position.y + fisrtPlatformPosition + k, 0), Quaternion.identity);
        }
        amount = (int)(k / delta);
        lastPlatform = Instantiate(level[(int) ((rand  / zone) + deltRand)], new Vector3(transform.position.x, transform.position.y + fisrtPlatformPosition + delta * (amount + 1), 0), Quaternion.identity);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        amount++;
        traps.GetComponent<TrapsScript>().Spawn();
        rand = Random.Range(0, num);
        rand = rand + Random.Range(0, num);
        rand = rand + Random.Range(0, num);
        deltRand = Random.Range(-1, 1) / 10;
        Destroy(other.gameObject);
        lastPlatform = Instantiate(level[(int) ((rand  / zone) + deltRand)], new Vector3(transform.position.x, lastPlatform.transform.position.y + delta, 0), Quaternion.identity);
    }
}
