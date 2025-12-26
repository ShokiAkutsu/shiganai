using UnityEngine;

[CreateAssetMenu(fileName = "CharacterDataSO", menuName = "Scriptable Objects/CharacterDataSO")]
public class CharacterDataSO : ScriptableObject
{
	enum Direction { Forward = 1, Backward = -1 } // ƒ^ƒu‚Å§ŒÀ‚·‚é‚½‚ß

	[SerializeField] Sprite _changeSprite; // isChange = false;‚È‚çÝ’è‚µ‚È‚¢
	[Header("”»’èðŒ")]
	[SerializeField] float _matchAngle = 0f; 
	[SerializeField] Direction _matchScale = Direction.Forward;

	public Sprite ChangeSprite => _changeSprite;
	public float MatchAngle => _matchAngle;
	public float MatchScale => _matchScale == Direction.Forward ? 1f : -1f;
}
