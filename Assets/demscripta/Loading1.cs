using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class Loading1 : MonoBehaviour
{
   
    public Image progressBar;
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(LoadLevelAsync());
    }
    IEnumerator LoadLevelAsync()
    {
        AsyncOperation loadingOperation = SceneManager.LoadSceneAsync(1);

        while (loadingOperation.isDone==false) {
        progressBar.fillAmount= loadingOperation.progress;

            yield return new WaitForSeconds(5.9f) ;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(1);
    }
}
