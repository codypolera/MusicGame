﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOff : MonoBehaviour {
	
	void Update () {
		AudioListener.pause = true;
	}
}
