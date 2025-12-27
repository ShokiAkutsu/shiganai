using System.Collections.Generic;
using UnityEngine;

public class BoxFactory : MonoBehaviour
{
    [SerializeField] Transform _creationPoint;
	[SerializeField] List<GameObject> _box = new List<GameObject>();
	[SerializeField] float _interval = 2f;
    float _timer;
    [SerializeField] float _speed = 4f;

	void Start()
    {
        
    }
    
    void Update()
    {
        _timer += Time.deltaTime;

        if(_timer > _interval)
        {
            _timer = 0;

            int rand = Random.Range(0, _box.Count);
			var box = Instantiate(_box[rand], _creationPoint);

            Rigidbody2D rb = box.GetComponent<Rigidbody2D>();
			if (rb != null) rb.linearVelocity = Vector2.left * _speed; // ¡‚Ì’e‚ğËo
		}
    }
}
