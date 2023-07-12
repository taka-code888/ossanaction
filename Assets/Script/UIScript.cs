using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*
        GameObject go = GameObject.Find("Text");
        go.GetComponent<Text>().text = "dondoko";
        */

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void sayHello()
    {
        SceneManager.LoadScene("06RigidBody");

        /*
        GameObject go = GameObject.Find("Text");
        go.GetComponent<Text>().text = "まじか";
        */
    }
    
    

    

}
