using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YMover : BaseMover {

	int sign = 1;
	public override void Move(){
		this.target.transform.Translate(0.0f,5.0f * sign,0.0f);
		if(this.target.transform.position.y >= 400) {
			sign = -1;
		}
		else if(this.target.transform.position.y <= -400) {
			sign = 1;
		}
	}
	public YMover(Enemy target) : base(target){}

	

}
