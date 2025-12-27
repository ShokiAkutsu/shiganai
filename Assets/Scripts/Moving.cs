using UnityEngine;

public class Moving : MonoBehaviour
{
	[SerializeField] float moveSpeed = 5f; // ˆÚ“®‘¬“x

	void Update()
	{
		float moveInput = Input.GetAxisRaw("Horizontal");

		transform.Translate(new Vector3(moveInput * moveSpeed * Time.deltaTime, 0, 0));
	}
}
