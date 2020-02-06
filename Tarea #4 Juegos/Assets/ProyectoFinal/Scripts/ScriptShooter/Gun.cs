using UnityEngine;
using UnityEngine.UI;
//using static UnityEngine.GraphicsBuffer;
//using static UnityEngine.GraphicsBuffer;

public class Gun : MonoBehaviour
{
    public Camera fpsCam;
    public int score;
    public GameObject scoreText;
    public int force;
    public int theScore;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Ray myRay = fpsCam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(myRay, out hit)) 
        { 
            Debug.Log(hit.transform.name);
            hit.rigidbody.AddForce(-hit.normal * force);

            if (hit.collider.tag == "Target")
            {
                Destroy(hit.transform.gameObject);
                Debug.Log("Flag");
                theScore++;
                scoreText.GetComponent<Text>().text = "Enemigos Destruidos: " + theScore;
            }

        }
    }
}
