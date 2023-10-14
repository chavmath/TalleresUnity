using UnityEngine;

public class MovimientoCamara : MonoBehaviour
{
	public float velocidadRotacion = 3.0f;

	void Update()
	{
		float mouseX = Input.GetAxis("Mouse X");
		float mouseY = Input.GetAxis("Mouse Y");

		// Girar la c�mara en funci�n del movimiento del rat�n
		transform.Rotate(Vector3.up, mouseX * velocidadRotacion);
		transform.Rotate(Vector3.left, mouseY * velocidadRotacion);
	}
}
