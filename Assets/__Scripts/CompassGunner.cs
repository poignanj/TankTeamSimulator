﻿using UnityEngine.UI;
using UnityEngine;
public class CompassGunner : MonoBehaviour
{
	public RawImage CompassImage;
	public Transform turret;
    public Transform tank;
	public Text CompassDirectionText;

	public void Update()
	{
        //Get a handle on the Image's uvRect
        float couille = turret.localEulerAngles.y / 360 + tank.localEulerAngles.y / 360;
        CompassImage.uvRect = new Rect(couille, 0, 1, 1);
        

        // Get a copy of your forward vector
        Vector3 forward = - turret.transform.up;

		// Zero out the y component of your forward vector to only get the direction in the X,Z plane
		forward.y = 0;

		//Clamp our angles to only 5 degree increments
		float headingAngle = Quaternion.LookRotation(forward).eulerAngles.y;
		headingAngle = 5 * (Mathf.RoundToInt(headingAngle / 5.0f));

		//Convert float to int for switch
		int displayangle;
		displayangle = Mathf.RoundToInt(headingAngle);

		//Set the text of Compass Degree Text to the clamped value, but change it to the letter if it is a True direction
		switch (displayangle)
		{
		case 0:
			CompassDirectionText.text = "N";
			break;
		case 360:
			CompassDirectionText.text = "N";
			break;
		case 45:
			CompassDirectionText.text = "NE";
			break;
		case 90:
			CompassDirectionText.text = "E";
			break;
		case 130:
			CompassDirectionText.text = "SE";
			break;
		case 180:
			CompassDirectionText.text = "S";
			break;
		case 225:
			CompassDirectionText.text = "SW";
			break;
		case 270:
			CompassDirectionText.text = "W";
			break;
        case 315:
            CompassDirectionText.text = "NW";
            break;
		default:
			CompassDirectionText.text = headingAngle.ToString ();
			break;
		}
	}
}