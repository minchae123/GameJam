using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cakeattack : MonoBehaviour
{
    [SerializeField] private GameObject cakePrefab;
    [SerializeField] private GameObject clickslider;
    [SerializeField] private Transform canvasTras;

    [SerializeField] float minT = 10.0f;
    [SerializeField] float maxT = 60.0f;

    public bool isSpawn = false;

    private void Awake()
    {
        StartCoroutine("SpawnCake");
    }

    private IEnumerator SpawnCake()
    {
        while(true)
        {
            Vector3 cakeSpawn = new Vector3(11f, -3.835135f, 0);
            Instantiate(cakePrefab, cakeSpawn, Quaternion.identity);

            float spawnT = Random.Range(minT, maxT);

            yield return new WaitForSeconds(spawnT);
        }
    }

    /*private void SpawnSlider(GameObject cake)
    {
        GameObject sliderClone = Instantiate(clickslider);

        sliderClone.transform.SetParent(canvasTras);
        sliderClone.transform.localScale = Vector3.one;

        sliderClone.GetComponent<SliderAuto>().Setup(cake.transform);
    }  */ // 슬라이더가 케이크를 따라다님
}
