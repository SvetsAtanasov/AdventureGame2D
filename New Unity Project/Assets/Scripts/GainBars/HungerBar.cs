using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HungerBar: MonoBehaviour
{
    public float maxValue = 100f;
    public float valueLoss = 5f;

    private Image progressImage;
    private float value;
    void Start()
    {
        progressImage = GetComponent<Image>();
        value = maxValue;
    }

    void Update()
    {
        value -= valueLoss * Time.deltaTime;
        value = Mathf.Clamp(value, 0f, maxValue);

        progressImage.fillAmount = value / maxValue;
    }

    public bool IsEmpty()
    {
        return (value == 0f);
    }

    public void AddValue(float add)
    {
        value += add;
    }
}
