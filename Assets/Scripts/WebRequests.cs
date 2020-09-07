using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class WebRequests : MonoBehaviour
{
    void Start() {
        
    }

    public void SendDATA(string fieldname, string field) {
        StartCoroutine(UploadData(fieldname, field));
    }


    IEnumerator UploadData(string fieldname,string field) {
        List<IMultipartFormSection> formData = new List<IMultipartFormSection>();
        MultipartFormDataSection data = new MultipartFormDataSection(fieldname, field);
        formData.Add(data);

        UnityWebRequest www = UnityWebRequest.Post("http://localhost:3000/unitypost", formData);
        Debug.Log(formData);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError) {
            Debug.Log(www.error);
        } else {
            Debug.Log("Form upload complete!");
        }
    }
}
