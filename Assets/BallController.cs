using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Rigidbody sphereRigidbody;
    public float ballSpeed = 2f;
    void Start()
    {
        Debug.Log("Calling the Start method");
    }

    // Update is called once per frame
    void Update()
 {
  Vector2 inputVector= Vector2.zero; //intializeour inputvector
  if (Input.GetKey(KeyCode.W))
  {
  inputVector+=Vector2.up; //"a +=b"<=> "a= a+b"
  }

  if (Input.GetKey(KeyCode.S))
     {
     inputVector += Vector2.down;
     }

  if (Input.GetKey(KeyCode.D))
     {
     inputVector += Vector2.right;
     }

  if (Input.GetKey(KeyCode.A))
     {
     inputVector += Vector2.left;
     }

        Vector3 inputXZPlane = new Vector3(inputVector.x, 0, inputVector.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }
}
