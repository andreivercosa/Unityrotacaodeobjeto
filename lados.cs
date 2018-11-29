using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lados : MonoBehaviour {

	
	void Start () {
		
	}
	
	
	void Update () {
        //o objeto vai se mover para a direita, caso o valor seja negativo ele se move para a esquerda
        transform.Translate(new Vector3(0.1f,0,0));
	}
}
