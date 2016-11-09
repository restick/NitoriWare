﻿//This class is to help trigger certain animation events

using UnityEngine;
using System.Collections;

public class AnimationEventHelper : MonoBehaviour
{

	private Animator animator;

	public ParticleSystem[] particleSystems;
	public Vibrate[] vibrates;

	void Awake ()
	{
		animator = GetComponent<Animator>();
	}
	
	void Update ()
	{
	
	}

	public void enableVibrate(int index)
	{
		vibrates[index].vibrateOn = true;
	}

	public void disableVibrate(int index)
	{
		vibrates[index].vibrateOn = false;
	}

	public void playParticles(int index)
	{
		particleSystems[index].Stop();
		particleSystems[index].Play();
	}

	public void killParticles(int index)
	{
		particleSystems[index].Stop();
		particleSystems[index].SetParticles(new ParticleSystem.Particle[0], 0);
	}

	public void stopParticles(int index)
	{
		particleSystems[index].Stop();
	}

	public void setParticleSpeed(int index, float speed)
	{

	}

	public void setShakeSpeed(float shakeSpeed)
	{
		CameraShake.instance.setShakeSpeed(shakeSpeed);
	}

	public void setScreenShake(float shake)
	{
		CameraShake.instance.setScreenShake(shake);
	}

	public void setXshake(float shake)
	{
		CameraShake.instance.setXShake(shake);
	}

	public void setYShake(float shake)
	{
		CameraShake.instance.setYShake(shake);
	}

	public void addScreenShake(float shake)
	{
		CameraShake.instance.addScreenShake(shake);
	}

	public void addXshake(float shake)
	{
		CameraShake.instance.addXShake(shake);
	}

	public void addYShake(float shake)
	{
		CameraShake.instance.addYShake(shake);
	}

	public void setShakeCoolRate(float coolRate)
	{
		CameraShake.instance.setShakeCoolRate(coolRate);
	}

	public void setFloat(AnimationEvent values)
	{
		animator.SetFloat(values.stringParameter, values.floatParameter);
	}

	public void setInteger(AnimationEvent values)
	{
		animator.SetInteger(values.stringParameter, values.intParameter);
	}

	public void setBool(AnimationEvent values)
	{
		animator.SetBool(values.stringParameter, values.intParameter > 0);
	}

}
