using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseMover {

	protected Enemy target;
	public abstract void Move();
	public BaseMover(Enemy target){
		this.target = target;
	}
}
