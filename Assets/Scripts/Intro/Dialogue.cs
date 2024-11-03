using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public AudioSource dialogue1;
    public float waitforseconds;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(play());
    }

    IEnumerator play()
    {
        yield return new WaitForSeconds(waitforseconds);
        dialogue1.Play();
    }
}
