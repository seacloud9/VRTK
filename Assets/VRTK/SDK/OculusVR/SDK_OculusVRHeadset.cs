// OculusVR Headset|SDK_OculusVR|002
namespace VRTK
{
#if VRTK_SDK_OCULUSVR
    using UnityEngine;

    /// <summary>
    /// The OculusVR Headset SDK script provides a bridge to the OculusVR SDK.
    /// </summary>
    public class SDK_OculusVRHeadset : SDK_BaseHeadset
    {
        /// <summary>
        /// The GetHeadset method returns the Transform of the object that is used to represent the headset in the scene.
        /// </summary>
        /// <returns>A transform of the object representing the headset in the scene.</returns>
        public override Transform GetHeadset()
        {
            cachedHeadset = GetSDKManagerHeadset();
            if (cachedHeadset == null)
            {
                cachedHeadset = FindObjectOfType<OVRManager>().transform.FindChild("TrackingSpace/CenterEyeAnchor");
            }
            return cachedHeadset;
        }

        /// <summary>
        /// The GetHeadsetCamera method returns the Transform of the object that is used to hold the headset camera in the scene.
        /// </summary>
        /// <returns>A transform of the object holding the headset camera in the scene.</returns>
        public override Transform GetHeadsetCamera()
        {
            cachedHeadsetCamera = GetSDKManagerHeadset();
            if (cachedHeadsetCamera == null)
            {
                cachedHeadsetCamera = FindObjectOfType<OVRManager>().transform.FindChild("TrackingSpace/CenterEyeAnchor");
            }
            return cachedHeadsetCamera;
        }

        /// <summary>
        /// The HeadsetFade method is used to apply a fade to the headset camera to progressively change the colour.
        /// </summary>
        /// <param name="color">The colour to fade to.</param>
        /// <param name="duration">The amount of time the fade should take to reach the given colour.</param>
        /// <param name="fadeOverlay">Determines whether to use an overlay on the fade.</param>
        public override void HeadsetFade(Color color, float duration, bool fadeOverlay = false)
        {
        }

        /// <summary>
        /// The HasHeadsetFade method checks to see if the given game object (usually the camera) has the ability to fade the viewpoint.
        /// </summary>
        /// <param name="obj">The Transform to check to see if a camera fade is available on.</param>
        /// <returns>Returns true if the headset has fade functionality on it.</returns>
        public override bool HasHeadsetFade(Transform obj)
        {
            return false;
        }

        /// <summary>
        /// The AddHeadsetFade method attempts to add the fade functionality to the game object with the camera on it.
        /// </summary>
        /// <param name="camera">The Transform to with the camera on to add the fade functionality to.</param>
        public override void AddHeadsetFade(Transform camera)
        {
        }
    }
#else
    public class SDK_OculusVRHeadset : SDK_FallbackHeadset
    {
    }
#endif
}