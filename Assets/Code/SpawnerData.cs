using Unity.Mathematics;
using UnityEngine;

[CreateAssetMenu(fileName = "SpawnerData", menuName = "Scriptable Objects/SpawnerData")]
public class SpawnerData : ScriptableObject
{
    public GameObject prefab;
    public int cantidad;
    public quaternion rotacion;
    public Vector3 maximo;
    public Vector3 minimo;
}
