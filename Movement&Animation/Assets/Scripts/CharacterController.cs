using UnityEngine;

public class MovimientoConAnimacion : MonoBehaviour
{
    public float velocidad = 5.0f;
	public float velocidadRotacion = 3.0f;
	private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        float mouseX = Input.GetAxis("Mouse X");

		Vector3 movimiento = new Vector3(movimientoHorizontal, 0.0f, movimientoVertical);
		transform.Rotate(Vector3.up, mouseX * velocidadRotacion);

		if (movimiento != Vector3.zero)
        {
            // Reproducir la animación de movimiento
            animator.SetBool("isMoving", true);
            transform.Translate(movimiento * velocidad * Time.deltaTime);
        }
        else
        {
            // Detener la reproducción de la animación si no hay movimiento
            animator.SetBool("isMoving", false);
        }
    }
}
