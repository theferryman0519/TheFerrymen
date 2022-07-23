using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static string Scene00 = "00FerrymanLogo";
	public static string Scene01 = "01MainLogo";
	public static string Scene02 = "02TitleScreen";
	public static string Scene03 = "03Prologue";
	public static string Scene04 = "04TutorialRiver";
	public static string Scene05 = "05TutorialShip";
	public static string Scene06 = "06TutorialLand";
	public static string Scene07 = "07GameplayLand";
	public static string Scene08 = "08GameplayRiver";
	public static string Scene09 = "09GameplayShip";
	public static string Scene10 = "10GameplayNewShip";
	public static string Scene11 = "11GameplayProfile";
	public static string Scene12 = "12AppStore";
	public static string Scene13 = "13ContactUs";
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
	// Ferryman Logo Scene
    public void Scene00Load() {
        SceneManager.LoadScene(Scene00);
    }

	// Main Logo Scene
    public void Scene01Load() {
        SceneManager.LoadScene(Scene01);
    }

	// Title Scene
    public void Scene02Load() {
        SceneManager.LoadScene(Scene02);
    }

	// Prologue Scene
    public void Scene03Load() {
        SceneManager.LoadScene(Scene03);
    }

	// Tutorial River Scene
    public void Scene04Load() {
        SceneManager.LoadScene(Scene04);
    }

	// Tutorial Ship Scene
    public void Scene05Load() {
        SceneManager.LoadScene(Scene05);
    }

	// Tutorial Land Scene
    public void Scene06Load() {
        SceneManager.LoadScene(Scene06);
    }

	// Gameplay Land Scene
    public void Scene07Load() {
        SceneManager.LoadScene(Scene07);
    }

	// Gameplay River Scene
    public void Scene08Load() {
        SceneManager.LoadScene(Scene08);
    }

	// Gameplay Ship Scene
    public void Scene09Load() {
        SceneManager.LoadScene(Scene09);
    }

	// Gameplay New Ship Scene
    public void Scene10Load() {
        SceneManager.LoadScene(Scene10);
    }

	// Gameplay Profile Scene
    public void Scene11Load() {
        SceneManager.LoadScene(Scene11);
    }

	// App Store Scene
    public void Scene12Load() {
        SceneManager.LoadScene(Scene12);
    }

	// Contact Us Scene
    public void Scene13Load() {
        SceneManager.LoadScene(Scene13);
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}