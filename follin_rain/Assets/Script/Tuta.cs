using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuta : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 mypos;
    public GameObject tuta, tuta_Up;
    void Start()
    {
        mypos = transform.position;
    }
    private void Update()
    {
        if (Input.GetKey("space"))
        {
            StartCoroutine("Nobiru");
        }
    }
    void OnTriggerEnter(Collider2D col)
    {
        if (col.CompareTag("ame"))
        {
            StartCoroutine("Nobiru");
        }
    }
    IEnumerator Nobiru()
    {
        Instantiate(tuta, new Vector3(mypos.x, mypos.y + 1, mypos.z), Quaternion.identity);
        yield return new WaitForSeconds(0.5f);
        Instantiate(tuta, new Vector3(mypos.x, mypos.y + 2, mypos.z), Quaternion.identity);
        yield return new WaitForSeconds(0.5f);
        Instantiate(tuta, new Vector3(mypos.x, mypos.y + 3, mypos.z), Quaternion.identity);
        yield return new WaitForSeconds(0.5f);
        Instantiate(tuta, new Vector3(mypos.x, mypos.y + 4, mypos.z), Quaternion.identity);
        yield return new WaitForSeconds(0.5f);
        Instantiate(tuta, new Vector3(mypos.x, mypos.y + 5, mypos.z), Quaternion.identity);
        yield return new WaitForSeconds(0.5f);
        Instantiate(tuta_Up, new Vector3(mypos.x, mypos.y + 6, mypos.z), Quaternion.identity);
        yield break;
    }
}
