using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject[] ListeView;
    private int taille;
    private int numView;

    // Start is called before the first frame update
    void Start()
    {
        taille = ListeView.Length;
        ListeView[0].SetActive(true);
        for(int i=1; i<taille; i++)
        {
            ListeView[i].SetActive(false);
        }
        numView = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            Debug.Log("change camera");
            ListeView[numView].SetActive(false);
            numView += 1;
            if (numView == taille)
            {
                numView = 0;
            }
            ListeView[numView].SetActive(true);
        }
    }
}
