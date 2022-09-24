using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CubeSpawnerController : MonoBehaviour
{
    [SerializeField] TMP_InputField inputField;
    [SerializeField] GameObject CubePrefab;
    private void Start()
    {
        inputField.onSubmit.AddListener(delegate { SpawnCubes(); });
    }
    void SpawnCubes()
    {
        var count = int.Parse(inputField.text);
        for(var i = 0; i < count; i++)
        {
            var Cube = Instantiate(CubePrefab);
            var height = Cube.GetComponent<BoxCollider>().bounds.size.y;
            Cube.transform.position = new Vector3(0, i * height, 0);
        }
    }
}
