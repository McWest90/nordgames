using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    //Exposed Variables
    ///////////////////
    
    [SerializeField] private string mainMenuSceneName;
    [SerializeField]
    public bool reachedTheEnd;
    
    //----------------------------------------
    
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            reachedTheEnd = true;
            SceneManager.LoadScene(mainMenuSceneName);
        }
    }
}

