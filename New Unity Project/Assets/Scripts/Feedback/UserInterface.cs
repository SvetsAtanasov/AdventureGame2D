using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.Animations;

public class UserInterface : MonoBehaviour
{
    public Text goodJobText;
    public GameObject textFloatPrefab;
    GameObject spawnedObject;
    private void Start()
    {
        HideGoodJobText();
    }
    public void ShowGoodJobText()
    {
        goodJobText.gameObject.SetActive(true);
        CancelInvoke("HideGoodJobText");
        Invoke("HideGoodJobText", 2f);
    }

    void HideGoodJobText()
    {
        goodJobText.gameObject.SetActive(false);
    }

    public void SpawnText(Vector2 pos, float value)
    {
        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);
        spawnedObject = Instantiate(textFloatPrefab, this.transform);
        spawnedObject.transform.position = screenPos;
        spawnedObject.GetComponentInChildren<Text>().text = "+" + value;
        Debug.Log(value);

        Destroy(spawnedObject, 2);
    }
}
