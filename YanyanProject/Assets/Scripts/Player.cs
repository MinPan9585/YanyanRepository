using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //bool exploded = false;
    public GameObject particle;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = transform.position + new Vector3(0, 0, 0.01f);
        //if(exploded == false)
        //{
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 5f);
        //}
        

        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position - new Vector3(0.01f, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(0.01f, 0, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //exploded = true;
        //GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -50), ForceMode.Impulse);
        Destroy(other.gameObject);
        particle.SetActive(true);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Time.timeScale = 0;
        SceneManager.LoadScene("SampleScene");
    }
}
