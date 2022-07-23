using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class SceneMainLogo : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Image MainLogo;
	public Image OverlayImage;

	public Button OverlayButton;

	public Color OverlayOriginal = new Color(1.0f, 1.0f, 1.0f, 1.0f);
	public Color OverlayAlpha = new Color(1.0f, 1.0f, 1.0f, 0.0f);
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Change
	public ChangeScene Scene02LoadRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// OverlayButton
		Button OverlayButtonClick = OverlayButton.GetComponent<Button>();
		OverlayButtonClick.onClick.AddListener(OverlayButtonClicking);

		// Overlay Starting Color
		OverlayImage.GetComponent<Image>().color = OverlayOriginal;

		// Play Fade Out Coroutine
		StartCoroutine(OverlayFadeOut());
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
	public void OverlayButtonClicking() {
		// Load Title Screen Scene
		Scene02LoadRun.Scene02Load();
	}

	public IEnumerator OverlayFadeOut() {
		// Fade Overlay to Alpha
		float ElapsedTime = 0.0f;

		while (ElapsedTime < 1.5f) {
			ElapsedTime += Time.deltaTime * 1.0f;
			OverlayImage.GetComponent<Image>().color = Color.Lerp(OverlayOriginal, OverlayAlpha, ElapsedTime);
			yield return null;
		}

		// Play Fade In Coroutine
		StartCoroutine(OverlayFadeIn());
	}

	public IEnumerator OverlayFadeIn() {
		// Fade Overlay to Original
		float ElapsedTime = 0.0f;

		while (ElapsedTime < 1.5f) {
			ElapsedTime += Time.deltaTime * 1.0f;
			OverlayImage.GetComponent<Image>().color = Color.Lerp(OverlayOriginal, OverlayAlpha, ElapsedTime);
			yield return null;
		}

		// Load Title Screen Scene
		Scene02LoadRun.Scene02Load();
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}