using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// Button Click Effect
/// </summary>

[RequireComponent(typeof(Button))]
public class botton : MonoBehaviour
{
    public Vector3 from = Vector3.one;
    public Vector3 to = Vector3.one * 0.95f;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() => StartCoroutine(Scaling()));
        GetComponent<RectTransform>().localScale = from;
    }

    IEnumerator Scaling()
    {
        GetComponent<RectTransform>().localScale = to;
        yield return new WaitForSeconds(Time.fixedDeltaTime * 3);
        GetComponent<RectTransform>().localScale = from;
    }
}