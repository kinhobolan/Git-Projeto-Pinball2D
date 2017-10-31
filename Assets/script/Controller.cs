using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {


	public HingeJoint2D leftArmHj;
	public HingeJoint2D rightArmHj;

	[Range(300,1500)]
	public int speed;

	[Range(300,1500)]
	public int torque;

	private JointMotor2D moto2D;

	void Start () {

		moto2D = new JointMotor2D ();
		moto2D.maxMotorTorque = torque;
		
	}
	

	void Update () {

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {

			esquerdaParaCima ();
		}

		if (Input.GetKeyUp (KeyCode.LeftArrow)) {

			esquerdaParaBaixo ();
		}


		if (Input.GetKeyDown (KeyCode.RightArrow)) {

			direitaParaCima ();

		}

		if (Input.GetKeyUp (KeyCode.RightArrow)) {

			direitaParaBaixo ();
		}


	}


	void esquerdaParaCima(){

		moto2D.motorSpeed = -1 * speed;
		leftArmHj.motor = moto2D;

	}

	void esquerdaParaBaixo(){
		
		moto2D.motorSpeed = speed;
		leftArmHj.motor = moto2D;
	}


	void direitaParaCima(){

		moto2D.motorSpeed = speed;
		rightArmHj.motor = moto2D;

	}

	void direitaParaBaixo(){

		moto2D.motorSpeed = -1 * speed;
		rightArmHj.motor = moto2D;

	}


}
