using UnityEngine;

public class ArrayScript : MonoBehaviour
{
    public string[] playerItems = {"pliers","gold coin","toothpaste","gum"};
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("The first item is: " + playerItems[0]);
        Debug.Log("The second item is: "+playerItems[1]);
        Debug.Log("The third item is: "+playerItems[2]);
        Debug.Log("The fourth item is: "+playerItems[3]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
