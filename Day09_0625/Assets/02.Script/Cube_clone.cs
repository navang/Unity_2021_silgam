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
		//���콺 ���� ��ư Ŭ���ϸ�
		if (Input.GetMouseButtonDown(0))
		{
			//Ŭ���� ȭ�� ��ǥ�� - ������ǥ�� ��ȯ ( ������ , ���� )
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			RaycastHit hit;//������ , ���� , �浹üũ , �� ���� ( float or Mathf.Infinity (������) )
			if (Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity))
			{

				Instantiate(Cube, hit.point + new Vector3(0,0.5f,0), Quaternion.identity);

			}
		}
		if (Input.GetMouseButtonDown(1))
		{
			//Ŭ���� ȭ�� ��ǥ�� - ������ǥ�� ��ȯ ( ������ , ���� )
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			RaycastHit hit;//������ , ���� , �浹üũ , �� ���� ( float or Mathf.Infinity (������) )
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
