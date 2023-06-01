using System.Collections;
using UnityEngine;

public class flicklight : MonoBehaviour
{
    Light testLight;
    // Start is called before the first frame update
    void Start()
    {

        testLight = GetComponent<Light>();
        StartCoroutine(Flashing());
    }
    IEnumerator Flashing()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            testLight.enabled = !testLight.enabled;
        }
    } }

   