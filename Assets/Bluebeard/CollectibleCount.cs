using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectibleCount : MonoBehaviour

{
    TMPro.TMP_Text text;
    int count;

    public string LevelToLoad;
    void Awake()
    {
        text = GetComponent <TMPro.TMP_Text>();
    }

    void Start() => UpdateCount();

    void OnEnable() => Collectible.OnCollected += OnCollectibleCollected;
    void OnDisable() => Collectible.OnCollected -= OnCollectibleCollected;

    void OnCollectibleCollected()
    {
        count++;
        UpdateCount();
    }
    void UpdateCount()
    {
        text.text = $"{count} / {Collectible.total} ";
        if (count >= 6)
        {
            Invoke("TimedChangeScene", 3);

        }

    }

    public void TimedChangeScene()
    {
        {
            SceneManager.LoadScene("StoryArc2");
        }
    }

}
