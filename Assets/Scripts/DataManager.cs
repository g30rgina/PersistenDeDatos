using UnityEngine; 
using UnityEngine.SceneManagement; 

public class DataManager : MonoBehaviour
{
    public string nombreUsuario; 

    public int vitalidad; 

    public int fuerza; 

    public int destreza; 

    public int inteligencia;  

    public float experiencia; 


    void Awake ()
    {
        DontDestroyOnLoad(gameObject);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LoadData();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(1); 
        }

        if(Input.GetKeyDown(KeyCode.G)) 
        {
            SaveData(); 
        }
        if(Input.GetkeyDown(KeyCode.C)) 
        
    }  
    void SaveData ()  
    {
        PlayerPrefs.SetString("NombreUsuario", nombreUsuario);
        PlayerPrefs.SetInt("VitalidadPersonaje", vitalidad); 
        PlayerPrefs.SetFloat("ExperienciaUsuario", experiencia);

    }
    void LoadData() 
    {
        nombreUsuario = PlayerPrefs.GetString("NombreUsuario", "Sin Nombre"); 
        vitalidad = PlayerPrefs.GetInt("VitalidadPersonaje", 1); 
        experiencia = PlayerPrefs.GetFloat("ExperienciaUsuario", 0.5f);

    }

    void SaveData() 
    {
        PlayerData.nombreUsuario = nombreUsuario; 
        PlayerData.destreza = 
    } 
      void SaveData() 
    {
        nombreUsuario = PlayerData.nombreUsuario; 
        destreza = PlayerData.destreza; 
    }
}
