using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AboutText : MonoBehaviour
{
    public Text scrollingText; 
    public float scrollSpeed = 5.0f; 
    public int levelIndex = 1; 
    private bool hasScrolled = false; 

    private void Update()
    {
        if (!hasScrolled)
        {
            
            scrollingText.transform.Translate(Vector3.up * scrollSpeed * Time.deltaTime);

            
            if (Input.GetKey(KeyCode.M))
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
