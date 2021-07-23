using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_clone : MonoBehaviour
{
    public GameObject Cube;
	public GameObject notGameOb;
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		//마우스 왼쪽 버튼 클릭하면
		if (Input.GetMouseButtonDown(0))
		{
			//클릭한 화면 좌표를 - 레이좌표로 변환 ( 시작점 , 방향 )
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			RaycastHit hit;//시작점 , 방향 , 충돌체크 , 선 길이 ( float or Mathf.Infinity (무제한) )
			if (Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity))
			{

				Instantiate(Cube, hit.point + new Vector3(0,0.5f,0), Quaternion.identity);

			}
		}
		if (Input.GetMouseButtonDown(1))
		{
			//클릭한 화면 좌표를 - 레이좌표로 변환 ( 시작점 , 방향 )
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			RaycastHit hit;//시작점 , 방향 , 충돌체크 , 선 길이 ( float or Mathf.Infinity (무제한) )
			if (Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity))
			{

				if ( hit.transform.tag == "Monster")
                {
					Destroy(hit.collider.gameObject);

				}

			}
		}
	}
}
