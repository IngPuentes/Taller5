using UnityEngine;
using System.Collections;

public class Creacion : MonoBehaviour {

	// Use this for initialization
	void Start() {

		GameObject cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube1.transform.position = new Vector3(10.05294f, 0.9822722F, -7.826861f);
		cube1.transform.localScale = new Vector3 (1,0.5772875f,1.732237f);
		cube1.transform.rotation = Quaternion.Euler (0,0,337.514f);

		GameObject cube2 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		cube2.transform.position = new Vector3(7.030624f, 1.865119F, -7.109964f);
		cube2.transform.localScale = new Vector3 (0.7643764f,0.1f,0.09f);
		cube2.transform.rotation = Quaternion.Euler (0,0,315.4399f);

		GameObject cube3 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		cube3.transform.position = new Vector3(8.595223f, 1.246319F, -7.826861f);
		cube3.transform.localScale = new Vector3 (1.547793f,0.8935211f,1.732237f);
		cube3.transform.rotation = Quaternion.Euler (0,0,324.7946f);

		GameObject cube4 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		cube4.transform.position = new Vector3(7.640162f, 1.325088F, -7.826861f);
		cube4.transform.localScale = new Vector3 (1.180803f,0.8935211f,1.732237f);
		cube4.transform.rotation = Quaternion.Euler (0,0,0.583859f);

		GameObject cube5 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		cube5.transform.position = new Vector3(6.933599f, 1.23442F, -7.828794f);
		cube5.transform.localScale = new Vector3 (1,0.1498624f,1.732237f);
		cube5.transform.rotation = Quaternion.Euler (0,0,44.37468f);

		GameObject cube6 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		cube6.transform.position = new Vector3(7.637346f, 1.601356F, -7.826861f);
		cube6.transform.localScale = new Vector3 (1.180803f,0.8935211f,1.732237f);
		cube6.transform.rotation = Quaternion.Euler (0,0,0.583859f);

		GameObject cube7 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		cube7.transform.position = new Vector3(9.200708f, 1.151082F, -7.826861f);
		cube7.transform.localScale = new Vector3 (1,0.5772875f,1.732237f);
		cube7.transform.rotation = Quaternion.Euler (0,0,0);

		GameObject cube8 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		cube8.transform.position = new Vector3(6.741031f, 2.110087F, -7.839122f);
		cube8.transform.localScale = new Vector3 (0.5036803f,0.1035894f,2.180262f);
		cube8.transform.rotation = Quaternion.Euler (0,0,27.33509f);

		GameObject cube9 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		cube9.transform.position = new Vector3(7.030624f, 1.865119F, -8.52345f);
		cube9.transform.localScale = new Vector3 (0.7643764f,0.1f,0.09f);
		cube9.transform.rotation = Quaternion.Euler (0,0,315.4399f);

		GameObject cube10 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		cube10.transform.position = new Vector3(6.840946f, 1.345706F, -7.828794f);
		cube10.transform.localScale = new Vector3 (1,0.1498624f,1.732237f);
		cube10.transform.rotation = Quaternion.Euler (0,0,44.37468f);

		GameObject cube11 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		cube11.transform.position = new Vector3(8.529894f, 0.7444354F, -7.826861f);
		cube11.transform.localScale = new Vector3 (4.189132f,0.6307604f,1.732237f);
		cube11.transform.rotation = Quaternion.Euler (0,0,0);

		GameObject llanta1 = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		llanta1.transform.position = new Vector3 (10.02132f, 0.7198889f,-6.859875f);
		llanta1.transform.localScale = new Vector3 (1, 0.1005499f, 1);
		llanta1.transform.rotation = Quaternion.Euler (90, 0, 0);

		GameObject llanta2 = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		llanta2.transform.position = new Vector3 (10.02132f, 0.7198892f,-8.781905f);
		llanta2.transform.localScale = new Vector3 (1, 0.1005499f, 1);
		llanta2.transform.rotation = Quaternion.Euler (90, 0, 0);

		GameObject llanta3 = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		llanta3.transform.position = new Vector3 (7.223932f, 0.7784822f,-6.859876f);
		llanta3.transform.localScale = new Vector3 (1.13665f, 0.11429f, 1.13665f);
		llanta3.transform.rotation = Quaternion.Euler (90, 0, 0);

		GameObject llanta4 = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		llanta4.transform.position = new Vector3 (7.223932f, 0.7784822f,-8.810316f);
		llanta4.transform.localScale = new Vector3 (1.13665f, 0.11429f, 1.13665f);
		llanta4.transform.rotation = Quaternion.Euler (90, 0, 0);

		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
