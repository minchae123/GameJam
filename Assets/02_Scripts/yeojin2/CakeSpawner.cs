using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakeSpawner : MonoBehaviour
{
    public GameObject ClickText;
    public GameObject CakePref;
    public GameObject CakeHPslider;
    public Transform canvasTrans;

    public float minST = 10.0f; // �ּ� ���� �ð�
    public float maxST = 40.0f; // �ִ� ���� �ð�
    
    // ����ũ ����
    float posX = 11f; 
    float posY = -3.835135f;

    // �ؽ�Ʈ ����
    float posX2 = -6.55f;
    float posY2 = -3.0f;


    private void Start()
    {
        StartCoroutine("SpawnCake");
    }

    private IEnumerator SpawnCake()
    {
        while(true)
        {
            // ����ũ ����
            Vector3 CakeSpawn = new Vector3(posX, posY, 0);
            GameObject cakeClone= Instantiate(CakePref, CakeSpawn, Quaternion.identity);
            SpawnCakeHPSlider(cakeClone);

            yield return new WaitForSeconds(4.5f); // 4�ʰ� ���

            // �ؽ�Ʈ ����
            Vector3 TextSpawn = new Vector3(posX2, posY2, 0);
            GameObject CakeText = Instantiate(ClickText, TextSpawn, Quaternion.identity);
            
            yield return new WaitForSeconds(3.0f); // 3�ʰ� ���
            
            Destroy(CakeText); // �ؽ�Ʈ ������Ʈ ����

            // ��ٸ� + �����
            float spawnT = Random.Range(minST, minST);
            yield return new WaitForSeconds(spawnT);
        }
    }

    private void SpawnCakeHPSlider(GameObject Cake)
    {
        GameObject sliderClone = Instantiate(CakeHPslider);

        sliderClone.transform.SetParent(canvasTrans);
        sliderClone.transform.localScale = Vector3.one;

        sliderClone.GetComponent<SliderAuto>().Setup(Cake.transform);

    }

}
