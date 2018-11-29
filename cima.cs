using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cima : MonoBehaviour {

	
	void Start () {
		
	}
	

	void Update () {
        //o objeto se moverá para cima, cado o alor seja negativo ele iria para baixo
        transform.Translate(new Vector3(0,0.1f,0));
	}
}
