#pragma strict

//速度
var SPEED: Vector2 = Vector2(0.05f, 0.05f);

//Use this for initialization
function Start() {

}

//Update is called once per frame
function Update() {

    //移動速度
    Move();

}

//移動関数
function Move() {

    //Aキーを押し続けていたら
    if (Input.GetKey("A")) {

        //代入したPositionに対して加算減算を行う
        transform.position.x -= SPEED.x;

    } else if (Input.GetKey("D")) {       //Dキーを押し続けていたら

        //代入したPositionに対して加算減算を行う
        transform.position.x += SPEED.x;

    } else if (Input.GetKey("W")) {     //Wキーを押し続けていたら

        //代入したPositionに対して加算減算を行う
        transform.position.y += SPEED.y;

    } else if (Input.GetKey("S")) {     //Sキーを押し続けていたら

        //代入したPositionに対して加算減算を行う
        transform.position.y -= SPEED.y;

    }

}