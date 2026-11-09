using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _rigidbody;  
    
    public float movementSpeed = 10; 

    public int direction; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Start()
    {
        
    } 

    void Update()
    { 

     if(Input.GetKeyDown(KeyCode.W)) 
        {
            direction = 1;      
        }
        else if(Input.GetKeyUp(KeyCode.W)) 
        {
            direction = 0;       
        }
    }

    void FixedUpdate ()
    {
        
            _rigidbody.linearVelocity = Vector3.forward * movementSpeed * direction; 
        
    } 

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("CheckPoint")) 
        {

            PlayerPrefs.SetFloat("XPosition", transform.position.x);  
            PlayerPrefs.SetFloat("YPosition", transform.position.y); 
            PlayerPrefs.SetFloat("ZPosition", transform.position.z); 
        }
    }

    void Teleport() 
    { 
        Vector3 teleportPosition; 
        teleportPosition.x = PlayerPrefs.GetFloar("XPosition");
        teleportPosition.x = PlayerPrefs.GetFloar("YPosition");
        teleportPosition.x = PlayerPrefs.GetFloar("ZPosition"); 

        transform.position = teleportPosition; 
    }
}
