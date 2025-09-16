using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField] private SpawnerData spawnerData;
    private float posx;
    private float posy;
    private float posz;
    Vector3 posicionspawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < spawnerData.cantidad; i++)
        {
            posx = Random.Range(spawnerData.minimo.x, spawnerData.maximo.x);
            posy = Random.Range(spawnerData.minimo.y, spawnerData.maximo.y);
            posz = Random.Range(spawnerData.minimo.z, spawnerData.maximo.z);
            posicionspawn = new Vector3(posx, posy, posz);
            Instantiate(spawnerData.prefab, posicionspawn, spawnerData.rotacion);
        }
   }
}
