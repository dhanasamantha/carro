using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    
    public float speed = 5.0f;
    public float turnSpeed;
    public InputAction moveAction;
    public Vector2 moveInput;
    void Start()
    {
        moveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // que lea el valor del input de movimiento en vector2 
        moveInput = moveAction.ReadValue<Vector2>();
        //mover el carro adelante y atras
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);
        //mover a los lados
        transform.Translate (Vector3.right * Time.deltaTime * turnSpeed * moveInput.x);
    }
}
