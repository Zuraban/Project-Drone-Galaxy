using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class StarWarsText : MonoBehaviour
{
    public TMP_Text scrollingText; 
    public float scrollSpeed = 5.0f; 
    public int levelIndex = 1; 
    private bool hasScrolled = false; 

    private void Update()
    {
        if (!hasScrolled)
        {
            
            scrollingText.transform.Translate(Vector3.up * scrollSpeed * Time.deltaTime);

             
            if (scrollingText.transform.position.y > Camera.main.ViewportToWorldPoint(Vector3.up).y + scrollingText.preferredHeight)
            {
                hasScrolled = true;
                LoadLevel(levelIndex); 
            }
        }
    }

    
    public void LoadLevel(int index)
    {
        SceneManager.LoadScene(index);
    }
}

