using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class CountdownTimer : MonoBehaviour
{
    public string LevelToLoad;
    private float timer = 30f;

    TMPro.TMP_Text text;
    int count;

    void Awake()
    {
        text = GetComponent<TMPro.TMP_Text>();
    }


    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        text.text = timer.ToString("f0");
        if (timer <= 0)
        {
            SceneManager.LoadScene(LevelToLoad);
        }

    }
}