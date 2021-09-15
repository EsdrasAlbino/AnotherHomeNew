using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingScript : MonoBehaviour
{
    public int partesNave;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "parteNave")
        {
            Destroy(other.gameObject);
            partesNave++;
        }
    }
}
