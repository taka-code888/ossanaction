using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabsScript : MonoBehaviour
{
    float sumTime = 0;
    public GameObject targetPrefab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sumTime += Time.deltaTime;

        if(sumTime >= 1)
        {
            int rndX = Random.Range(-11, 12);
            int rndY = Random.Range(-5, 6);

            GameObject go = Instantiate(targetPrefab);

            go.transform.position = new Vector2(rndX, rndY);

            sumTime = 0;
        }
    }
}
