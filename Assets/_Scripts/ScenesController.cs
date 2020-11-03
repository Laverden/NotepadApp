using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SwitchToApp());
    }

    IEnumerator SwitchToApp()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }
}
