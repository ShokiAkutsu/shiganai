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
		SetBullet();
	}

	void Update()
    {
		_timer += Time.deltaTime;

		if (_timer > _intervalTime && Input.GetKeyDown(KeyCode.Space))
		{
			_timer = 0f;

			Rigidbody2D rb = _activeBullet.GetComponent<Rigidbody2D>();
			if (rb != null) rb.linearVelocity = Vector2.up * _speed; // ¡‚Ì’e‚ğËo

			SetBullet(); // Ÿ‚Ì’e‚ğ€”õ‚·‚é
		}

		if(Input.GetKeyDown(KeyCode.Q))
		{
			_activeBullet.transform.Rotate(0, 0, 45f);
		}
		if (Input.GetKeyDown(KeyCode.E))
		{
			_activeBullet.transform.Rotate(0, 0, -45f);
		}
	}

	/// <summary>
	/// ’e‚Ì•â[ŠÖ”
	/// ‚P‚Â•ÏX‚·‚é‚¾‚¯‚Åg‚¦‚é‚æ‚¤‚ÉŠÖ”‰»
	/// </summary>
	void SetBullet()
	{
		if(_activeBullet) _activeBullet.transform.parent = null;
		_activeBullet = Instantiate(_shiBullet, transform);
	}
}
