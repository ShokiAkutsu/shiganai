using UnityEngine;

public class HitJudge : MonoBehaviour
{
    [SerializeField] float _matchAngle = 0f;
    [SerializeField] float _matchScale = 1f;
    [SerializeField] GameObject _gameObject;


    void Start()
    {
        
    }

    void Update()
    {
        
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
        float scaleX = collision.transform.lossyScale.x;
        float currentZ = collision.transform.localEulerAngles.z;
		
		float diff = Mathf.DeltaAngle(currentZ, _matchAngle);

		if (Mathf.Abs(diff) < 1.0f && scaleX == _matchScale)
		{
			// •¶Žš‚ð•Ï‰»‚³‚¹‚éˆ—
		}
	}
}
