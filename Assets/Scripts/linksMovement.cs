using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linksMovement : MonoBehaviour
{
    Vector3 movement;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 6.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // Distancia = velocidad * tiempo
        // Time.deltaTime es el tiempo transcurrido desde el último frame
        // movement es la variable que almacena el vector de movimiento del GameObject
        // El vector está formado por 3 componentes (x,y,z).
        // Modificar cualquiera de las componentes modificará la posición del elemento

        if (Input.GetKey(KeyCode.A))
        {
            
            movement = this.transform.position;
            movement.x -= speed * Time.deltaTime;
            this.transform.position = movement;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            movement = this.transform.position;
            movement.y -= speed * Time.deltaTime;
            this.transform.position = movement;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            movement = this.transform.position;
            movement.x += speed * Time.deltaTime;
            this.transform.position = movement;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            movement = this.transform.position;
            movement.y += speed * Time.deltaTime;
            this.transform.position = movement;
        }
    }
}
