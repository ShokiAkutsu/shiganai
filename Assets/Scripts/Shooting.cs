using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] GameObject _shiBullet;
	[SerializeField] float _speed = 2f;
	[SerializeField] float _intervalTime = 1f;
	GameObject _activeBullet; // ¶¬‚µ‚½’e‚ğ•Û‘¶‚·‚é
	float _timer = 0f;
	public float IntervalTime => _intervalTime;

	private void Start()
	{
		_activeBullet = Instantiate(_shiBullet);
	}

	void Update()
    {
		_timer += Time.deltaTime;

		if (_timer > _intervalTime && Input.GetKeyDown(KeyCode.Space))
		{
			_timer = 0f;

			Rigidbody2D rb = _activeBullet.GetComponent<Rigidbody2D>();
			if (rb != null) rb.linearVelocity = Vector2.up * _speed; // ¡‚Ì’e‚ğËo

			_activeBullet = Instantiate(_shiBullet, transform); // Ÿ‚Ì’e‚ğ€”õ‚·‚é
		}
	}
}
