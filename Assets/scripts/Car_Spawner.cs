using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Spawner : MonoBehaviour
{
    public GameObject[] car;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCars());
    }

    // Update is called once per frame
    void Update()
    {   

    }

    void Cars()
    {
        int rand = Random.Range(0, car.Length);
    float randXPos = Random.Range(-1.8f, 1.8f);

    Quaternion rotation = Quaternion.identity;

    // Rotate specific cars by name or index
    if (car[rand].name.Contains("car3") || car[rand].name.Contains("car4") || car[rand].name.Contains("car5") || car[rand].name.Contains("car6"))
    {
        rotation = Quaternion.Euler(0, 0, 90); // or 90, depending on the sprite
    }

    Instantiate(car[rand], new Vector3(randXPos, transform.position.y, transform.position.z), rotation);
    }

    IEnumerator SpawnCars()
    {
        while(true)
        {
            yield return new WaitForSeconds(0.9f);
            Cars();
        }
    }
}