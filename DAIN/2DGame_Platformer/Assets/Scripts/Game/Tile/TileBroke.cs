using UnityEngine;

public class TileBroke : TileBase // 부모 클래스를 TileBase로 변경
{
	[Header("Tile Broke")]
	[SerializeField]
	private	GameObject	tileBrokeEffect;

	public override void UpdateCollision()
	{
		// 부모 클래스인 TileBase에 있는 UpdateCollision() 메소드 호출
		base.UpdateCollision();
		// 타일이 부서지는 파티클 재생
		Instantiate(tileBrokeEffect, transform.position, Quaternion.identity);
		// 타일 오브젝트 삭제
		Destroy(gameObject);
	}
}

