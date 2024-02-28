using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Clothes : MonoBehaviour
{
    public GameObject clouds;
    public GameObject stars;
    public GameObject bubbles;


    void Start()
    {
        clouds.SetActive(true);
        stars.SetActive(false);
        bubbles.SetActive(false);
        StartCoroutine(ChangeClothes());
    }

    IEnumerator ChangeClothes()
    {
        print(Time.time);
        yield return new WaitForSeconds(1);
        ChangeClothes2();
    }

    public void ChangeClothes2()
    {
        clouds.SetActive(false);
        stars.SetActive(true);
        bubbles.SetActive(false);
        StartCoroutine(ChangeClothes3());
    }

    IEnumerator ChangeClothes3()
    {
        print(Time.time);
        yield return new WaitForSeconds(1);
        ChangeClothes4();
    }

    public void ChangeClothes4()
    {
        clouds.SetActive(false);
        stars.SetActive(false);
        bubbles.SetActive(true);
        StartCoroutine(ChangeClothes5());
    }

    IEnumerator ChangeClothes5()
    {
        print(Time.time);
        yield return new WaitForSeconds(1);
        ChangeClothes6();
    }

    public void ChangeClothes6()
    {
        clouds.SetActive(true);
        stars.SetActive(false);
        bubbles.SetActive(false);
        StartCoroutine(ChangeClothes());
    }
}
