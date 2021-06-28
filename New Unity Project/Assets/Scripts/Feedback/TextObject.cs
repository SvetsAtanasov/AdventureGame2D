using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextObject : MonoBehaviour
{
    public Text[] objectText;


    private void Start()
    {
        HideObjectGrains();
        HideObjectFruits();
        HideObjectDairy();
        HideObjectProtein();
        HideObjectVegetables();

    }
    public void ShowObjectGrains ()
    {
        objectText[0].gameObject.SetActive(true);
        CancelInvoke("HideObjectGrains");
        Invoke("HideObjectGrains", 2f);
    }

    void HideObjectGrains()
    {
        objectText[0].gameObject.SetActive(false);
    }

    public void ShowObjectFruits()
    {
        objectText[1].gameObject.SetActive(true);
        CancelInvoke("HideObjectFruits");
        Invoke("HideObjectFruits", 2f);
    }

    void HideObjectFruits()
    {
        objectText[1].gameObject.SetActive(false);
    }

    public void ShowObjectDairy()
    {
        objectText[2].gameObject.SetActive(true);
        CancelInvoke("HideObjectDairy");
        Invoke("HideObjectDairy", 2f);
    }

    void HideObjectDairy()
    {
        objectText[2].gameObject.SetActive(false);
    }

    public void ShowObjectProtein()
    {
        objectText[3].gameObject.SetActive(true);
        CancelInvoke("HideObjectProtein");
        Invoke("HideObjectProtein", 2f);
    }

    void HideObjectProtein()
    {
        objectText[3].gameObject.SetActive(false);
    }

    public void ShowObjectVegetables()
    {
        objectText[4].gameObject.SetActive(true);
        CancelInvoke("HideObjectVegetables");
        Invoke("HideObjectVegetables", 2f);
    }

    void HideObjectVegetables()
    {
        objectText[4].gameObject.SetActive(false);
    }
}
