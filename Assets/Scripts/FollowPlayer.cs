using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);
    void Start()
    {
        
    }

    // Update is called once 
    //lateUpdate nos hace seguir al obejto con un retraso 
    void LateUpdate()
    {
        //aqui estamos siguiendo al jugador, pero con un
        //  offset de 6 en el eje y y 9 en el eje z y 
        // puse new vetor 3 porque es un valor que la computadora no conoce
        transform.position = player.transform.position + offset ;
    }
}
