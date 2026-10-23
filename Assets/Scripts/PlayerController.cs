using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    
   //movimiento del carro QUE ES EDITABLE EN INSPECTOR
    public float speed = 5.0f;
    public float turnSpeed =100f;
    //input action e input system  para el movimiento WASD
    public InputAction moveAction;
    // input value x=IZQUIERDA DERECHA y= ATRAS Y ADELANTE    
     private Vector2 moveInput;
    void Start()
    {
        // habilitar el input action para que pueda leer el input del jugador
        moveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // que lea el valor del input de movimiento en vector2 
        moveInput = moveAction.ReadValue<Vector2>();
        //mover el carro adelante y atras
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);
        //mover a los lados pero rotando el carro en lugar de moverlo lateralmente
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * moveInput.x);
        

    }
}
